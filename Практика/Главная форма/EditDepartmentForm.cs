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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Бюро_технической_инвентаризации
{
    public partial class EditDepartmentForm : Form
    {
        public EditDepartmentForm()
        {
            InitializeComponent();
        }

        private void ConfirmButtonEditDep_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");

            var id = textBox1.Text;
            var chief = comboBox1.Text;
            var execut = comboBox2.Text;
            var tech = comboBox3.Text;

            string updatestring = $"UPDATE Executors SET Chief_Code = '{chief}', Executor_Code = '{execut}', Worker_Code = '{tech}' WHERE Department_Code = '{id}'";
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

        private void CancelButtonEditDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
