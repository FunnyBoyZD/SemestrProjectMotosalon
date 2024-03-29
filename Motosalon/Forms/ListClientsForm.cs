﻿using Motosalon.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class ListClientsForm : Form
    {
        private WorkingWithFiles<List<Client>> WorkingWithFiles;
        private List<Client> Clients = null;

        public ListClientsForm()
        {
            InitializeComponent();
            WorkingWithFiles = new WorkingWithFiles<List<Client>>();
        }

        private void ListClientsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            Clients = DataService.GetClients();
            if (Clients == null)
            {
                MessageBox.Show("Не вдалося зчитати файл");
                return;
            }
            AddToListView(Clients, ChangeBackGroundColor);
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
                if (Clients[ClientListView.SelectedItems[0].Index].Comment != "")
                {
                    MessageBox.Show($"{Clients[ClientListView.SelectedItems[0].Index].Comment}", "Коментар", MessageBoxButtons.OK);
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
                Mototransport mototransport = Clients[ClientListView.SelectedItems[0].Index].BoughtMoto;
                if (mototransport is Motorcycle motorcycle)
                {
                    if (motorcycle == null)
                        return;
                    MessageBox.Show($"Тип: Мотоцикл\n\nБренд: {mototransport.Brand}\n\nМодель: {mototransport.Model}\n\nЦіна: {mototransport.Price}\n\nОб'єм двигуна: {mototransport.Volume}\n\nТип мотоцикла: {motorcycle.TypeMotorcycle}\n\n", "Мототранспорт", MessageBoxButtons.OK);
                }
                else if(mototransport is Scooter scooter)
                {
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
                // Classical variant with using 'Thread' for multithreading operations
                Thread dbClientRemovalThread = new Thread(async () =>
                {
                    await DataService.RemoveClientAsync(Clients[ClientListView.SelectedItems[0].Index]);
                });

                Thread listClientRemovalThread = new Thread(() =>
                {
                    Clients.Remove(Clients[ClientListView.SelectedItems[0].Index]);
                });

                dbClientRemovalThread.Start();
                listClientRemovalThread.Start();

                dbClientRemovalThread.Join();
                listClientRemovalThread.Join();

                /*// Variant with using TPL(Task Parallel Library) and 'Task' class from it specifically for multithreading operations
                Task dbClientRemovalTask = Task.Run(async () =>
                {
                    await DataService.RemoveClientAsync(Clients[ClientListView.SelectedItems[0].Index]);
                });

                Task listClientRemovalTask = Task.Run(() =>
                {
                    Clients.Remove(Clients[ClientListView.SelectedItems[0].Index]);
                });

                Task.WhenAll(dbClientRemovalTask, listClientRemovalTask).Wait();*/

                AddToListView(Clients, ChangeBackGroundColor);
                WorkingWithFiles.WritingToFile(Clients, "Clients.bin");
            }
            else
            {
                MessageBox.Show("Виберіть хоча б одного клієнта");
            }
        }
    }
}
