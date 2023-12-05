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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Клиенты);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Клиенты);
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
            else
            {
                Hide();
                Form11 form11 = new Form11();
                form11.Show();
            }
        }
        public void d(string b)
        {
            if (b == "Администратор")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            else
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Клиенты);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            клиентыBindingSource1.CancelEdit();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
