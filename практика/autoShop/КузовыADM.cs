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
    public partial class КузовыADM : Form
    {
        public КузовыADM()
        {
            InitializeComponent();
        }

        private void Кузовы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Кузов". При необходимости она может быть перемещена или удалена.
            this.кузовTableAdapter.Fill(this.autoShopDataSet.Кузов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            МенюАдмина adminForm = new МенюАдмина();
            adminForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            кузовBindingSource.EndEdit();
            кузовTableAdapter.Update(autoShopDataSet);
        }
    }
}
