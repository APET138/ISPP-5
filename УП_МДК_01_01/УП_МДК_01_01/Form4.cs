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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Договоры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Продление". При необходимости она может быть перемещена или удалена.
            this.продлениеTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Продление);

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
        private void button1_Click(object sender, EventArgs e)
        {
            продлениеTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Продление);
            договорыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Договоры);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            продлениеTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Продление);
            договорыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Договоры);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           fKПродлениеДоговорыBindingSource.CancelEdit();
            договорыBindingSource.CancelEdit(); 
        }
    }
}
