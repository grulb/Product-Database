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
using Npgsql;

namespace My_Database
{
    public partial class Workers : Form
    {
        Class1 db = new Class1();
        public Workers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet10.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter2.Fill(this.shopDBDataSet10.productstable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet8.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter1.Fill(this.shopDBDataSet8.productstable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet5.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter.Fill(this.shopDBDataSet5.productstable);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FilterDataInDataGridView()
        {
            db.openConnection();

            string productName = textBox_Search.Text;

            string searchString = $"select * from productstable where productname like '%" + productName + "%'";

            NpgsqlCommand command = new NpgsqlCommand(searchString, db.GetConnection());

            try
            {
                db.openConnection();

                NpgsqlDataReader read = command.ExecuteReader();

                // Создаем временный DataTable для хранения данных
                DataTable dataTable = new DataTable();
                dataTable.Load(read);

                // Привязываем DataTable к dataGridView2
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterDataInDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }
    }
}
