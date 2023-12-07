using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Бюро_технической_инвентаризации
{
    public partial class RegistrationForm : Form
    {
        
        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private Boolean checkuser()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var loginusr = LoginTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT Login FROM Users WHERE Login = '{loginusr}'";

            SqlCommand cmd = new SqlCommand(querystring, cn);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if(table.Rows.Count > 0) 
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
 
        private void Form3_Load(object sender, EventArgs e)
        {
            PassTextBox.PasswordChar = '•';
            ConfPassTextBox.PasswordChar = '•';
            ToolTip t = new ToolTip();
            t.SetToolTip(RemoveButton, "Очистка полей");
            t.SetToolTip(CloseButton, "Закрытие формы");
            t.SetToolTip(ShowPasswordReg, "Показать пароль");
            t.SetToolTip(HideButtonReg, "Спрятать пароль");
            t.SetToolTip(FamNameTextBox, "Введите фамилию");
            t.SetToolTip(NameTextBox, "Введите имя");
            t.SetToolTip(SurnameTextBox, "Введите отчество");
            t.SetToolTip(PhoneTextBox, "Введите номер телефона");
            t.SetToolTip(LoginTextBox, "Введите логин");
            t.SetToolTip(PassTextBox, "Введите пароль");
            t.SetToolTip(ConfPassTextBox, "Введите пароль повторно");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var login = LoginTextBox.Text;
            var password = PassTextBox.Text;
            var famnam = FamNameTextBox.Text;
            var name = NameTextBox.Text;
            var surname = SurnameTextBox.Text;
            var phone = PhoneTextBox.Text;
            SqlCommand cmd;
            string querystring = $"insert into Users(Login, Password, Famnam, Name, Surname, Phone) values('{login}', '{password}', '{famnam}', '{name}', '{surname}', '{phone}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (FamNameTextBox.Text == "" || NameTextBox.Text == "" || SurnameTextBox.Text == "" || PhoneTextBox.Text == "")
            {
                MessageBox.Show("У вас есть незаполненные поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (LoginTextBox.Text == "")
            {
                MessageBox.Show("Введите логин!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (PassTextBox.Text == "")
            {
                MessageBox.Show("Введите пароль!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (ConfPassTextBox.Text == "")
            {
                MessageBox.Show("Введите подтверждение пароля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (PassTextBox.Text != ConfPassTextBox.Text)
            {
                MessageBox.Show("Неправильно введено подтверждение пароля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (checkuser())
            {
                return;
            }
            else
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AuthorizationForm LogForm = new AuthorizationForm();
                LogForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FamNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {

            }
            else
                e.Handled = true;
            if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar != 8)
            {
                if (FamNameTextBox.TextLength >= 20)
                {
                    MessageBox.Show("Данное поле может содержать только 20 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {

            }
            else
                e.Handled = true;
            if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar != 8)
            {
                if (NameTextBox.TextLength >= 20)
                {
                    MessageBox.Show("Данное поле может содержать только 20 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
            {

            }
            else
                e.Handled = true;
            if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar != 8)
            {
                if (SurnameTextBox.TextLength >= 20)
                {
                    MessageBox.Show("Данное поле может содержать только 20 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar != 8)
            {
                if (PhoneTextBox.TextLength >= 7)
                {
                    MessageBox.Show("Данное поле может содержать только 7 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (LoginTextBox.TextLength >= 20)
                {
                    MessageBox.Show("Данное поле может содержать только 20 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (PassTextBox.TextLength >= 8)
                {
                    MessageBox.Show("Данное поле может содержать только 8 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void ConfPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (ConfPassTextBox.TextLength >= 8)
                {
                    MessageBox.Show("Данное поле может содержать только 8 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (FamNameTextBox.Text == "" && NameTextBox.Text == "" && PhoneTextBox.Text == "" && SurnameTextBox.Text == "" && LoginTextBox.Text == "" && PassTextBox.Text == "" && ConfPassTextBox.Text == "")
            {
                MessageBox.Show("Поля для ввода пусты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FamNameTextBox.Text = "";
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            SurnameTextBox.Text = "";
            LoginTextBox.Text = "";
            PassTextBox.Text = "";
            ConfPassTextBox.Text = "";
        }

        private void AuthLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorizationForm LogForm = new AuthorizationForm();
            LogForm.Show();
        }

        private void HideButtonReg_Click(object sender, EventArgs e)
        {
                HideButtonReg.Visible = false;
                ShowPasswordReg.Visible = true;
                PassTextBox.PasswordChar = '•';
                ConfPassTextBox.PasswordChar = '•';
        }

        private void ShowPasswordReg_Click(object sender, EventArgs e)
        {
            ShowPasswordReg.Visible=false;
            HideButtonReg.Visible = true;
            PassTextBox.PasswordChar = (char)0;
            ConfPassTextBox.PasswordChar = (char)0;
        }
    }
}
