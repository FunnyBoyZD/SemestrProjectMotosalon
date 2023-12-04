using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net;

namespace Motosalon.Data
{
    public class MotoContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Mototransport> Mototransports { get; set;}
        public DbSet<Motorcycle> Motorcycles { get; set;}
        public DbSet<Scooter> Scooters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, options =>
            {
                options.EnableRetryOnFailure();
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Client>().Property(c=>c.Id).UseIdentityColumn();
            modelBuilder.Entity<Client>().HasAlternateKey(c => c.PhoneNumber);
            modelBuilder.Entity<Mototransport>().Property(c => c.Id).UseIdentityColumn();
            modelBuilder.Entity<Mototransport>()
            .Property(m => m.Brand).IsRequired();

            modelBuilder.Entity<Mototransport>()
                .Property(m => m.Model).IsRequired();
            modelBuilder.Entity<Client>()
            .HasOne(c => c.BoughtMoto)
            .WithMany(m=>m.Clients)
            .HasForeignKey(c => c.BoughtMotoId);

            base.OnModelCreating(modelBuilder);

        }
    }
}
