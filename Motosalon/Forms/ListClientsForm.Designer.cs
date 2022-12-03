
namespace Motosalon
{
    partial class ListClientsForm
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
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientMoto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientListView = new System.Windows.Forms.ListView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowMotoButton = new System.Windows.Forms.Button();
            this.ShowCommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientListView
            // 
            this.ClientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.ClientSurname,
            this.ClientPhone,
            this.ClientComment,
            this.ClientMoto});
            this.ClientListView.FullRowSelect = true;
            this.ClientListView.GridLines = true;
            this.ClientListView.HideSelection = false;
            this.ClientListView.Location = new System.Drawing.Point(12, 12);
            this.ClientListView.Name = "ClientListView";
            this.ClientListView.Size = new System.Drawing.Size(830, 420);
            this.ClientListView.TabIndex = 0;
            this.ClientListView.UseCompatibleStateImageBehavior = false;
            this.ClientListView.View = System.Windows.Forms.View.Details;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Ім\'я";
            this.ClientName.Width = 125;
            // 
            // ClientSurname
            // 
            this.ClientSurname.Text = "Прізвище";
            this.ClientSurname.Width = 114;
            // 
            // ClientPhone
            // 
            this.ClientPhone.Text = "Номер телефона";
            this.ClientPhone.Width = 148;
            // 
            // ClientComment
            // 
            this.ClientComment.Text = "Коментар";
            this.ClientComment.Width = 81;
            // 
            // ClientMoto
            // 
            this.ClientMoto.Text = "Придбаний мототранспорт";
            this.ClientMoto.Width = 217;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 438);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(211, 42);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Видалити клієнта";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowMotoButton
            // 
            this.ShowMotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMotoButton.Location = new System.Drawing.Point(631, 438);
            this.ShowMotoButton.Name = "ShowMotoButton";
            this.ShowMotoButton.Size = new System.Drawing.Size(211, 42);
            this.ShowMotoButton.TabIndex = 2;
            this.ShowMotoButton.Text = "Характеристики мото ";
            this.ShowMotoButton.UseVisualStyleBackColor = true;
            this.ShowMotoButton.Click += new System.EventHandler(this.ShowMotoButton_Click);
            // 
            // ShowCommentButton
            // 
            this.ShowCommentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCommentButton.Location = new System.Drawing.Point(321, 438);
            this.ShowCommentButton.Name = "ShowCommentButton";
            this.ShowCommentButton.Size = new System.Drawing.Size(211, 42);
            this.ShowCommentButton.TabIndex = 3;
            this.ShowCommentButton.Text = "Показати коментар";
            this.ShowCommentButton.UseVisualStyleBackColor = true;
            this.ShowCommentButton.Click += new System.EventHandler(this.ShowCommentButton_Click);
            // 
            // ListClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.ShowCommentButton);
            this.Controls.Add(this.ShowMotoButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClientListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListClientsForm";
            this.Load += new System.EventHandler(this.ListClientsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader ClientSurname;
        private System.Windows.Forms.ColumnHeader ClientPhone;
        private System.Windows.Forms.ColumnHeader ClientComment;
        private System.Windows.Forms.ColumnHeader ClientMoto;
        private System.Windows.Forms.ListView ClientListView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowMotoButton;
        private System.Windows.Forms.Button ShowCommentButton;
    }
}