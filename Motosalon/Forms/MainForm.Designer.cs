
namespace Motosalon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotoListView = new System.Windows.Forms.ListView();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.PriceToBox = new System.Windows.Forms.TextBox();
            this.PriceFromBox = new System.Windows.Forms.TextBox();
            this.VolumeToBox = new System.Windows.Forms.TextBox();
            this.VolumeFromBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.ClientListButton = new System.Windows.Forms.Button();
            this.MotoListButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Text = "Тип мототранспорту";
            this.Type.Width = 150;
            // 
            // Brand
            // 
            this.Brand.Text = "Бренд";
            this.Brand.Width = 122;
            // 
            // Model
            // 
            this.Model.Text = "Модель";
            this.Model.Width = 119;
            // 
            // Price
            // 
            this.Price.Text = "Ціна($)";
            this.Price.Width = 85;
            // 
            // Volume
            // 
            this.Volume.Text = "Об\'єм двигуна(см^3)";
            this.Volume.Width = 172;
            // 
            // MotoListView
            // 
            this.MotoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Brand,
            this.Model,
            this.Price,
            this.Volume});
            this.MotoListView.FullRowSelect = true;
            this.MotoListView.GridLines = true;
            this.MotoListView.HideSelection = false;
            this.MotoListView.Location = new System.Drawing.Point(368, 10);
            this.MotoListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MotoListView.Name = "MotoListView";
            this.MotoListView.Size = new System.Drawing.Size(578, 411);
            this.MotoListView.TabIndex = 0;
            this.MotoListView.UseCompatibleStateImageBehavior = false;
            this.MotoListView.View = System.Windows.Forms.View.Details;
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(170, 52);
            this.BrandComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(114, 21);
            this.BrandComboBox.TabIndex = 2;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(170, 84);
            this.ModelComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(114, 21);
            this.ModelComboBox.TabIndex = 5;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Мотоцикл",
            "Скутер"});
            this.TypeComboBox.Location = new System.Drawing.Point(170, 21);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(114, 21);
            this.TypeComboBox.TabIndex = 6;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // PriceToBox
            // 
            this.PriceToBox.Location = new System.Drawing.Point(233, 155);
            this.PriceToBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceToBox.Name = "PriceToBox";
            this.PriceToBox.Size = new System.Drawing.Size(50, 20);
            this.PriceToBox.TabIndex = 12;
            // 
            // PriceFromBox
            // 
            this.PriceFromBox.Location = new System.Drawing.Point(170, 155);
            this.PriceFromBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceFromBox.Name = "PriceFromBox";
            this.PriceFromBox.Size = new System.Drawing.Size(50, 20);
            this.PriceFromBox.TabIndex = 11;
            // 
            // VolumeToBox
            // 
            this.VolumeToBox.Location = new System.Drawing.Point(233, 123);
            this.VolumeToBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VolumeToBox.Name = "VolumeToBox";
            this.VolumeToBox.Size = new System.Drawing.Size(50, 20);
            this.VolumeToBox.TabIndex = 10;
            // 
            // VolumeFromBox
            // 
            this.VolumeFromBox.Location = new System.Drawing.Point(170, 123);
            this.VolumeFromBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VolumeFromBox.Name = "VolumeFromBox";
            this.VolumeFromBox.Size = new System.Drawing.Size(50, 20);
            this.VolumeFromBox.TabIndex = 9;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(368, 428);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(115, 32);
            this.SortButton.TabIndex = 14;
            this.SortButton.Text = "Сортувати";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectButton.Location = new System.Drawing.Point(830, 428);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(115, 32);
            this.SelectButton.TabIndex = 15;
            this.SelectButton.Text = "Обрати";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(16, 210);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(115, 32);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Фільтрувати";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFilterButton.Location = new System.Drawing.Point(170, 210);
            this.ClearFilterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(115, 32);
            this.ClearFilterButton.TabIndex = 15;
            this.ClearFilterButton.Text = "Очистити поля";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // ClientListButton
            // 
            this.ClientListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientListButton.Location = new System.Drawing.Point(184, 61);
            this.ClientListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientListButton.Name = "ClientListButton";
            this.ClientListButton.Size = new System.Drawing.Size(123, 43);
            this.ClientListButton.TabIndex = 19;
            this.ClientListButton.Text = "Список клієнтів";
            this.ClientListButton.UseVisualStyleBackColor = true;
            this.ClientListButton.Click += new System.EventHandler(this.ClientListButton_Click);
            // 
            // MotoListButton
            // 
            this.MotoListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotoListButton.Location = new System.Drawing.Point(32, 61);
            this.MotoListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MotoListButton.Name = "MotoListButton";
            this.MotoListButton.Size = new System.Drawing.Size(133, 43);
            this.MotoListButton.TabIndex = 18;
            this.MotoListButton.Text = "Список мототранспорту";
            this.MotoListButton.UseVisualStyleBackColor = true;
            this.MotoListButton.Click += new System.EventHandler(this.MotoListButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Location = new System.Drawing.Point(16, 270);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(115, 32);
            this.AdminButton.TabIndex = 18;
            this.AdminButton.Text = "Адмін. панель";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бренд: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Модель: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип мототранспорта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Об\'єм(від/до): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ціна(від/до): ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ClearFilterButton);
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.PriceToBox);
            this.panel1.Controls.Add(this.PriceFromBox);
            this.panel1.Controls.Add(this.VolumeToBox);
            this.panel1.Controls.Add(this.VolumeFromBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TypeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ModelComboBox);
            this.panel1.Controls.Add(this.BrandComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 473);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClientListButton);
            this.panel2.Controls.Add(this.MotoListButton);
            this.panel2.Location = new System.Drawing.Point(2, 306);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 164);
            this.panel2.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 470);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.MotoListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ListView MotoListView;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox PriceToBox;
        private System.Windows.Forms.TextBox PriceFromBox;
        private System.Windows.Forms.TextBox VolumeToBox;
        private System.Windows.Forms.TextBox VolumeFromBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.Button ClientListButton;
        private System.Windows.Forms.Button MotoListButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}