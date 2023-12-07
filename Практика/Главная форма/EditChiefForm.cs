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
    public partial class EditChiefForm : Form
    {
        public EditChiefForm()
        {
            InitializeComponent();
        }

        private void ConfirmButtonEditChief_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");

            var fanam = textBox1.Text;
            var name = textBox2.Text;
            var surname = textBox3.Text;
            var id = textBox4.Text;

            string updatestring = $"UPDATE HeadsOfDepartments SET FamName = '{fanam}', Name = '{name}', Surname = '{surname}' WHERE Chief_Code = '{id}'";
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

        private void CancelButtonEditChief_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
