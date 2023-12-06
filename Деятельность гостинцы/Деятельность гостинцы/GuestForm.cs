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
using System.Collections;
using System.IO;

namespace Деятельность_гостинцы
{
    public partial class GuestForm : Form
    {
        public static event EventHandler<ReservationEventArgs> ReservationRequested;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HotelManagement;Integrated Security=True;";
        private string query = "SELECT Number, Rooms, Storey, TV, Fridge, Bed, Type, Balcony FROM Rooms WHERE 1=1 ";

        public GuestForm()
        {
            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.ReadOnly = true;
            this.roomsTableAdapter.Fill(this.dataSet2.Rooms);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int roomNumber = Convert.ToInt32(row.Cells[0].Value.ToString());
                comboBox1.Items.Add(roomNumber);
                maskedTextBox1.Mask = "+7 (999) 000-0000";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rooms, storey, beds;
            bool tv, fridge, balcony;
            int.TryParse(textBox1.Text, out rooms);
            int.TryParse(textBox2.Text, out storey);
            int.TryParse(textBox3.Text, out beds);
            tv = checkBox1.Checked;
            fridge = checkBox2.Checked;
            balcony = checkBox3.Checked;

            if (rooms <= 0 && storey <= 0 && beds <= 0 && !tv && !fridge && !balcony)
            {
                string defaultQuery = "SELECT Number, Rooms, Storey, TV, Fridge, Bed, RoomPhoto, Balcony FROM Rooms";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand defaultCommand = new SqlCommand(defaultQuery, connection);
                    SqlDataAdapter defaultAdapter = new SqlDataAdapter(defaultCommand);
                    DataTable defaultDataTable = new DataTable();
                    defaultAdapter.Fill(defaultDataTable);
                    dataGridView1.DataSource = defaultDataTable;
                }
            }
            else
            {
                string query = "SELECT Number, Rooms, Storey, TV, Fridge, Bed, RoomPhoto, Balcony FROM Rooms WHERE 1=1 ";
                if (storey > 0)
                {
                    query += "AND Storey = @Storey ";
                }
                if (rooms > 0)
                {
                    query += "AND Rooms = @Rooms ";
                }
                if (tv)
                {
                    query += "AND TV = @TV ";
                }
                if (fridge)
                {
                    query += "AND Fridge = @Fridge ";
                }
                if (beds > 0)
                {
                    query += "AND Bed = @Beds ";
                }
                if (balcony)
                {
                    query += "AND Balcony = @Balcony ";
                }

                query += "ORDER BY ";

                if (storey > 0)
                {
                    query += "Storey ASC, ";
                }
                if (rooms > 0)
                {
                    query += "Rooms ASC, ";
                }
                if (tv)
                {
                    query += "TV DESC, ";
                }
                if (fridge)
                {
                    query += "Fridge DESC, ";
                }
                if (beds > 0)
                {
                    query += "Bed ASC, ";
                }
                if (balcony)
                {
                    query += "Balcony DESC, ";
                }
                query = query.TrimEnd(',', ' ');

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (storey > 0)
                    {
                        command.Parameters.AddWithValue("@Storey", storey);
                    }
                    if (rooms > 0)
                    {
                        command.Parameters.AddWithValue("@Rooms", rooms);
                    }
                    if (tv)
                    {
                        command.Parameters.AddWithValue("@TV", tv);
                    }
                    if (fridge)
                    {
                        command.Parameters.AddWithValue("@Fridge", fridge);
                    }
                    if (beds > 0)
                    {
                        command.Parameters.AddWithValue("@Beds", beds);
                    }
                    if (balcony)
                    {
                        command.Parameters.AddWithValue("@Balcony", balcony);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRoomNumber = Convert.ToInt32(comboBox1.SelectedItem);
            string phoneNumber = maskedTextBox1.Text;
            ReservationRequested?.Invoke(this, new ReservationEventArgs(selectedRoomNumber, phoneNumber));
            SaveReservationData(selectedRoomNumber, phoneNumber);
        }
        protected virtual void OnReservationRequested(ReservationEventArgs e)
        {
            ReservationRequested?.Invoke(this, e);
        }
        public class ReservationEventArgs : EventArgs
        {
            public int RoomNumber { get; }
            public string PhoneNumber { get; }

            public ReservationEventArgs(int roomNumber, string phoneNumber)
            {
                RoomNumber = roomNumber;
                PhoneNumber = phoneNumber;
            }
        }
        private void SaveReservationData(int roomNumber, string phoneNumber)
        {
            string filePath = "ReservationData.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"{roomNumber},{phoneNumber}");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int columnIndex = -1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.HeaderText == "Номер комнаты")
                    {
                        columnIndex = column.Index;
                        break;
                    }
                }
                if (columnIndex != -1)
                {
                    int selectedRoomNumber = Convert.ToInt32(row.Cells[columnIndex].Value.ToString());
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string getImageQuery = "SELECT RoomPhoto FROM Rooms WHERE Number = @RoomNumber";
                        SqlCommand getImageCommand = new SqlCommand(getImageQuery, connection);
                        getImageCommand.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);

                        byte[] imageBytes = (byte[])getImageCommand.ExecuteScalar();

                        if (imageBytes != null)
                        {
                            MemoryStream ms = new MemoryStream(imageBytes);
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
        }
    }
}


