using Motosalon.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class ClientInfoEntryForm : Form
    {
        private Mototransport Mototransport;
        private MotoContext Db;

        public ClientInfoEntryForm(Mototransport mototransport,MotoContext db)
        {
            InitializeComponent();
            this.Mototransport = mototransport;
            this.Db = db;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            Client client;

            if (NameTextBox.Text == "" || SurnameTextBox.Text == "")
            {
                MessageBox.Show("Перевірте правильність вводу");
                return;
            }
            /*for (int i = 0; i < 10; i++)
            {
                PhoneTextBox.Text
            }*/
            try
            {
                client = new Client(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, CommentTextBox.Text, Mototransport);
            }
            catch (PhoneException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                return;
            }
            catch (CommentException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tДовжина рядка: {ex.Value}");
                return;
            }
            SuccessfulOrderForm form = new SuccessfulOrderForm(client,Db);
            this.Visible = false;
            this.Close();
            form.ShowDialog();
        }

        private void CommentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CommentTextBox.Text.Length != 0)
            {
                AmountSymbolLabel.Visible = true;
                AmountSymbolLabel.Text = "Кількість символів: " + CommentTextBox.Text.Length;
            }
            else
            {
                AmountSymbolLabel.Visible = false;
            }
        }

        private void ClientInfoEntryForm_Load(object sender, EventArgs e)
        {
            AmountSymbolLabel.Visible = false;
            BackColor = Color.LightGray;
        }
    }
}
