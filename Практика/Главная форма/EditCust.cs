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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Бюро_технической_инвентаризации
{
    public partial class EditCust : Form
    {
        
        public EditCust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            
            var id = textBox9.Text;
            var fanam = textBox1.Text;
            var name = textBox2.Text;
            var surname = textBox3.Text;
            var phone = textBox4.Text;
            var receipt = checkBox1.Checked;
            var bank = textBox5.Text;
            var acc = textBox6.Text;
            Form1 UsrFrm = new Form1();
            string updatestring = $"UPDATE Customers SET Fam = '{fanam}', Name = '{name}', Surname = '{surname}', Phone = '{phone}', Receipt = '{receipt}', Bank = '{bank}', Account = '{acc}' WHERE Customer_Code = '{id}'";
            var cmd = new SqlCommand(updatestring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно изменена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Информация не добавлена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.ReadOnly = true;
        }
    }
}
