﻿using System;
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
    public partial class МенюГостя : Form
    {
        private RegisteredUser currentUser;
        public МенюГостя(RegisteredUser user)
        {
            InitializeComponent();
            currentUser = user;
            label1.Text = currentUser.UserName;
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

        private void button5_Click(object sender, EventArgs e)
        {
            ДобавлениеКлиента client = new ДобавлениеКлиента(currentUser);
            client.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
