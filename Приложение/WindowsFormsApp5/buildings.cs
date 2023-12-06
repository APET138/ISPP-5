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
using System.IO;

namespace WindowsFormsApp5
{
    public partial class buildings : Form
    {
        public buildings()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet.Buildings". При необходимости она может быть перемещена или удалена.
            //this.buildingsTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Buildings);
           

        }
        string pyt = "";
        int press = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // заполнения поля через checbox
            int bit = 0;
            if (checkBox1.Checked == true)
            {
                bit = 1;
            }
            else bit = 0;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter($"INSERT INTO Buildings(Elevator) VALUES ('{bit}');", sqlConnect);
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //показывание картинки в pictureBox
            try
            {
                pictureBox1.Image = Image.FromFile(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[14].Value.ToString());
            }
            catch
            {

            }
            

            
            }

        private void Переход_Click_1(object sender, EventArgs e)
        {
            //скрывание элементов формы и заплонение их через кнопку
            if (press == 0)
            {
                label2.Text = "Материал стен здания";
                label3.Text = "Материал фундамента";
                label4.Text = "Примечания";
                label5.Text = "Износ в процентах";
                label1.Text = "Количество этажей в здании";
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox3.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                press = 1;
                label1.Location = new Point(6, 112);
                label2.Location = new Point(176, 112);
                label3.Location = new Point(330, 112);
                label4.Location = new Point(491, 112);
                label5.Location = new Point(650, 112);
            }
            else
            {
                if (press == 1)
                {
                    label2.Text = "Количество этажей в здании";
                    label3.Text = "Расстояние от центра города";
                    label4.Text = "Площадь нежилых помещений";
                    label5.Text = "Фото здания";
                    label1.Text = "Год постройки здания";
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox3.Visible = false;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    textBox13.Visible = true;
                    textBox14.Visible = true;
                    textBox15.Visible = true;

                    checkBox1.Visible = true;
                    Вставка.Visible = true;
                    label6.Visible = true;

                    label2.Location = new Point(150, 112);
                    label3.Location = new Point(310, 112);
                    label4.Location = new Point(480, 112);
                    press = 0;
                }
            }
        }

        private void переход2_Click(object sender, EventArgs e)
        {
            if (press == 0)
            {
                label2.Text = "Год постройки здания";
                label3.Text = "Материал стен здания";
                label4.Text = "Материал фундамента";
                label5.Text = "Примечания";
                label1.Text = "Площадь земельного участка"; ;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox3.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                press = 1;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                label1.Location = new Point(6, 112);
                label2.Location = new Point(176, 112);
                label3.Location = new Point(330, 112);
                label4.Location = new Point(491, 112);
                label5.Location = new Point(650, 112);
                Вставка.Visible = false;

                checkBox1.Visible = false;
                label6.Visible = false;

            }
            else
            {
                if (press == 1)
                {
                    label2.Text = "Номер помещения";
                    label3.Text = "Номер этажа";
                    label4.Text = "Адрес здания";
                    label5.Text = "Площадь земельного участка";
                    label1.Text = "Кадастровый номер здания";
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox3.Visible = true;
                    textBox11.Visible = false;
                    textBox12.Visible = false;
                    textBox13.Visible = false;
                    textBox14.Visible = false;
                    textBox15.Visible = false;

                    checkBox1.Visible = false;
                    Вставка.Visible = false;
                    label6.Visible = false;

                    label1.Location = new Point(6, 112);
                    label2.Location = new Point(176, 112);
                    label3.Location = new Point(330, 112);
                    label4.Location = new Point(491, 112);
                    label5.Location = new Point(618, 112);
                    press = 0;
                }
            }
        }
        private void Добавить_Click(object sender, EventArgs e)
        {
            // добавление данных в поля и обновление их
            int bit;
            if (checkBox1.Checked == true)
            {
                bit = 1;
            }
            else bit = 0;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Buildings (Kadastr,HallNum,Storey,Address,District,Land,Years,Material,Base,Comment,Wear,Flow,Line,square,Hall,Elevator, picture) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}','{textBox9.Text}','{textBox10.Text}','{textBox11.Text}','{textBox12.Text}','{textBox13.Text}','{textBox14.Text}','{textBox15.Text}','{bit}','{pyt}');", sqlConnect);
            da.Fill(dt);
            //this.buildingsTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Buildings);
            MessageBox.Show("Данные внесены");
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Buildings", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];

            daa.Fill(dta);
        }
        private void Удалить_Click(object sender, EventArgs e)
        {
            //удаление данных в полях
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"delete from Buildings where Kadastr   = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Buildings", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            //изменения данных в полях
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataSet dta = new DataSet();
            //,,,Room,,,,,),'{textBox6.Text},'')
            SqlDataAdapter da = new SqlDataAdapter($"update Buildings  set  Kadastr =  '{textBox1.Text}',HallNum = '{textBox2.Text}',Storey='{textBox3.Text}',Address='{textBox4.Text}',District='{textBox5.Text}',Land='{textBox6.Text}',Years='{textBox7.Text}',Material= '{textBox8.Text}',Base='{textBox9.Text}',Comment='{textBox10.Text}',Wear='{textBox11.Text}',Flow='{textBox12.Text}',Line='{textBox13.Text}',square='{textBox14.Text}',Hall='{textBox15.Text}' where Kadastr = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()} ;", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Buildings", sqlConnect);
            daa.Fill(dta);
            dataGridView1.DataSource = dta.Tables[0];
        }

        private void Вставка_Click(object sender, EventArgs e)
        {
            // вставка пути картинки в поле
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pyt = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(pyt);
            }
        }

        private void выход_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AdmFr = new admin();
            AdmFr.Show();
        }

        private void buildings_Load(object sender, EventArgs e)
        {
            // перевод название полей на русский
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Kadastr as [Кадастровый номер здания], HallNum as [Номер помещения], Storey as [Номер этажа], Address as [Адрес здания], District as [Район города], Land as [Площадь земельного участка ], Years as [Год постройки здания], Material as  [Материал стен здания], Base as [Материал фундамента], Comment as [Примечания], Wear as [Износ в процентах], Flow as [Количество этажей в здании], Line as [Расстояние от центра города], square as [Площадь нежилых помещений], picture as [Фото здания], Hall as [Количество помещений в здании], Elevator as [Наличие лифта] from Buildings", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

            checkBox1.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            Вставка.Visible = false;
        }
    }
    }

