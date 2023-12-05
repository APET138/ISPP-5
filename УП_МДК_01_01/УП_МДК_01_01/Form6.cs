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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            агентыTableAdapter2.Update(уП01_ИСПП5_Работягова_ААDataSet3.Агенты);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Агенты". При необходимости она может быть перемещена или удалена.
            this.агентыTableAdapter2.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Агенты);

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
            else if (dost == "Клиент")
            {
                Hide();
                Form10 form10 = new Form10();
                form10.Show();
            }
            else
            {
                Hide();
                Form13 form13 = new Form13();
                form13.Show();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            агентыTableAdapter2.Update(уП01_ИСПП5_Работягова_ААDataSet3.Агенты);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           агентыBindingSource.CancelEdit();
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
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
