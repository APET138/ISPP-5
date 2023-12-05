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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.i("Агент");
            form1.d("Агент");
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.i("Агент");
            form4.d("Агент");
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form7 = new Form7();
            form7.i("Агент");
            form7.d("Агент");
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 form8 = new Form8();
            form8.i("Агент");
            form8.d("Агент");
            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                Close();
                Form2 form11 = new Form2();
                form11.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
