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
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

namespace Учебная_практика
{
    public partial class CreateAbiturient : Form
    {
        public CreateAbiturient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Tables form = new Tables();
            form.table(0);
            form.Show();
        }
        string pyt = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pyt = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pyt = "";
            pictureBox1.Image = null;
        }
        public void ObPola()
        {
            MessageBox.Show("Это поле является обязательным для заполнения","Внимание!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Добавить")
            {
                bool obpola = true;
                var textbox = new TextBox[]
                {
                textBox1,textBox2,textBox3,textBox6
                };
                for (int i = 0; i < textbox.Length; i++)
                {
                    if (textbox[i].Text == "")
                    {
                        obpola = false;
                    }
                }
                if (maskedTextBox2.Text == "")
                {
                    obpola = false;
                }
                if (obpola == false)
                {
                    MessageBox.Show("Введите обязательные поля", "Внимание!");
                }
                else
                {
                    t[0] = textBox1.Text;
                    t[1] = textBox2.Text;
                    t[2] = textBox3.Text;
                    t[3] = dateTimePicker1.Value.ToString();
                    t[4] = textBox5.Text;
                    t[5] = maskedTextBox1.Text;
                    t[6] = dateTimePicker3.Value.ToString();
                    t[7] = maskedTextBox2.Text.Replace(" ", "");
                    t[8] = dateTimePicker2.Value.ToString();
                    t[9] = textBox4.Text;
                    t[10] = textBox6.Text;
                    t[11] = textBox7.Text;
                    if (checkBox1.Checked == true)
                    {
                        t[12] = "1";
                    }
                    else t[12] = "0";
                    t[13] = pyt;
                    SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                    sqlConnect.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet dt = new DataSet();
                    try
                    {

                        da = new SqlDataAdapter($"Insert Into Passport(Passport,PassportDate,Region) Values ('{t[7]}','{t[8]}','{t[9]}')", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данные паспортные данные уже зарегистрированны, проверьте корректность ввода данных", "Ошибка!");
                    }
                    try
                    {
                        da = new SqlDataAdapter($"Insert Into Attestat(Attestat,Middle) Values ('{t[10]}','{t[11]}')", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter($"Insert Into Enrollee(LastName,Name,FirthName,Date,Adress,Phone,Birth,Passport,Attestat,Money,Picture) Values ('{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[6]}','{t[7]}','{t[10]}','{t[12]}','{t[13]}')", sqlConnect);
                        da.Fill(dt);
                        Tables form = new Tables();
                        form.table(0);
                        ochistka();
                        Close();
                        MessageBox.Show("Запись успешно добавлена", "Успешно!");
                        form.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Данный номер аттестата уже зарегистрирован, проверьте корректность ввода данных", "Ошибка!");
                    }
                }
            }
            if (button3.Text == "Изменить")
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet dt = new DataSet();
                string a;
                if (checkBox1.Checked == true)
                {
                    a = "1";
                }
                else a = "0";
                da = new SqlDataAdapter($"Update Passport Set PassportDate='{dateTimePicker2.Value.ToString()}',Region='{textBox4.Text}' where Passport='{t[7]}' and PassportDate='{t[8]}' and Region='{t[9]}'", sqlConnect);
                da.Fill(dt);
                da = new SqlDataAdapter($"Update Attestat set Attestat='{textBox6.Text}',Middle='{textBox7.Text}' where Attestat='{t[10]}' and Middle='{t[11]}'", sqlConnect);
                da.Fill(dt);
                da = new SqlDataAdapter($"Update Enrollee set LastName = '{textBox1.Text}',Name = '{textBox2.Text}',FirthName = '{textBox3.Text}',Date = '{dateTimePicker1.Value.ToString()}',Adress = '{textBox5.Text}',Phone = '{maskedTextBox1.Text}',Birth = '{dateTimePicker3.Value.ToString()}',Passport = '{maskedTextBox2.Text.Replace(" ", "")}',Attestat = '{textBox6.Text}',Money = '{a}',Picture='{pyt}' where Passport = '{t[7]}' and Attestat = '{t[10]}'", sqlConnect);
                da.Fill(dt);
                MessageBox.Show("Запись успешно изменена", "Успешно!");
                Hide();
                Tables form = new Tables();
                form.Show();
            }
        }
        string[] t = new string[15];
        public void Update(string[] a)
        {
            for (int i = 0; i < t.Length-1; i++)
            {
                t[i] = a[i];
            }
            textBox1.Text = t[0];
            textBox2.Text=t[1];
            textBox3.Text = t[2];
            dateTimePicker1.Value = DateTime.Parse(t[3]);
            textBox5.Text = t[4];
            maskedTextBox1.Text = t[5];
            dateTimePicker3.Value = DateTime.Parse(t[6]);
            maskedTextBox2.Text = t[7];
            dateTimePicker2.Value = DateTime.Parse(t[8]);
            textBox4.Text = t[9];
            textBox6.Text = t[10];
            textBox7.Text = t[11];
            if (t[12] == "0")
            {
                checkBox1.Checked = false;
            }
            else checkBox1.Checked = true;
            button3.Text = "Изменить";
            maskedTextBox2.Enabled = false;
            textBox6.Enabled = false;
        }
        public void create()
        {
            button3.Text = "Добавить";
            maskedTextBox2.Enabled = true;
            textBox6.Enabled = true;
        }
        public void ochistka()
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = "";
            }
        }
        private void CreateAbiturient_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -=e.KeyChar;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ' '))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }
    }
}
