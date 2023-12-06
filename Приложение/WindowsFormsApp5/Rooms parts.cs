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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        private void Record_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Record as [Номер составной части помещения], SquarePart as [Площадь составной части], Size as [Размеры сост. части в плане], NamePart as [Назначение],Decoration as [Отделка], HeightPart as [Высота составной части], Socket as  [Число розеток в помещении], Sections as [Число элементов в батарее отопления]   from Rooms_Parts", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
        }
        private void Переход2_Click(object sender, EventArgs e)
        {
            textBox8.Visible = false;
            textBox7.Visible = false;
            textBox6.Visible = false;
            textBox5.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label1.Text = "Номер составной части помещения";
            label2.Text = "Площадь составной части";
            label3.Text = "Размеры сост. части в плане";
            label4.Text = "Назначение";
            label1.Location = new Point(2, 165);
            label4.Location = new Point(641, 165);
        }
        private void Переход_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            label1.Text = "Отделка";
            label2.Text = "Высота составной части";
            label3.Text = "Число розеток в помещении";
            label4.Text = "Число элементов в батарее отопления";
            label1.Location = new Point(41, 165);
            label4.Location = new Point(590, 165);
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Rooms_Parts (Record,SquarePart,Size,NamePart,Decoration,HeightPart,Socket,Sections) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}');", sqlConnect);
            da.Fill(dt);
            MessageBox.Show("Данные внесены");
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms_Parts", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void удалить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"delete from Rooms_Parts where  Record = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms_Parts", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"update Rooms_Parts  set  Record =  '{textBox1.Text}',SquarePart = '{textBox2.Text}',Size='{textBox3.Text}',NamePart='{textBox4.Text}',Decoration='{textBox5.Text}',HeightPart='{textBox6.Text}',Socket='{textBox7.Text}',Sections= '{textBox8.Text}' where Record = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Rooms_Parts", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AdmFr = new admin();
            AdmFr.Show();
        }
    }
}
