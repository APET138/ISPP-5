using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShop
{
    public partial class ДвигателиUSER : Form
    {
        public ДвигателиUSER()
        {
            InitializeComponent();
        }

        private void ДвигателиUSER_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Двигатели". При необходимости она может быть перемещена или удалена.
            this.двигателиTableAdapter.Fill(this.autoShopDataSet.Двигатели);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            двигателиBindingSource.EndEdit();
            двигателиTableAdapter.Update(autoShopDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            МенюПользователя userForm = new МенюПользователя();
            userForm.Show();
            this.Close();
        }
    }
}
