namespace УП_МДК_01_01
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.пользователиTableAdapter = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet1TableAdapters.ПользователиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.фотографииДомовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01ИСПП5РаботяговаААDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Работягова_ААDataSet3 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажейВДомеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районГородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инфраструктураТерриторииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодФотографииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKДомаФотографииДомовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.домаTableAdapter = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet1TableAdapters.ДомаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureSet = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодФотографииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотографияЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотографии_домовTableAdapter = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet2TableAdapters.Фотографии_домовTableAdapter();
            this.домаTableAdapter1 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet2TableAdapters.ДомаTableAdapter();
            this.фотографии_домовTableAdapter1 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.Фотографии_домовTableAdapter();
            this.домаTableAdapter2 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.ДомаTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографииДомовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5РаботяговаААDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKДомаФотографииДомовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button2.Location = new System.Drawing.Point(486, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться в меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.bindingNavigator1.BindingSource = this.фотографииДомовBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveButton,
            this.CancelButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(698, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // фотографииДомовBindingSource
            // 
            this.фотографииДомовBindingSource.DataMember = "Фотографии домов";
            this.фотографииДомовBindingSource.DataSource = this.уП01ИСПП5РаботяговаААDataSet3BindingSource;
            // 
            // уП01ИСПП5РаботяговаААDataSet3BindingSource
            // 
            this.уП01ИСПП5РаботяговаААDataSet3BindingSource.DataSource = this.уП01_ИСПП5_Работягова_ААDataSet3;
            this.уП01ИСПП5РаботяговаААDataSet3BindingSource.Position = 0;
            // 
            // уП01_ИСПП5_Работягова_ААDataSet3
            // 
            this.уП01_ИСПП5_Работягова_ААDataSet3.DataSetName = "УП01_ИСПП5_Работягова_ААDataSet3";
            this.уП01_ИСПП5_Работягова_ААDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "Save";
            // 
            // CancelButton
            // 
            this.CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(23, 22);
            this.CancelButton.Text = "Cancel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(171)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДомаDataGridViewTextBoxColumn,
            this.типДомаDataGridViewTextBoxColumn,
            this.этажейВДомеDataGridViewTextBoxColumn,
            this.районГородаDataGridViewTextBoxColumn,
            this.инфраструктураТерриторииDataGridViewTextBoxColumn,
            this.кодФотографииDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.fKДомаФотографииДомовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // кодДомаDataGridViewTextBoxColumn
            // 
            this.кодДомаDataGridViewTextBoxColumn.DataPropertyName = "Код дома";
            this.кодДомаDataGridViewTextBoxColumn.HeaderText = "Код дома";
            this.кодДомаDataGridViewTextBoxColumn.Name = "кодДомаDataGridViewTextBoxColumn";
            this.кодДомаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типДомаDataGridViewTextBoxColumn
            // 
            this.типДомаDataGridViewTextBoxColumn.DataPropertyName = "Тип дома";
            this.типДомаDataGridViewTextBoxColumn.HeaderText = "Тип дома";
            this.типДомаDataGridViewTextBoxColumn.Name = "типДомаDataGridViewTextBoxColumn";
            // 
            // этажейВДомеDataGridViewTextBoxColumn
            // 
            this.этажейВДомеDataGridViewTextBoxColumn.DataPropertyName = "Этажей в доме";
            this.этажейВДомеDataGridViewTextBoxColumn.HeaderText = "Этажей в доме";
            this.этажейВДомеDataGridViewTextBoxColumn.Name = "этажейВДомеDataGridViewTextBoxColumn";
            // 
            // районГородаDataGridViewTextBoxColumn
            // 
            this.районГородаDataGridViewTextBoxColumn.DataPropertyName = "Район города";
            this.районГородаDataGridViewTextBoxColumn.HeaderText = "Район города";
            this.районГородаDataGridViewTextBoxColumn.Name = "районГородаDataGridViewTextBoxColumn";
            // 
            // инфраструктураТерриторииDataGridViewTextBoxColumn
            // 
            this.инфраструктураТерриторииDataGridViewTextBoxColumn.DataPropertyName = "Инфраструктура территории";
            this.инфраструктураТерриторииDataGridViewTextBoxColumn.HeaderText = "Инфраструктура территории";
            this.инфраструктураТерриторииDataGridViewTextBoxColumn.Name = "инфраструктураТерриторииDataGridViewTextBoxColumn";
            // 
            // кодФотографииDataGridViewTextBoxColumn1
            // 
            this.кодФотографииDataGridViewTextBoxColumn1.DataPropertyName = " Код фотографии";
            this.кодФотографииDataGridViewTextBoxColumn1.HeaderText = " Код фотографии";
            this.кодФотографииDataGridViewTextBoxColumn1.Name = "кодФотографииDataGridViewTextBoxColumn1";
            // 
            // fKДомаФотографииДомовBindingSource
            // 
            this.fKДомаФотографииДомовBindingSource.DataMember = "FK_Дома_Фотографии домов";
            this.fKДомаФотографииДомовBindingSource.DataSource = this.фотографииДомовBindingSource;
            // 
            // домаTableAdapter
            // 
            this.домаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(486, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureSet
            // 
            this.pictureSet.Location = new System.Drawing.Point(270, 184);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(198, 178);
            this.pictureSet.TabIndex = 20;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(171)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодФотографииDataGridViewTextBoxColumn,
            this.фотографияЗданияDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.фотографииДомовBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 178);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // кодФотографииDataGridViewTextBoxColumn
            // 
            this.кодФотографииDataGridViewTextBoxColumn.DataPropertyName = "Код фотографии";
            this.кодФотографииDataGridViewTextBoxColumn.HeaderText = "Код фотографии";
            this.кодФотографииDataGridViewTextBoxColumn.Name = "кодФотографииDataGridViewTextBoxColumn";
            // 
            // фотографияЗданияDataGridViewTextBoxColumn
            // 
            this.фотографияЗданияDataGridViewTextBoxColumn.DataPropertyName = "Фотография здания";
            this.фотографияЗданияDataGridViewTextBoxColumn.HeaderText = "Фотография здания";
            this.фотографияЗданияDataGridViewTextBoxColumn.Name = "фотографияЗданияDataGridViewTextBoxColumn";
            // 
            // фотографии_домовTableAdapter
            // 
            this.фотографии_домовTableAdapter.ClearBeforeFill = true;
            // 
            // домаTableAdapter1
            // 
            this.домаTableAdapter1.ClearBeforeFill = true;
            // 
            // фотографии_домовTableAdapter1
            // 
            this.фотографии_домовTableAdapter1.ClearBeforeFill = true;
            // 
            // домаTableAdapter2
            // 
            this.домаTableAdapter2.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button3.Location = new System.Drawing.Point(486, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 30);
            this.button3.TabIndex = 28;
            this.button3.Text = "Найти фото";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(698, 373);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureSet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о домах";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографииДомовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5РаботяговаААDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKДомаФотографииДомовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private УП01_ИСПП5_Работягова_ААDataSet1TableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private УП01_ИСПП5_Работягова_ААDataSet1TableAdapters.ДомаTableAdapter домаTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private УП01_ИСПП5_Работягова_ААDataSet2TableAdapters.Фотографии_домовTableAdapter фотографии_домовTableAdapter;
        private УП01_ИСПП5_Работягова_ААDataSet2TableAdapters.ДомаTableAdapter домаTableAdapter1;
        private System.Windows.Forms.BindingSource уП01ИСПП5РаботяговаААDataSet3BindingSource;
        private УП01_ИСПП5_Работягова_ААDataSet3 уП01_ИСПП5_Работягова_ААDataSet3;
        private УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.Фотографии_домовTableAdapter фотографии_домовTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодФотографииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотографияЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource фотографииДомовBindingSource;
        private System.Windows.Forms.BindingSource fKДомаФотографииДомовBindingSource;
        private УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.ДомаTableAdapter домаTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажейВДомеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районГородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn инфраструктураТерриторииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодФотографииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
    }
}