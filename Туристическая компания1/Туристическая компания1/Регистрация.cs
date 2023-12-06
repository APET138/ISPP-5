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

namespace Туристическая_компания1
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }           

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Проверяет на отсутствие букв
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы!");
            }
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Пользователи);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Переходит на форму 'Авторизация'
            if ((textBox2.Text == "") || (textBox1.Text == ""))
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка");
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
                sqlConnect.Open();
                DataTable dt = new DataTable();
                DataTable dta = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter($"select * from Пользователи", sqlConnect);
                daa.Fill(dta);
                string n = dta.Rows[dta.Rows.Count - 1]["Id"].ToString();
                SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Пользователи (Id,Логин,Пароль,[Права доступа]) VALUES ('{int.Parse(n) + 1}','{textBox1.Text}','{textBox2.Text}','Гость');", sqlConnect);
                da.Fill(dt);
                пользователиTableAdapter.Update(уП01_ИСПП5_Шипицына_ОИDataSet.Пользователи);
                MessageBox.Show($"Регистрация пользователя с логином {textBox1.Text} выполнена.\nВы зарегистрированы как гость");
                this.Hide();
                Авторизация UsrFrm = new Авторизация();
                UsrFrm.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Переход на форму авторизации
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }        
    }
}
