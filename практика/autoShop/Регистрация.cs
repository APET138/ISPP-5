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

namespace autoShop
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не введён логин или пароль");
                return;
            }
            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Users where Login = @login", sqlConnect);
            da.SelectCommand.Parameters.AddWithValue("@login", login);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
            }
            else
            {
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into Users (Login, Password, Access) Values (@login, @password, 'guest')", sqlConnect))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);
                        try
                        {
                            sqlConnect.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Регистрация успешно завершена
                                MessageBox.Show("Регистрация успешно завершена!");
                                Form2 logForm = new Form2();
                                logForm.Show();
                                this.Close();
                            }
                            else
                            {
                                // Вставка не удалась
                                MessageBox.Show("Ошибка при регистрации. Пожалуйста, попробуйте снова.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Обработка ошибок при выполнении SQL-запроса
                            MessageBox.Show("Ошибка при регистрации: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 logForm = new Form2();
            logForm.Show();
            this.Close();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }
    }
}
