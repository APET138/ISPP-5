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
using System.IO;
using System.Drawing.Imaging;

namespace УП_МДК_01_01
{
    public partial class Form2 : Form
    {
        static public string loginActive;
        static public string whois;
        public Form2()
        {
            InitializeComponent();
        }
      
        private void label5_Click(object sender, EventArgs e)
        {
            
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 UsrFrm = new Form3();
            UsrFrm.Show();
            Form3 form3 = new Form3();
            form3.load();
        }
        int j = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog =уП01_ИСПП5_Работягова_АА ; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;

            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text)) { j = i; flag = true; }
            if (flag==true)
            {
                
                switch (dt.Rows[j]["Права доступа"].ToString())
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует", "Проверьте данные и попоробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            this.Hide();
                            Form5 form5 = new Form5();
                            form5.Show();
                            form5.а("Администратор");
                          
                            break;
                        }
                    case "Клиент":
                        {
                            this.Hide();
                            Form10 form10 = new Form10();
                            form10.Show();
                            break;
                        }

                    case "Агент":
                        {
                            this.Hide();
                            Form11 form11 = new Form11();
                            form11.Show();
                            break;
                        }
                    case "Оператор":
                        {
                            this.Hide();
                            Form5 form5 = new Form5();
                            form5.Show();
                            form5.а("Оператор");
                            break;
                        }
                    
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 30;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать цифры!", "Ошибка");
            }

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox2.MaxLength = 15;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form13 = new Form13();
            form13.Show(); 
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
