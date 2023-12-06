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
    public partial class АвтомобилиADM : Form
    {
        public АвтомобилиADM()
        {
            InitializeComponent();
        }

        private void АвтомобилиADM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.autoShopDataSet.Автомобиль);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            автомобильBindingSource.EndEdit();
            автомобильTableAdapter.Update(autoShopDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            МенюАдмина adminForm = new МенюАдмина();
            adminForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
