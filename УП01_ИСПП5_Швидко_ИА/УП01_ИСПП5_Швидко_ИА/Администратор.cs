﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        public void tab(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();

            switch (i)
            {
                case 0: Поле_для_таблиц_DataGridView1.DataSource = продажиBindingSource; break;
                case 1: Поле_для_таблиц_DataGridView1.DataSource = покупателиBindingSource; break;
                case 2: Поле_для_таблиц_DataGridView1.DataSource = оптовыепокупателиBindingSource; break;
                case 3: Поле_для_таблиц_DataGridView1.DataSource = продавцыBindingSource; break;
                case 4: Поле_для_таблиц_DataGridView1.DataSource = сортарастенийBindingSource; break;
                case 5: Поле_для_таблиц_DataGridView1.DataSource = новыесортарастенийBindingSource; break;
                case 6: Поле_для_таблиц_DataGridView1.DataSource = упаковкисемянBindingSource; break;
                case 7: Поле_для_таблиц_DataGridView1.DataSource = пользователиBindingSource; break;
            }
        }

        public Boolean a = false;
        int id = 0;

        int c;
        private void вернуться_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void обновить_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 0: продажиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продажи); break;

                case 1: покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); break;

                case 2: оптовые_покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); break;

                case 3: продавцыTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); break;

                case 4: сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений); break;

                case 5: новые_сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); break;

                case 6: упаковки_семянTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); break;

                case 7: пользователиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Пользователи); break;
            }
        }

        private void выйти_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Таблица_Продажи_Click(object sender, EventArgs e)
        {
            tab(0);
            c = 0;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Покупатели_Click(object sender, EventArgs e)
        {
            tab(1);
            c = 1;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Оптовые_покупатели_Click(object sender, EventArgs e)
        {
            tab(2);
            c = 2;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Продавцы_Click(object sender, EventArgs e)
        {
            tab(3);
            c = 3;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)
        {
            tab(4);
            c = 4;
            a = true;
            Фотография_представителя_PictureBox2.Visible = true;
            Кнопка_найти_фотографию_Button1.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }

        private void Таблица_Новые_сорта_растений_Click(object sender, EventArgs e)
        {
            tab(5);
            c = 5;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)
        {
            tab(6);
            c = 6;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Пользователи_Click(object sender, EventArgs e)
        {
            tab(7);
            c = 7;
            Фотография_представителя_PictureBox2.Visible = false;
            Кнопка_найти_фотографию_Button1.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)
        {
                for (int i = 0; i < Поле_для_таблиц_DataGridView1.RowCount; i++)
                {
                Поле_для_таблиц_DataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < Поле_для_таблиц_DataGridView1.ColumnCount; j++)
                        if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value != null)
                            if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Строка_поиска_TextBox1.Text))
                            {
                            Поле_для_таблиц_DataGridView1.Rows[i].Selected = true;
                                break;
                            }
            }
        }
        string pic;
        private void Поле_для_таблиц_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex.ToString());
            if (c == 4)
            {
                try
                {
                    pic = Поле_для_таблиц_DataGridView1[7, id].Value.ToString();
                    выйти_PictureBox1.Image = Image.FromFile(pic);
                    if (выйти_PictureBox1.Image != null)
                    {
                        Фотография_представителя_PictureBox2.Visible = true;
                    }

                }
                catch
                {
                    MessageBox.Show("Отсутствует изображение");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (c == 4)
                {
                    Фотография_представителя_PictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }
        Point Mouse;

        private void Администратор_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Администратор_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }

        private void Администратор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели". При необходимости она может быть перемещена или удалена.
            this.оптовые_покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений". При необходимости она может быть перемещена или удалена.
            this.новые_сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.

        }
    }
}
