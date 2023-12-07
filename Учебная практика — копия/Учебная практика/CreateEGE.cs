using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Учебная_практика
{
    public partial class CreateEGE : Form
    {
        public CreateEGE()
        {
            InitializeComponent();
        }
        string[] t = new string[3];
        private void CreateEGE_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Enrolle, LastName, Name, FirthName from Enrollee group by Enrolle, LastName, Name, FirthName", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Enrolle"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + " " + dt.Rows[i]["Name"].ToString() + " " + dt.Rows[i]["FirthName"].ToString());
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Tables form = new Tables();
            form.Show();
            form.table(1);
        }
        public void Update(string[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                t[i] = a[i];
            }
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"select Enrollee.Enrolle, LastName,Name,FirthName from Enrollee join EGE on Enrollee.Enrolle = EGE.Enrolle where Enrollee.Enrolle ='{t[0]}'", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            button1.Text = "Изменить";
            comboBox1.Text = dt.Rows[0]["Enrolle"].ToString() + " " + dt.Rows[0]["LastName"].ToString() + " " + dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["FirthName"].ToString();
            textBox1.Text = t[1];
            textBox2.Text = t[2];
        }
        public void create()
        {
            button1.Text = "Добавить";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                t[0] = comboBox1.Text.Split(' ')[0];
                t[1] = textBox1.Text;
                t[2] = textBox2.Text;
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataSet dt = new DataSet();
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter($"Insert Into EGE (Enrolle,Lessons,Score) Values ('{t[0]}','{t[1]}','{t[2]}')", sqlConnect);
                    da.Fill(dt);
                }
                catch
                {
                }
                MessageBox.Show("Записть успешно создана","Успешно!");
                Close();
                Tables form = new Tables();
                form.Show();
            }
            if (button1.Text == "Изменить")
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter($"Update EGE set EGE.Enrolle = '{comboBox1.Text.Split(' ')[0]}', Lessons = '{textBox1.Text}', Score = '{textBox2.Text}' from Enrollee join EGE on Enrollee.Enrolle = EGE.Enrolle where EGE.Enrolle ='{t[0]}' and Lessons ='{t[1]}' and Score = {t[2]}", sqlConnect);
                DataSet ds = new DataSet();
                da.Fill(dt);
                MessageBox.Show("Изменение записи произошло успешно", "Успешно!");
                Hide();
                Tables form = new Tables();
                form.Show();
            }

        }
    }
}
