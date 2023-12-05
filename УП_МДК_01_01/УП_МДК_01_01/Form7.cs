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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace УП_МДК_01_01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Квартиры". При необходимости она может быть перемещена или удалена.
            this.квартирыTableAdapter2.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Квартиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet2.Квартиры". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.План_квартир". При необходимости она может быть перемещена или удалена.
            this.план_квартирTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.План_квартир);

            sqlConnect.Open();

        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (c)
            {
                case 0: 
                    план_квартирTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.План_квартир); 
                    план_квартирTableAdapter1.Fill(уП01_ИСПП5_Работягова_ААDataSet3.План_квартир); break;
                case 1:  
                    квартирыTableAdapter2.Update(уП01_ИСПП5_Работягова_ААDataSet3.Квартиры);
                    квартирыTableAdapter2.Fill(уП01_ИСПП5_Работягова_ААDataSet3.Квартиры); break;
            }

        }
        public string dost;
        public void i(string b)
        {
            dost = b;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dost == "Администратор")
            {
                Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if (dost == "Клиент")
            {
                Hide();
                Form10 form10 = new Form10();
                form10.Show();
            }
            else
            {
                Hide();
                Form11 form11 = new Form11();
                form11.Show();
            }


        }
        public void d(string b)
        {
            if (b == "Администратор")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            else
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }


        private void btnSet_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void pictureSet_Click(object sender, EventArgs e)
        {
            pictureSet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureView_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Работягова_АА; Integrated Security = True");
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                pictureSet.ImageLocation = load.FileName;
                SqlDataAdapter a = new SqlDataAdapter($"Update [План квартир] set [План квартиры] = '{load.FileName}' where [Код плана квартиры] = '{dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value}'", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
                this.план_квартирTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.План_квартир);
            }
        }
        string pic;
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        int c;
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pic = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                pictureSet.Image = Image.FromFile(pic);
            }
            catch
            {
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                pictureSet.ImageLocation = load.FileName;

                SqlDataAdapter a = new SqlDataAdapter($"Insert into [План квартир] Values( '{load.FileName}')", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
                this.план_квартирTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.План_квартир);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }

}

