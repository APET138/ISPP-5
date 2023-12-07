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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Бюро_технической_инвентаризации
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void ConfirmButtonUser_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var login = textBox1.Text;
            var pass = textBox2.Text;
            var rights = comboBox1.Text;
            var fam = textBox3.Text;
            var name = textBox4.Text;
            var surname = textBox5.Text;
            var phone = textBox6.Text;

            SqlCommand cmd;
            string querystring = $"insert into Users(Login, Password, Rights, Famnam, Name, Surname, Phone) values('{login}', '{pass}', '{rights}', '{fam}', '{name}', '{surname}', '{phone}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
                comboBox1.Items.Add("Гость");
                comboBox1.Items.Add("Бухгалтер");
                comboBox1.Items.Add("Сотрудник");
                comboBox1.Items.Add("Начальник");
        }

        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
