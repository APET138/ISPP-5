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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string a;
        public void а(string b)
        {
            if (b == "Администратор")
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.i("Администратор");
            form1.d("Администратор");
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.i("Администратор");
            form4.d("Администратор");
            form4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form6 = new Form6();
            form6.i("Администратор");
            form6.d("Администратор");
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form7 = new Form7();
            form7.i("Администратор");
            form7.d("Администратор");
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
                Form9 form5 = new Form9();
                form5.i("Администратор");
            form5.Show();   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
                Form2 form5 = new Form2();
                form5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 form8 = new Form8();
            form8.i("Администратор");
            form8.Show();
        }
    }
}
