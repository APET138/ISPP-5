using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Покупатель : Form
    {
        public Покупатель()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }
        public void Zap(int v)             //Добавляет таблицы
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] sos = new SqlDataAdapter[1];
            sos[0] = new SqlDataAdapter("select Название_растения, Название_сорта, Год_выведения, Адаптация, Морозоустойчивость, Способ_посадки, Фотография, Срок_созревания_в_днях, Примечание, Наличие_в_текущее_время, Срок_годности, Одобрено_инспекцией, Вид_упаковки, Количество_в_упаковке, Цена, Вес_семян_в_граммах from Сорта_растений join Упаковки_семян on Сорта_растений.Код_сорта_растения = Упаковки_семян.Код_сорта_растения", sqlConnect);
            DataSet pk = new DataSet();
            sos[v].Fill(pk);
            Поле_для_таблиц_DataGridView1.DataSource = pk.Tables[0];
        }

        private void вернуться_Click(object sender, EventArgs e)        //Переходит на форму 'Авторизация'
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void Покупатель_Load(object sender, EventArgs e)                                 //Загрузка данных в таблицы
        {
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
        }

        private void выйти_Click(object sender, EventArgs e)      //Прекращает работу программы
        {
            Application.Exit();
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)          //Выделение строки, которая подходит под введённые данные в поисковую строку
        {
            for (int i = 0; i < Поле_для_таблиц_DataGridView1.RowCount; i++)
            {
                Поле_для_таблиц_DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < Поле_для_таблиц_DataGridView1.ColumnCount; j++)
                    if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value != null)
                        if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Строка_поиска_TextBox1.Text))
                        {
                            Поле_для_таблиц_DataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        Point Mouse;
        private void Покупатель_MouseMove(object sender, MouseEventArgs e)       //Перемещает форму при удержании мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Покупатель_MouseDown(object sender, MouseEventArgs e)       //Перемещает форму при удержании мыши
        {
            Mouse = new Point(e.X, e.Y);
        }
        string pic;
        private void Поле_для_таблиц_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)       //Изменение фотографий при нажатие на разные строки
        {
            try
            {
                pic = Поле_для_таблиц_DataGridView1.Rows[Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                Фотография_представителя_PictureBox2.Image = Image.FromFile(pic);
            }
            catch { }
        }

        private void Асортимент_ToolStripMenuItem3_Click(object sender, EventArgs e)                    //Открывает таблицы 'Сорта растени' и 'Упаковки семян'
        {
            Zap(0);
            Фотография_представителя_PictureBox2.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }
    }
}
