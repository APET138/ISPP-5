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
    public partial class AddCompleteApp : Form
    {
        public AddCompleteApp()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var appid = comboBox1.Text;
            var depid = comboBox2.Text;
            var datecost = textBox1.Text;
            var value = textBox2.Text;
            var comment = textBox3.Text;
            var inspector = textBox4.Text;
            var time = textBox5.Text;
            var dateworker = textBox6.Text;
            var datestop = textBox7.Text;
            var cash = checkBox1.Checked;
            var finish = checkBox2.Checked;

            SqlCommand cmd;
            string querystring = $"insert into CompletedApplications(Application_Code, Department_Code, Inspector ,Time, DateWorker, Cash, DateCost, Value, DateStop, Finish, Comment) values('{appid}', '{depid}', '{inspector}', '{time}', '{dateworker}', '{cash}', '{datecost}', '{value}', '{datestop}', '{finish}', '{comment}')";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddCompleteApp_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd.CommandText = "SELECT * FROM Applications";
            cmd2.CommandText = "SELECT * FROM Departments";
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dt = cmd2.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Application_Code"]);
            }
            while (dt.Read())
            {
                comboBox2.Items.Add(dt["Department_Code"]);
            }
            con.Close();
        }
    }
}
