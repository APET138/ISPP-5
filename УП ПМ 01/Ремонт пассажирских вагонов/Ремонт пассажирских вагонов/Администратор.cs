using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Ремонт_пассажирских_вагонов
{
    public partial class Администратор : Form
    {
        int s;
        public Администратор()
        {
            InitializeComponent();
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        public void Просмотр(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Макуров_ВА; Integrated Security = True"); // Подключение к базе
            sqlConnect.Open();

            switch (i) // Просмотр таблиц
            {
                case 0: Таблица.DataSource = вагоныBindingSource; break;
                case 1: Таблица.DataSource = ремонтныеРаботыBindingSource; break;
                case 2: Таблица.DataSource = железныеДорогиBindingSource; break;
                case 3: Таблица.DataSource = ремонтыBindingSource; break;
                case 4: Таблица.DataSource = бригадыBindingSource; break;
                case 5: Таблица.DataSource = сотрудникиBindingSource; break;
                case 6: Таблица.DataSource = бригадирыBindingSource; break;
                case 7: Таблица.DataSource = пользователиBindingSource; break;
            }
            s = i;
        }

        private void Внести_Изменения_Click(object sender, EventArgs e) // Кнопка для внесения изменения в базе данных 
        {
            switch (s)
            {
                case 0:
                    вагоныTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Вагоны); // Обновление таблицы
                    вагоныTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Вагоны); // Перезаписывание таблицы после обновления 
                    break;

                case 1:
                    ремонтные_РаботыTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Ремонтные_Работы);
                    ремонтные_РаботыTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Ремонтные_Работы);
                    break;

                case 2:
                    железные_ДорогиTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Железные_Дороги);
                    железные_ДорогиTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Железные_Дороги);
                    break;

                case 3:
                    ремонтыTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Ремонты);
                    ремонтыTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Ремонты);
                    break;

                case 4:
                    бригадыTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Бригады);
                    бригадыTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Бригады);
                    break;

                case 5:
                    сотрудникиTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Сотрудники);
                    сотрудникиTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Сотрудники);
                    break;

                case 6:
                    бригадирыTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Бригадиры);
                    бригадирыTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Бригадиры);
                    break;

                case 7:
                    пользователиTableAdapter.Update(уП01_ИСПП5_Макуров_ВАDataSet.Пользователи);
                    пользователиTableAdapter.Fill(уП01_ИСПП5_Макуров_ВАDataSet.Пользователи);
                    break;
            }
            MessageBox.Show("Изменения внесены.", "Уводмление"); // При нажатии появляется окно уведомления, что изменения в базу внесены
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

        private void Железные_Дороги_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Железные дороги
        {
            Просмотр(2);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Ремонты_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Ремонты
        {
            Просмотр(3);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Бригады_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Бригады
        {
            Просмотр(4);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Сотрудники_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Сотрудники
        {
            Просмотр(5);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Бригадиры_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Бригадиры
        {
            Просмотр(6);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Пользователи_Click(object sender, EventArgs e) // Кнопка для просмотра таблицы Пользователи
        {
            Просмотр(7);
            Фото_Вагона.Visible = false;
            Таблица.Size = new Size(1041, 438);
        }

        private void Выйти_Click(object sender, EventArgs e) // Кнопка Выйти
        {
            Application.Exit();
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
        private void Администратор_MouseMove(object sender, MouseEventArgs e) // Навигация формы курсором с помощью левой кнопкой мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Администратор_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }

        private void Администратор_Load(object sender, EventArgs e) // Метод вызванный самой программой при добавлении в табличную часть объектов, представленные ниже
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Ремонты". При необходимости она может быть перемещена или удалена.
            this.ремонтыTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Ремонты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Ремонтные_Работы". При необходимости она может быть перемещена или удалена.
            this.ремонтные_РаботыTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Ремонтные_Работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Железные_Дороги". При необходимости она может быть перемещена или удалена.
            this.железные_ДорогиTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Железные_Дороги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Вагоны". При необходимости она может быть перемещена или удалена.
            this.вагоныTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Вагоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Бригады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Макуров_ВАDataSet.Бригадиры". При необходимости она может быть перемещена или удалена.
            this.бригадирыTableAdapter.Fill(this.уП01_ИСПП5_Макуров_ВАDataSet.Бригадиры);
        }

        private void Выбрать_Фотографию_Click(object sender, EventArgs e) // Кнопка для выбора фотографий
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Макуров_ВА; Integrated Security = True");
            sqlConnect.Open();

            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK) // Если кнопка нажата и пользователь выбрал файл, то программа сохраняет файл туда куда он указал его в табличной части в виде пути к папке
            {
                Фото_Вагона.ImageLocation = load.FileName;
                SqlDataAdapter a = new SqlDataAdapter($"UPDATE Вагоны SET Фотография = '{load.FileName}' WHERE Код_Вагона = '{Таблица.Rows[Таблица.SelectedCells[0].RowIndex].Cells[0].Value}'", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
            }
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
