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
    public partial class AddChiefForm : Form
    {
        public AddChiefForm()
        {
            InitializeComponent();
        }

        private void ConfirmButtonChief_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var fam = textBox1.Text;
            var name = textBox2.Text;
            var surname = textBox3.Text;

            SqlCommand cmd;
            string querystring = $"insert into HeadsOfDepartments(FamName, Name, Surname) values('{fam}', '{name}', '{surname}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CancelButtonChief_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
