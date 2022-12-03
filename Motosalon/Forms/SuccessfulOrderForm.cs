using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class SuccessfulOrderForm : Form
    {
        private Client client;
        private WorkingWithFiles<List<Client>> workingWithFiles;
        public SuccessfulOrderForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            workingWithFiles = new WorkingWithFiles<List<Client>>();
        }

        private void SuccessfulOrderForm_Load(object sender, EventArgs e)
        {
            ClientName.Text += client.Name;
            ClientSurname.Text += client.Surname;
            ClientPhone.Text += client.PhoneNumber;
            BackColor = Color.LightGray;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();

            clients = workingWithFiles.ReadingFromFile("Clients.bin");
            if (clients == null)
            {
                MessageBox.Show("Не вдалося прочитати файл");
                return;
            }
            clients.Add(client);
            workingWithFiles.WritingToFile(clients, "Clients.bin");
            this.Close();
        }
    }
}
