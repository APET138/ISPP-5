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

namespace Учебная_практика
{
    public partial class CreatEnrollment : Form
    {
        public CreatEnrollment()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"Insert Into Enrollment (PersonID,Type) values ('{comboBox1.Text}' , '{comboBox2.Text}')",sqlConnect);

        }

        private void CreatEnrollment_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select PersonID, LastName, Name, FirthName from ((Enrollee join EGE on Enrollee.Enrolle = EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Commission.PersonID = Enrollment.PersonID", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["PersonID"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + " " + dt.Rows[i]["Name"].ToString() + " " + dt.Rows[i]["FirthName"].ToString());
            }
        }
    }
}
