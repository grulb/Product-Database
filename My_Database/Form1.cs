using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace My_Database
{
    public partial class Form_Login : Form
    {
        Class1 db = new Class1();
        public Form_Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Login.Clear();
            textBox_Pass.Clear();
            button_Enter.BackColor = Color.White;
            button_Enter.ForeColor = Color.Black;

            label_Login_Check.Text = "Проверка логина";
            label_Login_Check.ForeColor = Color.Black;

            label_Pass_Check.Text = "Проверка пароля";
            label_Pass_Check.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {
            var userLogin = textBox_Login.Text;
            var userPass = textBox_Pass.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querryString = $"select UserLogin, UserType from UsersTable where UserLogin = '{userLogin}'";

            NpgsqlCommand command = new NpgsqlCommand(querryString, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                label_Login_Check.Text = "Верный логин";
                label_Login_Check.ForeColor = Color.Green;
            }
            else if (table.Rows.Count == 0)
            {
                label_Login_Check.Text = "Неверный логин";
                label_Login_Check.ForeColor = Color.Red;
            }
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {
            var userLogin = textBox_Login.Text;
            var userPass = textBox_Pass.Text;
            var userCheck = comboBox_UserType.SelectedIndex;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querryString = $"select UserLogin, UserPassword from UsersTable where UserLogin = '{userLogin}' and UserPassword = '{userPass}'";


            NpgsqlCommand command = new NpgsqlCommand(querryString, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                label_Pass_Check.Text = "Верный пароль";
                label_Pass_Check.ForeColor = Color.Green;
            }
            else if (table.Rows.Count == 0)
            {
                label_Pass_Check.Text = "Неверный пароль";
                label_Pass_Check.ForeColor = Color.Red;
            }
        }


        private void comboBox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userLogin = textBox_Login.Text;
            var userPass = textBox_Pass.Text;
            var userCheck = comboBox_UserType.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string querryString = $"select UserLogin, UserPassword, UserType from UsersTable where UserLogin = '{userLogin}' and UserPassword = '{userPass}' and UserType = '{userCheck}'";

            NpgsqlCommand command = new NpgsqlCommand(querryString, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                button_Enter.ForeColor = Color.White;
                button_Enter.BackColor = Color.Green;
            }
            else if (table.Rows.Count == 0)
            {
                button_Enter.ForeColor = Color.Black;
                button_Enter.BackColor= Color.Red;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var userLogin = textBox_Login.Text;
            var userPass = textBox_Pass.Text;
            var userCheck = comboBox_UserType.Text;
            int choose = 0;
            Administrator AInterface = new Administrator();
            Managers MInterface = new Managers();
            Workers WInterface = new Workers();

            //Проверка на заполнение
            if (textBox_Login.Text == null || textBox_Pass.Text == null || comboBox_UserType.Text == null)
            {
                choose = 0;
            }

            //Проверка на админа
            if (label_Login_Check.Text == "Верный логин" && label_Pass_Check.Text == "Верный пароль" && comboBox_UserType.Text == "Администратор" && button_Enter.BackColor == Color.Green)
            {
                choose = 1;
            }
            else if (comboBox_UserType.Text == "Администратор")
            {
                MessageBox.Show("Такого администратора не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                choose = 4;
            }

            //Проверка на менеджера
            if (label_Login_Check.Text == "Верный логин" && label_Pass_Check.Text == "Верный пароль" && comboBox_UserType.Text == "Менеджер" && button_Enter.BackColor == Color.Green)
            {
                choose = 2;
            }
            else if (comboBox_UserType.Text == "Менеджер")
            {
                MessageBox.Show("Такого менеджера не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                choose = 4;
            }

            //Проверка на сотрудника
            if (label_Login_Check.Text == "Верный логин" && label_Pass_Check.Text == "Верный пароль" && comboBox_UserType.Text == "Сотрудник" && button_Enter.BackColor == Color.Green)
            {
                choose = 3;
            }
            else if (comboBox_UserType.Text == "Сотрудник")
            {
                MessageBox.Show("Такого сотрудника не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                choose = 4;
            }

            switch (choose)
            {
                case 0:
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:
                        this.Hide();
                        AInterface.Show();
                    break;

                case 2:
                        this.Hide();
                        MInterface.Show();


                    break;

                case 3:
                        this.Hide();
                        WInterface.Show();
                    break;

                    case 4:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
