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
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace Бюро_технической_инвентаризации
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        int k = 0;

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox1.Text == "" && PassTextBox1.Text == "")
            {
                MessageBox.Show("Поля для ввода пусты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoginTextBox1.Text = "";
            PassTextBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PassTextBox1.PasswordChar = '•';
            ToolTip t = new ToolTip();
            t.SetToolTip(RemoveButton, "Очистка полей");
            t.SetToolTip(CloseButton, "Закрыть форму");
            t.SetToolTip(ShowPasswordAuth, "Показать пароль");
            t.SetToolTip(HideButtonAuth, "Спрятать пароль");
            t.SetToolTip(LoginTextBox1, "Введите логин");
            t.SetToolTip(PassTextBox1, "Введите пароль");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            k++;
            if (k > 5)
            {
                MessageBox.Show("Исчерпано количество попыток авторизации", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            label4.Text = "Попыток входа: " + k.ToString();
            SqlConnection sqlConnect = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True");
            SqlCommand work = new SqlCommand("Select Rights, Famnam, Name From Users where Login = @login", sqlConnect);
            work.Parameters.AddWithValue("@login", LoginTextBox1.Text);
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Login"].ToString() == LoginTextBox1.Text) && (dt.Rows[i]["Password"].ToString() == PassTextBox1.Text))
                    flag = true;
            if (flag == true)
            {
                MessageBox.Show("Вы успешно вошли!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var r = work.ExecuteScalar().ToString();
                if (r == "Бухгалтер")
                {
                    Form1 UsrFrm = new Form1();
                    UsrFrm.Show();
                    SqlDataReader rd = work.ExecuteReader();
                    UsrFrm.tabPage5.Parent = null;
                    UsrFrm.InfoButton.Visible = false;
                    UsrFrm.AdminButton.Visible = false;
                    UsrFrm.AddButtonDep.Visible = false;
                    UsrFrm.EditButtonDep.Visible = false;
                    UsrFrm.RemoveButtonDep.Visible = false;
                    UsrFrm.AddButtonTech.Visible = false;
                    UsrFrm.EditButtonTech.Visible = false;
                    UsrFrm.RemoveButtonTech.Visible = false;
                    UsrFrm.AddButtonExecut.Visible = false;
                    UsrFrm.EditButtonExecut.Visible = false;
                    UsrFrm.RemoveButtonExecut.Visible = false;
                    UsrFrm.AddButtonChief.Visible = false;
                    UsrFrm.EditButtonChief.Visible = false;
                    UsrFrm.RemoveButtonChief.Visible = false;
                    while (rd.Read())
                    {
                        UsrFrm.UserName.Text = String.Format("{0} {1}", rd["Famnam"], rd["Name"]);
                        UsrFrm.UserRight.Text = String.Format("{0}", rd["Rights"]);
                    }
                }
                if (r == "Начальник")
                {
                    Form1 UsrFrm = new Form1();
                    UsrFrm.Show();
                    SqlDataReader rd = work.ExecuteReader();
                    UsrFrm.tabPage5.Parent = null;
                    UsrFrm.InfoButton.Visible = false;
                    UsrFrm.AdminButton.Visible = false;
                    UsrFrm.AddButtonCust.Visible = false;
                    UsrFrm.EditButtonCust.Visible = false;
                    UsrFrm.RemoveButtonCust.Visible = false;
                    UsrFrm.AddButtonApp.Visible = false;
                    UsrFrm.EditButtonApp.Visible = false;
                    UsrFrm.RemoveButtonApp.Visible = false;
                    UsrFrm.AddButtonChief.Visible = false;
                    UsrFrm.EditButtonChief.Visible = false;
                    UsrFrm.RemoveButtonChief.Visible = false;
                    UsrFrm.dataGridView5.Visible = false;
                    UsrFrm.RefreshButtonChief.Visible = false;
                    while (rd.Read())
                    {
                        UsrFrm.UserName.Text = String.Format("{0} {1}", rd["Famnam"], rd["Name"]);
                        UsrFrm.UserRight.Text = String.Format("{0}", rd["Rights"]);
                    }
                }
                if (r == "Администратор")
                {
                    Form1 UsrFrm = new Form1();
                    UsrFrm.Show();
                    SqlDataReader rd = work.ExecuteReader();
                    UsrFrm.InfoButton.Visible = false;
                    while (rd.Read())
                    {
                        UsrFrm.UserName.Text = String.Format("{0} {1}", rd["Famnam"], rd["Name"]);
                        UsrFrm.UserRight.Text = String.Format("{0}", rd["Rights"]);
                    }
                }
                if (r == "Сотрудник")
                {
                    Form1 UsrFrm = new Form1();
                    UsrFrm.Show();
                    SqlDataReader rd = work.ExecuteReader();
                    UsrFrm.tabPage1.Parent = null;
                    UsrFrm.tabPage3.Parent = null;
                    UsrFrm.tabPage4.Parent = null;
                    UsrFrm.tabPage5.Parent = null;
                    UsrFrm.AddButtonApp.Visible = false;
                    UsrFrm.EditButtonApp.Visible = false;
                    UsrFrm.RemoveButtonApp.Visible = false;
                    UsrFrm.InfoButton.Visible = false;
                    UsrFrm.AdminButton.Visible = false;
                    while (rd.Read())
                    {
                        UsrFrm.UserName.Text = String.Format("{0} {1}", rd["Famnam"], rd["Name"]);
                        UsrFrm.UserRight.Text = String.Format("{0}", rd["Rights"]);
                    }
                }
                if (r == "Гость")
                {
                    Form1 UsrFrm = new Form1();
                    UsrFrm.Show();
                    SqlDataReader rd = work.ExecuteReader();
                    UsrFrm.tabPage1.Parent = null;
                    UsrFrm.tabPage2.Parent = null;
                    UsrFrm.tabPage3.Parent = null;
                    UsrFrm.tabPage4.Parent = null;
                    UsrFrm.AddButtonCompApp.Visible = false;
                    UsrFrm.EditButtonCompApp.Visible = false;
                    UsrFrm.RemoveButtonCompApp.Visible = false;
                    UsrFrm.AdminButton.Visible = false;
                    while (rd.Read())
                    {
                        UsrFrm.UserName.Text = String.Format("{0} {1}", rd["Famnam"], rd["Name"]);
                        UsrFrm.UserRight.Text = String.Format("{0}", rd["Rights"]);
                    }
                }
            }
            else
            if (LoginTextBox1.Text == "" && PassTextBox1.Text == "")
            {
                MessageBox.Show("Не введены данные в оба текстовые поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (LoginTextBox1.Text == "" || PassTextBox1.Text == "")
            {
                MessageBox.Show("Не введены данные в одно поле!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if ((flag == false))
            {
                MessageBox.Show("Не совпадает пара логин/пароль с данными в базе данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && e.KeyChar != 'ё' && e.KeyChar != 'Ё')
            {

            }
            else
                e.Handled = true;
            if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar != 8)
            {
                if (LoginTextBox1.TextLength >= 20)
                {
                    MessageBox.Show("Логин может содержать максимум 20 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void PassTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (PassTextBox1.TextLength >= 8)
                {
                    MessageBox.Show("Пароль может содержать максимум 8 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void HideButtonAuth_Click(object sender, EventArgs e)
        {
            HideButtonAuth.Visible = false;
            ShowPasswordAuth.Visible = true;
            PassTextBox1.PasswordChar = '•';
        }

        private void ShowPasswordAuth_Click(object sender, EventArgs e)
        {
            HideButtonAuth.Visible = true;
            ShowPasswordAuth.Visible = false;
            PassTextBox1.PasswordChar = (char)0;
        }
    }
}
