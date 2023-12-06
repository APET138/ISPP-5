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
    public partial class ДобавлениеКлиента : Form
    {
        RegisteredUser currentUser;
        public ДобавлениеКлиента(RegisteredUser user)
        {
            InitializeComponent();
            currentUser = user;
            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Клиент where UserID = @login", sqlConnect);
            da.SelectCommand.Parameters.AddWithValue("@login", currentUser.UserID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                button1.Visible = false;
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string patronimic = textBox3.Text.Trim();
            string phone = textBox4.Text.Trim();
            string sign = comboBox1.SelectedItem.ToString();
            string bank = textBox5.Text.Trim();
            string account = textBox6.Text.Trim();

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");
            sqlConnect.Open();

            using (SqlCommand cmd = new SqlCommand("Insert Into Клиент(LastName, Name, Patronimic, Phone, Sign, Bank, Account, UserID) Values (@lastName, @name, @patronimic, @phone, @sign, @bank, @account, @userid)", sqlConnect))
            {
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@patronimic", patronimic);
                cmd.Parameters.AddWithValue("@phone", phone);
                if(sign == "Физическое лицо")
                {
                    cmd.Parameters.AddWithValue("@sign", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@sign", 0);
                }
                cmd.Parameters.AddWithValue("@bank", bank);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@userid", currentUser.UserID);

                try
                {
                    sqlConnect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Регистрация успешно завершена
                        MessageBox.Show("Данные успешно введены");
                        groupBox1.Visible = false;
                        groupBox2.Visible = false;
                        button1.Visible = false;
                        label8.Visible = true;
                    }
                    else
                    {
                        // Вставка не удалась, обработайте это по необходимости
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

        private void button2_Click(object sender, EventArgs e)
        {
            МенюГостя gstForm = new МенюГостя(currentUser);
            gstForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
