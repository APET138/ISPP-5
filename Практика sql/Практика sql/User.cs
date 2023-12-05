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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        int k = 0;
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog =уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи",sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;
           
            
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Логин"].ToString() == textBoxLogin.Text) &&
               (dt.Rows[i]["Пароль"].ToString() == textBoxPassword.Text)) {flag = true;k = i; }
                    
            if (flag == true)
            {switch (dt.Rows[k]["Права_Доступа"].ToString())
                {
                    case "Админ":
                        this.Hide();
                        Admin UsrFrm = new Admin();
                        UsrFrm.Show(); break;
                   

                    case "Квартиросъемщик":
                        this.Hide();
                        Tenat form3 = new Tenat();
                        form3.Show(); break;

                    case "Инспектор":
                        this.Hide();
                        Inspector form4 = new Inspector();
                        form4.Show(); break;



                }   
            }
            else MessageBox.Show("Неверный пароль или логин!");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Registration check = new Registration();
            check.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }
    }
}
