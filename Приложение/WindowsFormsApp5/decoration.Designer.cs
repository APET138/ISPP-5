namespace WindowsFormsApp5
{
    partial class decoration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decoration));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.decorationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.б_АЮ_Учебная_ПрактикаDataSet2 = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet2();
            this.decorationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decorationTableAdapter = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet2TableAdapters.DecorationTableAdapter();
            this.Добавить = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.удалить = new System.Windows.Forms.Button();
            this.Изменить = new System.Windows.Forms.Button();
            this.Выход = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // decorationBindingSource1
            // 
            this.decorationBindingSource1.DataMember = "Decoration";
            this.decorationBindingSource1.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet2;
            // 
            // б_АЮ_Учебная_ПрактикаDataSet2
            // 
            this.б_АЮ_Учебная_ПрактикаDataSet2.DataSetName = "Б_АЮ_Учебная_ПрактикаDataSet2";
            this.б_АЮ_Учебная_ПрактикаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // decorationBindingSource
            // 
            this.decorationBindingSource.DataMember = "Decoration";
            this.decorationBindingSource.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet2;
            // 
            // decorationTableAdapter
            // 
            this.decorationTableAdapter.ClearBeforeFill = true;
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.Aquamarine;
            this.Добавить.Location = new System.Drawing.Point(45, 271);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(118, 23);
            this.Добавить.TabIndex = 4;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(434, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(553, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-2, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер состовного помещения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(205, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Обои";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(332, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Паркет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(466, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Плинтус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(582, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Плитка";
            // 
            // удалить
            // 
            this.удалить.BackColor = System.Drawing.Color.Aquamarine;
            this.удалить.Location = new System.Drawing.Point(169, 271);
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(118, 23);
            this.удалить.TabIndex = 32;
            this.удалить.Text = "Удалить";
            this.удалить.UseVisualStyleBackColor = false;
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // Изменить
            // 
            this.Изменить.BackColor = System.Drawing.Color.Aquamarine;
            this.Изменить.Location = new System.Drawing.Point(45, 311);
            this.Изменить.Name = "Изменить";
            this.Изменить.Size = new System.Drawing.Size(118, 23);
            this.Изменить.TabIndex = 31;
            this.Изменить.Text = "Изменить";
            this.Изменить.UseVisualStyleBackColor = false;
            this.Изменить.Click += new System.EventHandler(this.Изменить_Click);
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.Aquamarine;
            this.Выход.Location = new System.Drawing.Point(169, 311);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(118, 23);
            this.Выход.TabIndex = 30;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // decoration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 339);
            this.Controls.Add(this.удалить);
            this.Controls.Add(this.Изменить);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.dataGridView1);
            this.Name = "decoration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отделка";
            this.Load += new System.EventHandler(this.decoration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Б_АЮ_Учебная_ПрактикаDataSet2 б_АЮ_Учебная_ПрактикаDataSet2;
        private System.Windows.Forms.BindingSource decorationBindingSource;
        private Б_АЮ_Учебная_ПрактикаDataSet2TableAdapters.DecorationTableAdapter decorationTableAdapter;
        private System.Windows.Forms.BindingSource decorationBindingSource1;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button удалить;
        private System.Windows.Forms.Button Изменить;
        private System.Windows.Forms.Button Выход;
    }
}