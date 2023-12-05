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

namespace Деятельность_гостинцы
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm(int roomNumber, string guestName, DateTime checkInDate, DateTime checkOutDate, string receiptNumber, string amountToPay, bool isCashPayment)
        {
            InitializeComponent();
            label1.Text = roomNumber.ToString();
            label2.Text = guestName;
            label3.Text = checkInDate.ToString("dd.MM.yyyy");
            label4.Text = checkOutDate.ToString("dd.MM.yyyy");
            label5.Text = receiptNumber;
            label6.Text = amountToPay;
            if (!isCashPayment)
            {
                DisplayQRCode();
            }
        }

        private void DisplayQRCode()
        {
            string qrCodeImagePath = "C:\\Users\\Tays\\Desktop\\Практика\\Деятельность гостинцы\\Data\\qr.png";

            if (File.Exists(qrCodeImagePath))
            {
                pictureBox1.Image = Image.FromFile(qrCodeImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
