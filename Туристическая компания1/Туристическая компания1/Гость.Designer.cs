namespace Туристическая_компания1
{
    partial class Гость
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.гостиницаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Шипицына_ОИDataSet = new Туристическая_компания1.УП01_ИСПП5_Шипицына_ОИDataSet();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new Туристическая_компания1.УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.МаршрутыTableAdapter();
            this.пунктыМаршрутаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пункты_маршрутаTableAdapter = new Туристическая_компания1.УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.Пункты_маршрутаTableAdapter();
            this.экскурсииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экскурсииTableAdapter = new Туристическая_компания1.УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.ЭкскурсииTableAdapter();
            this.гостиницаTableAdapter = new Туристическая_компания1.УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.ГостиницаTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Шипицына_ОИDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пунктыМаршрутаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экскурсииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.textBox1.Location = new System.Drawing.Point(204, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.label1.Location = new System.Drawing.Point(150, -20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "\r\nПоиск:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 32);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 28);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 28);
            this.toolStripMenuItem2.Text = "Вернуться";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 28);
            this.toolStripMenuItem4.Text = "Выход";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 28);
            this.toolStripMenuItem3.Text = "Таблицы";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(226, 28);
            this.toolStripMenuItem7.Text = "Маршруты";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(226, 28);
            this.toolStripMenuItem8.Text = "Пункты маршрута";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(226, 28);
            this.toolStripMenuItem9.Text = "Гостиница";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(226, 28);
            this.toolStripMenuItem10.Text = "Экскурсии";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 288);
            this.dataGridView1.TabIndex = 15;
            // 
            // гостиницаBindingSource
            // 
            this.гостиницаBindingSource.DataMember = "Гостиница";
            this.гостиницаBindingSource.DataSource = this.уП01_ИСПП5_Шипицына_ОИDataSet;
            // 
            // уП01_ИСПП5_Шипицына_ОИDataSet
            // 
            this.уП01_ИСПП5_Шипицына_ОИDataSet.DataSetName = "УП01_ИСПП5_Шипицына_ОИDataSet";
            this.уП01_ИСПП5_Шипицына_ОИDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.уП01_ИСПП5_Шипицына_ОИDataSet;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // пунктыМаршрутаBindingSource
            // 
            this.пунктыМаршрутаBindingSource.DataMember = "Пункты маршрута";
            this.пунктыМаршрутаBindingSource.DataSource = this.уП01_ИСПП5_Шипицына_ОИDataSet;
            // 
            // пункты_маршрутаTableAdapter
            // 
            this.пункты_маршрутаTableAdapter.ClearBeforeFill = true;
            // 
            // экскурсииBindingSource
            // 
            this.экскурсииBindingSource.DataMember = "Экскурсии";
            this.экскурсииBindingSource.DataSource = this.уП01_ИСПП5_Шипицына_ОИDataSet;
            // 
            // экскурсииTableAdapter
            // 
            this.экскурсииTableAdapter.ClearBeforeFill = true;
            // 
            // гостиницаTableAdapter
            // 
            this.гостиницаTableAdapter.ClearBeforeFill = true;
            // 
            // Гость
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Гость";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гость";
            this.Load += new System.EventHandler(this.Гость_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Шипицына_ОИDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пунктыМаршрутаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экскурсииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private УП01_ИСПП5_Шипицына_ОИDataSet уП01_ИСПП5_Шипицына_ОИDataSet;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.BindingSource пунктыМаршрутаBindingSource;
        private УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.Пункты_маршрутаTableAdapter пункты_маршрутаTableAdapter;
        private System.Windows.Forms.BindingSource экскурсииBindingSource;
        private УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.ЭкскурсииTableAdapter экскурсииTableAdapter;
        private System.Windows.Forms.BindingSource гостиницаBindingSource;
        private УП01_ИСПП5_Шипицына_ОИDataSetTableAdapters.ГостиницаTableAdapter гостиницаTableAdapter;
    }
}