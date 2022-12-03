
namespace Motosalon
{
    partial class SuccessfulOrderForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientSurname = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дякуємо за замовлення!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(666, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Найближчим часом з вами зв\'яжуться наші менеджери.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Будьте на зв\'язку!  ";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(322, 325);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(139, 53);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ClientSurname
            // 
            this.ClientSurname.AutoSize = true;
            this.ClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSurname.Location = new System.Drawing.Point(255, 109);
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.Size = new System.Drawing.Size(147, 20);
            this.ClientSurname.TabIndex = 32;
            this.ClientSurname.Text = "Ваше прізвище: ";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(255, 76);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 20);
            this.ClientName.TabIndex = 35;
            this.ClientName.Text = "Ваше ім\'я: ";
            // 
            // ClientPhone
            // 
            this.ClientPhone.AutoSize = true;
            this.ClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPhone.Location = new System.Drawing.Point(255, 145);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(206, 20);
            this.ClientPhone.TabIndex = 34;
            this.ClientPhone.Text = "Ваш номер телефону:  ";
            // 
            // SuccessfulOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientPhone);
            this.Controls.Add(this.ClientSurname);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SuccessfulOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessfulOrderForm";
            this.Load += new System.EventHandler(this.SuccessfulOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ClientSurname;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ClientPhone;
    }
}