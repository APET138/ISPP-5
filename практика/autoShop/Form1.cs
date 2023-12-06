using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Кузов". При необходимости она может быть перемещена или удалена.
            this.кузовTableAdapter.Fill(this.autoShopDataSet.Кузов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Двигатели". При необходимости она может быть перемещена или удалена.
            this.двигателиTableAdapter.Fill(this.autoShopDataSet.Двигатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.autoShopDataSet.Автомобиль);

        }

        private void автомобильBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            object current = автомобильBindingSource.Current;
            if (current != null)
            {
                DataRowView dataRowView = (DataRowView)current;
                int selectedID = Convert.ToInt32(dataRowView["BodyID"]);
                UpdateTextBoxData(selectedID);
            }
        }

        private void UpdateTextBoxData(int selectedID)
        {
            string query = "SELECT * FROM Кузов WHERE BodyID = @selectedID";

            using (SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                connect.Open();

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@selectedID", selectedID);
                    using(SqlDataReader reader =  command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox2.Text = reader["BodyModel"].ToString();
                        }
                    }
                } 
            }
        }
    }
}
