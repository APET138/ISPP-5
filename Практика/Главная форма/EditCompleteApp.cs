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
    public partial class EditCompleteApp : Form
    {
        public EditCompleteApp()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var appid = comboBox1.Text;
            var depid = comboBox2.Text;
            var compappid = textBox8.Text;
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
            string querystring = $"update CompletedApplications Set Application_Code = '{appid}', Department_Code = '{depid}', Cash = '{cash}', DateCost = '{datecost}', Value = '{value}', DateStop = '{datestop}', Finish = '{finish}', Comment = '{comment}' WHERE CompAppID = '{compappid}'";
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCompleteApp_Load(object sender, EventArgs e)
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
