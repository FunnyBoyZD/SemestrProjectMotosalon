using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Motosalon.Data
{
    internal class DataService
    {
        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public static List<Client> GetClients()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients
                    .Include(c => c.BoughtMoto)
                    .ToList();
            }
        }

        public static async Task AddClientAsync(Client client)
        {
            await _semaphore.WaitAsync();
            try
            {
                using (MotoContext db = new MotoContext())
                {
                    db.Clients.Add(client);
                    await db.SaveChangesAsync();
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public static async Task RemoveClientAsync(Client client)
        {
            await _semaphore.WaitAsync();
            try
            {
                using (MotoContext db = new MotoContext())
                {
                    db.Clients.Remove(client);
                    await db.SaveChangesAsync();
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }
        public static List<Mototransport> GetMototransport()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Mototransports.ToList();
            }
        }
        public static void AddMototransport(Mototransport mototransport)
        {
            using (MotoContext db = new MotoContext())
            {
                db.Mototransports.Add(mototransport);
                db.SaveChanges();
            }
        }
        public static void RemoveMototransport(Mototransport mototransport)
        {
            using (MotoContext db = new MotoContext())
            {
                db.Mototransports.Remove(mototransport);
                db.SaveChanges();
            }
        }

        public static List<Mototransport> GetMototransportsWithPriceOver100000()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Mototransports.Where(m => m.Price > 100000).ToList();
            }
        }

        public static List<Client> GetClientsWhoBoughtHondaOrYamaha()
        {
            using (MotoContext db = new MotoContext())
            {
                return (List<Client>)db.Clients.Union(
                    db.Clients.Where(c => c.BoughtMoto.Brand == "Yamaha").ToList());
            }
        }

        public static List<Client> GetClientsWhoBoughtHondaButNotYamaha()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients.Except(
                    db.Clients.Where(c => c.BoughtMoto.Brand == "Yamaha")).ToList();
            }
        }

        public static List<Client> GetClientsWhoBoughtHondaAndYamaha()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients.Intersect(
                    db.Clients.Where(c => c.BoughtMoto.Brand == "Yamaha")).ToList();
            }
        }

        public static Dictionary<string, int> GetMototransportCountByBrand()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Mototransports
                    .GroupBy(m => m.Brand)
                    .ToDictionary(g => g.Key, g => g.Count());
            }
        }

        public static List<Client> GetClientsWithMototransport()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients
                    .Include(c => c.BoughtMoto) // Eager loading
                    .ToList();
            }
        }

        public static Client GetClientWithMototransport(int clientId)
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients
                    .Include(c => c.BoughtMoto) // Eager loading
                    .FirstOrDefault(c => c.Id == clientId);
            }
        }

        public static List<Client> GetClientsWithoutMototransport()
        {
            using (MotoContext db = new MotoContext())
            {
                return db.Clients
                    .Where(c => c.BoughtMoto.Clients.Count == 0) // Explicit loading
                    .ToList();
            }
        }
    }
}
