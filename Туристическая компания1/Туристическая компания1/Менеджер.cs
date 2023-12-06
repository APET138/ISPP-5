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

namespace Туристическая_компания1
{
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }
        string r;
        public void ii(string b)
        {
            r = b;
            i1();
        }
        public void i1()
        {
            if (r == "Менеджер")
            {
                Text = "Менеджер";
            }
        }
        public void Tub(int i)
        {   //Добавляет таблицы
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[7];
            so[0] = new SqlDataAdapter("select * from Контракты", sqlConnect);
            so[1] = new SqlDataAdapter("select * from Клиенты", sqlConnect);
            so[2] = new SqlDataAdapter("select * from Документы", sqlConnect);
            so[3] = new SqlDataAdapter("select * from Маршруты", sqlConnect);
            so[4] = new SqlDataAdapter("select * from [Пункты маршрута]", sqlConnect);
            so[5] = new SqlDataAdapter("select * from Гостиница", sqlConnect);
            so[6] = new SqlDataAdapter("select * from Экскурсии", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            dataGridView1.DataSource = ps.Tables[0];
        }
        public Boolean a = false;
        public Boolean b = false;
        int t;        
        private void Менеджер_Load(object sender, EventArgs e)
        {   //Загрузка данных в таблицы
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии". При необходимости она может быть перемещена или удалена.
            this.экскурсииTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута". При необходимости она может быть перемещена или удалена.
            this.пункты_маршрутаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Контракты". При необходимости она может быть перемещена или удалена.
            this.контрактыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Контракты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница);

        }       
        
        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {   //Открывает таблицу 'Контракты'
            Tub(0);
            t = 0;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {   //Переходит на форму 'Авторизация'
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {   //Прекращает работу программы
            Application.Exit();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Клиенты'
            Tub(1);
            t = 1;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Документы'
            Tub(2);
            t = 2;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Маршруты'
            Tub(3);
            t = 3;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Пункты маршрута'
            Tub(4);
            t = 4;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Гостиница'
            Tub(5);
            t = 5;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {   //Открывает таблицу 'Экскурсии'
            Tub(6);
            t = 6;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Выделение строки, которая подходит под введённые данные в поисковую строку
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
