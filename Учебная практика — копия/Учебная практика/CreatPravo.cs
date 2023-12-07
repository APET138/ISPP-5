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

namespace Учебная_практика
{
    public partial class CreatPravo : Form
    {
        public CreatPravo()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            bool login = true, password = false;
            string pass = textBox2.Text;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("Select * from Users", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Login"].ToString() == textBox3.Text)
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
                    if ((comboBox1.Text != "Администратор") || (comboBox1.Text != "Сотрудник") || (comboBox1.Text != "Пользователь") || (comboBox1.Text != "Оператор"))
                    {
                        MessageBox.Show("Права введены некорректно!", "Ошибка!");
                    }
                    else
                    {
                        string pravo="";
                        if (comboBox1.Text == "Администратор")
                        {
                            pravo = "admin";
                        }
                        if (comboBox1.Text == "Оператор")
                        {
                            pravo = "oper";
                        }
                        if (comboBox1.Text == "Сотрудник")
                        {
                            pravo = "personal";
                        }
                        if (comboBox1.Text == "Пользователь")
                        {
                            pravo = "user";
                        }
                        da = new SqlDataAdapter($"Insert Into Users (Login,Password,Pravo) values ('{textBox3.Text}','{textBox2.Text}','{pravo}')", sqlConnect);
                        da.Fill(dt);
                        MessageBox.Show("Пользователь добавлен успешно", "Успешно!");
                        Close();
                        Avtorization form = new Avtorization();
                        form.Show();
                    }
                    
                }
            }
        }
    }
}
