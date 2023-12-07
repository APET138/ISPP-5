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
using Microsoft.SqlServer.Server;

namespace Учебная_практика
{
    public partial class Tables : Form
    {
        string[] t = new string[15]; 
        string pr;
        int tabl = 0;
        
        public Tables() {InitializeComponent();}
        public void pravoo(string a){pr = a;}
        public void table(int a)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter[] da = new SqlDataAdapter[6];
            da[0] = new SqlDataAdapter("select  LastName as [Фамилия], Name as [Имя], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес],  Phone as [Номер телефона], Birth as [Дата рождения],Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Convert (bit,Money) as [Есть возможность оплачивать?] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
            da[1] = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента], Lessons as [Предметы которые сдавались], Score as [Общий балл за ЕГЭ] from (Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat) join EGE on Enrollee.Enrolle = EGE.Enrolle", sqlConnect);
            da[2] = new SqlDataAdapter("select ContractAbout as [Условия договора], ContAdress as [Адрес предприятия], CountPhone as [Телефон предприятия], Convert (bit,Payment) as [Платят?] from Contract", sqlConnect);
            da[3] = new SqlDataAdapter("select EGE as [Номер аттестата ЕГЭ], Faculty as [Факультет], Speciality as [Специальность], Registrar as [Фамилия принявшего документы], convert(bit,Talk) as [Рекомендация для собеседования], Result as [Набрано баллов при поступлении] from Commission", sqlConnect);
            da[4] = new SqlDataAdapter("select PersonID as [Номер регистрации абитуриента], Type as [Основа, на которой зачислен] from Enrollment", sqlConnect);
            da[5] = new SqlDataAdapter("select Login as [Логин], Password as [Пароль], Pravo as [Право доступа] from Users", sqlConnect);
            tabl = a;
            Update.Enabled = true;
            if (tabl == 4)
            {
                Update.Enabled = false;
            }
            if (tabl == 0)
            {
                Size = new Size(859, 361);
                PhotoAbPicture.Visible = true;
                label6.Visible = true;
            }
            else
            {
                Size = new Size(642, 361);
                PhotoAbPicture.Visible = false;
                label6.Visible = false;
            }
            da[a].Fill(dt);
            UniversalTable.DataSource = dt.Tables[0];
        }
        private void ArrowLeft_Click(object sender, EventArgs e)
        {
        }
        private void Abityrient_Click(object sender, EventArgs e) { table(0); }
        private void EGE_Click(object sender, EventArgs e){table(1);}
        private void Contract_Click(object sender, EventArgs e){table(2);}
        private void Commission_Click(object sender, EventArgs e){table(3);}
        private void Proshedshie_Click(object sender, EventArgs e) { table(4); }
        private void PravaDostypa_Click(object sender, EventArgs e) { table(5); }
        private void Tables_Load(object sender, EventArgs e)
        {
            if (pr == "admin")
            {
                PravaDostypa.Visible = true;
            }
            else
            {
                PravaDostypa.Visible = false;
            }
        }
        private void Exit_Click(object sender, EventArgs e){Application.Exit();}
        private void ExitToAvtorization_Click(object sender, EventArgs e)
        {
            //Переход на форму авторизации
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        public void del()
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            switch (tabl)
            {
                case 0:
                    try
                    {


                        da = new SqlDataAdapter("Select Enrolle from Enrollee", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from Enrollee where Enrolle = '{ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["Enrolle"].ToString()}'; Delete from Passport where Passport = '{UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value}';Delete from Attestat where Attestat = '{UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[9].Value}';", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
                case 1:
                    try
                    {
                        da = new SqlDataAdapter("Select EGE from EGE", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from EGE where EGE = '{ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["EGE"].ToString()}'", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
                case 2:
                    try
                    {
                        da = new SqlDataAdapter("Select ContractID from Contract", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from Contract where ContractID = {ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["ContractID"].ToString()}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
                case 3:
                    try
                    {
                        da = new SqlDataAdapter("Select PersonID from Commission", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from Commission where PersonID = {ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["PersonID"].ToString()}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
                case 4:
                    try
                    {
                        da = new SqlDataAdapter("Select YesID from Enrollment", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from Enrollment where YesID = {ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["YesID"].ToString()}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
                case 5:
                    try
                    {
                        da = new SqlDataAdapter("Select Id from Users", sqlConnect);
                        da.Fill(ds);
                        da = new SqlDataAdapter($"Delete from Users where Id = {ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["Id"].ToString()}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    table(tabl);
                    break;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            del();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    string[] table = new string[14];

                    for (int i = 0; i < table.Length; i++)
                    {
                        try
                        {
                            table[i] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[i].Value.ToString();
                        }
                        catch
                        {

                        }
                    }
                    CreateAbiturient form = new CreateAbiturient();
                    form.Update(table);
                    Hide();
                    form.Show();
                    ochicenie(table);
                    break;
                case 1:
                    table = new string[4];

                    for (int i = 0; i < table.Length; i++)
                    {
                        try
                        {
                            table[i] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[i].Value.ToString();
                        }
                        catch
                        {

                        }
                    }
                    CreateEGE forma = new CreateEGE();
                    forma.Update(table);
                    Hide();
                    forma.Show();
                    ochicenie(table);
                    break;
                case 2:
                    table = new string[4];

                    for (int i = 0; i < table.Length; i++)
                    {
                        try
                        {
                            table[i] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[i].Value.ToString();
                        }
                        catch
                        {

                        }
                    }
                    CreateContract formaaaa = new CreateContract();
                    formaaaa.Update(table);
                    Hide();
                    SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                    sqlConnect.Open();
                    DataSet dt = new DataSet();
                    DataTable ds = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("Select ContractID from Contract", sqlConnect);
                    da.Fill(ds);
                    formaaaa.ID(ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["ContractID"].ToString());
                    formaaaa.Show();
                    ochicenie(table);
                    break;
                case 3:
                    string[] table1 = new string[8];

                    for (int i = 0; i < table1.Length; i++)
                    {
                        try
                        {
                            table1[i] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[i].Value.ToString();
                        }
                        catch
                        {

                        }
                    }

                    CreateCommission form1 = new CreateCommission();
                    form1.Update(table1);
                    Hide();
                    sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                    sqlConnect.Open();
                    ds = new DataTable();
                    da = new SqlDataAdapter("Select PersonID from Commission", sqlConnect);
                    da.Fill(ds);
                    form1.ID(ds.Rows[UniversalTable.SelectedCells[0].RowIndex]["PersonID"].ToString());
                    form1.Show();
                    ochicenie(table1);
                    break;
            }
        }
        public string[] ochicenie(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = "";
            }
            return a;
        }
        private void Create_Click(object sender, EventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    CreateAbiturient form = new CreateAbiturient();
                    Hide();
                    form.ShowDialog();
                    form.create();
                    break;
                case 1:
                    CreateEGE forma = new CreateEGE();
                    Hide();
                    forma.ShowDialog();
                    forma.create();
                    break;
                case 2:
                    CreateContract formaa = new CreateContract();
                    Hide();
                    formaa.ShowDialog();
                    formaa.create();
                    break;
                case 3:
                    CreateCommission formaaA = new CreateCommission();
                    Hide();
                    formaaA.ShowDialog();
                    formaaA.create();
                    break;
            }
        }
        private void UniversalTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabl == 0)
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Picture from Enrollee", sqlConnect);
                da.Fill(dt);
                try
                {
                    PhotoAbPicture.Image = Image.FromFile(dt.Rows[UniversalTable.SelectedCells[0].RowIndex]["Picture"].ToString());
                }
                catch
                {
                    PhotoAbPicture.Image = null;
                }
            }
        }
           
    }
}
