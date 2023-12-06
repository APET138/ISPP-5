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
    public partial class МенюАдмина : Form
    {
        public МенюАдмина()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            УправлениеПользователями userLog = new УправлениеПользователями();
            userLog.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 logForm = new Form2();
            logForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ПросмотрЗаказовADM order = new ПросмотрЗаказовADM();
            order.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            КлиентыADM client = new КлиентыADM();
            client.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            АвтомобилиADM car = new АвтомобилиADM();
            car.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ДвигателиADM engine = new ДвигателиADM();
            engine.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            МаркиADM model = new МаркиADM();
            model.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            КузовыADM body = new КузовыADM();
            body.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Филиалы branch = new Филиалы();
            branch.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ДиректорскийПерсонал staff = new ДиректорскийПерсонал();
            staff.Show();
            this.Close();
        }
    }
}
