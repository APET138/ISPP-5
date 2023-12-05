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


namespace Практика_sql
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        int index;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog =уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True"))
            { 
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean Логин = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Логин"].ToString() == textBox1.Text)
                    {
                        Логин = false;
                    }
                } 
                if (textBox1.Text== "" || textBox2.Text== "")
                {
                    MessageBox.Show("Введите все данные!");
                }
                else
                {
                    if (Логин == false)
                    {
                        MessageBox.Show("Пользователь уже существует!");
                    }
                    else
                    {
                        index = index + 1;
                        SqlDataAdapter infol1 = new SqlDataAdapter($"INSERT INTO Пользователи(Логин, Пароль,Права_Доступа)VALUES('{textBox1.Text}','{textBox2.Text}','Квартиросъемщик')", sqlConnect);
                        DataTable dt1 = new DataTable();
                        infol1.Fill(dt1);
                        MessageBox.Show("Пользователь создан!");
                        User check = new User();
                        check.Show();
                        Hide();
                    }
                }
            }
        }

            private void buttonBack_Click(object sender, EventArgs e)
            {
            User check = new User();
            check.Show();
            Hide();
            }
    }
}
