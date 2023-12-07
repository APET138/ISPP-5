using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Учебная_практика
{
    public partial class AbityrientForm : Form
    {
        public AbityrientForm(){InitializeComponent();}
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        private void FindForFIO_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void AbityrientForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter($"select YesID as [№], LastName as [Фамилия],Name as [Имя], FirthName as [Отчество],Faculty as [Факультет], Speciality as [Специальность] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId", sqlConnect);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Location = new Point(12, 36);
            pictureBox1.Location = new Point(504, 0);
            ExitButton.Location = new Point(12, 214);
            Size = new Size(573, 282);
            groupBox1.Visible = false;
            da = new SqlDataAdapter("select Faculty from Commission group by Faculty", sqlConnect);
            da.Fill(dt);
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Faculty"].ToString());
            }
            da = new SqlDataAdapter("select Speciality from Commission group by Speciality", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Faculty"].ToString());
            }
            da = new SqlDataAdapter("select LastName, Name, FirthName from Enrollee group by LastName, Name, FirthName", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox3.Items.Add(dt.Rows[i]["LastName"].ToString() + " " + dt.Rows[i]["Name"].ToString() + " " + dt.Rows[i]["FirthName"].ToString());
            }
        }
        bool click=false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (click == false)
            {
                Size = new Size(573, 324);
                groupBox1.Visible = true;
                dataGridView1.Location = new Point(12, 75);
                ExitButton.Location = new Point(12, 253);
                pictureBox1.Location = new Point(504, 36);
                click = true;
            }
            else
            {
                dataGridView1.Location = new Point(12, 36);
                pictureBox1.Location = new Point(504, 0);
                ExitButton.Location = new Point(12, 214);
                Size = new Size(573, 282);
                groupBox1.Visible = false;
                click = false;
            }


        }
    }
}
