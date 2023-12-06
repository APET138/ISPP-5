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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet.Buildings". При необходимости она может быть перемещена или удалена.
            //this.buildingsTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Buildings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Rooms);
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select HallNum as [Номер помещения], Record as [Номер составной части помещения], Storey as [Номер этажа], Room as [Количество составных частей],SquareHall as [Общая площадь помещения], Branch as [Вспомогательная площадь помещения], Balcony as  [Балкон], Height as [Высота помещения], Level as [Помещение в двух уровнях]   from Rooms", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }

        private void Переход_Click(object sender, EventArgs e)
        {
            label1.Text = "Общая площадь помещения";
            label2.Text = "Вспомогательная площадь помещения";
            label3.Text = "Балкон";
            label4.Text = "Высота помещения";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            checkBox1.Visible = true;
        }

        private void Переход2_Click(object sender, EventArgs e)
        {
            label1.Text = "Номер помещения";
            label2.Text = "Номер состовной части";
            label3.Text = "Номер этажа";
            label4.Text = "Количество составных частей";
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            checkBox1.Visible = false;
        }

        private void добавить_Click(object sender, EventArgs e)
        {
            int bit = 0;
            if (checkBox1.Checked == true)
            {
                bit = 1;
            }
            else bit = 0;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Rooms (HallNum,Record,Storey,Room,SquareHall,Branch,Balcony,Height,Level) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}','{bit}');", sqlConnect);
            da.Fill(dt);
            //dataGridView2.DataSource = dt.Tables[0];
            roomsTableAdapter.Update(б_АЮ_Учебная_ПрактикаDataSet.Rooms);
            MessageBox.Show("Данные внесены");
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void удалить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"delete from Rooms where  HallNum = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void изменить_Click(object sender, EventArgs e)
        {
            int bit = 0;
            if (checkBox1.Checked == true)
            {
                bit = 1;
            }
            else bit = 0;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            //,,,Room,,,,,),'{textBox6.Text},'')
            SqlDataAdapter da = new SqlDataAdapter($"update Rooms  set  Room =  '{textBox4.Text}',HallNum = '{textBox1.Text}',Record='{textBox2.Text}',Storey='{textBox3.Text}',SquareHall='{textBox5.Text}',Branch='{textBox6.Text}',Balcony='{textBox7.Text}',Height= '{textBox8.Text}',Level='{bit}' where HallNum = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void выход_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AdmFr = new admin();
            AdmFr.Show();
        }
    }
}
