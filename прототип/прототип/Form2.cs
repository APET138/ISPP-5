using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace прототип
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void выйти_PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Frm1 = new Form1();
            Frm1.Show();
        }
    }
}
