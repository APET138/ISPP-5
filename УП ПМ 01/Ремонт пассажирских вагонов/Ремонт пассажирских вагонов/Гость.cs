using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ремонт_пассажирских_вагонов
{
    public partial class Гость : Form
    {
        public Гость()
        {
            InitializeComponent();
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        public void Просмотр(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Макуров_ВА; Integrated Security = True"); // Подключение к базе
            sqlConnect.Open();

            SqlDataAdapter[] sa = new SqlDataAdapter[3]; // Просмотр таблиц 
            sa[0] = new SqlDataAdapter("SELECT * FROM Вагоны", sqlConnect);
            sa[1] = new SqlDataAdapter("SELECT * FROM Ремонтные_Работы", sqlConnect);
            sa[2] = new SqlDataAdapter("SELECT * FROM Бригады", sqlConnect);
            DataSet ds = new DataSet();
            sa[i].Fill(ds);
            Таблица.DataSource = ds.Tables[0];
        }

        private void Выйти_Click(object sender, EventArgs e) // Кнопка Выйти
        {
            Application.Exit();
        }

        private void Вагоны_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Вагоны 
        {
            Просмотр(0);
            Фото_Вагона.Visible = true;
            Таблица.Size = new Size(826, 438);
        }

        private void Ремонтные_Работы_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Ремонтные работы
        {
            Просмотр(1);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Бригады_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Бригады
        {
            Просмотр(2);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Вернуться_Click(object sender, EventArgs e) // Кнопка Вернуться
        {
            Hide();
            Авторизация UserForm = new Авторизация();
            UserForm.Show();
        }

        private void Поиск_TextChanged(object sender, EventArgs e) // Динамичный поиск при вводе данных в поле 
        {
            for (int i = 0; i < Таблица.RowCount; i++)
            {
                Таблица.Rows[i].Selected = false;
                for (int j = 0; j < Таблица.ColumnCount; j++)
                    if (Таблица.Rows[i].Cells[j].Value != null)
                        if (Таблица.Rows[i].Cells[j].Value.ToString().Contains(Поиск.Text))
                        {
                            Таблица.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        Point Mouse;
        private void Гость_MouseMove(object sender, MouseEventArgs e) // Навигация формы курсором с помощью левой кнопкой мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Гость_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }

        string picture;
        private void Таблица_CellClick(object sender, DataGridViewCellEventArgs e) // При клике на любую строку в таблице меняет фотографию в picturebox
        {
            try
            {
                picture = Таблица.Rows[Таблица.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                Фото_Вагона.Image = Image.FromFile(picture);
            }
            catch { }
        }
    }
}
