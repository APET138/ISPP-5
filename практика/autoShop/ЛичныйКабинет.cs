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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace autoShop
{
    public partial class ЛичныйКабинет : Form
    {
        RegisteredUser CurrentUser;
        public ЛичныйКабинет(RegisteredUser currentUser)
        {
            InitializeComponent();
            button4.Visible = false;
            button5.Visible = false;
            dataGridView1.Visible = false;
            CurrentUser = currentUser;

            LoadUserData();
            LoadDataGridViewData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            МенюПокупателя brForm = new МенюПокупателя(CurrentUser);
            brForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказы orders = new Заказы(CurrentUser);
            orders.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dataGridView1.Visible = true;

            this.Size = new Size(671, 213);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            dataGridView1.Visible = false;

            this.Size = new Size(445, 213);
        }

        private void ЛичныйКабинет_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                try
                {
                    sqlConnect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Клиент WHERE UserID = @login", sqlConnect);

                    // Добавляем параметр к командам
                    adapter.UpdateCommand = new SqlCommand("UPDATE Клиент SET LastName = @LastName, Name = @Name, Patronimic = @Patronimic, Phone = @Phone, Bank = @Bank, Account = @Account WHERE UserID = @login", sqlConnect);
                    adapter.UpdateCommand.Parameters.AddWithValue("@login", CurrentUser.UserID);
                    adapter.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
                    adapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
                    adapter.UpdateCommand.Parameters.Add("@Patronimic", SqlDbType.NVarChar, 50, "Patronimic");
                    adapter.UpdateCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50, "Phone");
                    adapter.UpdateCommand.Parameters.Add("@Bank", SqlDbType.NVarChar, 50, "Bank");
                    adapter.UpdateCommand.Parameters.Add("@Account", SqlDbType.NVarChar, 50, "Account");

                    adapter.InsertCommand = new SqlCommand("INSERT INTO Клиент (UserID, LastName, Name, Patronimic, Phone, Bank, Account) VALUES (@login, @LastName, @Name, @Patronimic, @Phone, @Bank, @Account)", sqlConnect);
                    adapter.InsertCommand.Parameters.AddWithValue("@login", CurrentUser.UserID);
                    adapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
                    adapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
                    adapter.InsertCommand.Parameters.Add("@Patronimic", SqlDbType.NVarChar, 50, "Patronimic");
                    adapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50, "Phone");
                    adapter.InsertCommand.Parameters.Add("@Bank", SqlDbType.NVarChar, 50, "Bank");
                    adapter.InsertCommand.Parameters.Add("@Account", SqlDbType.NVarChar, 50, "Account");

                    adapter.DeleteCommand = new SqlCommand("DELETE FROM Клиент WHERE UserID = @login", sqlConnect);
                    adapter.DeleteCommand.Parameters.AddWithValue("@login", CurrentUser.UserID);

                    // Применяем изменения
                    adapter.Update((DataTable)dataGridView1.DataSource);

                    MessageBox.Show("Данные успешно обновлены");
                    МенюПокупателя brForm = new МенюПокупателя(CurrentUser);
                    brForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось обновить данные: " + ex.ToString());
                }
            }
        }

        private void LoadUserData()
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Клиент WHERE UserID = @login", sqlConnect);
                    cmd.Parameters.AddWithValue("@login", CurrentUser.UserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["LastName"].ToString();
                            textBox2.Text = reader["Name"].ToString();
                            textBox3.Text = reader["Patronimic"].ToString();
                            textBox4.Text = "+7" + reader["Phone"].ToString();
                            textBox5.Text = reader["Bank"].ToString();
                            textBox6.Text = reader["Account"].ToString();

                            string sign = reader["Sign"].ToString();
                            textBox7.Text = (sign == "1") ? "Физическое Лицо" : "Юридическое Лицо";

                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void LoadDataGridViewData()
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Клиент WHERE UserID = @login", sqlConnect);
                    cmd.Parameters.AddWithValue("@login", CurrentUser.UserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Привязываем данные к DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
