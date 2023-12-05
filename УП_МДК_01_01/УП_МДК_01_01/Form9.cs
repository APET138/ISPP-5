using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_МДК_01_01
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Пользователи);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            пользователиTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Пользователи);
        }
        public string dost;
        public void i(string b)
        {
            dost = b;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dost == "Администратор")
            {
                Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
