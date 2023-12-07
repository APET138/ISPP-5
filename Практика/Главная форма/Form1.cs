using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Бюро_технической_инвентаризации
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers". При необходимости она может быть перемещена или удалена.
            this.technicalWorkersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.Executors". При необходимости она может быть перемещена или удалена.
            this.executorsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Executors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments". При необходимости она может быть перемещена или удалена.
            this.headsOfDepartmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers". При необходимости она может быть перемещена или удалена.
            this.technicalWorkersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.Executors". При необходимости она может быть перемещена или удалена.
            this.executorsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Executors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments". При необходимости она может быть перемещена или удалена.
            this.headsOfDepartmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.CompletedApplications". При необходимости она может быть перемещена или удалена.
            this.completedApplicationsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.CompletedApplications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.CompletedApplications". При необходимости она может быть перемещена или удалена.
            this.completedApplicationsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.CompletedApplications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Иванченко_ИВDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Customers);
            ToolTip t = new ToolTip();
            t.SetToolTip(CloseButton, "Закрытие формы");
            t.SetToolTip(InfoButton, "Доп.информация");
            t.SetToolTip(AdminButton, "Редактирование пользователей ИС");
            t.SetToolTip(AddButtonCust, "Добавить клиента");
            t.SetToolTip(EditButtonCust, "Редактировать клиента");
            t.SetToolTip(RemoveButtonCust, "Удалить клиента");
            t.SetToolTip(RefreshButtonCust, "Обновить таблицу");
            t.SetToolTip(AddButtonApp, "Добавить заявку");
            t.SetToolTip(EditButtonApp, "Редактировать заявку");
            t.SetToolTip(RemoveButtonApp, "Удалить заявку");
            t.SetToolTip(RefreshButtonApp, "Обновить таблицу");
            t.SetToolTip(AddButtonCompApp, "Добавить выполненную заявку");
            t.SetToolTip(EditButtonCompApp, "Редактировать выполненную заявку");
            t.SetToolTip(RemoveButtonCompApp, "Удалить выполненную заявку");
            t.SetToolTip(RefreshButtonCompApp, "Обновить таблицу");
            t.SetToolTip(AddButtonDep, "Добавить отдел");
            t.SetToolTip(EditButtonDep, "Редактировать отдел");
            t.SetToolTip(RemoveButtonDep, "Удалить отдел");
            t.SetToolTip(RefreshButtonDep, "Обновить таблицу");
            t.SetToolTip(AddButtonTech, "Добавить техника");
            t.SetToolTip(EditButtonTech, "Редактировать техника");
            t.SetToolTip(RemoveButtonTech, "Удалить техника");
            t.SetToolTip(RefreshButtonTech, "Обновить таблицу");
            t.SetToolTip(AddButtonExecut, "Добавить исполнителя");
            t.SetToolTip(EditButtonExecut, "Редактировать исполнителя");
            t.SetToolTip(RemoveButtonExecut, "Удалить исполнителя");
            t.SetToolTip(RefreshButtonExecut, "Обновить таблицу");
            t.SetToolTip(AddButtonChief, "Добавить начальника");
            t.SetToolTip(EditButtonChief, "Редактировать начальника");
            t.SetToolTip(RemoveButtonChief, "Удалить начальника");
            t.SetToolTip(RefreshButtonChief, "Обновить таблицу");
            t.SetToolTip(RefreshButtonGuest, "Обновить таблицу");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm AuthFrm = new AuthorizationForm();
            AuthFrm.ShowDialog();
        }

        // Таблица "Отделы"
        private void RefrButton_Click(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Departments);
            this.executorsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Executors);
            this.headsOfDepartmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments);
            this.technicalWorkersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers);
        }
        // Кнопки таблицы "Клиенты"
        private void AddButtonCust_Click(object sender, EventArgs e)
        {
            AddCust RedCustForm = new AddCust();
            RedCustForm.ShowDialog();
        }

        private void EditButtonCust_Click(object sender, EventArgs e)
        {
            EditCust fr = new EditCust();
            int row = dataGridView1.CurrentRow.Index;
            fr.textBox9.Text = dataGridView1[0, row].Value.ToString();
            fr.textBox1.Text = dataGridView1[1, row].Value.ToString();
            fr.textBox2.Text = dataGridView1[2, row].Value.ToString();
            fr.textBox3.Text = dataGridView1[3, row].Value.ToString();
            fr.textBox4.Text = dataGridView1[4, row].Value.ToString();
            if (dataGridView1[5, row].Value.Equals(true))
                fr.checkBox1.Checked = true;
            else
                fr.checkBox1.Checked = false;
            fr.textBox5.Text = dataGridView1[6, row].Value.ToString();
            fr.textBox6.Text = dataGridView1[7, row].Value.ToString();
            fr.ShowDialog();
        }

        private void RemoveButtonCust_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM Customers WHERE Customer_Code=@id", cn);
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
        // Кнопки таблицы "Заявки"
        private void AddButtonApp_Click(object sender, EventArgs e)
        {
            AddApp AddAppForm = new AddApp();
            AddAppForm.ShowDialog();
        }

        private void EditButtonApp_Click(object sender, EventArgs e)
        {
            EditApp app = new EditApp();
            int row = dataGridView2.CurrentRow.Index;
            app.textBox3.Text = dataGridView2[0, row].Value.ToString();
            app.comboBox1.Text = dataGridView2[1, row].Value.ToString();
            app.textBox1.Text = dataGridView2[2, row].Value.ToString();
            app.comboBox2.Text = dataGridView2[3, row].Value.ToString();
            app.textBox6.Text = dataGridView2[7, row].Value.ToString();
            app.textBox8.Text = dataGridView2[5, row].Value.ToString();
            app.textBox9.Text = dataGridView2[6, row].Value.ToString();
            if (dataGridView2[4, row].Value.Equals(true))
                app.checkBox1.Checked = true;
            else
                app.checkBox1.Checked = false;
            app.ShowDialog();
        }

        private void RemoveButtonApp_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM Applications WHERE Application_Code=@id", cn);
                int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
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

        // Кнопки таблицы "Выполненные заказы"
        private void AddButtonCompApp_Click(object sender, EventArgs e)
        {
            AddCompleteApp AddFrm = new AddCompleteApp();
            AddFrm.ShowDialog();
        }

        private void EditButtonCompApp_Click(object sender, EventArgs e)
        {
            EditCompleteApp EditFrm = new EditCompleteApp();
            int row = dataGridView3.CurrentRow.Index;
            EditFrm.comboBox1.Text = dataGridView3[1, row].Value.ToString();
            EditFrm.comboBox2.Text = dataGridView3[2, row].Value.ToString();
            EditFrm.textBox8.Text = dataGridView3[0, row].Value.ToString();
            EditFrm.textBox1.Text = dataGridView3[7, row].Value.ToString();
            EditFrm.textBox2.Text = dataGridView3[8, row].Value.ToString();
            EditFrm.textBox3.Text = dataGridView3[11, row].Value.ToString();
            if (dataGridView3[6, row].Value.Equals(true))
                EditFrm.checkBox1.Checked = true;
            else
                EditFrm.checkBox1.Checked = false;
            if (dataGridView3[10, row].Value.Equals(true))
                EditFrm.checkBox2.Checked = true;
            else
                EditFrm.checkBox2.Checked = false;
            EditFrm.textBox7.Text = dataGridView3[9, row].Value.ToString();
            EditFrm.textBox4.Text = dataGridView3[3, row].Value.ToString();
            EditFrm.textBox5.Text = dataGridView3[4, row].Value.ToString();
            EditFrm.textBox6.Text = dataGridView3[5, row].Value.ToString();
            EditFrm.ShowDialog();
        }

        private void RemoveButtonCompApp_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM CompletedApplications WHERE Application_Code=@id", cn);
                int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
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

        private void InfoButton_Click(object sender, EventArgs e) // Кнопка для доп.информирования пользователя
        {
            if (UserRight.Text.Contains("Гость"))
            {
                MessageBox.Show("У вас есть возможность просмотра выполненных заявок с помощью поиска. Если данные по заявке(ам) отсутствуют обратитесь к сотрудникам БТИ или по почте 'btiang@yandex.ru'", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Кнопка администратора для редактирования пользователей
        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm AdFrm = new AdminForm();
            AdFrm.ShowDialog();
        }
        // Метод для поиска в таблице Клиенты
        private DataTable CustDataGridView()
        {
            string query = "SELECT * FROM Customers";
            query += " WHERE Fam LIKE '%' + @Fam + '%'";
            query += " OR @Fam = ''";
            string con = @"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            using (SqlConnection cn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Fam", searchTextBoxCust.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Метод для поиска в таблице Заявки
        private DataTable AppDataGridView()
        {
            string query = "SELECT * FROM Applications";
            query += " WHERE Customer_Code LIKE '%' + @id + '%'";
            query += " OR @id = ''";
            string con = @"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            using (SqlConnection cn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", searchTextBoxApp.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Метод для поиска в таблице Выполненные заявки
        private DataTable CompAppDataGridView()
        {
            string query = "SELECT * FROM CompletedApplications";
            query += " WHERE Application_Code LIKE '%' + @id + '%'";
            query += " OR @id = ''";
            string con = @"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            using (SqlConnection cn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", searchTextBoxCompApp.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Метод для поиска в таблице Выполненные заявки(Клиенты)
        private DataTable GuestDataGridView()
        {
            string query = "SELECT * FROM CompletedApplications";
            query += " WHERE Application_Code LIKE '%' + @id + '%'";
            query += " OR @id = ''";
            string con = @"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            using (SqlConnection cn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", searchTextBoxGuest.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // TextBox для поиска в таблице Клиенты
        private void searchTextBoxCust_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = this.CustDataGridView();
        }
        // Кнопка обновления таблицы Клиенты
        private void RefreshButtonCust_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        // Кнопка обновления таблицы Заявки
        private void RefreshButtonApp_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Applications", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;
        }

        // Кнопка обновления таблицы Выполненные заявки
        private void RefreshButtonCompApp_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CompletedApplications", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView3.DataSource = bs;
        }

        // Кнопка обновления таблицы Отделы
        private void RefreshButtonDep_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Departments", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView4.DataSource = bs;
        }

        // Кнопка обновления таблицы Выполненные заявки(Клиентская)
        private void RefreshButtonGuest_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CompletedApplications", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView8.DataSource = bs;
        }

        // TextBox для поиска в таблице Заявки
        private void searchTextBoxApp_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView2.DataSource = this.AppDataGridView();
        }

        // TextBox для поиска в таблице Выполненные заявки
        private void searchTextBoxCompApp_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView3.DataSource = this.CompAppDataGridView();
        }

        // TextBox для поиска в таблице Выполненные заявки(Клиент)
        private void searchTextBoxGuest_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView8.DataSource = this.GuestDataGridView();
        }

        // Кнопки для таблицы Отделы
        private void AddButtonDep_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepForm = new AddDepartmentForm();
            addDepForm.ShowDialog();
        }

        private void EditButtonDep_Click(object sender, EventArgs e)
        {
            EditDepartmentForm EditFrm = new EditDepartmentForm();
            int row = dataGridView4.CurrentRow.Index;
            EditFrm.textBox1.Text = dataGridView4[0, row].Value.ToString();
            EditFrm.comboBox1.Text = dataGridView4[1, row].Value.ToString();
            EditFrm.comboBox2.Text = dataGridView4[2, row].Value.ToString();
            EditFrm.comboBox3.Text = dataGridView4[3, row].Value.ToString();
            EditFrm.ShowDialog();
        }

        private void RemoveButtonDep_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM Departments WHERE Department_Code=@id", cn);
                int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
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
        
        // Кнопки для таблицы Техники
        private void AddButtonTech_Click(object sender, EventArgs e)
        {
            AddTechForm addTechFrm = new AddTechForm();
            addTechFrm.ShowDialog();
        }

        private void EditButtonTech_Click(object sender, EventArgs e)
        {
            EditTechForm EditFrm = new EditTechForm();
            int row = dataGridView7.CurrentRow.Index;
            EditFrm.textBox1.Text = dataGridView7[1, row].Value.ToString();
            EditFrm.textBox2.Text = dataGridView7[2, row].Value.ToString();
            EditFrm.textBox3.Text = dataGridView7[3, row].Value.ToString();
            EditFrm.textBox4.Text = dataGridView7[0, row].Value.ToString();
            EditFrm.ShowDialog();
        }

        private void RemoveButtonTech_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM TechnicalWorkers WHERE Worker_Code=@id", cn);
                int id = int.Parse(dataGridView7.CurrentRow.Cells[0].Value.ToString());
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

        private void RefreshButtonTech_Click(object sender, EventArgs e)
        {
            this.technicalWorkersTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.TechnicalWorkers);
        }

        // Кнопки таблицы Исполнители
        private void AddButtonExecut_Click(object sender, EventArgs e)
        {
            AddExecutorForm AddExecFrm = new AddExecutorForm();
            AddExecFrm.ShowDialog();
        }

        private void EditButtonExecut_Click(object sender, EventArgs e)
        {
            EditExecutorForm EditFrm = new EditExecutorForm();
            int row = dataGridView6.CurrentRow.Index;
            EditFrm.textBox1.Text = dataGridView6[1, row].Value.ToString();
            EditFrm.textBox2.Text = dataGridView6[2, row].Value.ToString();
            EditFrm.textBox3.Text = dataGridView6[3, row].Value.ToString();
            EditFrm.textBox4.Text = dataGridView6[0, row].Value.ToString();
            EditFrm.ShowDialog();
        }

        private void RemoveButtonExecut_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM Executors WHERE Executor_Code=@id", cn);
                int id = int.Parse(dataGridView6.CurrentRow.Cells[0].Value.ToString());
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

        private void RefreshButtonExecut_Click(object sender, EventArgs e)
        {
            this.executorsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.Executors);
        }

        // Кнопки таблицы Начальники
        private void AddButtonChief_Click(object sender, EventArgs e)
        {
            AddChiefForm AddChiefFrm = new AddChiefForm();
            AddChiefFrm.ShowDialog();
        }

        private void EditButtonChief_Click(object sender, EventArgs e)
        {
            EditChiefForm EditChiefFrm = new EditChiefForm();
            int row = dataGridView5.CurrentRow.Index;
            EditChiefFrm.textBox1.Text = dataGridView5[1, row].Value.ToString();
            EditChiefFrm.textBox2.Text = dataGridView5[2, row].Value.ToString();
            EditChiefFrm.textBox3.Text = dataGridView5[3, row].Value.ToString();
            EditChiefFrm.textBox4.Text = dataGridView5[0, row].Value.ToString();
            EditChiefFrm.ShowDialog();
        }

        private void RemoveButtonChief_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True"))
            {
                SqlCommand com = new SqlCommand("DELETE FROM HeadsOfDepartments WHERE Chief_Code=@id", cn);
                int id = int.Parse(dataGridView5.CurrentRow.Cells[0].Value.ToString());
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

        private void RefreshButtonChief_Click(object sender, EventArgs e)
        {
            this.headsOfDepartmentsTableAdapter.Fill(this.уП01_ИСПП5_Иванченко_ИВDataSet.HeadsOfDepartments);
        }
    }
}
