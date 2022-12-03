using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class ListClientsForm : Form
    {
        private WorkingWithFiles<List<Client>> workingWithFiles;
        private List<Client> clients = null;
        public ListClientsForm()
        {
            InitializeComponent();
            workingWithFiles = new WorkingWithFiles<List<Client>>();
        }

        private void ListClientsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            clients = workingWithFiles.ReadingFromFile("Clients.bin");
            if (clients == null)
            {
                MessageBox.Show("Не вдалося зчитати файл");
                return;
            }
            AddToListView(clients, ChangeBackGroundColor);
        }

        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }
        private void AddToListView(List<Client> clients, ChangeStyle changeStyleLines)
        {
            Random random = new Random();
            Color color;
            int rnd = random.Next(1, 3);
            if (rnd == 1)
            {
                color = Color.LightGray;
            }
            else if (rnd == 2)
            {
                color = Color.LightBlue;
            }
            else
            {
                color = Color.White;
            }
            ClientListView.Items.Clear();
            ListViewItem item = null;
            foreach (var client in clients)
            {
                item = new ListViewItem(new string[] { client.Name, client.Surname, client.PhoneNumber, client.Comment != "" ? "Є" : "Немає", client.BoughtMoto.Brand + " " + client.BoughtMoto.Model});
                changeStyleLines(item, color);
                ClientListView.Items.Add(item);
            }
        }

        private void ShowCommentButton_Click(object sender, EventArgs e)
        {
            if (ClientListView.SelectedItems.Count == 1)
            {
                if (clients[ClientListView.SelectedItems[0].Index].Comment != "")
                {
                    MessageBox.Show($"{clients[ClientListView.SelectedItems[0].Index].Comment}", "Коментар", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Коментаря немає", "Коментар", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одного клієнта");
            }
        }

        private void ShowMotoButton_Click(object sender, EventArgs e)
        {
            if (ClientListView.SelectedItems.Count == 1)
            {
                Mototransport mototransport = clients[ClientListView.SelectedItems[0].Index].BoughtMoto;
                if (mototransport.GetType().Name == "Motorcycle")
                {
                    Motorcycle motorcycle = mototransport as Motorcycle;
                    if (motorcycle == null)
                        return;
                    MessageBox.Show($"Тип: Мотоцикл\n\nБренд: {mototransport.Brand}\n\nМодель: {mototransport.Model}\n\nЦіна: {mototransport.Price}\n\nОб'єм двигуна: {mototransport.Volume}\n\nТип мотоцикла: {motorcycle.TypeMotorcycle}\n\n", "Мототранспорт", MessageBoxButtons.OK);
                }
                else
                {
                    Scooter scooter = mototransport as Scooter;
                    if (scooter == null)
                        return;
                    MessageBox.Show($"Тип: Скутер\n\nБренд: {mototransport.Brand}\n\nМодель: {mototransport.Model}\n\nЦіна: {mototransport.Price}\n\nОб'єм двигуна: {mototransport.Volume}\n\nТип скутера: {scooter.TypeScooter}\n\n", "Мототранспорт", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одного клієнта");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
         
            if (ClientListView.SelectedItems.Count == 1)
            {
                clients.Remove(clients[ClientListView.SelectedItems[0].Index]);
                AddToListView(clients, ChangeBackGroundColor);
                workingWithFiles.WritingToFile(clients, "Clients.bin");
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одного клієнта");
            }
        }
    }
}
