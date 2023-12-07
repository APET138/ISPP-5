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

namespace Бюро_технической_инвентаризации
{
    public partial class AddCust : Form
    {
        public AddCust()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var fanam = textBox1.Text;
            var name = textBox2.Text;
            var surname = textBox3.Text;
            var phone = textBox4.Text;
            var receipt = checkBox1.Checked;
            var bank = textBox5.Text;
            var acc = textBox6.Text;
            SqlCommand cmd;
            string querystring = $"insert into Customers(Fam, Name, Surname, Phone, Receipt, Bank, Account) values('{fanam}', '{name}', '{surname}', '{phone}', '{receipt}', '{bank}', '{acc}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
