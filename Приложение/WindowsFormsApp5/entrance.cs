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

namespace WindowsFormsApp5
{
    public partial class entrance : Form
    {
        public entrance()
        {
            InitializeComponent();
        }
        private void entrance_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            СкрытьПароль.Text = "Показать пороль";
        }
        private void ceckBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        private void Выйти_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Вход_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                if ((textBox1.Text == "") && (textBox2.Text == ""))
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
                Boolean flag = false;
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["login"].ToString() == textBox1.Text) &&
                    (dt.Rows[i]["parol"].ToString() == textBox2.Text))
                    {
                        string роль = dt.Rows[i]["reverh"].ToString();

                        switch (роль)
                        {
                            case "Админ":
                                this.Hide();
                                admin AdmFrm = new admin();
                                AdmFrm.Show();
                                break;

                            case "Сотрудник":
                                this.Hide();
                                admin AdmFr = new admin();
                                AdmFr.Show();
                                AdmFr.ii("Сотрудник");
                                break;

                            case "Директор":
                                this.Hide();
                                admin AdmF = new admin();
                                AdmF.Show();
                                AdmF.ii("Директор");
                                break;

                            default:

                                MessageBox.Show("Неправильный логин или пароль.");
                                break;
                        }

                        break;
                    }
                }
            }
        }

        private void СкрытьПароль_CheckedChanged(object sender, EventArgs e)
        {
            if (СкрытьПароль.Checked == true)
            {
                СкрытьПароль.Text = "Скрыть пороль";

                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                СкрытьПароль.Text = "Показать пороль";
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
