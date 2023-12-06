namespace autoShop
{
    partial class АвтомобилиADM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoShopDataSet = new autoShop.autoShopDataSet();
            this.автомобильTableAdapter = new autoShop.autoShopDataSetTableAdapters.АвтомобильTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.bodyIDDataGridViewTextBoxColumn,
            this.engineIDDataGridViewTextBoxColumn,
            this.driveDataGridViewCheckBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.newDataGridViewCheckBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.modelIDDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобильBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyIDDataGridViewTextBoxColumn
            // 
            this.bodyIDDataGridViewTextBoxColumn.DataPropertyName = "BodyID";
            this.bodyIDDataGridViewTextBoxColumn.HeaderText = "BodyID";
            this.bodyIDDataGridViewTextBoxColumn.Name = "bodyIDDataGridViewTextBoxColumn";
            // 
            // engineIDDataGridViewTextBoxColumn
            // 
            this.engineIDDataGridViewTextBoxColumn.DataPropertyName = "EngineID";
            this.engineIDDataGridViewTextBoxColumn.HeaderText = "EngineID";
            this.engineIDDataGridViewTextBoxColumn.Name = "engineIDDataGridViewTextBoxColumn";
            // 
            // driveDataGridViewCheckBoxColumn
            // 
            this.driveDataGridViewCheckBoxColumn.DataPropertyName = "Drive";
            this.driveDataGridViewCheckBoxColumn.HeaderText = "Drive";
            this.driveDataGridViewCheckBoxColumn.Name = "driveDataGridViewCheckBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // newDataGridViewCheckBoxColumn
            // 
            this.newDataGridViewCheckBoxColumn.DataPropertyName = "New";
            this.newDataGridViewCheckBoxColumn.HeaderText = "New";
            this.newDataGridViewCheckBoxColumn.Name = "newDataGridViewCheckBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "ModelID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.autoShopDataSet;
            // 
            // autoShopDataSet
            // 
            this.autoShopDataSet.DataSetName = "autoShopDataSet";
            this.autoShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Подтвердить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "<- Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // АвтомобилиADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(875, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "АвтомобилиADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтомобилиADM";
            this.Load += new System.EventHandler(this.АвтомобилиADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private autoShopDataSet autoShopDataSet;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private autoShopDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn driveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}