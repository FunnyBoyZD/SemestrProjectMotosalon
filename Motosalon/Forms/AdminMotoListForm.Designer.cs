
namespace Motosalon
{
    partial class AdminMotoListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MotoListView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowMotoButton = new System.Windows.Forms.Button();
            this.ShowAddPanelButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ExtraFieldLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ExtraComboBox = new System.Windows.Forms.ComboBox();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteMotoButton = new System.Windows.Forms.Button();
            this.AmountMotoLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SumLabel);
            this.panel1.Controls.Add(this.AmountMotoLabel);
            this.panel1.Controls.Add(this.ModelComboBox);
            this.panel1.Controls.Add(this.ModelLabel);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.VolumeTextBox);
            this.panel1.Controls.Add(this.ExtraComboBox);
            this.panel1.Controls.Add(this.BrandComboBox);
            this.panel1.Controls.Add(this.TypeComboBox);
            this.panel1.Controls.Add(this.ExtraFieldLabel);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.VolumeLabel);
            this.panel1.Controls.Add(this.BrandLabel);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 577);
            this.panel1.TabIndex = 0;
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
            this.MotoListView.Location = new System.Drawing.Point(316, 12);
            this.MotoListView.Name = "MotoListView";
            this.MotoListView.Size = new System.Drawing.Size(746, 505);
            this.MotoListView.TabIndex = 1;
            this.MotoListView.UseCompatibleStateImageBehavior = false;
            this.MotoListView.View = System.Windows.Forms.View.Details;
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
            // ShowMotoButton
            // 
            this.ShowMotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMotoButton.Location = new System.Drawing.Point(851, 524);
            this.ShowMotoButton.Name = "ShowMotoButton";
            this.ShowMotoButton.Size = new System.Drawing.Size(211, 42);
            this.ShowMotoButton.TabIndex = 3;
            this.ShowMotoButton.Text = "Характеристики";
            this.ShowMotoButton.UseVisualStyleBackColor = true;
            this.ShowMotoButton.Click += new System.EventHandler(this.ShowMotoButton_Click);
            // 
            // ShowAddPanelButton
            // 
            this.ShowAddPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAddPanelButton.Location = new System.Drawing.Point(592, 524);
            this.ShowAddPanelButton.Name = "ShowAddPanelButton";
            this.ShowAddPanelButton.Size = new System.Drawing.Size(211, 42);
            this.ShowAddPanelButton.TabIndex = 5;
            this.ShowAddPanelButton.Text = "Додати мото";
            this.ShowAddPanelButton.UseVisualStyleBackColor = true;
            this.ShowAddPanelButton.Click += new System.EventHandler(this.ShowAddPanelButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(11, 100);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(44, 20);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Тип:";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandLabel.Location = new System.Drawing.Point(11, 130);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(68, 20);
            this.BrandLabel.TabIndex = 7;
            this.BrandLabel.Text = "Бренд:";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeLabel.Location = new System.Drawing.Point(11, 192);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(62, 20);
            this.VolumeLabel.TabIndex = 8;
            this.VolumeLabel.Text = "Об\'єм:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(11, 220);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(51, 20);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Ціна:";
            // 
            // ExtraFieldLabel
            // 
            this.ExtraFieldLabel.AutoSize = true;
            this.ExtraFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraFieldLabel.Location = new System.Drawing.Point(11, 250);
            this.ExtraFieldLabel.Name = "ExtraFieldLabel";
            this.ExtraFieldLabel.Size = new System.Drawing.Size(108, 20);
            this.ExtraFieldLabel.TabIndex = 10;
            this.ExtraFieldLabel.Text = "Додаткове:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Мотоцикл",
            "Скутер"});
            this.TypeComboBox.Location = new System.Drawing.Point(174, 100);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.TypeComboBox.TabIndex = 11;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(174, 130);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(121, 24);
            this.BrandComboBox.TabIndex = 12;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ExtraComboBox
            // 
            this.ExtraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtraComboBox.FormattingEnabled = true;
            this.ExtraComboBox.Location = new System.Drawing.Point(174, 246);
            this.ExtraComboBox.Name = "ExtraComboBox";
            this.ExtraComboBox.Size = new System.Drawing.Size(121, 24);
            this.ExtraComboBox.TabIndex = 13;
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(174, 190);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(121, 22);
            this.VolumeTextBox.TabIndex = 14;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(174, 218);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(121, 22);
            this.PriceTextBox.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(124, 294);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 28);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(11, 160);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(80, 20);
            this.ModelLabel.TabIndex = 17;
            this.ModelLabel.Text = "Модель:";
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(174, 160);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(121, 24);
            this.ModelComboBox.TabIndex = 18;
            // 
            // DeleteMotoButton
            // 
            this.DeleteMotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMotoButton.Location = new System.Drawing.Point(316, 524);
            this.DeleteMotoButton.Name = "DeleteMotoButton";
            this.DeleteMotoButton.Size = new System.Drawing.Size(211, 42);
            this.DeleteMotoButton.TabIndex = 5;
            this.DeleteMotoButton.Text = "Видалити мото ";
            this.DeleteMotoButton.UseVisualStyleBackColor = true;
            this.DeleteMotoButton.Click += new System.EventHandler(this.DeleteMotoButton_Click);
            // 
            // AmountMotoLabel
            // 
            this.AmountMotoLabel.AutoSize = true;
            this.AmountMotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountMotoLabel.Location = new System.Drawing.Point(11, 19);
            this.AmountMotoLabel.Name = "AmountMotoLabel";
            this.AmountMotoLabel.Size = new System.Drawing.Size(222, 20);
            this.AmountMotoLabel.TabIndex = 19;
            this.AmountMotoLabel.Text = "Всього мототранспорту: ";
            this.AmountMotoLabel.Click += new System.EventHandler(this.AmountMotoLabel_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(11, 51);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(138, 20);
            this.SumLabel.TabIndex = 20;
            this.SumLabel.Text = "Загальна ціна: ";
            // 
            // AdminMotoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 578);
            this.Controls.Add(this.ShowAddPanelButton);
            this.Controls.Add(this.DeleteMotoButton);
            this.Controls.Add(this.ShowMotoButton);
            this.Controls.Add(this.MotoListView);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMotoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMotoListForm";
            this.Load += new System.EventHandler(this.AdminMotoListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView MotoListView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label ExtraFieldLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button ShowAddPanelButton;
        private System.Windows.Forms.Button ShowMotoButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.ComboBox ExtraComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button DeleteMotoButton;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label AmountMotoLabel;
    }
}