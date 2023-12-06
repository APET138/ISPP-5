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
                    if (dt.Rows[i]["Логин"].ToString() == textBoxЛогин.Text)
                    {
                        Логин = false;
                    }
                } 
                if (textBoxЛогин.Text== "" || textBoxПароль.Text== "")
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
                        
                        
                        SqlDataAdapter infol2 = new SqlDataAdapter($"INSERT INTO Apartments(Flat, FlatType,People,Building_number,Lastname,ForstName,Patronymic,Passport,[EStove])VALUES('{textBoxКвартира.Text}','{textBoxТипКвартиры.Text}','{textBoxЛюди.Text}','{textBoxДом.Text}','{textBoxИмя.Text}','{textBoxФамилия.Text}','{textBoxОтчество.Text}','{textBoxПаспорт.Text}','{checkBox1.Checked}')", sqlConnect);
                        DataTable dt2 = new DataTable();
                        int i = dataGridView1.RowCount;
                        dataGridView1.Rows[index].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, i - 2];
                        
                        infol2.Fill(dt2);SqlDataAdapter infol1 = new SqlDataAdapter($"INSERT INTO Пользователи(Логин, Пароль,Права_Доступа,reg)VALUES('{textBoxЛогин.Text}','{textBoxПароль.Text}','Квартиросъемщик','{label4.Text}')", sqlConnect);
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

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments". При необходимости она может быть перемещена или удалена.
            this.apartmentsTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
