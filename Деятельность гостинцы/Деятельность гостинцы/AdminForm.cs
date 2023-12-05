using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Деятельность_гостинцы
{
    public partial class AdminForm : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HotelManagement;Integrated Security=True;";
        private string selectedTable;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                DataTable schema = connection.GetSchema("Tables");

                foreach (DataRow row in schema.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    comboBox1.Items.Add(tableName);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                LoadTableData(comboBox1.SelectedItem.ToString());
            }
        }

        private void LoadTableData(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.AllowUserToAddRows = true;
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedTable = comboBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTable))
            {
                LoadTableData(selectedTable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && dataGridView1.SelectedRows.Count > 0)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM {selectedTable} WHERE {dataGridView1.Columns[0].HeaderText} = @ID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", idToDelete);
                        command.ExecuteNonQuery();
                    }
                }

                LoadTableData(selectedTable);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedTable))
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataTable changes = dataTable.GetChanges();

                if (changes != null)
                {
                    SaveChangesToDatabase(selectedTable, changes);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите таблицу для сохранения изменений.");
            }
        }

        private void SaveChangesToDatabase(string tableName, DataTable changes)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection))
                {
                    using (SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter))
                    {
                        adapter.Update(changes);
                    }
                }
            }
            LoadTableData(tableName);
        }
    }
    }

   

