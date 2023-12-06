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
    public partial class Филиалы : Form
    {
        public Филиалы()
        {
            InitializeComponent();
        }

        private void Филиалы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Филиал". При необходимости она может быть перемещена или удалена.
            this.филиалTableAdapter.Fill(this.autoShopDataSet.Филиал);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            филиалBindingSource.EndEdit();
            филиалTableAdapter.Update(autoShopDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            МенюАдмина adminForm = new МенюАдмина();
            adminForm.Show();
            this.Close();
        }
    }
}
