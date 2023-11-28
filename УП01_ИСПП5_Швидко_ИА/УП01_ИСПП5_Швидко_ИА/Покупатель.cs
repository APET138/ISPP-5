﻿using System;
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
        }

        public void Tob(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[2];
            so[0] = new SqlDataAdapter("select Название_растения, Название_сорта, Год_выведения, Адаптация, Морозоустойчивость, Способ_посадки, Фотография_представителя_сорта, Срок_созревания_в_днях, Примечание, Наличие_в_текущее_время from Сорта_растений", sqlConnect);
            so[1] = new SqlDataAdapter("select Срок_годности, Одобрено_инспекцией, Вид_упаковки, Количество_в_упаковке, Цена, Дата_расфасовки, Вес_семян_в_упаковке, Код_сорта_растения from Упаковки_семян", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            Поле_для_таблиц_DataGridView1.DataSource = ps.Tables[0];
        }
        public Boolean a = false;
        public Boolean b = false;

        private void вернуться_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)
        {
            Tob(0);
            a = true;
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)
        {
            Tob(1);
            a = true;
        }

        private void Покупатель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);

        }

        private void выйти_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)
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
        private void Покупатель_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Покупатель_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }
    }
}
