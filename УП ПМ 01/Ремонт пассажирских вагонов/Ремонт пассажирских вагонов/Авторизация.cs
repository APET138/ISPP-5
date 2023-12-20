using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ремонт_пассажирских_вагонов
{
    public partial class  Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
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

        private void Пароль_KeyPress(object sender, KeyPressEventArgs e) // Проверка на внесение букв в поле Пароль
        {
            Пароль.MaxLength = 15;
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы!", "Ошибка");
            }
        }

        private void Войти_Click(object sender, EventArgs e) // Кнопка Войти
        {
            try
            {
                if ((Логин.Text == "") || (Пароль.Text == "")) // В случае пустых полей в логине и пароле выходит ошибка, что поля не должны быть пустыми
                {
                    MessageBox.Show("Поля не должны быть пустыми.", "Ошибка");
                }
                else // Если поля заполнены, то происходит подключение к базе данных откуда берётся информация о пользователях в целях возможности входа в зависимости от прав доступа
                {
                    SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Макуров_ВА; Integrated Security = True"); // Подключение к базе
                    sqlConnect.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    int flag = -1;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((dt.Rows[i]["Права_Доступа"].ToString() == "Админ") && (dt.Rows[i]["Логин"].ToString() == Логин.Text) && (dt.Rows[i]["Пароль"].ToString() == Пароль.Text)) // Если введены данные под правами доступа Администратор, то выполянется переменная flag равная 0, которая ссылается на переход в другую форму
                            flag = 0;

                        if ((dt.Rows[i]["Права_Доступа"].ToString() == "Сотрудник") && (dt.Rows[i]["Логин"].ToString() == Логин.Text) && (dt.Rows[i]["Пароль"].ToString() == Пароль.Text)) // Если введены данные под правами доступа Сотрудник, то выполянется переменная flag равная 1, которая ссылается на переход в другую форму
                        {
                            flag = 1;
                        }
                        if ((dt.Rows[i]["Права_Доступа"].ToString() == "Бригадир") && (dt.Rows[i]["Логин"].ToString() == Логин.Text) && (dt.Rows[i]["Пароль"].ToString() == Пароль.Text)) // Если введены данные под правами доступа Бригадир, то выполянется переменная flag равная 2, которая ссылается на переход в другую форму
                        {
                            flag = 2;
                        }
                    }
                    if ((flag == 0) || (flag == 1) || (flag == 2))
                    {
                        if (flag == 0)
                        {
                            Hide();
                            Администратор UserForm1 = new Администратор(); // Переход на форму Администратор
                            UserForm1.Show();
                        }
                        if (flag == 1)
                        {
                            Hide();
                            Сотрудник UserForm2 = new Сотрудник(); // Переход на форму Сотрудник
                            UserForm2.Show();
                        }
                        if (flag == 2)
                        {
                            Hide();
                            Бригадир UserForm3 = new Бригадир(); // Переход на форму Бригадир
                            UserForm3.Show();
                        }
                    }
                    else // Если такого пользователя не существует, то выдается ошибка
                        MessageBox.Show("Пересоздайте пользователя! Такого пользователя не существует.", "Ошибка");
                }
            }
            catch { }
        }

        private void Регистрация_Click(object sender, EventArgs e) // Переход на форму Регистрация
        {
            Регистрация UserForm4 = new Регистрация();
            UserForm4.Show();
        }

        private void Войти_Как_Гость_Click(object sender, EventArgs e) // Переход на форму Гость
        {
            Hide();
            Гость UserForm = new Гость();
            UserForm.Show();

        }

        private void Показать_Пароль_Click(object sender, EventArgs e) // Кнопка показывающая или скрывающая пароль
        {
            if (Показать_Пароль.Text == "Показать пароль")
            {
                Пароль.PasswordChar = '\0';
                Показать_Пароль.Text = "Скрыть пароль";
            }
            else if (Показать_Пароль.Text == "Скрыть пароль")
            {
                Пароль.PasswordChar = '*';
                Показать_Пароль.Text = "Показать пароль";
            }
        }

        private void Выйти_Click(object sender, EventArgs e) // Кнопка выйти
        {
            Application.Exit();
        }

        Point Mouse;
        private void Авторизация_MouseMove(object sender, MouseEventArgs e) // Навигация формы курсором с помощью левой кнопкой мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Авторизация_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);    
        }
    }
}
