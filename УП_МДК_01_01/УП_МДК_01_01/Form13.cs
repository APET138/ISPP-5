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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form6 = new Form6();
            form6.i("Гость");
            form6.d("Гость");
            form6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
               Close();
               Form2 form13 = new Form2();
               form13.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
