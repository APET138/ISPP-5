using System;
using System.IO;
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
    public partial class test : Form
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True";
        private const string SelectQuery = "SELECT PIC FROM TEST WHERE PICID = @ID";
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            LoadImage(1);
        }

        private void LoadImage(int imageID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    // Параметр для передачи ID изображения
                    command.Parameters.AddWithValue("@ID", imageID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Получение строки данных изображения из базы данных
                                string imageDataString = reader["PIC"].ToString();

                                // Отображение изображения на форме
                                pictureBox1.Image = Image.FromFile(imageDataString);
                            }
                            else
                            {
                                MessageBox.Show("Изображение не найдено.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }
    }
}
