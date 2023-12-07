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
using Microsoft.SqlServer.Server;

namespace Учебная_практика
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(){InitializeComponent();}
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool login = true, password = false;
            string pass = Password.Text;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("Select * from Users", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Login"].ToString() == Login.Text)
                    {
                        login = false;
                    }
                }
            if (login == false)
            {
                MessageBox.Show("Такой логин уже существует!", "Ошибка");
            }
            else
            {
                if (pass.Length >= 8)
                {
                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (((pass[i] <= 'z') && (pass[i] >= 'a')) || ((pass[i] <= 'я') && (pass[i] >= 'а')))
                        {
                            for (int j = 0; j < pass.Length; j++)
                            {
                                if (((pass[j] <= 'Я') && (pass[j] >= 'А')) || ((pass[j] <= 'Z') && (pass[j] >= 'A')))
                                {
                                    password = true;
                                }
                            }
                        }
                    }
                }
                if (password == false)
                {

                    MessageBox.Show("Пароль введен в неправильном формате, для справки нажмите на символ ?*", "Внимание!");
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    da = new SqlDataAdapter($"Insert Into Users (Login,Password,Pravo) values ('{Login.Text}','{Password.Text}','user')", sqlConnect);
                    da.Fill(dt);
                    MessageBox.Show("Пользователь добавлен успешно", "Успешно!");
                    Close();
                    Avtorization form = new Avtorization();
                    form.Show();
                }
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пароль должен состоять из не менее 8 символов, где минимум 2 из них это буквы и одна из них заглавная", "Правила заполнения пароля");
        }
    }
}
