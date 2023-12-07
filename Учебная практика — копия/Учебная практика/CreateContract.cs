using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная_практика
{
    public partial class CreateContract : Form
    {
        public CreateContract()
        {
            InitializeComponent();
        }
        string[] t = new string[4];
        private void Create_Click(object sender, EventArgs e)
        {
            if (Create.Text == "Добавить")
            {
                t[0] = textBox1.Text;
                t[1] = textBox2.Text;
                t[2] = maskedTextBox1.Text;
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet dt = new DataSet();
                da = new SqlDataAdapter($"Insert Into Contract(ContractAbout,ContAdress,CountPhone, Payment) Values ('{t[0]}','{t[1]}','{t[2]}','{t[3]}')", sqlConnect);
                da.Fill(dt);
                MessageBox.Show("Запись успешно добавлена в таблицу", "Успешно!");
                Close();
                Tables form = new Tables();
                form.Show();
            }
            if (Create.Text == "Изменить")
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet dt = new DataSet();
               
                da = new SqlDataAdapter($"Update Contract set ContractAbout = '{textBox1.Text}', ContAdress = '{textBox2.Text}',CountPhone = '{maskedTextBox1.Text}', Payment = '{a}' where ContractID = {b}", sqlConnect);
                da.Fill(dt);
                Close();
                MessageBox.Show("Запись успешно изменена", "Успешно!");
                Tables form = new Tables();
                form.Show();
            }
        }
        string b;
        public void ID(string a)
        {
            b = a;
        }
        public void create()
        {
            Create.Text = "Добавить";
        }
        public void Update(string[] a)
        {
            Create.Text = "Изменить";
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = a[i];
            }
            textBox1.Text = t[0];
            textBox2.Text = t[1];
            maskedTextBox1.Text = t[2];
            if (t[3] == "0")
            {
                checkBox1.Checked = false;
            }
            else checkBox1.Checked = true;
        }

            private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }
        string a;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Tables form = new Tables();
            form.table(2);
            form.Show();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = "1";
            }
            else a = "0";
        }
    }
}
