namespace My_Database
{
    partial class Form_Login
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Login_Check = new System.Windows.Forms.Label();
            this.label_Pass_Check = new System.Windows.Forms.Label();
            this.comboBox_UserType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Login.Location = new System.Drawing.Point(63, 121);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(218, 22);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pass.Location = new System.Drawing.Point(63, 221);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(218, 22);
            this.textBox_Pass.TabIndex = 3;
            this.textBox_Pass.TextChanged += new System.EventHandler(this.textBox_Pass_TextChanged);
            // 
            // button_Enter
            // 
            this.button_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Enter.BackColor = System.Drawing.Color.White;
            this.button_Enter.Location = new System.Drawing.Point(129, 378);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(88, 25);
            this.button_Enter.TabIndex = 4;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(12, 440);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(88, 23);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_Login_Check
            // 
            this.label_Login_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Login_Check.AutoSize = true;
            this.label_Login_Check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Login_Check.Location = new System.Drawing.Point(60, 146);
            this.label_Login_Check.Name = "label_Login_Check";
            this.label_Login_Check.Size = new System.Drawing.Size(121, 16);
            this.label_Login_Check.TabIndex = 7;
            this.label_Login_Check.Text = "Проверка логина";
            // 
            // label_Pass_Check
            // 
            this.label_Pass_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Pass_Check.AutoSize = true;
            this.label_Pass_Check.Location = new System.Drawing.Point(60, 246);
            this.label_Pass_Check.Name = "label_Pass_Check";
            this.label_Pass_Check.Size = new System.Drawing.Size(122, 16);
            this.label_Pass_Check.TabIndex = 8;
            this.label_Pass_Check.Text = "Проверка пароля";
            // 
            // comboBox_UserType
            // 
            this.comboBox_UserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UserType.FormattingEnabled = true;
            this.comboBox_UserType.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Сотрудник"});
            this.comboBox_UserType.Location = new System.Drawing.Point(63, 329);
            this.comboBox_UserType.Name = "comboBox_UserType";
            this.comboBox_UserType.Size = new System.Drawing.Size(218, 24);
            this.comboBox_UserType.TabIndex = 10;
            this.comboBox_UserType.SelectedIndexChanged += new System.EventHandler(this.comboBox_UserType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип пользователя";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(278, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_UserType);
            this.Controls.Add(this.label_Pass_Check);
            this.Controls.Add(this.label_Login_Check);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Login_Check;
        private System.Windows.Forms.Label label_Pass_Check;
        private System.Windows.Forms.ComboBox comboBox_UserType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

