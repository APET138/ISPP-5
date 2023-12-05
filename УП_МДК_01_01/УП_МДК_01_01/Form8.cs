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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Дома". При необходимости она может быть перемещена или удалена.
            this.домаTableAdapter2.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Дома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов". При необходимости она может быть перемещена или удалена.
            this.фотографии_домовTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов);
        }
        int c;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 0:
                    фотографии_домовTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов);
                    фотографии_домовTableAdapter1.Fill(уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов); break;
                case 1:
                    домаTableAdapter2.Update(уП01_ИСПП5_Работягова_ААDataSet3.Дома);
                    домаTableAdapter2.Fill(уП01_ИСПП5_Работягова_ААDataSet3.Дома); break;
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
        private void pictureView_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureSet_Click(object sender, EventArgs e)
        {
            pictureSet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
             
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Работягова_АА; Integrated Security = True");
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                pictureSet.ImageLocation = load.FileName;

                SqlDataAdapter a = new SqlDataAdapter($"Insert into [Фотографии домов] Values( '{load.FileName}')", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
                this.фотографии_домовTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов);
            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

        }
        string pic;
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                pictureSet.ImageLocation = load.FileName;
                SqlDataAdapter a = new SqlDataAdapter($"Update [Фотографии домов] set [Фотография здания] = '{load.FileName}' where [Код фотографии] = '{dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value}'", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
                this.фотографии_домовTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet3.Фотографии_домов);
            }
        }
    }
}
