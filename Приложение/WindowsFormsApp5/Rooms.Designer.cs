namespace WindowsFormsApp5
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.б_АЮ_Учебная_ПрактикаDataSet = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet();
            this.roomsTableAdapter = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.RoomsTableAdapter();
            this.добавить = new System.Windows.Forms.Button();
            this.выход = new System.Windows.Forms.Button();
            this.fK2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.BuildingsTableAdapter();
            this.Переход2 = new System.Windows.Forms.Button();
            this.Переход = new System.Windows.Forms.Button();
            this.изменить = new System.Windows.Forms.Button();
            this.удалить = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 94);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet;
            // 
            // б_АЮ_Учебная_ПрактикаDataSet
            // 
            this.б_АЮ_Учебная_ПрактикаDataSet.DataSetName = "Б_АЮ_Учебная_ПрактикаDataSet";
            this.б_АЮ_Учебная_ПрактикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // добавить
            // 
            this.добавить.BackColor = System.Drawing.Color.Aquamarine;
            this.добавить.Location = new System.Drawing.Point(33, 191);
            this.добавить.Name = "добавить";
            this.добавить.Size = new System.Drawing.Size(118, 23);
            this.добавить.TabIndex = 3;
            this.добавить.Text = "Добавить";
            this.добавить.UseVisualStyleBackColor = false;
            this.добавить.Click += new System.EventHandler(this.добавить_Click);
            // 
            // выход
            // 
            this.выход.BackColor = System.Drawing.Color.Aquamarine;
            this.выход.Location = new System.Drawing.Point(206, 220);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(118, 23);
            this.выход.TabIndex = 4;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = false;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // fK2BindingSource
            // 
            this.fK2BindingSource.DataMember = "FK2";
            this.fK2BindingSource.DataSource = this.roomsBindingSource;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // Переход2
            // 
            this.Переход2.BackColor = System.Drawing.Color.Aquamarine;
            this.Переход2.Location = new System.Drawing.Point(33, 157);
            this.Переход2.Name = "Переход2";
            this.Переход2.Size = new System.Drawing.Size(118, 23);
            this.Переход2.TabIndex = 5;
            this.Переход2.Text = "<";
            this.Переход2.UseVisualStyleBackColor = false;
            this.Переход2.Click += new System.EventHandler(this.Переход2_Click);
            // 
            // Переход
            // 
            this.Переход.BackColor = System.Drawing.Color.Aquamarine;
            this.Переход.Location = new System.Drawing.Point(206, 157);
            this.Переход.Name = "Переход";
            this.Переход.Size = new System.Drawing.Size(118, 23);
            this.Переход.TabIndex = 6;
            this.Переход.Text = ">";
            this.Переход.UseVisualStyleBackColor = false;
            this.Переход.Click += new System.EventHandler(this.Переход_Click);
            // 
            // изменить
            // 
            this.изменить.BackColor = System.Drawing.Color.Aquamarine;
            this.изменить.Location = new System.Drawing.Point(33, 220);
            this.изменить.Name = "изменить";
            this.изменить.Size = new System.Drawing.Size(118, 23);
            this.изменить.TabIndex = 7;
            this.изменить.Text = "Изменить";
            this.изменить.UseVisualStyleBackColor = false;
            this.изменить.Click += new System.EventHandler(this.изменить_Click);
            // 
            // удалить
            // 
            this.удалить.BackColor = System.Drawing.Color.Aquamarine;
            this.удалить.Location = new System.Drawing.Point(206, 191);
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(118, 23);
            this.удалить.TabIndex = 8;
            this.удалить.Text = "Удалить";
            this.удалить.UseVisualStyleBackColor = false;
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "HallNum", true));
            this.textBox1.Location = new System.Drawing.Point(33, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Record", true));
            this.textBox2.Location = new System.Drawing.Point(206, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Storey", true));
            this.textBox3.Location = new System.Drawing.Point(417, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Room", true));
            this.textBox4.Location = new System.Drawing.Point(590, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "SquareHall", true));
            this.textBox5.Location = new System.Drawing.Point(33, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Branch", true));
            this.textBox6.Location = new System.Drawing.Point(206, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Balcony", true));
            this.textBox7.Location = new System.Drawing.Point(417, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Height", true));
            this.textBox8.Location = new System.Drawing.Point(590, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 16;
            this.textBox8.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер помещения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(188, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Номер состовной части";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(428, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Номер этажа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(562, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Количество составных частей";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(733, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Помещение в двух уровнях";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 255);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.удалить);
            this.Controls.Add(this.изменить);
            this.Controls.Add(this.Переход);
            this.Controls.Add(this.Переход2);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.добавить);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rooms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помещение";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fK2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Б_АЮ_Учебная_ПрактикаDataSet б_АЮ_Учебная_ПрактикаDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Button добавить;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.BindingSource fK2BindingSource;
        private Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.Button Переход2;
        private System.Windows.Forms.Button Переход;
        private System.Windows.Forms.Button изменить;
        private System.Windows.Forms.Button удалить;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}