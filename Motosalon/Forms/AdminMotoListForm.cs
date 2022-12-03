using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Motosalon
{
    public partial class AdminMotoListForm : Form
    {
        private WorkingWithFiles<List<Mototransport>> FileMoto;
        private WorkingWithFiles<Dictionary<string, List<string>>> FileBrandModel;
        private WorkingWithFiles<List<string>> FileType;
        private List<Mototransport> mototransports;
        private Dictionary<string, List<string>> brandModelMotorcycle;
        private Dictionary<string, List<string>> brandModelScooter;
        private List<string> typeMotorcycle;
        private List<string> typeScooter;
        public AdminMotoListForm()
        {
            InitializeComponent();
            FileMoto = new WorkingWithFiles<List<Mototransport>>();
            FileBrandModel = new WorkingWithFiles<Dictionary<string, List<string>>>();
            FileType = new WorkingWithFiles<List<string>>();
        }
        public AdminMotoListForm(ref List<Mototransport> mototransports)
        {
            InitializeComponent();
            FileMoto = new WorkingWithFiles<List<Mototransport>>();
            this.mototransports = mototransports;
            FileMoto = new WorkingWithFiles<List<Mototransport>>();
            FileBrandModel = new WorkingWithFiles<Dictionary<string, List<string>>>();
            FileType = new WorkingWithFiles<List<string>>();
        }

        private void AmountMotoShow()
        {
            AmountMotoLabel.Text = "Всього мототранспорту: " + mototransports.Count;
        }

        private void SumMotoShow()
        {
            int Sum = 0;
            foreach (var mototransport in mototransports)
            {
                Sum += mototransport.Price;
            }
            SumLabel.Text = "Загальна ціна: " + Sum + "$";
        }

        private void AdminMotoListForm_Load(object sender, EventArgs e)
        {
            AmountMotoShow();
            SumMotoShow();
            BackColor = Color.LightGray;
            panel1.Visible = true;
            TypeLabel.Visible = false;
            BrandLabel.Visible = false;
            ModelLabel.Visible = false;
            VolumeLabel.Visible = false;
            PriceLabel.Visible = false;
            ExtraFieldLabel.Visible = false;
            TypeComboBox.Visible = false;
            BrandComboBox.Visible = false;
            ModelComboBox.Visible = false;
            VolumeTextBox.Visible = false;
            PriceTextBox.Visible = false;
            ExtraComboBox.Visible = false;
            AddButton.Visible = false;


            brandModelMotorcycle = FileBrandModel.ReadingFromFile("BrandModelMotorcycle.bin");
            brandModelScooter = FileBrandModel.ReadingFromFile("BrandModelScooter.bin");
            typeMotorcycle = FileType.ReadingFromFile("Typemotorcycle.bin");
            typeScooter = FileType.ReadingFromFile("TypeScooter.bin");

            if (brandModelMotorcycle == null || brandModelScooter == null || typeMotorcycle == null || typeScooter == null)
            {
                MessageBox.Show("Не вдалося зчитати файл");
                return;
            }
            /*mototransports = FileMoto.ReadingFromFile("MotoTransport.bin");*/
            AddMotoToListView(mototransports, ChangeBackGroundColor, ChangeForeColor);
        }
        private void AddMotoToListView(List<Mototransport> mototransports, ChangeStyle changeStyleMotoLines, ChangeStyle changeStyleScooterLines)
        {
            MotoListView.Items.Clear();
            ListViewItem item = null;
            foreach (var mototransport in mototransports)
            {
                item = new ListViewItem(new string[] { mototransport.GetType().Name == "Motorcycle" ? "Мотоцикл" : "Скутер", mototransport.Brand, mototransport.Model, mototransport.Price.ToString(), mototransport.Volume.ToString() });
                if (mototransport.GetType().Name == "Motorcycle")
                {
                    changeStyleMotoLines(item, Color.LightGray);
                }
                else
                {
                    changeStyleScooterLines(item, Color.Brown);
                }
                MotoListView.Items.Add(item);
            }
        }
        private void ChangeBackGroundColor(ListViewItem item, Color color)
        {
            item.SubItems[0].BackColor = color;
        }
        private void ChangeForeColor(ListViewItem item, Color color)
        {
            item.SubItems[0].ForeColor = color;
        }

        private void ShowMotoButton_Click(object sender, EventArgs e)
        {
            if (MotoListView.SelectedItems.Count == 1)
            {
                Mototransport mototransport = mototransports[MotoListView.SelectedItems[0].Index];
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
                MessageBox.Show("Виберіть хоча б один мототранспорт");
            }
        }

        private void DeleteMotoButton_Click(object sender, EventArgs e)
        {
            if (MotoListView.SelectedItems.Count == 1)
            {
                mototransports.Remove(mototransports[MotoListView.SelectedItems[0].Index]);
                FileMoto.WritingToFile(mototransports, "MotoTransport.bin");
                AddMotoToListView(mototransports, ChangeBackGroundColor, ChangeForeColor);
                AmountMotoShow();
                SumMotoShow();
            }
            else
            {
                MessageBox.Show("Виберіть хоча б один мототранспорт");
            }
        }

        private void ShowAddPanelButton_Click(object sender, EventArgs e)
        {
            if (TypeLabel.Visible == false)
            {
                ShowAddPanelButton.BackColor = Color.LightBlue;
                AmountMotoLabel.Visible = false;
                SumLabel.Visible = false;
                panel1.BackColor = Color.Aquamarine;
                TypeLabel.Visible = true;
                BrandLabel.Visible = true;
                ModelLabel.Visible = true;
                VolumeLabel.Visible = true;
                PriceLabel.Visible = true;
                //ExtraFieldLabel.Visible = false;
                TypeComboBox.Visible = true;
                BrandComboBox.Visible = true;
                ModelComboBox.Visible = true;
                VolumeTextBox.Visible = true;
                PriceTextBox.Visible = true;
                //ExtraComboBox.Visible = false;
                AddButton.Visible = true;
            }
            else
            {
                ShowAddPanelButton.BackColor = Color.WhiteSmoke;
                AmountMotoLabel.Visible = true;
                SumLabel.Visible = true;
                panel1.BackColor = Color.Transparent;
                TypeLabel.Visible = false;
                BrandLabel.Visible = false;
                ModelLabel.Visible = false;
                VolumeLabel.Visible = false;
                PriceLabel.Visible = false;
                ExtraFieldLabel.Visible = false;
                TypeComboBox.Visible = false;
                BrandComboBox.Visible = false;
                ModelComboBox.Visible = false;
                VolumeTextBox.Visible = false;
                PriceTextBox.Visible = false;
                ExtraComboBox.Visible = false;
                AddButton.Visible = false;
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandComboBox.Text = "";
            BrandComboBox.Items.Clear();
            ModelComboBox.Text = "";
            ModelComboBox.Items.Clear();
            ExtraComboBox.Items.Clear();
            if (TypeComboBox.Text == "Мотоцикл")
            {
                foreach (var brand in brandModelMotorcycle)
                {
                    BrandComboBox.Items.Add(brand.Key);
                }
                ExtraFieldLabel.Visible = true;
                ExtraFieldLabel.Text = "Тип мотоцикла: ";
                ExtraComboBox.Visible = true;
                foreach (var type in typeMotorcycle)
                {
                    ExtraComboBox.Items.Add(type);
                }
            }
            else
            {
                foreach (var brand in brandModelScooter)
                {
                    BrandComboBox.Items.Add(brand.Key);
                }
                ExtraFieldLabel.Visible = true;
                ExtraFieldLabel.Text = "Тип скутера: ";
                ExtraComboBox.Visible = true;
                foreach (var type in typeScooter)
                {
                    ExtraComboBox.Items.Add(type);
                }
            }

        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelComboBox.Text = "";
            ModelComboBox.Items.Clear();
            if (TypeComboBox.Text == "Мотоцикл")
            {
                foreach (var brand in brandModelMotorcycle)
                {
                    if (BrandComboBox.Text == brand.Key)
                    {
                        for (int i = 0; i < brand.Value.Count; i++)
                        {
                            ModelComboBox.Items.Add(brand.Value[i]);
                        }
                        break;
                    }
                }
            }
            else
            {
                foreach (var brand in brandModelScooter)
                {
                    if (BrandComboBox.Text == brand.Key)
                    {
                        for (int i = 0; i < brand.Value.Count; i++)
                        {
                            ModelComboBox.Items.Add(brand.Value[i]);
                        }
                        break;
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int Price = 0;
            int Volume = 0;
            Motorcycle motorcycle = null;
            Scooter scooter = null;
            if (TypeComboBox.Text == "" || BrandComboBox.Text == "" || ModelComboBox.Text == "" || VolumeTextBox.Text == "" || PriceTextBox.Text == "" || ExtraComboBox.Text == "")
            {
                MessageBox.Show("Всі поля повинні бути заповненими");
                return;
            }
            if (Int32.TryParse(VolumeTextBox.Text, out Volume) == false || Int32.TryParse(PriceTextBox.Text, out Price) == false)
            {
                MessageBox.Show("Перевірте правильність вводу числових значеннь");
                return;
            }
            if (TypeComboBox.Text == "Мотоцикл")
            {
                try
                {
                    motorcycle = new Motorcycle(BrandComboBox.Text, ModelComboBox.Text, Price, Volume, ExtraComboBox.Text);
                }
                catch (PriceException ex)
                {

                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (VolumeException ex)
                {

                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (TypeMotorcycleException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                mototransports.Add(motorcycle);
            }
            else
            {
                try
                {
                    scooter = new Scooter(BrandComboBox.Text, ModelComboBox.Text, Price, Volume, ExtraComboBox.Text);
                }
                catch (PriceException ex)
                {

                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (VolumeException ex)
                {

                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (TypeScooterException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                mototransports.Add(scooter);
            }
            AddMotoToListView(mototransports, ChangeBackGroundColor, ChangeForeColor);
            FileMoto.WritingToFile(mototransports, "MotoTransport.bin");
            AmountMotoShow();
            SumMotoShow();
            MessageBox.Show("Успішно додано", "Повідомлення", MessageBoxButtons.OK);
        }

        private void AmountMotoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
