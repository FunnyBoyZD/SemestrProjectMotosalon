using Microsoft.EntityFrameworkCore;
using Motosalon.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class SuccessfulOrderForm : Form
    {
        private Client Client;
        private WorkingWithFiles<List<Client>> WorkingWithFiles;
        private MotoContext Db;

        public SuccessfulOrderForm(Client client,MotoContext db)
        {
            InitializeComponent();
            this.Client = client;
            WorkingWithFiles = new WorkingWithFiles<List<Client>>();
            this.Db = db;
        }

        private void SuccessfulOrderForm_Load(object sender, EventArgs e)
        {
            ClientName.Text += Client.Name;
            ClientSurname.Text += Client.Surname;
            ClientPhone.Text += Client.PhoneNumber;
            BackColor = Color.LightGray;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();

            clients = Db.Clients.Include(c=>c.BoughtMoto).ToList();
            if (clients == null)
            {
                MessageBox.Show("Не вдалося прочитати файл");
                return;
            }
            clients.Add(Client);
            Db.Clients.Add(Client);
            WorkingWithFiles.WritingToFile(clients, "Clients.bin");
            this.Close();
        }
    }
}
