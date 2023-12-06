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

namespace WindowsFormsApp5
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        //переход по формам по правам доступа
        string a;

        public void ii(string b)
        {
            a = b;
            i1();
        }
        public void i1()
        {
            if (a == "Сотрудник")
            {
                Text = "Панель Сотрудника";
                Пользователи.Visible = false;
                Здания.Location = new Point (12,23);
                Помещения.Location = new Point(12, 73);
                СоставнаяЧасть.Location = new Point(12, 121);
                Отделка.Location = new Point(12, 157);
                Выход.Location = new Point(12, 196);

            }
            if (a == "Админ")
            {
                Text = "Панель Администратора";
                Пользователи.Visible = true;

            }
            if (a == "Директор")
            {
                Text = "Панель Директора";
            }
        }   
        private void Пользователи_Click(object sender, EventArgs e)
        {
            //переход на форму
            this.Hide();
            Users AdmFrm = new Users();
            AdmFrm.Show();
        }

        private void Здания_Click(object sender, EventArgs e)
        {
            this.Hide();
            buildings AdmFr = new buildings();
            AdmFr.Show();
        }

        private void Помещения_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms AdmFr = new Rooms();
            AdmFr.Show();
        }

        private void СоставнаяЧасть_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record AdmFr = new Record();
            AdmFr.Show();
        }

        private void Отделка_Click(object sender, EventArgs e)
        {

            this.Hide();
            decoration AdmFr = new decoration();
            AdmFr.Show();
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            entrance AdmFr = new entrance();
            AdmFr.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
