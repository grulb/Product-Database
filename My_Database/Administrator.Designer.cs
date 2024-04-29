namespace My_Database
{
    partial class Administrator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDBDataSet1 = new My_Database.ShopDBDataSet1();
            this.userstableTableAdapter = new My_Database.ShopDBDataSet1TableAdapters.userstableTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.applyChange = new System.Windows.Forms.Button();
            this.endOfChange = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelCreateButton = new System.Windows.Forms.Button();
            this.addCreateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.userloginDataGridViewTextBoxColumn,
            this.userpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userstableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "Тип пользователя";
            this.usertypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.usertypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userloginDataGridViewTextBoxColumn
            // 
            this.userloginDataGridViewTextBoxColumn.DataPropertyName = "userlogin";
            this.userloginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.userloginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userloginDataGridViewTextBoxColumn.Name = "userloginDataGridViewTextBoxColumn";
            this.userloginDataGridViewTextBoxColumn.ReadOnly = true;
            this.userloginDataGridViewTextBoxColumn.Width = 125;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "userpassword";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.userpasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.userpasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userstableBindingSource
            // 
            this.userstableBindingSource.DataMember = "userstable";
            this.userstableBindingSource.DataSource = this.shopDBDataSet1;
            // 
            // shopDBDataSet1
            // 
            this.shopDBDataSet1.DataSetName = "ShopDBDataSet1";
            this.shopDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userstableTableAdapter
            // 
            this.userstableTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(721, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(499, 549);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(164, 58);
            this.deleteButton.TabIndex = 59;
            this.deleteButton.Text = "Удалить строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // applyChange
            // 
            this.applyChange.Location = new System.Drawing.Point(417, 477);
            this.applyChange.Margin = new System.Windows.Forms.Padding(4);
            this.applyChange.Name = "applyChange";
            this.applyChange.Size = new System.Drawing.Size(164, 58);
            this.applyChange.TabIndex = 58;
            this.applyChange.Text = "Применить изменения";
            this.applyChange.UseVisualStyleBackColor = true;
            this.applyChange.Visible = false;
            this.applyChange.Click += new System.EventHandler(this.applyChange_Click);
            // 
            // endOfChange
            // 
            this.endOfChange.Location = new System.Drawing.Point(589, 477);
            this.endOfChange.Margin = new System.Windows.Forms.Padding(4);
            this.endOfChange.Name = "endOfChange";
            this.endOfChange.Size = new System.Drawing.Size(164, 58);
            this.endOfChange.TabIndex = 57;
            this.endOfChange.Text = "Отменить редактирование";
            this.endOfChange.UseVisualStyleBackColor = true;
            this.endOfChange.Visible = false;
            this.endOfChange.Click += new System.EventHandler(this.endOfChange_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(143, 573);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Пароль:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(156, 495);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Логин:";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Enabled = false;
            this.textBox_Login.Location = new System.Drawing.Point(60, 520);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(259, 22);
            this.textBox_Login.TabIndex = 42;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Enabled = false;
            this.textBox_Password.Location = new System.Drawing.Point(56, 598);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(259, 22);
            this.textBox_Password.TabIndex = 41;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(499, 477);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(164, 58);
            this.changeButton.TabIndex = 39;
            this.changeButton.Text = "Редактировать";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cancelCreateButton
            // 
            this.cancelCreateButton.Location = new System.Drawing.Point(589, 399);
            this.cancelCreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelCreateButton.Name = "cancelCreateButton";
            this.cancelCreateButton.Size = new System.Drawing.Size(164, 58);
            this.cancelCreateButton.TabIndex = 38;
            this.cancelCreateButton.Text = "Отменить создание";
            this.cancelCreateButton.UseVisualStyleBackColor = true;
            this.cancelCreateButton.Visible = false;
            this.cancelCreateButton.Click += new System.EventHandler(this.cancelCreateButton_Click);
            // 
            // addCreateButton
            // 
            this.addCreateButton.Location = new System.Drawing.Point(417, 399);
            this.addCreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCreateButton.Name = "addCreateButton";
            this.addCreateButton.Size = new System.Drawing.Size(164, 58);
            this.addCreateButton.TabIndex = 37;
            this.addCreateButton.Text = "Добавить в БД";
            this.addCreateButton.UseVisualStyleBackColor = true;
            this.addCreateButton.Visible = false;
            this.addCreateButton.Click += new System.EventHandler(this.addCreateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(499, 399);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(164, 58);
            this.createButton.TabIndex = 36;
            this.createButton.Text = "Создать запись";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.Enabled = false;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Сотрудник"});
            this.comboBox_Type.Location = new System.Drawing.Point(62, 422);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(259, 24);
            this.comboBox_Type.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Тип пользователя";
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
            this.button1.TabIndex = 62;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.applyChange);
            this.Controls.Add(this.endOfChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cancelCreateButton);
            this.Controls.Add(this.addCreateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopDBDataSet1 shopDBDataSet1;
        private System.Windows.Forms.BindingSource userstableBindingSource;
        private ShopDBDataSet1TableAdapters.userstableTableAdapter userstableTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button applyChange;
        private System.Windows.Forms.Button endOfChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button cancelCreateButton;
        private System.Windows.Forms.Button addCreateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}