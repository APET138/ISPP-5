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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВAdminDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВAdminDataSet.Users);
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButtonAdmin, "Добавить пользователя");
            t.SetToolTip(EditButtonAdmin, "Редактировать пользователя");
            t.SetToolTip(RemoveButtonAdmin, "Удалить пользователя");
            t.SetToolTip(RefreshButtonAdmin, "Обновить пользователя");
        }
        // Кнопки формы администратора
        private void AdminCancelButton_Click(object sender, EventArgs e) // Кнопка возврата к главной форме
        {
            this.Close();
        }

        private void RefreshButtonAdmin_Click(object sender, EventArgs e) // Кнопка обновления данных пользователей
        {
            this.usersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВAdminDataSet.Users);
        }

        private void AddButtonAdmin_Click(object sender, EventArgs e) // Кнопка добавления пользователя
        {
            AddUser AddUsrFrm = new AddUser();
            AddUsrFrm.ShowDialog();
        }

        private void EditButtonAdmin_Click(object sender, EventArgs e) // Кнопка редактирования пользователя
        {
            EditUser EditUsrFrm = new EditUser();
            int row = UsersDataGrid.CurrentRow.Index;
            EditUsrFrm.comboBox1.Text = UsersDataGrid[3, row].Value.ToString();
            EditUsrFrm.textBox7.Text = UsersDataGrid[0, row].Value.ToString();
            EditUsrFrm.textBox1.Text = UsersDataGrid[1, row].Value.ToString();
            EditUsrFrm.textBox2.Text = UsersDataGrid[2, row].Value.ToString();
            EditUsrFrm.textBox3.Text = UsersDataGrid[4, row].Value.ToString();
            EditUsrFrm.textBox4.Text = UsersDataGrid[5, row].Value.ToString();
            EditUsrFrm.textBox5.Text = UsersDataGrid[6, row].Value.ToString();
            EditUsrFrm.textBox6.Text = UsersDataGrid[7, row].Value.ToString();
            EditUsrFrm.ShowDialog();
        }

        private void RemoveButtonAdmin_Click(object sender, EventArgs e) // Кнопка удаления пользователя
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM Users WHERE UserID=@id", cn);
                int id = int.Parse(UsersDataGrid.CurrentRow.Cells[0].Value.ToString());
                com.Parameters.AddWithValue("@id", id);
                cn.Open();
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Удалить не удалось!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
