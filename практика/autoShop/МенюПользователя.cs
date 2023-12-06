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
    public partial class МенюПользователя : Form
    {
        public МенюПользователя()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ПросмотрЗаказовUSER order = new ПросмотрЗаказовUSER();
            order.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            КлиентUSER client = new КлиентUSER();
            client.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            АвтомобилиUSER car = new АвтомобилиUSER();
            car.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ДвигателиUSER engine = new ДвигателиUSER();
            engine.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            МаркиUSER model = new МаркиUSER();
            model.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            КузовыUSER body = new КузовыUSER();
            body.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 logForm = new Form2();
            logForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
