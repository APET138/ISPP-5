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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        
        
        private void button6_Click(object sender, EventArgs e)
        {

            Hide();
            Form6 form6 = new Form6();
            form6.i("Клиент");
            form6.d("Клиент");
            form6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
                Form2 form10 = new Form2();
                form10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.i("Клиент");
            form4.d("Клиент");
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form7 = new Form7();
            form7.i("Клиент");
            form7.d("Клиент");
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 form8 = new Form8();
            form8.i("Клиент");
            form8.d("Клиент");
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
