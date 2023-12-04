using Motosalon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Motosalon
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            WorkingWithFiles<List<Mototransport>> FileMoto = new WorkingWithFiles<List<Mototransport>>();
            List<Mototransport> Mototransports = DataService.GetMototransport();
            WorkingWithFiles<List<Client>> File = new WorkingWithFiles<List<Client>>();
            List<Client> clients = DataService.GetClients();
            using(MotoContext db= new MotoContext())
            {
                /*db.AddRange(Mototransports);
                db.AddRange(clients);
                db.SaveChanges();
                Mototransport moto = db.Mototransports.First();
                Console.WriteLine(moto.GetType());*/
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
