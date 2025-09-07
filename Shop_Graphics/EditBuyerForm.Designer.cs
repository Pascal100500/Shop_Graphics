namespace Shop_Graphics
{
    partial class EditBuyerForm
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtLoginEdit = new System.Windows.Forms.TextBox();
            this.labelLoginEdit = new System.Windows.Forms.Label();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.labelPasswordEdit = new System.Windows.Forms.Label();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.labelFirstNameEdit = new System.Windows.Forms.Label();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.labelLastNameEdit = new System.Windows.Forms.Label();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.labelEmailEdit = new System.Windows.Forms.Label();
            this.txtPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.labelPhoneNumberEdit = new System.Windows.Forms.Label();
            this.dtpRegistrationDateEdit = new System.Windows.Forms.DateTimePicker();
            this.labelRegistrationDateEdit = new System.Windows.Forms.Label();
            this.labelBuyerEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(180, 355);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(93, 47);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtLoginEdit
            // 
            this.txtLoginEdit.Location = new System.Drawing.Point(161, 58);
            this.txtLoginEdit.Name = "txtLoginEdit";
            this.txtLoginEdit.Size = new System.Drawing.Size(100, 20);
            this.txtLoginEdit.TabIndex = 1;
            // 
            // labelLoginEdit
            // 
            this.labelLoginEdit.AutoSize = true;
            this.labelLoginEdit.Location = new System.Drawing.Point(99, 58);
            this.labelLoginEdit.Name = "labelLoginEdit";
            this.labelLoginEdit.Size = new System.Drawing.Size(41, 13);
            this.labelLoginEdit.TabIndex = 2;
            this.labelLoginEdit.Text = "Логин:";
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(161, 100);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordEdit.TabIndex = 3;
            // 
            // labelPasswordEdit
            // 
            this.labelPasswordEdit.AutoSize = true;
            this.labelPasswordEdit.Location = new System.Drawing.Point(92, 100);
            this.labelPasswordEdit.Name = "labelPasswordEdit";
            this.labelPasswordEdit.Size = new System.Drawing.Size(48, 13);
            this.labelPasswordEdit.TabIndex = 4;
            this.labelPasswordEdit.Text = "Пароль:";
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(161, 139);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameEdit.TabIndex = 5;
            // 
            // labelFirstNameEdit
            // 
            this.labelFirstNameEdit.AutoSize = true;
            this.labelFirstNameEdit.Location = new System.Drawing.Point(95, 145);
            this.labelFirstNameEdit.Name = "labelFirstNameEdit";
            this.labelFirstNameEdit.Size = new System.Drawing.Size(32, 13);
            this.labelFirstNameEdit.TabIndex = 6;
            this.labelFirstNameEdit.Text = "Имя:";
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(161, 175);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameEdit.TabIndex = 7;
            // 
            // labelLastNameEdit
            // 
            this.labelLastNameEdit.AutoSize = true;
            this.labelLastNameEdit.Location = new System.Drawing.Point(95, 181);
            this.labelLastNameEdit.Name = "labelLastNameEdit";
            this.labelLastNameEdit.Size = new System.Drawing.Size(59, 13);
            this.labelLastNameEdit.TabIndex = 8;
            this.labelLastNameEdit.Text = "Фамилия:";
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(161, 218);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEmailEdit.TabIndex = 9;
            // 
            // labelEmailEdit
            // 
            this.labelEmailEdit.AutoSize = true;
            this.labelEmailEdit.Location = new System.Drawing.Point(102, 224);
            this.labelEmailEdit.Name = "labelEmailEdit";
            this.labelEmailEdit.Size = new System.Drawing.Size(40, 13);
            this.labelEmailEdit.TabIndex = 10;
            this.labelEmailEdit.Text = "Почта:";
            // 
            // txtPhoneNumberEdit
            // 
            this.txtPhoneNumberEdit.Location = new System.Drawing.Point(161, 256);
            this.txtPhoneNumberEdit.Name = "txtPhoneNumberEdit";
            this.txtPhoneNumberEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumberEdit.TabIndex = 11;
            // 
            // labelPhoneNumberEdit
            // 
            this.labelPhoneNumberEdit.AutoSize = true;
            this.labelPhoneNumberEdit.Location = new System.Drawing.Point(102, 262);
            this.labelPhoneNumberEdit.Name = "labelPhoneNumberEdit";
            this.labelPhoneNumberEdit.Size = new System.Drawing.Size(55, 13);
            this.labelPhoneNumberEdit.TabIndex = 12;
            this.labelPhoneNumberEdit.Text = "Телефон:";
            // 
            // dtpRegistrationDateEdit
            // 
            this.dtpRegistrationDateEdit.Location = new System.Drawing.Point(224, 320);
            this.dtpRegistrationDateEdit.Name = "dtpRegistrationDateEdit";
            this.dtpRegistrationDateEdit.Size = new System.Drawing.Size(200, 20);
            this.dtpRegistrationDateEdit.TabIndex = 13;
            // 
            // labelRegistrationDateEdit
            // 
            this.labelRegistrationDateEdit.AutoSize = true;
            this.labelRegistrationDateEdit.Location = new System.Drawing.Point(102, 326);
            this.labelRegistrationDateEdit.Name = "labelRegistrationDateEdit";
            this.labelRegistrationDateEdit.Size = new System.Drawing.Size(103, 13);
            this.labelRegistrationDateEdit.TabIndex = 14;
            this.labelRegistrationDateEdit.Text = "Дата регистрации:";
            // 
            // labelBuyerEdit
            // 
            this.labelBuyerEdit.AutoSize = true;
            this.labelBuyerEdit.BackColor = System.Drawing.SystemColors.InfoText;
            this.labelBuyerEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBuyerEdit.Location = new System.Drawing.Point(161, 13);
            this.labelBuyerEdit.Name = "labelBuyerEdit";
            this.labelBuyerEdit.Size = new System.Drawing.Size(154, 13);
            this.labelBuyerEdit.TabIndex = 15;
            this.labelBuyerEdit.Text = "Редактирование Покупателя";
            // 
            // EditBuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBuyerEdit);
            this.Controls.Add(this.labelRegistrationDateEdit);
            this.Controls.Add(this.dtpRegistrationDateEdit);
            this.Controls.Add(this.labelPhoneNumberEdit);
            this.Controls.Add(this.txtPhoneNumberEdit);
            this.Controls.Add(this.labelEmailEdit);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.labelLastNameEdit);
            this.Controls.Add(this.txtLastNameEdit);
            this.Controls.Add(this.labelFirstNameEdit);
            this.Controls.Add(this.txtFirstNameEdit);
            this.Controls.Add(this.labelPasswordEdit);
            this.Controls.Add(this.txtPasswordEdit);
            this.Controls.Add(this.labelLoginEdit);
            this.Controls.Add(this.txtLoginEdit);
            this.Controls.Add(this.btnSaveChanges);
            this.Name = "EditBuyerForm";
            this.Text = "EditBuyerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtLoginEdit;
        private System.Windows.Forms.Label labelLoginEdit;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.Label labelPasswordEdit;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.Label labelFirstNameEdit;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.Label labelLastNameEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.Label labelEmailEdit;
        private System.Windows.Forms.TextBox txtPhoneNumberEdit;
        private System.Windows.Forms.Label labelPhoneNumberEdit;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDateEdit;
        private System.Windows.Forms.Label labelRegistrationDateEdit;
        private System.Windows.Forms.Label labelBuyerEdit;
    }
}