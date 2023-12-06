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
    public partial class decoration : Form
    {
        public decoration()
        {
            InitializeComponent();
        }

        private void decoration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet2.Decoration". При необходимости она может быть перемещена или удалена.
            this.decorationTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet2.Decoration);
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Decoration as [Номер состовного помещения], painter as [Обои], parquet as [Паркет], wallpaper as [Плинтус],tile as [Плитка] from Decoration", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }
        private void Добавить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Decoration (Decoration,painter,parquet,wallpaper,tile) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}');", sqlConnect);
            da.Fill(dt);
            decorationTableAdapter.Update(б_АЮ_Учебная_ПрактикаDataSet2.Decoration);
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Decoration", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
            MessageBox.Show("Данные добавленны");
        }

        private void удалить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter($"delete from Decoration where  Decoration = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Decoration", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            //,,,Room,,,,,),'{textBox6.Text},'')
            SqlDataAdapter da = new SqlDataAdapter($"update Decoration  set  Decoration =  '{textBox1.Text}',painter = '{textBox2.Text}',parquet='{textBox3.Text}',wallpaper='{textBox4.Text}',tile='{textBox5.Text}' where Decoration = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Decoration", sqlConnect);
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
