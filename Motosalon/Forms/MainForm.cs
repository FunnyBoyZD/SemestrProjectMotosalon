using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Motosalon
{
    delegate void ChangeStyle(ListViewItem item, Color color);
    public partial class MainForm : Form
    {
        private WorkingWithFiles<Dictionary<string, List<string>>> FileBrands = new WorkingWithFiles<Dictionary<string, List<string>>>();
        private WorkingWithFiles<List<Mototransport>> FileMoto = new WorkingWithFiles<List<Mototransport>>();
        private Dictionary<string, List<string>> BrandModelMotorcycle;
        private Dictionary<string, List<string>> BrandModelScooter;
        private List<Mototransport> Mototransports;
        private List<Mototransport> FiltredMoto = new List<Mototransport>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            panel1.BackColor = Color.Aquamarine;
            MotoListButton.Visible = false;
            ClientListButton.Visible = false;
            panel2.BackColor = Color.LightBlue;
            panel2.Visible = false;

            BrandModelMotorcycle = FileBrands.ReadingFromFile("BrandModelMotorcycle.bin");
            if (BrandModelMotorcycle == null)
            {
                MessageBox.Show("Не вдалося прочитати файл");
                return;
            }

            BrandModelScooter = FileBrands.ReadingFromFile("BrandModelScooter.bin");
            if (BrandModelScooter == null)
            {
                MessageBox.Show("Не вдалося прочитати файл");
                return;
            }

            Mototransports = FileMoto.ReadingFromFile("MotoTransport.bin");
            if (Mototransports == null)
            {
                MessageBox.Show("Не вдалося прочитати файл");
                return;
            }

            foreach (var moto in Mototransports)
            {
                FiltredMoto.Add(moto);
            }

            AddMotoToListView(FiltredMoto, ChangeBackGroundColor, ChangeForeColor);
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

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrandComboBox.Text = "";
            ModelComboBox.Text = "";
            BrandComboBox.Items.Clear();
            ModelComboBox.Items.Clear();
            if (TypeComboBox.Text == "Мотоцикл")
            {
                foreach (var brand in BrandModelMotorcycle)
                {
                    BrandComboBox.Items.Add(brand.Key);
                }
            }
            else
            {
                foreach (var brand in BrandModelScooter)
                {
                    BrandComboBox.Items.Add(brand.Key);
                }
            }
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelComboBox.Text = "";
            ModelComboBox.Items.Clear();
            if (TypeComboBox.Text == "Мотоцикл")
            {
                foreach (var brand in BrandModelMotorcycle)
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
                foreach (var brand in BrandModelScooter)
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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            int VolumeFrom = 0;
            int VolumeTo = 0;
            int PriceTo = 0;
            int PriceFrom = 0;
            Motorcycle motorcycleFrom;
            Motorcycle motorcycleTo;
            Scooter scooterFrom;
            Scooter scooterTo;
            Mototransport mototransportFrom;
            Mototransport mototransportTo;

            if (VolumeFromBox.Text != "" && Int32.TryParse(VolumeFromBox.Text, out VolumeFrom) == false)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }

            if (VolumeToBox.Text != "" && Int32.TryParse(VolumeToBox.Text, out VolumeTo) == false)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }
            if (VolumeFromBox.Text != "" && VolumeToBox.Text != "" && VolumeFrom > VolumeTo)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }


            if (PriceFromBox.Text != "" && Int32.TryParse(PriceFromBox.Text, out PriceFrom) == false)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }

            if (PriceToBox.Text != "" && Int32.TryParse(PriceToBox.Text, out PriceTo) == false)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }
            if (PriceFromBox.Text != "" && PriceToBox.Text != "" && PriceFrom > PriceTo)
            {
                MessageBox.Show("Перевірте правильність вводу об'єму двигуна");
                return;
            }

            if (TypeComboBox.Text == "Мотоцикл")
            {
                try
                {
                    motorcycleFrom = new Motorcycle(BrandComboBox.Text, ModelComboBox.Text, PriceFrom, VolumeFrom, "");
                    motorcycleTo = new Motorcycle(BrandComboBox.Text, ModelComboBox.Text, PriceTo, VolumeTo, "");
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
                FiltredMoto = FiltringList(motorcycleFrom, motorcycleTo);
            }
            else if (TypeComboBox.Text == "Скутер")
            {
                try
                {
                    scooterFrom = new Scooter(BrandComboBox.Text, ModelComboBox.Text, PriceFrom, VolumeFrom, "");
                    scooterTo = new Scooter(BrandComboBox.Text, ModelComboBox.Text, PriceTo, VolumeTo, "");
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
                FiltredMoto = FiltringList(scooterFrom, scooterTo);
            }
            else
            {
                try
                {
                    mototransportFrom = new Mototransport(BrandComboBox.Text, ModelComboBox.Text, PriceFrom, VolumeFrom);
                    mototransportTo = new Mototransport(BrandComboBox.Text, ModelComboBox.Text, PriceTo, VolumeTo);
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
                FiltredMoto = FiltringList(mototransportFrom, mototransportTo);
            }
            MotoListView.Items.Clear();
            AddMotoToListView(FiltredMoto, ChangeBackGroundColor, ChangeForeColor);

        }

        private List<Mototransport> FiltringList(Mototransport mototransportFrom, Mototransport mototransportTo)
        {
            List<Mototransport> filtredMoto = new List<Mototransport>();

            foreach (var mototransport in Mototransports)
            {
                if (mototransport.Filter(mototransportFrom, mototransportTo) == true)
                {
                    filtredMoto.Add(mototransport);
                }
            }
            return filtredMoto;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (FiltredMoto.Count == 0)
                return;

            FiltredMoto.Sort();
            MotoListView.Items.Clear();
            AddMotoToListView(FiltredMoto, ChangeBackGroundColor, ChangeForeColor);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Mototransport mototransport;
            if (MotoListView.SelectedItems.Count == 1)
            {
                DialogResult result = default(DialogResult);
                mototransport = FiltredMoto[MotoListView.SelectedItems[0].Index];
                //new confirmation form
                if (mototransport.GetType().Name == "Motorcycle")
                {
                    Motorcycle motorcycle = mototransport as Motorcycle;
                    if (motorcycle == null)
                        return;
                    result = MessageBox.Show($"Тип: Мотоцикл\n\nБренд: {mototransport.Brand}\n\nМодель: {mototransport.Model}\n\nЦіна: {mototransport.Price}\n\nОб'єм двигуна: {mototransport.Volume}\n\nТип мотоцикла: {motorcycle.TypeMotorcycle}\n\n", "Підтвердження замовлення", MessageBoxButtons.OKCancel);
                }
                else
                {
                    Scooter scooter = mototransport as Scooter;
                    if (scooter == null)
                        return;
                    result = MessageBox.Show($"Тип: Скутер\n\nБренд: {mototransport.Brand}\n\nМодель: {mototransport.Model}\n\nЦіна: {mototransport.Price}\n\nОб'єм двигуна: {mototransport.Volume}\n\nТип скутера: {scooter.TypeScooter}\n\n", "Підтвердження замовлення", MessageBoxButtons.OKCancel);
                }
                if (result == DialogResult.OK)
                {
                    ClientInfoEntryForm form = new ClientInfoEntryForm(mototransport);
                    form.ShowDialog();
                }
            }
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            TypeComboBox.Text = "";
            TypeComboBox.Items.Clear();
            TypeComboBox.Items.Add("Мотоцикл");
            TypeComboBox.Items.Add("Скутер");
            BrandComboBox.Text = "";
            BrandComboBox.Items.Clear();
            ModelComboBox.Text = "";
            ModelComboBox.Items.Clear();
            VolumeFromBox.Text = "";
            VolumeToBox.Text = "";
            PriceFromBox.Text = "";
            PriceToBox.Text = "";
        }

        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                AdminButton.BackColor = Color.LightBlue;
                panel2.Visible = true;
                ClientListButton.Visible = true;
                MotoListButton.Visible = true;
            }
            else
            {
                AdminButton.BackColor = Color.WhiteSmoke;
                panel2.Visible = false;
                ClientListButton.Visible = false;
                MotoListButton.Visible = false;
            }

        }

        private void MotoListButton_Click(object sender, EventArgs e)
        {
            AdminMotoListForm form = new AdminMotoListForm(ref Mototransports);
            form.ShowDialog();
            AddMotoToListView(Mototransports, ChangeBackGroundColor, ChangeForeColor);
            ClearFilterButton.PerformClick();
            FiltredMoto.Clear();
            for (int i = 0; i < Mototransports.Count; i++)
            {
                FiltredMoto.Add(Mototransports[i]);
            }
        }

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            ListClientsForm form = new ListClientsForm();
            form.ShowDialog();
        }
    }
}
