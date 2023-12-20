using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ремонт_пассажирских_вагонов
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Почта_KeyPress(object sender, KeyPressEventArgs e) // Проверка на внесение цифр в поле Почта
        {
            Почта.MaxLength = 30;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать цифры!", "Ошибка");
            }
        }

        private void Логин_KeyPress(object sender, KeyPressEventArgs e) // Проверка на внесение цифр в поле Логин
        {
            Логин.MaxLength = 30;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать цифры!", "Ошибка");
            }
        }

        private void Пароль_KeyPress(object sender, KeyPressEventArgs e) // Проверка на внесение цифр в поле Пароль
        {
            Пароль.MaxLength = 15;
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы!", "Ошибка");
            }
        }

        private void Подтвердить_Click(object sender, EventArgs e) // Кнопка Подтвердить
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Макуров_ВА; Integrated Security = True"); // Подключение к базе
            sqlConnect.Open();

            if ((Почта.Text == "") || (Логин.Text == "") || (Пароль.Text == "")) // В случае пустых полей в почте, логине и пароле выходит ошибка, что поля не должны быть пустыми
            {
                MessageBox.Show("Поля не должны быть пустыми.", "Ошибка");
            }
            else // Заполнение таблицы Пользователи в базу данных с помощью полей Почта, Логин, Пароль
            {
                SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Пользователи (Почта, Логин, Пароль) VALUES ('{Почта.Text}', '{Логин.Text}', '{Пароль.Text}');", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Вы зарегистрированы, как сотрудник.", "Уведомление"); // Если данные внесены, то пользователь будет зарегистрирован, как сотрудник

                Hide();
                Сотрудник UserForm = new Сотрудник(); // Переход на форму Сотрудник
                UserForm.Close();
            }
        }

        private void Выйти_Click(object sender, EventArgs e)
        {
            Hide();
            Регистрация UserForm = new Регистрация(); // Переход на форму Регистрация
            UserForm.Close();
        }

        Point Mouse;
        private void Регистрация_MouseMove(object sender, MouseEventArgs e) // Навигация формы курсором с помощью левой кнопкой мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Регистрация_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }
    }
}
