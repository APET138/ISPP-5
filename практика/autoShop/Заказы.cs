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
    public partial class Заказы : Form
    {
        RegisteredUser currentUser;
        public Заказы(RegisteredUser user)
        {
            InitializeComponent();
            currentUser = user;

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");

            try
            {
                sqlConnect.Open();
                SqlCommand da = new SqlCommand("select * from Orders where UserID = @login", sqlConnect);
                da.Parameters.AddWithValue("@login", currentUser.UserID);
                // Создаем адаптер данных и таблицу для хранения результатов запроса
                SqlDataAdapter adapter = new SqlDataAdapter(da);
                DataTable dataTable = new DataTable();

                // Заполняем таблицу данными из базы данных
                adapter.Fill(dataTable);

                // Связываем DataTable с DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Опибка при входе: " + ex.Message);
            }
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ЛичныйКабинет profile = new ЛичныйКабинет(currentUser);
            profile.Show();
            this.Close();
        }
    }
}
