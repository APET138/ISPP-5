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
    public partial class Гость : Form
    {
        public Гость()
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
            if (r == "Гость")
            {
                Text = "Гость";
            }
        }
        //Добавляет таблицы
        public void Tub(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[4];
            so[0] = new SqlDataAdapter("select * from Маршруты", sqlConnect);
            so[1] = new SqlDataAdapter("select * from [Пункты маршрута]", sqlConnect);
            so[2] = new SqlDataAdapter("select * from Гостиница", sqlConnect);
            so[3] = new SqlDataAdapter("select * from Экскурсии", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            dataGridView1.DataSource = ps.Tables[0];            
        }
        public Boolean a = false;
        public Boolean b = false;
        int t;
       
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        { //Прекращает работу программы
            Application.Exit();
        }
        //Загрузка данных в таблицы
        private void Гость_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии". При необходимости она может быть перемещена или удалена.
            this.экскурсииTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута". При необходимости она может быть перемещена или удалена.
            this.пункты_маршрутаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты);
        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {//Переходит на форму 'Авторизация'
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {//Открывает таблицу 'Маршруты'
            Tub(0);
            t = 0;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;                                   
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {//Открывает таблицу 'Пункты маршрута'
            Tub(1);
            t = 1;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {//Открывает таблицу 'Гостиница'
            Tub(2);
            t = 2;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {//Открывает таблицу 'Экскурсии'
            Tub(3);
            t = 3;
            a = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
