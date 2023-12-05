using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_sql
{
    public partial class Inspector : Form
    {
        public Inspector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User check = new User();
            check.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet1.Pay". При необходимости она может быть перемещена или удалена.
            this.payTableAdapter1.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet1.Pay);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay". При необходимости она может быть перемещена или удалена.
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
            
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView1.CurrentCell = dataGridView1[0, index - 1];
            }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, i - 1];
            }
        }
        int k;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                dataGridView1.Visible = true;

                this.Width = 900;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;

                this.Width = 320;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            payTableAdapter1.Update(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet1.Pay);
        }
    }
}
