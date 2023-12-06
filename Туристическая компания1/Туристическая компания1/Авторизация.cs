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

namespace Туристическая_компания1
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }
        int a = 0;
        int popitki = 6;
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Проверяет на отсутствие букв
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы!");
            }
        }       

        private void label6_Click(object sender, EventArgs e)
        {
            //Переходит на форму 'Администратор', 'Оператор', 'Менеджер', 'Клиент' и 'Гость'
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                if ((textBox1.Text == "") && (textBox2.Text == "") && (textBox3.Text == ""))
                {
                    MessageBox.Show("Заполните все поля!!!");
                }
                else
                {
                    if ((textBox1.Text == "") && (textBox2.Text == ""))
                    {
                        MessageBox.Show("Введите Логин и Пароль!!!");
                    }
                    else
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Введите Логин!!!");
                        }
                        else
                        {
                            if (textBox2.Text == "")
                            {
                                MessageBox.Show("Введите Пароль!!!");
                            }
                        }
                    }

                }
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean log = false, password = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["Логин"].ToString() == textBox1.Text)
                    {
                        if (dt.Rows[i]["Пароль"].ToString() == textBox2.Text)
                        {
                            password = true;
                            textBox3.Text = dt.Rows[i]["Права доступа"].ToString();
                        }
                        log = true;
                    }
                if ((password == true) && (log == true))
                {
                    if (textBox3.Text == "Гость")
                    {
                        this.Hide();
                        Клиент UsrFrm = new Клиент();
                        UsrFrm.Show();
                        UsrFrm.ii("Гость");
                    }
                    if (textBox3.Text == "Клиент")
                    {
                        this.Hide();
                        Клиент UsrFrm = new Клиент();
                        UsrFrm.Show();
                        UsrFrm.ii("Клиент");
                    }
                    if (textBox3.Text == "Менеджер ")
                    {
                        this.Hide();
                        Менеджер UsrFrm = new Менеджер();
                        UsrFrm.Show();
                        UsrFrm.ii("Менеджер ");
                    }
                    if (textBox3.Text == "Администратор")
                    {
                        this.Hide();
                        Администратор UsrFrm = new Администратор();
                        UsrFrm.Show();
                        UsrFrm.ii("Администратор");
                    }
                    if (textBox3.Text == "Оператор")
                    {
                        this.Hide();
                        Оператор UsrFrm = new Оператор();
                        UsrFrm.Show();
                        UsrFrm.ii("Оператор");
                    }

                }
                else
                {
                    if ((password == false) && (log == false))
                    {
                        MessageBox.Show("Данный пользователь отсутвует!!!");
                    }
                    else
                    {
                        if (password == false)
                        {
                            MessageBox.Show("Неверно введен Пароль!!!");
                            popitki -= 1;
                            label4.Text = "Количество попыток для ввода Пароля осталось: " + popitki;
                            if (popitki == 0)
                            {
                                label5.Visible = true;
                                label7.Visible = false;
                                label8.Location = new Point(113, 125);
                                label9.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Переходит на форму 'Регистрация'
            this.Hide();
            Регистрация UsrFrm4 = new Регистрация();
            UsrFrm4.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Переходит на форму 'Гость'
            this.Hide();
            Гость UsrFrm3 = new Гость();
            UsrFrm3.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Прекращает работу программы
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Видимость пароля            
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
