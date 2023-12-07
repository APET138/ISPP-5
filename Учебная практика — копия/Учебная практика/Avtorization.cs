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

namespace Учебная_практика
{
    public partial class Avtorization : Form
    {
        public Avtorization(){InitializeComponent();}
        string pravo;
        private void Sing_Click(object sender, EventArgs e)
        {
            if ((Login.Text=="")||(Password.Text==""))
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean log = false, password = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["Login"].ToString() == Login.Text)
                    {
                        if (dt.Rows[i]["Password"].ToString() == Password.Text)
                        {
                            password = true;
                            pravo = dt.Rows[i]["Pravo"].ToString();
                        }
                        log = true;
                    }
                if ((password == true) && (log == true))
                {
                    if ((pravo == "admin") || (pravo == "oper") || (pravo == "personal"))
                    {
                        Tables form = new Tables();
                        form.pravoo(pravo);
                        form.Show();
                        Hide();
                    }
                    else
                    {
                        AbityrientForm form = new AbityrientForm();
                        form.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Логин/пароль введен неверно","Внимание!");
                }
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            Hide();
        }
        private void PasswordVisible_MouseClick(object sender, MouseEventArgs e)
        {
            if (PasswordVisible.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e){Application.Exit();}

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пароль должен состоять из не менее 8 символов, где минимум 2 из них это буквы и одна из них заглавная", "Правила заполнения пароля");
        }
    }
}
