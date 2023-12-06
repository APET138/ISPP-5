namespace autoShop
{
    partial class КузовыUSER
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoShopDataSet = new autoShop.autoShopDataSet();
            this.кузовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кузовTableAdapter = new autoShop.autoShopDataSetTableAdapters.КузовTableAdapter();
            this.bodyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кузовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Подтвердить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "<- Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bodyIDDataGridViewTextBoxColumn,
            this.bodyModelDataGridViewTextBoxColumn,
            this.helmDataGridViewCheckBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.кузовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // autoShopDataSet
            // 
            this.autoShopDataSet.DataSetName = "autoShopDataSet";
            this.autoShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кузовBindingSource
            // 
            this.кузовBindingSource.DataMember = "Кузов";
            this.кузовBindingSource.DataSource = this.autoShopDataSet;
            // 
            // кузовTableAdapter
            // 
            this.кузовTableAdapter.ClearBeforeFill = true;
            // 
            // bodyIDDataGridViewTextBoxColumn
            // 
            this.bodyIDDataGridViewTextBoxColumn.DataPropertyName = "BodyID";
            this.bodyIDDataGridViewTextBoxColumn.HeaderText = "BodyID";
            this.bodyIDDataGridViewTextBoxColumn.Name = "bodyIDDataGridViewTextBoxColumn";
            this.bodyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyModelDataGridViewTextBoxColumn
            // 
            this.bodyModelDataGridViewTextBoxColumn.DataPropertyName = "BodyModel";
            this.bodyModelDataGridViewTextBoxColumn.HeaderText = "BodyModel";
            this.bodyModelDataGridViewTextBoxColumn.Name = "bodyModelDataGridViewTextBoxColumn";
            // 
            // helmDataGridViewCheckBoxColumn
            // 
            this.helmDataGridViewCheckBoxColumn.DataPropertyName = "Helm";
            this.helmDataGridViewCheckBoxColumn.HeaderText = "Helm";
            this.helmDataGridViewCheckBoxColumn.Name = "helmDataGridViewCheckBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // КузовыUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(573, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "КузовыUSER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КузовыUSER";
            this.Load += new System.EventHandler(this.КузовыUSER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кузовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private autoShopDataSet autoShopDataSet;
        private System.Windows.Forms.BindingSource кузовBindingSource;
        private autoShopDataSetTableAdapters.КузовTableAdapter кузовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}