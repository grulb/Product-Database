using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace My_Database
{
    public partial class Managers : Form
    {
        Class1 db = new Class1();
        int selectedRow;
        public Managers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Managers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet9.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter4.Fill(this.shopDBDataSet9.productstable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet7.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter3.Fill(this.shopDBDataSet7.productstable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet6.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter2.Fill(this.shopDBDataSet6.productstable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDBDataSet3.productstable". При необходимости она может быть перемещена или удалена.
            this.productstableTableAdapter1.Fill(this.shopDBDataSet3.productstable);

            db.openConnection();

            Dictionary<string, bool> changedProducts = new Dictionary<string, bool>();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var newCount = Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                var oldCount = Convert.ToInt32(dataGridView1.Rows[index].Cells[5].Value);

                if (newCount != oldCount)
                {
                    var productName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    if (!changedProducts.ContainsKey(productName))
                    {
                        changedProducts.Add(productName, true);
                    }
                }
            }

            db.closeConnection();

            if (changedProducts.Count > 0)
            {
                string changedProductNames = string.Join(",\n", changedProducts.Keys);
                MessageBox.Show($"Количество товаров {changedProductNames} изменилось.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.Visible = false;
            cancelCreateButton.Visible = true;
            addCreateButton.Visible = true;
            textBox_Name.Clear();
            textBox_Name.Enabled = true;
            textBox_Price.Clear();
            textBox_Price.Enabled = true;
            textBox_Count.Clear();
            textBox_Count.Enabled = true;
            changeButton.Enabled = false;
            deleteButton.Enabled = false;
            button_setPhoto.Enabled = true;
            pictureBox_Product.Image = null;
        }

        private void cancelCreateButton_Click(object sender, EventArgs e)
        {
            createButton.Visible = true;
            cancelCreateButton.Visible = false;
            addCreateButton.Visible = false;
            textBox_Name.Clear();
            textBox_Name.Enabled = false;
            textBox_Price.Clear();
            textBox_Price.Enabled = false;
            textBox_Count.Clear();
            textBox_Count.Enabled = false;
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
            button_setPhoto.Enabled = false;
            pictureBox_Product.Image = null;
        }

        private void addCreateButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            string queryMaxID = "SELECT MAX(productid) FROM productstable";
            NpgsqlCommand getMaxIDCommand = new NpgsqlCommand(queryMaxID, db.GetConnection());
            object maxIDObject = getMaxIDCommand.ExecuteScalar();
            int maxID = (maxIDObject == DBNull.Value) ? 0 : Convert.ToInt32(maxIDObject);

            int newID = maxID + 1;

            var prodName = textBox_Name.Text;
            var prodPrice = textBox_Price.Text;
            var prodCount = textBox_Count.Text;
            byte[] prodPhoto;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox_Product.Image.Save(ms, pictureBox_Product.Image.RawFormat);
                prodPhoto = ms.ToArray();
            }

                string queryInsertUser = "INSERT INTO productstable (productid, productname, productsum, productcount, productphoto, productoldcount) " +
                                         "VALUES (@productid, @productname, @productsum, @productcount, @productphoto, @productoldcount)";

            NpgsqlCommand insertUserCommand = new NpgsqlCommand(queryInsertUser, db.GetConnection());
            insertUserCommand.Parameters.AddWithValue("@productid", newID);
            insertUserCommand.Parameters.AddWithValue("@productname", prodName);
            insertUserCommand.Parameters.AddWithValue("@productsum", prodPrice);
            insertUserCommand.Parameters.AddWithValue("@productcount", prodCount);
            insertUserCommand.Parameters.AddWithValue("@productphoto", prodPhoto);
            insertUserCommand.Parameters.AddWithValue("@productoldcount", prodCount);

            insertUserCommand.ExecuteNonQuery();

            // Обновляем данные в DataGridView
            this.productstableTableAdapter4.Fill(this.shopDBDataSet9.productstable);

            db.closeConnection();

            createButton.Visible = true;
            cancelCreateButton.Visible = false;
            addCreateButton.Visible = false;
            textBox_Name.Clear();
            textBox_Name.Enabled = false;
            textBox_Price.Clear();
            textBox_Price.Enabled = false;
            textBox_Count.Clear();
            textBox_Count.Enabled = false;
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
            button_setPhoto.Enabled = false;
            pictureBox_Product.Image = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                var productid = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                var deleteQuery = $"DELETE FROM productsTable WHERE productID = '{productid}'";

                var command = new NpgsqlCommand(deleteQuery, db.GetConnection());

                command.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }

            db.closeConnection();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Visible = false;
            endOfChange.Visible = true;
            applyChange.Visible = true;
            textBox_Name.Enabled = true;
            textBox_Price.Enabled = true;
            textBox_Count.Enabled = true;
            createButton.Enabled = false;
            deleteButton.Enabled = false;
            button_setPhoto.Enabled = true;
        }

        private void endOfChange_Click(object sender, EventArgs e)
        {
            changeButton.Visible = true;
            endOfChange.Visible = false;
            applyChange.Visible = false;
            textBox_Name.Clear();
            textBox_Name.Enabled = false;
            textBox_Price.Clear();
            textBox_Price.Enabled = false;
            textBox_Count.Clear();
            textBox_Count.Enabled = false;
            createButton.Enabled = true;
            deleteButton.Enabled = true;
            button_setPhoto.Enabled = false;
            pictureBox_Product.Image = null;
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var prodName = textBox_Name.Text;
            var prodPrice = textBox_Price.Text;
            var prodCount = textBox_Count.Text;

            dataGridView1.Rows[selectedRowIndex].Cells[1].Value = prodName;
            dataGridView1.Rows[selectedRowIndex].Cells[2].Value = prodPrice;
            dataGridView1.Rows[selectedRowIndex].Cells[3].Value = prodCount;
        }

        private void applyChange_Click(object sender, EventArgs e)
        {
            Change();

            db.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var prodid = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var prodName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                var prodPrice = dataGridView1.Rows[index].Cells[2].Value.ToString();
                var prodCount = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"UPDATE productsTable SET productname = '{prodName}', productsum = '{prodPrice}', productcount = '{prodCount}' WHERE productid = '{prodid}'";

                var command = new NpgsqlCommand(changeQuery, db.GetConnection());

                command.ExecuteNonQuery();
            }

            db.closeConnection();

            changeButton.Visible = true;
            endOfChange.Visible = false;
            applyChange.Visible = false;
            textBox_Name.Clear();
            textBox_Name.Enabled = false;
            textBox_Price.Clear();
            textBox_Price.Enabled = false;
            textBox_Count.Clear();
            textBox_Count.Enabled = false;
            createButton.Enabled = true;
            deleteButton.Enabled = true;
            button_setPhoto.Enabled = false;
            pictureBox_Product.Image = null;
        }

        private void button_setPhoto_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Product.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productstableTableAdapter2.FillBy(this.shopDBDataSet6.productstable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Price.Text = row.Cells[2].Value.ToString();
                textBox_Count.Text = row.Cells[3].Value.ToString();

                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells[4].Value;

                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox_Product.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox_Product.Image = null;
                }
            }
        }
    }
}
