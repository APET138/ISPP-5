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
    public partial class ОформлениеЗаказа : Form
    {
        RegisteredUser currentUser;
        public ОформлениеЗаказа(RegisteredUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void ОформлениеЗаказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Двигатели". При необходимости она может быть перемещена или удалена.
            this.двигателиTableAdapter.Fill(this.autoShopDataSet.Двигатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Кузов". При необходимости она может быть перемещена или удалена.
            this.кузовTableAdapter.Fill(this.autoShopDataSet.Кузов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet.Skladi". При необходимости она может быть перемещена или удалена.
            this.skladiTableAdapter.Fill(this.autoShopDataSet.Skladi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            groupBox1.Visible = true;
            pictureBox1.Visible = true;
            label16.Visible = true;
            comboBox1.Visible = true;
            bindingNavigator1.Visible = true;
            this.Size = new Size(879, 435);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            МенюПокупателя brForm = new МенюПокупателя(currentUser);
            brForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            pictureBox1.Visible = false;
            button6.Visible = true;
            dataGridView1.Visible = true;
            this.Size = new Size(879, 312);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            pictureBox1.Visible = true;
            button6.Visible = false;
            dataGridView1.Visible = false;
            this.Size = new Size(879, 435);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filial = comboBox1.SelectedItem.ToString();
            string client = LoadUserData();
            label17.Visible = true;
            string car = label17.Text.ToString();
            label17.Visible = false;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string userID = currentUser.UserID.ToString();

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите филиал для заказа");
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into Заказы (IDfilial, ClientID, CarID, StartDate, Price, UserID) Values (@filial, @client, @car, @date, @price, @userid)", sqlConnect))
                {

                    cmd.Parameters.AddWithValue("@filial", filial);
                    cmd.Parameters.AddWithValue("@client", client);
                    cmd.Parameters.AddWithValue("@car", car);
                    cmd.Parameters.AddWithValue("@date", date);
                    decimal priceValue;
                    if (decimal.TryParse(label7.Text, out priceValue))
                    {
                        // Верное преобразование строки в decimal
                        cmd.Parameters.AddWithValue("@price", priceValue);
                    }
                    else
                    {
                        // Обработка ошибки, если строку нельзя преобразовать в decimal
                        MessageBox.Show("Ошибка при преобразовании строки в значение Price.");
                    }
                    cmd.Parameters.AddWithValue("@userid", userID);
                    try
                    {
                        sqlConnect.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Регистрация успешно завершена
                            MessageBox.Show("Заказ успешно оформлен!");
                            МенюПокупателя brForm = new МенюПокупателя(currentUser);
                            brForm.Show();
                            this.Close();
                        }
                        else
                        {
                            // Вставка не удалась, обработайте это по необходимости
                            MessageBox.Show("Ошибка при оформлении. Пожалуйста, попробуйте снова.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Обработка ошибок при выполнении SQL-запроса
                        MessageBox.Show("Ошибка при оформлении: " + ex.Message);
                    }
                }
            }
        }

        private string LoadUserData()
        {
            string clientID = null;
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ClientID FROM Клиент WHERE UserID = @login", sqlConnect);
                    cmd.Parameters.AddWithValue("@login", currentUser.UserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientID = reader["ClientID"].ToString();
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            return clientID;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            button3.Visible = true;
            groupBox2.Visible = true;

            this.Size = new Size(324, 437);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            button9.Visible = true;

            this.Size = new Size(975, 437);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            button10.Visible = true;

            this.Size = new Size(975, 437);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            button9.Visible = false;

            if(dataGridView3.Visible == false)
            {
                this.Size = new Size(324, 437);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            button10.Visible = false;

            if (dataGridView2.Visible == false)
            {
                this.Size = new Size(324, 437);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int price = 0;
            string model = comboBox2.SelectedItem.ToString();
            string modelID = null;
            string body = textBox1.Text;
            string bodyPrice = null;
            string engine = textBox2.Text;
            string enginePrice = null;
            string engineVolume = null;
            bool drive = checkBox1.Checked;
            string color = comboBox5.SelectedItem.ToString();

            using (SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog=autoShop;Integrated Security=True"))
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ModelID FROM Марки WHERE Model = @model", sqlConnect);
                    cmd.Parameters.AddWithValue("@model", model);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            modelID = reader["ModelID"].ToString();
                            reader.Close();
                        }
                    }
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Price FROM Кузов WHERE BodyID = @body", sqlConnect);
                    cmd.Parameters.AddWithValue("@body", body);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bodyPrice = reader["Price"].ToString();
                            reader.Close();
                        }
                    }
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Price FROM Двигатели WHERE EngineID = @engine", sqlConnect);
                    cmd.Parameters.AddWithValue("@engine", engine);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            enginePrice = reader["Price"].ToString();
                            reader.Close();
                        }
                    }
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

                try
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Volume FROM Двигатели WHERE EngineID = @engine", sqlConnect);
                    cmd.Parameters.AddWithValue("@engine", engine);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            engineVolume = reader["Volume"].ToString();
                            reader.Close();
                        }
                    }
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

            if (drive)
            {
                price += 500;
            }

            // Assuming enginePrice and bodyPrice are numeric values, you can convert them to integers before adding
            decimal enginePriceDecimal, bodyPriceDecimal;

            if (decimal.TryParse(enginePrice, out enginePriceDecimal) && decimal.TryParse(bodyPrice, out bodyPriceDecimal))
            {
                // Add the decimal values to the price
                price += (int)(enginePriceDecimal + bodyPriceDecimal);
            }
            else
            {
                MessageBox.Show("Ошибка при преобразовании цен в числа.");
            }

            groupBox2.Visible = false;
            groupBox3.Visible = true;
            label16.Visible = true;
            comboBox1.Visible = true;

            this.Size = new Size(546, 437);

            label32.Text = model;
            label34.Text = body;
            label20.Text = engine;
            label20.Visible = false;
            label35.Text = modelID;
            label35.Visible = false;
            label36.Text = engineVolume;
            if (drive)
            {
                label27.Text = "есть";
            }
            else
            {
                label27.Text = "нет";
            }
            label33.Text = color;
            label31.Text = price.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal price;
            label35.Visible = true;
            string modelID = label35.Text;
            label35.Visible = false;
            string body = label34.Text;
            label20.Visible = true;
            string engine = label20.Text;
            label20.Visible = false;
            string drive = label27.Text;
            string color = label33.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string year = DateTime.Now.ToString("yyyy");
            string carID;


            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");
            using (SqlCommand cmd = new SqlCommand("Insert Into Автомобиль (BodyID, EngineID, Drive, DateStart, Cost, New, Year, Distance, ModelID, Status, Color) Values (@bodyid, @engineid, @drive, @date, @cost, 1, @year, 0, @modelid, 0, @color); SELECT CONVERT(VARCHAR(10), SCOPE_IDENTITY());", sqlConnect))
            {
                cmd.Parameters.AddWithValue("@bodyid", body); // Replace bodyID with the actual value
                cmd.Parameters.AddWithValue("@engineid", engine); // Replace engineID with the actual value
                if(drive == "есть")
                {
                    cmd.Parameters.AddWithValue("@drive", 1); // Replace drive with the actual value
                }
                else
                {
                    cmd.Parameters.AddWithValue("@drive", 0); // Replace drive with the actual value
                }
                cmd.Parameters.AddWithValue("@date", date); // Replace date with the actual value
                if (decimal.TryParse(label31.Text, out price))
                {
                    // Use the 'price' variable as needed
                    cmd.Parameters.AddWithValue("@cost", price); // Replace cost with the actual value
                }
                else
                {
                    MessageBox.Show("Failed to parse price from label31.Text");
                }
                cmd.Parameters.AddWithValue("@year", year); // Replace year with the actual value
                cmd.Parameters.AddWithValue("@modelid", modelID); // Replace modelID with the actual value
                cmd.Parameters.AddWithValue("@color", color); // Replace color with the actual value

                sqlConnect.Open();

                // Execute the command and get the newly inserted CarID
                carID = Convert.ToString(cmd.ExecuteScalar());
                sqlConnect.Close();
            }

            string filial = comboBox1.SelectedItem.ToString();
            string client = LoadUserData();
            string userID = currentUser.UserID.ToString();

            using (SqlCommand cmd = new SqlCommand("Insert Into Заказы (IDfilial, ClientID, CarID, StartDate, Price, UserID) Values (@filial, @client, @car, @date, @price, @userid)", sqlConnect))
            {


                cmd.Parameters.AddWithValue("@filial", filial);
                cmd.Parameters.AddWithValue("@client", client);
                cmd.Parameters.AddWithValue("@car", carID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@userid", userID);
                try
                {
                    sqlConnect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Регистрация успешно завершена
                        MessageBox.Show("Заказ успешно оформлен!");
                        МенюПокупателя brForm = new МенюПокупателя(currentUser);
                        brForm.Show();
                        this.Close();
                    }
                    else
                    {
                        // Вставка не удалась, обработайте это по необходимости
                        MessageBox.Show("Ошибка при оформлении. Пожалуйста, попробуйте снова.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при выполнении SQL-запроса
                    MessageBox.Show("Ошибка при оформлении: " + ex.Message);
                }
            }
        }
    }
}


