namespace Практика_sql
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxПароль = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxЛогин = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxКвартира = new System.Windows.Forms.TextBox();
            this.textBoxТипКвартиры = new System.Windows.Forms.TextBox();
            this.textBoxОтчество = new System.Windows.Forms.TextBox();
            this.textBoxФамилия = new System.Windows.Forms.TextBox();
            this.textBoxЛюди = new System.Windows.Forms.TextBox();
            this.textBoxДом = new System.Windows.Forms.TextBox();
            this.textBoxИмя = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxПаспорт = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apartmentcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eStoveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buildingnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet = new Практика_sql.УП_ПМ01_ИСПП_5_Буйлов_МАDataSet();
            this.apartmentsTableAdapter = new Практика_sql.УП_ПМ01_ИСПП_5_Буйлов_МАDataSetTableAdapters.ApartmentsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.fK5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterTableAdapter = new Практика_sql.УП_ПМ01_ИСПП_5_Буйлов_МАDataSetTableAdapters.CounterTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxПароль
            // 
            this.textBoxПароль.Location = new System.Drawing.Point(370, 211);
            this.textBoxПароль.Name = "textBoxПароль";
            this.textBoxПароль.Size = new System.Drawing.Size(100, 20);
            this.textBoxПароль.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(293, 214);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(45, 13);
            this.Password.TabIndex = 10;
            this.Password.Text = "Пароль";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(178, 329);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxЛогин
            // 
            this.textBoxЛогин.Location = new System.Drawing.Point(370, 178);
            this.textBoxЛогин.Name = "textBoxЛогин";
            this.textBoxЛогин.Size = new System.Drawing.Size(100, 20);
            this.textBoxЛогин.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(293, 181);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(38, 13);
            this.Login.TabIndex = 7;
            this.Login.Text = "Логин";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(178, 300);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(144, 23);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Добавить Пользователя";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxКвартира
            // 
            this.textBoxКвартира.Location = new System.Drawing.Point(130, 87);
            this.textBoxКвартира.Name = "textBoxКвартира";
            this.textBoxКвартира.Size = new System.Drawing.Size(100, 20);
            this.textBoxКвартира.TabIndex = 12;
            // 
            // textBoxТипКвартиры
            // 
            this.textBoxТипКвартиры.Location = new System.Drawing.Point(130, 117);
            this.textBoxТипКвартиры.Name = "textBoxТипКвартиры";
            this.textBoxТипКвартиры.Size = new System.Drawing.Size(100, 20);
            this.textBoxТипКвартиры.TabIndex = 13;
            // 
            // textBoxОтчество
            // 
            this.textBoxОтчество.Location = new System.Drawing.Point(370, 146);
            this.textBoxОтчество.Name = "textBoxОтчество";
            this.textBoxОтчество.Size = new System.Drawing.Size(100, 20);
            this.textBoxОтчество.TabIndex = 15;
            // 
            // textBoxФамилия
            // 
            this.textBoxФамилия.Location = new System.Drawing.Point(370, 91);
            this.textBoxФамилия.Name = "textBoxФамилия";
            this.textBoxФамилия.Size = new System.Drawing.Size(100, 20);
            this.textBoxФамилия.TabIndex = 14;
            // 
            // textBoxЛюди
            // 
            this.textBoxЛюди.Location = new System.Drawing.Point(130, 146);
            this.textBoxЛюди.Name = "textBoxЛюди";
            this.textBoxЛюди.Size = new System.Drawing.Size(100, 20);
            this.textBoxЛюди.TabIndex = 16;
            // 
            // textBoxДом
            // 
            this.textBoxДом.Location = new System.Drawing.Point(130, 178);
            this.textBoxДом.Name = "textBoxДом";
            this.textBoxДом.Size = new System.Drawing.Size(100, 20);
            this.textBoxДом.TabIndex = 19;
            // 
            // textBoxИмя
            // 
            this.textBoxИмя.Location = new System.Drawing.Point(370, 120);
            this.textBoxИмя.Name = "textBoxИмя";
            this.textBoxИмя.Size = new System.Drawing.Size(100, 20);
            this.textBoxИмя.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Квартира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Тип квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Людей проживает";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Номер дома";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Паспортные данные";
            // 
            // textBoxПаспорт
            // 
            this.textBoxПаспорт.Location = new System.Drawing.Point(130, 206);
            this.textBoxПаспорт.Name = "textBoxПаспорт";
            this.textBoxПаспорт.Size = new System.Drawing.Size(100, 20);
            this.textBoxПаспорт.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(159, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Регистрация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartmentcodeDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn,
            this.flatTypeDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.eStoveDataGridViewCheckBoxColumn,
            this.buildingnumberDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.forstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apartmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // apartmentcodeDataGridViewTextBoxColumn
            // 
            this.apartmentcodeDataGridViewTextBoxColumn.DataPropertyName = "Apartment_code";
            this.apartmentcodeDataGridViewTextBoxColumn.HeaderText = "Apartment_code";
            this.apartmentcodeDataGridViewTextBoxColumn.Name = "apartmentcodeDataGridViewTextBoxColumn";
            this.apartmentcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "Flat";
            this.flatDataGridViewTextBoxColumn.HeaderText = "Flat";
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            // 
            // flatTypeDataGridViewTextBoxColumn
            // 
            this.flatTypeDataGridViewTextBoxColumn.DataPropertyName = "FlatType";
            this.flatTypeDataGridViewTextBoxColumn.HeaderText = "FlatType";
            this.flatTypeDataGridViewTextBoxColumn.Name = "flatTypeDataGridViewTextBoxColumn";
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // eStoveDataGridViewCheckBoxColumn
            // 
            this.eStoveDataGridViewCheckBoxColumn.DataPropertyName = "EStove";
            this.eStoveDataGridViewCheckBoxColumn.HeaderText = "EStove";
            this.eStoveDataGridViewCheckBoxColumn.Name = "eStoveDataGridViewCheckBoxColumn";
            // 
            // buildingnumberDataGridViewTextBoxColumn
            // 
            this.buildingnumberDataGridViewTextBoxColumn.DataPropertyName = "Building_number";
            this.buildingnumberDataGridViewTextBoxColumn.HeaderText = "Building_number";
            this.buildingnumberDataGridViewTextBoxColumn.Name = "buildingnumberDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // forstNameDataGridViewTextBoxColumn
            // 
            this.forstNameDataGridViewTextBoxColumn.DataPropertyName = "ForstName";
            this.forstNameDataGridViewTextBoxColumn.HeaderText = "ForstName";
            this.forstNameDataGridViewTextBoxColumn.Name = "forstNameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // apartmentsBindingSource
            // 
            this.apartmentsBindingSource.DataMember = "Apartments";
            this.apartmentsBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet;
            // 
            // уП_ПМ01_ИСПП_5_Буйлов_МАDataSet
            // 
            this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.DataSetName = "УП_ПМ01_ИСПП_5_Буйлов_МАDataSet";
            this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartmentsTableAdapter
            // 
            this.apartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartmentsBindingSource, "Apartment_code", true));
            this.label4.Location = new System.Drawing.Point(569, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Фамилия";
            // 
            // fK5BindingSource
            // 
            this.fK5BindingSource.DataMember = "FK5";
            this.fK5BindingSource.DataSource = this.apartmentsBindingSource;
            // 
            // counterTableAdapter
            // 
            this.counterTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(390, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 377);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxПаспорт);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxДом);
            this.Controls.Add(this.textBoxИмя);
            this.Controls.Add(this.textBoxЛюди);
            this.Controls.Add(this.textBoxОтчество);
            this.Controls.Add(this.textBoxФамилия);
            this.Controls.Add(this.textBoxТипКвартиры);
            this.Controls.Add(this.textBoxКвартира);
            this.Controls.Add(this.textBoxПароль);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxЛогин);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.buttonRegister);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователй";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxПароль;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxЛогин;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxКвартира;
        private System.Windows.Forms.TextBox textBoxТипКвартиры;
        private System.Windows.Forms.TextBox textBoxОтчество;
        private System.Windows.Forms.TextBox textBoxФамилия;
        private System.Windows.Forms.TextBox textBoxЛюди;
        private System.Windows.Forms.TextBox textBoxДом;
        private System.Windows.Forms.TextBox textBoxИмя;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxПаспорт;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private УП_ПМ01_ИСПП_5_Буйлов_МАDataSet уП_ПМ01_ИСПП_5_Буйлов_МАDataSet;
        private System.Windows.Forms.BindingSource apartmentsBindingSource;
        private УП_ПМ01_ИСПП_5_Буйлов_МАDataSetTableAdapters.ApartmentsTableAdapter apartmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eStoveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fK5BindingSource;
        private УП_ПМ01_ИСПП_5_Буйлов_МАDataSetTableAdapters.CounterTableAdapter counterTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}