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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Бюро_технической_инвентаризации
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void ConfirmButtonEditUser_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var id = textBox7.Text;
            var login = textBox1.Text;
            var pass = textBox2.Text;
            var rights = comboBox1.Text;
            var fam = textBox3.Text;
            var name = textBox4.Text;
            var surname = textBox5.Text;
            var phone = textBox6.Text;

            SqlCommand cmd;
            string querystring = $"update Users Set Login = '{login}', Password = '{pass}', Rights = '{rights}', Famnam = '{fam}', Name = '{name}', Surname = '{surname}', Phone = '{phone}' WHERE UserID = '{id}'";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно изменена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Информация не добавлена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UserEditCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Гость");
            comboBox1.Items.Add("Бухгалтер");
            comboBox1.Items.Add("Сотрудник");
            comboBox1.Items.Add("Начальник");
        }
    }
}
