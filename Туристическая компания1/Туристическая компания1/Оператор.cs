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
    public partial class Оператор : Form
    {
        public Оператор()
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
            if (r == "Оператор")
            {
                Text = "Оператор";
            }
        }
        int c;
        public void tab(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
            sqlConnect.Open();
            switch (i)
            {
                case 0: dataGridView1.DataSource = контрактыBindingSource; break;
                case 1: dataGridView1.DataSource = клиентыBindingSource; break;
                case 2: dataGridView1.DataSource = документыBindingSource; break;
                case 3: dataGridView1.DataSource = маршрутыBindingSource; break;
                case 4: dataGridView1.DataSource = пунктыМаршрутаBindingSource; break;
                case 5: dataGridView1.DataSource = гостиницаBindingSource; break;
                case 6: dataGridView1.DataSource = экскурсииBindingSource; break;                
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }
        private void Оператор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии". При необходимости она может быть перемещена или удалена.
            this.экскурсииTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута". При необходимости она может быть перемещена или удалена.
            this.пункты_маршрутаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута);            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Контракты". При необходимости она может быть перемещена или удалена.
            this.контрактыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Контракты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница);            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 0: контрактыTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Контракты); break;

                case 1: клиентыTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты); break;

                case 2: документыTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Документы); break;

                case 3: маршрутыTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты); break;

                case 4: пункты_маршрутаTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута); break;

                case 5: гостиницаTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница); break;

                case 6: экскурсииTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии); break;                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tab(0);
            c = 0;
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tab(1);
            c = 1;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tab(2);
            c = 2;
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            tab(3);
            c = 3;
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            tab(4);
            c = 4;
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tab(5);
            c = 5;
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            tab(6);
            c = 6;
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
