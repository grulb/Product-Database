using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Database
{
    public partial class Administrator : Form
    {
        Class1 db = new Class1();
        int selectedRow;
        public Administrator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet1.userstable". При необходимости она может быть перемещена или удалена.
            this.userstableTableAdapter.Fill(this.shopDBDataSet1.userstable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCreateButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            string queryMaxID = "SELECT MAX(userid) FROM userstable";
            NpgsqlCommand getMaxIDCommand = new NpgsqlCommand(queryMaxID, db.GetConnection());
            object maxIDObject = getMaxIDCommand.ExecuteScalar();
            int maxID = (maxIDObject == DBNull.Value) ? 0 : Convert.ToInt32(maxIDObject);

            // Увеличиваем максимальный ID на 1
            int newID = maxID + 1;

            var userType = comboBox_Type.Text;
            var userlog = textBox_Login.Text;
            var userpas = textBox_Password.Text;

            string queryInsertUser = "INSERT INTO userstable (userid, usertype, userlogin, userpassword) " +
                                     "VALUES (@UserID, @UserType, @UserLogin, @UserPassword)";

            NpgsqlCommand insertUserCommand = new NpgsqlCommand(queryInsertUser, db.GetConnection());
            insertUserCommand.Parameters.AddWithValue("@UserID", newID);
            insertUserCommand.Parameters.AddWithValue("@UserType", userType);
            insertUserCommand.Parameters.AddWithValue("@UserLogin", userlog);
            insertUserCommand.Parameters.AddWithValue("@UserPassword", userpas);

            insertUserCommand.ExecuteNonQuery();

            // Обновляем данные в DataGridView
            this.userstableTableAdapter.Fill(this.shopDBDataSet1.userstable);

            db.closeConnection();

            createButton.Visible = true;
            cancelCreateButton.Visible = false;
            addCreateButton.Visible = false;
            textBox_Login.Clear();
            textBox_Login.Enabled = false;
            textBox_Password.Clear();
            textBox_Password.Enabled = false;
            comboBox_Type.Enabled = false;
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.Visible = false;
            cancelCreateButton.Visible = true;
            addCreateButton.Visible = true;
            textBox_Login.Clear();
            textBox_Login.Enabled = true;
            textBox_Password.Clear();
            textBox_Password.Enabled = true;
            comboBox_Type.Enabled = true;
            changeButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Visible = false;
            endOfChange.Visible = true;
            applyChange.Visible = true;
            textBox_Login.Enabled = true;
            textBox_Password.Enabled = true;
            comboBox_Type.Enabled = true;
            createButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                var id = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                var deleteQuery = $"DELETE FROM usersTable WHERE userID = '{id}'";

                var command = new NpgsqlCommand(deleteQuery, db.GetConnection());

                command.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }

            db.closeConnection();
        }

        private void endOfChange_Click(object sender, EventArgs e)
        {
            changeButton.Visible = true;
            endOfChange.Visible = false;
            applyChange.Visible = false;
            textBox_Login.Clear();
            textBox_Login.Enabled = false;
            textBox_Password.Clear();
            textBox_Password.Enabled = false;
            comboBox_Type.Enabled = false;
            createButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void cancelCreateButton_Click(object sender, EventArgs e)
        {
            createButton.Visible = true;
            cancelCreateButton.Visible = false;
            addCreateButton.Visible = false;
            textBox_Login.Clear();
            textBox_Login.Enabled = false;
            textBox_Password.Clear();
            textBox_Password.Enabled = false;
            comboBox_Type.Enabled = false;
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                comboBox_Type.Text = row.Cells[1].Value.ToString();
                textBox_Login.Text = row.Cells[2].Value.ToString();
                textBox_Password.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var usertype = comboBox_Type.Text;
            var userlogin = textBox_Login.Text;
            var userpas = textBox_Password.Text;

            dataGridView1.Rows[selectedRowIndex].Cells[1].Value = usertype;
            dataGridView1.Rows[selectedRowIndex].Cells[2].Value = userlogin;
            dataGridView1.Rows[selectedRowIndex].Cells[3].Value = userpas;
        }
        private void applyChange_Click(object sender, EventArgs e)
        {
            Change();

            db.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var userid = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var usertype = dataGridView1.Rows[index].Cells[1].Value.ToString();
                var userlogin = dataGridView1.Rows[index].Cells[2].Value.ToString();
                var userpas = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $@"UPDATE usersTable SET usertype = '{usertype}', userlogin = '{userlogin}', userpassword = '{userpas}' WHERE userid = '{userid}'";

                var command = new NpgsqlCommand(changeQuery, db.GetConnection());

                command.ExecuteNonQuery();
            }

            db.closeConnection();

            changeButton.Visible = true;
            endOfChange.Visible = false;
            applyChange.Visible = false;
            textBox_Login.Clear();
            textBox_Login.Enabled = false;
            textBox_Password.Clear();
            textBox_Password.Enabled = false;
            comboBox_Type.Enabled = false;
            createButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }
    }
}
