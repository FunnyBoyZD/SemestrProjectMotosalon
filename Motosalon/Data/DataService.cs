using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon.Data
{
    internal class DataService
    {
        public static List<Client> GetClients()
        {
            using(MotoContext db = new MotoContext())
            {
                return db.Clients.Include(c=>c.BoughtMoto).ToList();
            }
        }
        public static void AddClient(Client client)
        {
            using (MotoContext db = new MotoContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }
        public static void RemoveClient(Client client)
        {
            using (MotoContext db = new MotoContext())
            {
                db.Clients.Remove(client);
                db.SaveChanges();
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
    }
}
