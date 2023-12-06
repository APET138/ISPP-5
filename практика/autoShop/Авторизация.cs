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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = pictureBox1.InitialImage;

        }

        private int loginAttempts = 5;
        bool hidden = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не введён логин или пароль");
                return;
            }

            if (loginAttempts <= 0)
            {
                MessageBox.Show("Превышено количество попыток входа. Обратитесь к администратору.");
                this.Close();
                return;
            }

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");

            try
            {
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Users where Login = @login", sqlConnect);
                da.SelectCommand.Parameters.AddWithValue("@login", login);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь с таким логином не существует.");
                    loginAttempts--;
                }
                else
                {
                    string dbPassword = dt.Rows[0]["Password"].ToString();
                    string role = dt.Rows[0]["Access"].ToString();
                    RegisteredUser currentUser = userLog(login);
                    if (password == dbPassword)
                    {
                        switch (role)
                        {
                            case "admin":
                                МенюАдмина adminForm = new МенюАдмина();
                                adminForm.Show();
                                this.Hide();
                                break;
                            case "user":
                                МенюПользователя userForm = new МенюПользователя();
                                userForm.Show();
                                this.Hide();
                                break;
                            case "buyer":
                                МенюПокупателя brForm = new МенюПокупателя(currentUser);
                                brForm.Show();
                                this.Hide();
                                break;
                            case "guest":
                                МенюГостя gstForm = new МенюГостя(currentUser);
                                gstForm.Show();
                                this.Hide();
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неверный Пароль.");
                        loginAttempts--;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Опибка при входе: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hidden == false)
            {
                pictureBox1.Image = Properties.Resources.glazik;
                textBox2.PasswordChar = '*';
                hidden = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.glazik_zakryt;
                textBox2.PasswordChar = '\0';
                hidden = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Регистрация regForm = new Регистрация();
            regForm.Show();
            this.Hide();
        }

        private RegisteredUser userLog(string login)
        {
            RegisteredUser currentUser = new RegisteredUser();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True"))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();

                    string selectQuery = "SELECT UserID FROM Users WHERE Login = @EnteredLogin";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Задаем параметр для безопасного использования в запросе
                        command.Parameters.AddWithValue("@EnteredLogin", login);

                        // Выполняем запрос и получаем результат
                        object result = command.ExecuteScalar();

                        // Проверяем, был ли найден UserID
                        if (result != null)
                        {
                            currentUser.UserID = Convert.ToInt32(result);
                            currentUser.UserName = login;
                        }
                        else
                        {
                            Console.WriteLine("Пользователь с таким логином не найден.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
                }
            }

            return currentUser;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
