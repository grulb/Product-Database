namespace My_Database
{
    partial class Managers
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.productstableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet3 = new My_Database.ShopDBDataSet3();
            this.shopDBDataSet2 = new My_Database.ShopDBDataSet2();
            this.productstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productstableTableAdapter = new My_Database.ShopDBDataSet2TableAdapters.productstableTableAdapter();
            this.productstableTableAdapter1 = new My_Database.ShopDBDataSet3TableAdapters.productstableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.applyChange = new System.Windows.Forms.Button();
            this.endOfChange = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelCreateButton = new System.Windows.Forms.Button();
            this.addCreateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.pictureBox_Product = new System.Windows.Forms.PictureBox();
            this.button_setPhoto = new System.Windows.Forms.Button();
            this.productstableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet6 = new My_Database.ShopDBDataSet6();
            this.productstableTableAdapter2 = new My_Database.ShopDBDataSet6TableAdapters.productstableTableAdapter();
            this.productstableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet7 = new My_Database.ShopDBDataSet7();
            this.productstableTableAdapter3 = new My_Database.ShopDBDataSet7TableAdapters.productstableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopDBDataSet9 = new My_Database.ShopDBDataSet9();
            this.productstableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productstableTableAdapter4 = new My_Database.ShopDBDataSet9TableAdapters.productstableTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productphotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productoldcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(945, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productstableBindingSource1
            // 
            this.productstableBindingSource1.DataMember = "productstable";
            this.productstableBindingSource1.DataSource = this.shopDBDataSet3;
            // 
            // shopDBDataSet3
            // 
            this.shopDBDataSet3.DataSetName = "ShopDBDataSet3";
            this.shopDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopDBDataSet2
            // 
            this.shopDBDataSet2.DataSetName = "ShopDBDataSet2";
            this.shopDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableBindingSource
            // 
            this.productstableBindingSource.DataMember = "productstable";
            this.productstableBindingSource.DataSource = this.shopDBDataSet2;
            // 
            // productstableTableAdapter
            // 
            this.productstableTableAdapter.ClearBeforeFill = true;
            // 
            // productstableTableAdapter1
            // 
            this.productstableTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 554);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Кол-во товара";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(740, 549);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(164, 58);
            this.deleteButton.TabIndex = 72;
            this.deleteButton.Text = "Удалить строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // applyChange
            // 
            this.applyChange.Location = new System.Drawing.Point(659, 476);
            this.applyChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyChange.Name = "applyChange";
            this.applyChange.Size = new System.Drawing.Size(164, 58);
            this.applyChange.TabIndex = 71;
            this.applyChange.Text = "Применить изменения";
            this.applyChange.UseVisualStyleBackColor = true;
            this.applyChange.Visible = false;
            this.applyChange.Click += new System.EventHandler(this.applyChange_Click);
            // 
            // endOfChange
            // 
            this.endOfChange.Location = new System.Drawing.Point(831, 476);
            this.endOfChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endOfChange.Name = "endOfChange";
            this.endOfChange.Size = new System.Drawing.Size(164, 58);
            this.endOfChange.TabIndex = 70;
            this.endOfChange.Text = "Отменить редактирование";
            this.endOfChange.UseVisualStyleBackColor = true;
            this.endOfChange.Visible = false;
            this.endOfChange.Click += new System.EventHandler(this.endOfChange_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 476);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Цена за единицу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Название товара";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(41, 422);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(259, 22);
            this.textBox_Name.TabIndex = 67;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Enabled = false;
            this.textBox_Price.Location = new System.Drawing.Point(37, 501);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(259, 22);
            this.textBox_Price.TabIndex = 66;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(740, 476);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(164, 58);
            this.changeButton.TabIndex = 65;
            this.changeButton.Text = "Редактировать";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cancelCreateButton
            // 
            this.cancelCreateButton.Location = new System.Drawing.Point(831, 399);
            this.cancelCreateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelCreateButton.Name = "cancelCreateButton";
            this.cancelCreateButton.Size = new System.Drawing.Size(164, 58);
            this.cancelCreateButton.TabIndex = 64;
            this.cancelCreateButton.Text = "Отменить создание";
            this.cancelCreateButton.UseVisualStyleBackColor = true;
            this.cancelCreateButton.Visible = false;
            this.cancelCreateButton.Click += new System.EventHandler(this.cancelCreateButton_Click);
            // 
            // addCreateButton
            // 
            this.addCreateButton.Location = new System.Drawing.Point(659, 399);
            this.addCreateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCreateButton.Name = "addCreateButton";
            this.addCreateButton.Size = new System.Drawing.Size(164, 58);
            this.addCreateButton.TabIndex = 63;
            this.addCreateButton.Text = "Добавить в БД";
            this.addCreateButton.UseVisualStyleBackColor = true;
            this.addCreateButton.Visible = false;
            this.addCreateButton.Click += new System.EventHandler(this.addCreateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(740, 399);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(164, 58);
            this.createButton.TabIndex = 62;
            this.createButton.Text = "Создать запись";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 75;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Count
            // 
            this.textBox_Count.Enabled = false;
            this.textBox_Count.Location = new System.Drawing.Point(37, 582);
            this.textBox_Count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(259, 22);
            this.textBox_Count.TabIndex = 76;
            // 
            // pictureBox_Product
            // 
            this.pictureBox_Product.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox_Product.Location = new System.Drawing.Point(369, 399);
            this.pictureBox_Product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Product.Name = "pictureBox_Product";
            this.pictureBox_Product.Size = new System.Drawing.Size(203, 176);
            this.pictureBox_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Product.TabIndex = 77;
            this.pictureBox_Product.TabStop = false;
            // 
            // button_setPhoto
            // 
            this.button_setPhoto.Enabled = false;
            this.button_setPhoto.Location = new System.Drawing.Point(384, 582);
            this.button_setPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_setPhoto.Name = "button_setPhoto";
            this.button_setPhoto.Size = new System.Drawing.Size(164, 34);
            this.button_setPhoto.TabIndex = 78;
            this.button_setPhoto.Text = "Добавить фото";
            this.button_setPhoto.UseVisualStyleBackColor = true;
            this.button_setPhoto.Click += new System.EventHandler(this.button_setPhoto_Click);
            // 
            // productstableBindingSource2
            // 
            this.productstableBindingSource2.DataMember = "productstable";
            this.productstableBindingSource2.DataSource = this.shopDBDataSet6;
            // 
            // shopDBDataSet6
            // 
            this.shopDBDataSet6.DataSetName = "ShopDBDataSet6";
            this.shopDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableTableAdapter2
            // 
            this.productstableTableAdapter2.ClearBeforeFill = true;
            // 
            // productstableBindingSource3
            // 
            this.productstableBindingSource3.DataMember = "productstable";
            this.productstableBindingSource3.DataSource = this.shopDBDataSet7;
            // 
            // shopDBDataSet7
            // 
            this.shopDBDataSet7.DataSetName = "ShopDBDataSet7";
            this.shopDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableTableAdapter3
            // 
            this.productstableTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productsumDataGridViewTextBoxColumn,
            this.productcountDataGridViewTextBoxColumn,
            this.productphotoDataGridViewImageColumn,
            this.productoldcountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productstableBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(9, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(998, 337);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // shopDBDataSet9
            // 
            this.shopDBDataSet9.DataSetName = "ShopDBDataSet9";
            this.shopDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableBindingSource4
            // 
            this.productstableBindingSource4.DataMember = "productstable";
            this.productstableBindingSource4.DataSource = this.shopDBDataSet9;
            // 
            // productstableTableAdapter4
            // 
            this.productstableTableAdapter4.ClearBeforeFill = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Visible = false;
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsumDataGridViewTextBoxColumn
            // 
            this.productsumDataGridViewTextBoxColumn.DataPropertyName = "productsum";
            this.productsumDataGridViewTextBoxColumn.HeaderText = "productsum";
            this.productsumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productsumDataGridViewTextBoxColumn.Name = "productsumDataGridViewTextBoxColumn";
            this.productsumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productsumDataGridViewTextBoxColumn.Width = 125;
            // 
            // productcountDataGridViewTextBoxColumn
            // 
            this.productcountDataGridViewTextBoxColumn.DataPropertyName = "productcount";
            this.productcountDataGridViewTextBoxColumn.HeaderText = "productcount";
            this.productcountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productcountDataGridViewTextBoxColumn.Name = "productcountDataGridViewTextBoxColumn";
            this.productcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.productcountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productphotoDataGridViewImageColumn
            // 
            this.productphotoDataGridViewImageColumn.DataPropertyName = "productphoto";
            this.productphotoDataGridViewImageColumn.HeaderText = "productphoto";
            this.productphotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.productphotoDataGridViewImageColumn.MinimumWidth = 6;
            this.productphotoDataGridViewImageColumn.Name = "productphotoDataGridViewImageColumn";
            this.productphotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // productoldcountDataGridViewTextBoxColumn
            // 
            this.productoldcountDataGridViewTextBoxColumn.DataPropertyName = "productoldcount";
            this.productoldcountDataGridViewTextBoxColumn.HeaderText = "productoldcount";
            this.productoldcountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoldcountDataGridViewTextBoxColumn.Name = "productoldcountDataGridViewTextBoxColumn";
            this.productoldcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoldcountDataGridViewTextBoxColumn.Visible = false;
            this.productoldcountDataGridViewTextBoxColumn.Width = 125;
            // 
            // Managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_setPhoto);
            this.Controls.Add(this.pictureBox_Product);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.applyChange);
            this.Controls.Add(this.endOfChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cancelCreateButton);
            this.Controls.Add(this.addCreateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Managers";
            this.Text = "Managers";
            this.Load += new System.EventHandler(this.Managers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private ShopDBDataSet2 shopDBDataSet2;
        private System.Windows.Forms.BindingSource productstableBindingSource;
        private ShopDBDataSet2TableAdapters.productstableTableAdapter productstableTableAdapter;
        private ShopDBDataSet3 shopDBDataSet3;
        private System.Windows.Forms.BindingSource productstableBindingSource1;
        private ShopDBDataSet3TableAdapters.productstableTableAdapter productstableTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button applyChange;
        private System.Windows.Forms.Button endOfChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button cancelCreateButton;
        private System.Windows.Forms.Button addCreateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.PictureBox pictureBox_Product;
        private System.Windows.Forms.Button button_setPhoto;
        private ShopDBDataSet6 shopDBDataSet6;
        private System.Windows.Forms.BindingSource productstableBindingSource2;
        private ShopDBDataSet6TableAdapters.productstableTableAdapter productstableTableAdapter2;
        private ShopDBDataSet7 shopDBDataSet7;
        private System.Windows.Forms.BindingSource productstableBindingSource3;
        private ShopDBDataSet7TableAdapters.productstableTableAdapter productstableTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopDBDataSet9 shopDBDataSet9;
        private System.Windows.Forms.BindingSource productstableBindingSource4;
        private ShopDBDataSet9TableAdapters.productstableTableAdapter productstableTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productphotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoldcountDataGridViewTextBoxColumn;
    }
}