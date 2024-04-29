namespace My_Database
{
    partial class Workers
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
            this.productstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet5 = new My_Database.ShopDBDataSet5();
            this.productstableTableAdapter = new My_Database.ShopDBDataSet5TableAdapters.productstableTableAdapter();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.productstableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet8 = new My_Database.ShopDBDataSet8();
            this.productstableTableAdapter1 = new My_Database.ShopDBDataSet8TableAdapters.productstableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopDBDataSet10 = new My_Database.ShopDBDataSet10();
            this.productstableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productstableTableAdapter2 = new My_Database.ShopDBDataSet10TableAdapters.productstableTableAdapter();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productphotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productoldcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(895, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productstableBindingSource
            // 
            this.productstableBindingSource.DataMember = "productstable";
            this.productstableBindingSource.DataSource = this.shopDBDataSet5;
            // 
            // shopDBDataSet5
            // 
            this.shopDBDataSet5.DataSetName = "ShopDBDataSet5";
            this.shopDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableTableAdapter
            // 
            this.productstableTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(608, 22);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(224, 22);
            this.textBox_Search.TabIndex = 22;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 31);
            this.button1.TabIndex = 63;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productstableBindingSource1
            // 
            this.productstableBindingSource1.DataMember = "productstable";
            this.productstableBindingSource1.DataSource = this.shopDBDataSet8;
            // 
            // shopDBDataSet8
            // 
            this.shopDBDataSet8.DataSetName = "ShopDBDataSet8";
            this.shopDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableTableAdapter1
            // 
            this.productstableTableAdapter1.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.productstableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(936, 496);
            this.dataGridView1.TabIndex = 64;
            // 
            // shopDBDataSet10
            // 
            this.shopDBDataSet10.DataSetName = "ShopDBDataSet10";
            this.shopDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableBindingSource2
            // 
            this.productstableBindingSource2.DataMember = "productstable";
            this.productstableBindingSource2.DataSource = this.shopDBDataSet10;
            // 
            // productstableTableAdapter2
            // 
            this.productstableTableAdapter2.ClearBeforeFill = true;
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
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Workers";
            this.Text = "Workers";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private ShopDBDataSet5 shopDBDataSet5;
        private System.Windows.Forms.BindingSource productstableBindingSource;
        private ShopDBDataSet5TableAdapters.productstableTableAdapter productstableTableAdapter;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ShopDBDataSet8 shopDBDataSet8;
        private System.Windows.Forms.BindingSource productstableBindingSource1;
        private ShopDBDataSet8TableAdapters.productstableTableAdapter productstableTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopDBDataSet10 shopDBDataSet10;
        private System.Windows.Forms.BindingSource productstableBindingSource2;
        private ShopDBDataSet10TableAdapters.productstableTableAdapter productstableTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productphotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoldcountDataGridViewTextBoxColumn;
    }
}