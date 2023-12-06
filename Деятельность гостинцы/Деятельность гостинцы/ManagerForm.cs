using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Деятельность_гостинцы.GuestForm;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using QRCoder;
using System.Runtime.Remoting.Messaging;

namespace Деятельность_гостинцы
{
    public partial class ManagerForm : Form
    {
        private static GuestForm guestFormInstance;
        private byte[] imageData;
        private int currentReceiptNumber = 1;

        public ManagerForm(GuestForm guestForm)
        {
            InitializeComponent();
            guestFormInstance = guestForm;
            textBox14.Text = currentReceiptNumber.ToString("D4");
            maskedTextBox1.Mask = "9999-00-00";
            maskedTextBox2.Mask = "9999-00-00";
            maskedTextBox3.Mask = "9999-00-00";
            maskedTextBox4.Mask = "9999-00-00";
        }


        private void ManagerForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            GuestForm.ReservationRequested += GuestForm_ReservationRequested;
        }
        private void GuestForm_ReservationRequested(object sender, GuestForm.ReservationEventArgs e)
        {
            HandleReservationData(e.RoomNumber, e.PhoneNumber);
        }
        private void HandleReservationData(int roomNumber, string phoneNumber)
        {
            textBox1.Text = roomNumber.ToString();
            textBox2.Text = phoneNumber;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string filePath = "ReservationData.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string[] data = lines[0].Split(',');
                    int roomNumber = int.Parse(data[0]);
                    string phoneNumber = data[1];
                    HandleReservationData(roomNumber, phoneNumber);
                    File.Delete(filePath);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                pictureBox1.Image = Image.FromFile(imagePath);

                imageData = File.ReadAllBytes(imagePath);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveGuestToDatabase();
                MessageBox.Show("Данные успешно сохранены!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrEmpty(textBox3.Text)
                && !string.IsNullOrEmpty(textBox2.Text)
                && !string.IsNullOrEmpty(textBox4.Text)
                && !string.IsNullOrEmpty(textBox5.Text)
                && !string.IsNullOrEmpty(maskedTextBox2.Text)
                && !string.IsNullOrEmpty(textBox7.Text)
                && !string.IsNullOrEmpty(textBox8.Text)
                && !string.IsNullOrEmpty(textBox9.Text)
                && !string.IsNullOrEmpty(textBox10.Text)
                && !string.IsNullOrEmpty(maskedTextBox1.Text)
                && !string.IsNullOrEmpty(textBox12.Text)
                && !string.IsNullOrEmpty(textBox13.Text);
        }

        private void SaveGuestToDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HotelManagement;Integrated Security=True";
            string query = @"
        INSERT INTO Guests 
        (LastName, FirstName, MiddleName, Address, Town, Aim, Passport, PassportDate, Region, Work, BirthYear, Picture, PhoneNumber) 
        VALUES 
        (@LastName, @FirstName, @MiddleName, @Address, @Town, @Aim, @Passport, @PassportDate, @Region, @Work, @BirthYear, @Picture, @PhoneNumber)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@FirstName", textBox4.Text);
                    command.Parameters.AddWithValue("@MiddleName", textBox5.Text);
                    command.Parameters.AddWithValue("@Address", textBox8.Text);
                    command.Parameters.AddWithValue("@Town", textBox7.Text);
                    command.Parameters.AddWithValue("@Aim", textBox9.Text);
                    command.Parameters.AddWithValue("@Passport", textBox10.Text);
                    DateTime passportDate;
                    if (DateTime.TryParseExact(maskedTextBox1.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out passportDate))
                    {
                        command.Parameters.AddWithValue("@PassportDate", passportDate);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода даты паспорта.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Region", textBox12.Text);
                    command.Parameters.AddWithValue("@Work", textBox13.Text);
                    DateTime BirthYear;
                    if (DateTime.TryParseExact(maskedTextBox2.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out BirthYear))
                    {
                        command.Parameters.AddWithValue("@BirthYear", BirthYear);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода даты рождения.");
                        return;
                    }
                    SqlParameter pictureParameter = new SqlParameter("@Picture", SqlDbType.VarBinary);
                    if (imageData != null && imageData.Length > 0)
                    {
                        pictureParameter.Value = imageData;
                    }
                    else
                    {
                        pictureParameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(pictureParameter);

                    command.Parameters.AddWithValue("@PhoneNumber", textBox2.Text);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateReservationInputs())
            {
                MakeReservation();
                ShowInvoiceForm();
                MessageBox.Show("Бронирование успешно завершено!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
            }
        }
        private void ShowInvoiceForm()
        {
            int selectedRoomNumber = int.Parse(textBox1.Text);
            string guestName = $"{textBox3.Text} {textBox4.Text} {textBox5.Text}";
            DateTime checkInDate = DateTime.ParseExact(maskedTextBox3.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime checkOutDate = DateTime.ParseExact(maskedTextBox4.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string receiptNumber = textBox14.Text;
            string amountToPay = textBox15.Text;
            bool isCashPayment = checkBox1.Checked;

            InvoiceForm invoiceForm = new InvoiceForm(selectedRoomNumber, guestName, checkInDate, checkOutDate, receiptNumber, amountToPay, isCashPayment);
            invoiceForm.ShowDialog();
        }

        private bool ValidateReservationInputs()
        {
            return !string.IsNullOrEmpty(textBox3.Text)
               && !string.IsNullOrEmpty(textBox4.Text)
               && !string.IsNullOrEmpty(textBox5.Text)
               && !string.IsNullOrEmpty(maskedTextBox3.Text)
               && !string.IsNullOrEmpty(maskedTextBox4.Text)
               && !string.IsNullOrEmpty(textBox15.Text)
               && !string.IsNullOrEmpty(textBox14.Text)
               && !string.IsNullOrEmpty(textBox16.Text)
              && !string.IsNullOrEmpty(textBox17.Text);
        }
        private void MakeReservation()
        {
            int selectedRoomNumber = int.Parse(textBox1.Text);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HotelManagement;Integrated Security=True";
            string query = @"
        INSERT INTO Reservations 
        (RoomNumber, LastName, FirstName, MiddleName, Come, Leave, Money, Cash, Receipt, Comment, Registrar) 
        VALUES 
        (@RoomNumber, @LastName, @FirstName, @MiddleName, @Come, @Leave, @Money, @Cash, @Receipt, @Comment, @Registrar)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@FirstName", textBox4.Text);
                    command.Parameters.AddWithValue("@MiddleName", textBox5.Text);
                    DateTime ComeDate;
                    if (DateTime.TryParseExact(maskedTextBox3.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out ComeDate))
                    {
                        command.Parameters.AddWithValue("@Come", ComeDate);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода даты.");
                        return;
                    }
                    DateTime LeaveDate;
                    if (DateTime.TryParseExact(maskedTextBox4.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out LeaveDate))
                    {
                        command.Parameters.AddWithValue("@Leave", LeaveDate);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода даты.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Money", textBox15.Text);
                    command.Parameters.AddWithValue("@Cash", checkBox1.Checked);
                    command.Parameters.AddWithValue("@Receipt", textBox14.Text);
                    command.Parameters.AddWithValue("@Comment", textBox16.Text);
                    command.Parameters.AddWithValue("@Registrar", textBox17.Text);
                    command.ExecuteNonQuery();
                    currentReceiptNumber++;
                    textBox14.Text = currentReceiptNumber.ToString("D4");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
