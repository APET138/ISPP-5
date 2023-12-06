namespace WindowsFormsApp5
{
    partial class buildings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buildings));
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.б_АЮ_Учебная_ПрактикаDataSet = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet();
            this.buildingsTableAdapter = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.BuildingsTableAdapter();
            this.Добавить = new System.Windows.Forms.Button();
            this.выход = new System.Windows.Forms.Button();
            this.Вставка = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Удалить = new System.Windows.Forms.Button();
            this.Изменить = new System.Windows.Forms.Button();
            this.Переход = new System.Windows.Forms.Button();
            this.переход2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet;
            // 
            // б_АЮ_Учебная_ПрактикаDataSet
            // 
            this.б_АЮ_Учебная_ПрактикаDataSet.DataSetName = "Б_АЮ_Учебная_ПрактикаDataSet";
            this.б_АЮ_Учебная_ПрактикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.Aquamarine;
            this.Добавить.Location = new System.Drawing.Point(37, 193);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(118, 23);
            this.Добавить.TabIndex = 2;
            this.Добавить.Text = "Выполнить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // выход
            // 
            this.выход.BackColor = System.Drawing.Color.Aquamarine;
            this.выход.Location = new System.Drawing.Point(161, 233);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(118, 23);
            this.выход.TabIndex = 3;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = false;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // Вставка
            // 
            this.Вставка.BackColor = System.Drawing.Color.Aquamarine;
            this.Вставка.Location = new System.Drawing.Point(638, 128);
            this.Вставка.Name = "Вставка";
            this.Вставка.Size = new System.Drawing.Size(140, 20);
            this.Вставка.TabIndex = 4;
            this.Вставка.Text = "Вставить картинку";
            this.Вставка.UseVisualStyleBackColor = false;
            this.Вставка.Visible = false;
            this.Вставка.Click += new System.EventHandler(this.Вставка_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(808, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Kadastr", true));
            this.textBox1.Location = new System.Drawing.Point(24, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "HallNum", true));
            this.textBox2.Location = new System.Drawing.Point(173, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 91);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Address", true));
            this.textBox4.Location = new System.Drawing.Point(479, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "District", true));
            this.textBox5.Location = new System.Drawing.Point(638, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Land", true));
            this.textBox6.Location = new System.Drawing.Point(24, 128);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Storey", true));
            this.textBox3.Location = new System.Drawing.Point(323, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Years", true));
            this.textBox7.Location = new System.Drawing.Point(173, 128);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Material", true));
            this.textBox8.Location = new System.Drawing.Point(323, 128);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Base", true));
            this.textBox9.Location = new System.Drawing.Point(479, 128);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Comment", true));
            this.textBox10.Location = new System.Drawing.Point(638, 128);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 17;
            this.textBox10.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Wear", true));
            this.textBox11.Location = new System.Drawing.Point(24, 128);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 18;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Flow", true));
            this.textBox12.Location = new System.Drawing.Point(173, 128);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 19;
            this.textBox12.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Line", true));
            this.textBox13.Location = new System.Drawing.Point(323, 128);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 20;
            this.textBox13.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "square", true));
            this.textBox14.Location = new System.Drawing.Point(479, 128);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 21;
            this.textBox14.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingsBindingSource, "Hall", true));
            this.textBox15.Location = new System.Drawing.Point(359, 184);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 22;
            this.textBox15.Visible = false;
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.Aquamarine;
            this.Удалить.Location = new System.Drawing.Point(161, 193);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(118, 23);
            this.Удалить.TabIndex = 28;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Изменить
            // 
            this.Изменить.BackColor = System.Drawing.Color.Aquamarine;
            this.Изменить.Location = new System.Drawing.Point(37, 233);
            this.Изменить.Name = "Изменить";
            this.Изменить.Size = new System.Drawing.Size(118, 23);
            this.Изменить.TabIndex = 27;
            this.Изменить.Text = "Изменить";
            this.Изменить.UseVisualStyleBackColor = false;
            this.Изменить.Click += new System.EventHandler(this.Изменить_Click);
            // 
            // Переход
            // 
            this.Переход.BackColor = System.Drawing.Color.Aquamarine;
            this.Переход.Location = new System.Drawing.Point(161, 158);
            this.Переход.Name = "Переход";
            this.Переход.Size = new System.Drawing.Size(118, 23);
            this.Переход.TabIndex = 26;
            this.Переход.Text = ">";
            this.Переход.UseVisualStyleBackColor = false;
            this.Переход.Click += new System.EventHandler(this.Переход_Click_1);
            // 
            // переход2
            // 
            this.переход2.BackColor = System.Drawing.Color.Aquamarine;
            this.переход2.Location = new System.Drawing.Point(37, 158);
            this.переход2.Name = "переход2";
            this.переход2.Size = new System.Drawing.Size(118, 23);
            this.переход2.TabIndex = 25;
            this.переход2.Text = "<";
            this.переход2.UseVisualStyleBackColor = false;
            this.переход2.Click += new System.EventHandler(this.переход2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Кадастровый номер здания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(176, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Номер помещения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(330, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Номер этажа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(491, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Адрес здания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(618, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Площадь земельного участка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(319, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Количество помещений в здании";
            this.label6.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(528, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Наличие лифта";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1189, 277);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Изменить);
            this.Controls.Add(this.Переход);
            this.Controls.Add(this.переход2);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Вставка);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.Добавить);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "buildings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Здание";
            this.Load += new System.EventHandler(this.buildings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Б_АЮ_Учебная_ПрактикаDataSet б_АЮ_Учебная_ПрактикаDataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button Вставка;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Изменить;
        private System.Windows.Forms.Button Переход;
        private System.Windows.Forms.Button переход2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}