﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Гость : Form
    {
        public Гость()
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
            dataGridView1.DataSource = ps.Tables[0];
        }
        public Boolean a = false;
        public Boolean b = false;
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tob(0);
            a = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Tob(1);
            a = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
