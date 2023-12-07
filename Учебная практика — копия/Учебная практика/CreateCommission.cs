using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Учебная_практика
{
    public partial class CreateCommission : Form
    {
        public CreateCommission()
        {
            InitializeComponent();
        }

        private void CreateCommission_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select EGE, LastName, Name, FirthName from Enrollee join EGE on Enrollee.Enrolle = EGE.Enrolle group by EGE, LastName, Name, FirthName", sqlConnect);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["EGE"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + " " + dt.Rows[i]["Name"].ToString() + " " + dt.Rows[i]["FirthName"].ToString());
            }
        }
        public void create()
        {
            button3.Text = "Добавить";
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success) || (e.KeyChar == (char)Keys.Back))
            {
            }
            else e.KeyChar -= e.KeyChar;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Tables form = new Tables();
            form.table(3);
            form.Show();
        }
        string[] t = new string[7];
        public void Update(string[] a)
        {
            for (int i = 0; i < t.Length; i++)
            {
                try 
                { 
                    t[i] = a[i];
                }
                catch
                {

                }
                comboBox1.Text.Split(' ')[0] = t[0];
                textBox2.Text = t[1];
                textBox1.Text = t[2];
                textBox3.Text = t[3];
                textBox4.Text = t[4];
                if (t[5] == "0")
                {
                    checkBox1.Checked = false;
                }
                else checkBox1.Checked = true;
                button3.Text = "Изменить";

            }
        }
        string b;
        public void ID(string a)
        {
            b = a;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Добавить")
            {
                t[0] = comboBox1.Text.Split(' ')[0];
                t[1] = textBox2.Text;
                t[2] = textBox1.Text;
                t[3] = textBox3.Text;
                t[4] = textBox4.Text;
                if (checkBox1.Checked == false)
                {
                    t[5] = "0";
                }
                else t[5] = "1";
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter($"insert into Commission (EGE, Faculty, Speciality, Registrar, Talk, Result)  VALUES ('{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[5]}','{t[4]}');", sqlConnect);
                da.Fill(dt);
                Tables form = new Tables();
                Close();
                MessageBox.Show("Запись добавлена в таблицу", "Успешно!");
                form.Show();
            }
            if (button3.Text == "Изменить")
            {
                string a;
                if (t[5] == "1")
                {
                    a = "1";
                    checkBox1.Checked = true;
                }
                else
                {
                    a = "0";
                    checkBox1.Checked = false;
                }
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter($"Update Commission set EGE = '{comboBox1.Text.Split(' ')[0]}', Faculty = '{textBox2.Text}', Speciality ='{textBox1.Text}', Registrar = '{textBox3.Text}', Talk = '{a}',Result = '{textBox4.Text}'  where PersonID = '{b}';", sqlConnect);
                da.Fill(dt);
                Tables form = new Tables();
                Close();
                MessageBox.Show("Запись изменена", "Успешно!");
                form.Show();
            }
        }
    }
}
