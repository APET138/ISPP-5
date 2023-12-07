﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Бюро_технической_инвентаризации
{
    public partial class EditApp : Form
    {
        public EditApp()
        {
            InitializeComponent();
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            var id = textBox3.Text;
            var datestart = textBox1.Text;
            var document = comboBox2.Text;
            var cost = textBox6.Text;
            var address = textBox8.Text;
            var district = textBox9.Text;
            var custid = comboBox1.Text;
            var speed = checkBox1.Checked;

            SqlCommand cmd;
            string querystring = $"update Applications Set Customer_Code = '{custid}', DateStart = '{datestart}', Document = '{document}', Speed = '{speed}', Address = '{address}', District = '{district}', Cost = '{cost}' WHERE Application_Code = '{id}'";
            cmd = new SqlCommand(querystring, cn);
            cn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Информация успешно изменена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Информация не добавлена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RedApp_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7J49MA8; Initial Catalog = УП01_ИСПП5_Иванченко_ИВ; Integrated Security = True; MultipleActiveResultSets = True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Customers";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Customer_Code"]);
            }
            comboBox2.Items.Add("Технический паспорт объекта");
            comboBox2.Items.Add("Справка БТИ");
            comboBox2.Items.Add("Кадастровый паспорт");
            comboBox2.Items.Add("Справка об инвентаризационной стоимости");
            comboBox2.Items.Add("Справка о соответствии адреса");
            con.Close();
        }
    }
}
