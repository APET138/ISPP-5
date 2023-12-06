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
    public partial class МенюПокупателя : Form
    {
        RegisteredUser currentUser;
        public МенюПокупателя(RegisteredUser user)
        {
            InitializeComponent();
            currentUser = user;
            label1.Text = currentUser.UserName;
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

        private void button5_Click(object sender, EventArgs e)
        {
            ЛичныйКабинет profile = new ЛичныйКабинет(currentUser);
            profile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ОформлениеЗаказа createOrder = new ОформлениеЗаказа(currentUser);
            createOrder.Show();
            this.Close();
        }
    }
}
