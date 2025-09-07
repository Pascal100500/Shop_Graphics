namespace Shop_Graphics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProductImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteBuyer = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.textBoxSelectedProduct = new System.Windows.Forms.TextBox();
            this.labelProductSelect = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.btnShowOrdersByDate = new System.Windows.Forms.Button();
            this.labelBuyers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(330, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "МАГАЗИН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберете действие";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 263);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProduct.Location = new System.Drawing.Point(681, 133);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(231, 206);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 4;
            this.pictureBoxProduct.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Изображение выбранного товара";
            // 
            // btnAddProductImage
            // 
            this.btnAddProductImage.Location = new System.Drawing.Point(643, 354);
            this.btnAddProductImage.Name = "btnAddProductImage";
            this.btnAddProductImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductImage.TabIndex = 6;
            this.btnAddProductImage.Text = "Загрузить";
            this.btnAddProductImage.UseVisualStyleBackColor = true;
            this.btnAddProductImage.Click += new System.EventHandler(this.btnAddProductImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteBuyer
            // 
            this.btnDeleteBuyer.Location = new System.Drawing.Point(134, 105);
            this.btnDeleteBuyer.Name = "btnDeleteBuyer";
            this.btnDeleteBuyer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBuyer.TabIndex = 8;
            this.btnDeleteBuyer.Text = "Удалить";
            this.btnDeleteBuyer.UseVisualStyleBackColor = true;
            this.btnDeleteBuyer.Click += new System.EventHandler(this.btnDeleteBuyer_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(240, 105);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Обновить базу ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(804, 354);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteImage.TabIndex = 11;
            this.btnDeleteImage.Text = "Удалить Изображение";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // comboBoxActions
            // 
            this.comboBoxActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Location = new System.Drawing.Point(160, 47);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(359, 21);
            this.comboBoxActions.TabIndex = 12;
            this.comboBoxActions.SelectedIndexChanged += new System.EventHandler(this.comboBoxActions_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(704, 27);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(126, 41);
            this.btnSaveAndClose.TabIndex = 14;
            this.btnSaveAndClose.Text = "Закрыть с изменениями";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(561, 27);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(126, 41);
            this.btnCancelChanges.TabIndex = 16;
            this.btnCancelChanges.Text = "Закрыть без изменений";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // textBoxSelectedProduct
            // 
            this.textBoxSelectedProduct.Location = new System.Drawing.Point(753, 403);
            this.textBoxSelectedProduct.Name = "textBoxSelectedProduct";
            this.textBoxSelectedProduct.Size = new System.Drawing.Size(159, 20);
            this.textBoxSelectedProduct.TabIndex = 17;
            // 
            // labelProductSelect
            // 
            this.labelProductSelect.AutoSize = true;
            this.labelProductSelect.Location = new System.Drawing.Point(629, 406);
            this.labelProductSelect.Name = "labelProductSelect";
            this.labelProductSelect.Size = new System.Drawing.Size(101, 13);
            this.labelProductSelect.TabIndex = 18;
            this.labelProductSelect.Text = "Выбранный товар:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(460, 193);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 19;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(365, 193);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(73, 13);
            this.labelDateFrom.TabIndex = 20;
            this.labelDateFrom.Text = "Дата старта:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(460, 238);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 21;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(365, 244);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(79, 13);
            this.labelDateTo.TabIndex = 22;
            this.labelDateTo.Text = "Дата финиша:";
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Location = new System.Drawing.Point(447, 160);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(123, 13);
            this.labelDateRange.TabIndex = 23;
            this.labelDateRange.Text = "Укажите диапазон дат";
            // 
            // btnShowOrdersByDate
            // 
            this.btnShowOrdersByDate.Location = new System.Drawing.Point(474, 279);
            this.btnShowOrdersByDate.Name = "btnShowOrdersByDate";
            this.btnShowOrdersByDate.Size = new System.Drawing.Size(126, 23);
            this.btnShowOrdersByDate.TabIndex = 24;
            this.btnShowOrdersByDate.Text = "Показать заказы";
            this.btnShowOrdersByDate.UseVisualStyleBackColor = true;
            this.btnShowOrdersByDate.Click += new System.EventHandler(this.btnShowOrdersByDate_Click);
            // 
            // labelBuyers
            // 
            this.labelBuyers.AutoSize = true;
            this.labelBuyers.Location = new System.Drawing.Point(94, 86);
            this.labelBuyers.Name = "labelBuyers";
            this.labelBuyers.Size = new System.Drawing.Size(154, 13);
            this.labelBuyers.TabIndex = 25;
            this.labelBuyers.Text = "Меню работы с покупателем";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.labelBuyers);
            this.Controls.Add(this.btnShowOrdersByDate);
            this.Controls.Add(this.labelDateRange);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelProductSelect);
            this.Controls.Add(this.textBoxSelectedProduct);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxActions);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteBuyer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddProductImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProductImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteBuyer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.ComboBox comboBoxActions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.TextBox textBoxSelectedProduct;
        private System.Windows.Forms.Label labelProductSelect;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.Button btnShowOrdersByDate;
        private System.Windows.Forms.Label labelBuyers;
    }
}

