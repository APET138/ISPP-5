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
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void ConfirmButtonDep_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var chief = comboBox1.Text;
            var executor = comboBox2.Text;
            var worker = comboBox3.Text;

            SqlCommand cmd;
            string querystring = $"insert into Departments(Chief_Code, Executor_Code, Worker_Code) values('{chief}', '{executor}', '{worker}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CancelButtonDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM HeadsOfDepartments");
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Executors");
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM TechnicalWorkers");
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            SqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Chief_Code"]);
            }
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["Executor_Code"]);
            }
            while (dr3.Read())
            {
                comboBox3.Items.Add(dr3["Worker_Code"]);
            }
            con.Close();
        }
    }
}
