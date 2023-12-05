namespace УП_МДК_01_01
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureSet = new System.Windows.Forms.PictureBox();
            this.планКвартирBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.уП01ИСПП5РаботяговаААDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Работягова_ААDataSet3 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.кодКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документНаПравоСобственностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеПриватизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяПлощадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типПланировкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типСанузлаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жилаяПлощадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьКухниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПланаКвартирыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKКвартирыПланКвартирBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодПланаКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.планКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.план_квартирTableAdapter1 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.План_квартирTableAdapter();
            this.fKКвартирыПланКвартирBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квартирыTableAdapter2 = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.КвартирыTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.планКвартирBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5РаботяговаААDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКвартирыПланКвартирBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКвартирыПланКвартирBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(501, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button2.Location = new System.Drawing.Point(501, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Вернуться в меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureSet
            // 
            this.pictureSet.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.планКвартирBindingSource1, "План квартиры", true));
            this.pictureSet.Location = new System.Drawing.Point(297, 184);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(198, 178);
            this.pictureSet.TabIndex = 13;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
            // 
            // планКвартирBindingSource1
            // 
            this.планКвартирBindingSource1.DataMember = "План квартир";
            this.планКвартирBindingSource1.DataSource = this.уП01ИСПП5РаботяговаААDataSet3BindingSource;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.bindingNavigator1.BindingSource = this.планКвартирBindingSource1;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(712, 25);
            this.bindingNavigator1.TabIndex = 21;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Txt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(62, 22);
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
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
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
            this.кодКвартирыDataGridViewTextBoxColumn,
            this.кодДомаDataGridViewTextBoxColumn,
            this.документНаПравоСобственностиDataGridViewTextBoxColumn,
            this.наличиеПриватизацииDataGridViewTextBoxColumn,
            this.общаяПлощадьDataGridViewTextBoxColumn,
            this.этажКвартирыDataGridViewTextBoxColumn,
            this.типПланировкиDataGridViewTextBoxColumn,
            this.типСанузлаDataGridViewTextBoxColumn,
            this.адресКвартирыDataGridViewTextBoxColumn,
            this.жилаяПлощадьDataGridViewTextBoxColumn,
            this.площадьКухниDataGridViewTextBoxColumn,
            this.кодПланаКвартирыDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.fKКвартирыПланКвартирBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // кодКвартирыDataGridViewTextBoxColumn
            // 
            this.кодКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.HeaderText = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.Name = "кодКвартирыDataGridViewTextBoxColumn";
            // 
            // кодДомаDataGridViewTextBoxColumn
            // 
            this.кодДомаDataGridViewTextBoxColumn.DataPropertyName = "Код дома";
            this.кодДомаDataGridViewTextBoxColumn.HeaderText = "Код дома";
            this.кодДомаDataGridViewTextBoxColumn.Name = "кодДомаDataGridViewTextBoxColumn";
            // 
            // документНаПравоСобственностиDataGridViewTextBoxColumn
            // 
            this.документНаПравоСобственностиDataGridViewTextBoxColumn.DataPropertyName = "Документ на право собственности";
            this.документНаПравоСобственностиDataGridViewTextBoxColumn.HeaderText = "Документ на право собственности";
            this.документНаПравоСобственностиDataGridViewTextBoxColumn.Name = "документНаПравоСобственностиDataGridViewTextBoxColumn";
            // 
            // наличиеПриватизацииDataGridViewTextBoxColumn
            // 
            this.наличиеПриватизацииDataGridViewTextBoxColumn.DataPropertyName = "Наличие приватизации";
            this.наличиеПриватизацииDataGridViewTextBoxColumn.HeaderText = "Наличие приватизации";
            this.наличиеПриватизацииDataGridViewTextBoxColumn.Name = "наличиеПриватизацииDataGridViewTextBoxColumn";
            // 
            // общаяПлощадьDataGridViewTextBoxColumn
            // 
            this.общаяПлощадьDataGridViewTextBoxColumn.DataPropertyName = "Общая площадь";
            this.общаяПлощадьDataGridViewTextBoxColumn.HeaderText = "Общая площадь";
            this.общаяПлощадьDataGridViewTextBoxColumn.Name = "общаяПлощадьDataGridViewTextBoxColumn";
            // 
            // этажКвартирыDataGridViewTextBoxColumn
            // 
            this.этажКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Этаж квартиры";
            this.этажКвартирыDataGridViewTextBoxColumn.HeaderText = "Этаж квартиры";
            this.этажКвартирыDataGridViewTextBoxColumn.Name = "этажКвартирыDataGridViewTextBoxColumn";
            // 
            // типПланировкиDataGridViewTextBoxColumn
            // 
            this.типПланировкиDataGridViewTextBoxColumn.DataPropertyName = "Тип планировки";
            this.типПланировкиDataGridViewTextBoxColumn.HeaderText = "Тип планировки";
            this.типПланировкиDataGridViewTextBoxColumn.Name = "типПланировкиDataGridViewTextBoxColumn";
            // 
            // типСанузлаDataGridViewTextBoxColumn
            // 
            this.типСанузлаDataGridViewTextBoxColumn.DataPropertyName = "Тип санузла";
            this.типСанузлаDataGridViewTextBoxColumn.HeaderText = "Тип санузла";
            this.типСанузлаDataGridViewTextBoxColumn.Name = "типСанузлаDataGridViewTextBoxColumn";
            // 
            // адресКвартирыDataGridViewTextBoxColumn
            // 
            this.адресКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Адрес квартиры";
            this.адресКвартирыDataGridViewTextBoxColumn.HeaderText = "Адрес квартиры";
            this.адресКвартирыDataGridViewTextBoxColumn.Name = "адресКвартирыDataGridViewTextBoxColumn";
            // 
            // жилаяПлощадьDataGridViewTextBoxColumn
            // 
            this.жилаяПлощадьDataGridViewTextBoxColumn.DataPropertyName = "Жилая площадь";
            this.жилаяПлощадьDataGridViewTextBoxColumn.HeaderText = "Жилая площадь";
            this.жилаяПлощадьDataGridViewTextBoxColumn.Name = "жилаяПлощадьDataGridViewTextBoxColumn";
            // 
            // площадьКухниDataGridViewTextBoxColumn
            // 
            this.площадьКухниDataGridViewTextBoxColumn.DataPropertyName = "Площадь кухни";
            this.площадьКухниDataGridViewTextBoxColumn.HeaderText = "Площадь кухни";
            this.площадьКухниDataGridViewTextBoxColumn.Name = "площадьКухниDataGridViewTextBoxColumn";
            // 
            // кодПланаКвартирыDataGridViewTextBoxColumn1
            // 
            this.кодПланаКвартирыDataGridViewTextBoxColumn1.DataPropertyName = " Код плана квартиры";
            this.кодПланаКвартирыDataGridViewTextBoxColumn1.HeaderText = " Код плана квартиры";
            this.кодПланаКвартирыDataGridViewTextBoxColumn1.Name = "кодПланаКвартирыDataGridViewTextBoxColumn1";
            // 
            // fKКвартирыПланКвартирBindingSource1
            // 
            this.fKКвартирыПланКвартирBindingSource1.DataMember = "FK_Квартиры_План квартир";
            this.fKКвартирыПланКвартирBindingSource1.DataSource = this.планКвартирBindingSource1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(171)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПланаКвартирыDataGridViewTextBoxColumn,
            this.планКвартирыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.планКвартирBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(264, 178);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // кодПланаКвартирыDataGridViewTextBoxColumn
            // 
            this.кодПланаКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Код плана квартиры";
            this.кодПланаКвартирыDataGridViewTextBoxColumn.HeaderText = "Код плана квартиры";
            this.кодПланаКвартирыDataGridViewTextBoxColumn.Name = "кодПланаКвартирыDataGridViewTextBoxColumn";
            this.кодПланаКвартирыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // планКвартирыDataGridViewTextBoxColumn
            // 
            this.планКвартирыDataGridViewTextBoxColumn.DataPropertyName = "План квартиры";
            this.планКвартирыDataGridViewTextBoxColumn.HeaderText = "План квартиры";
            this.планКвартирыDataGridViewTextBoxColumn.Name = "планКвартирыDataGridViewTextBoxColumn";
            this.планКвартирыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // план_квартирTableAdapter1
            // 
            this.план_квартирTableAdapter1.ClearBeforeFill = true;
            // 
            // квартирыTableAdapter2
            // 
            this.квартирыTableAdapter2.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.button3.Location = new System.Drawing.Point(501, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Найти фото";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(712, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureSet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Данные о квартирах";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.планКвартирBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5РаботяговаААDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКвартирыПланКвартирBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKКвартирыПланКвартирBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureSet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource уП01ИСПП5РаботяговаААDataSet3BindingSource;
        private УП01_ИСПП5_Работягова_ААDataSet3 уП01_ИСПП5_Работягова_ААDataSet3;
        private System.Windows.Forms.BindingSource планКвартирBindingSource1;
        private УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.План_квартирTableAdapter план_квартирTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПланаКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn планКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKКвартирыПланКвартирBindingSource;
        private System.Windows.Forms.BindingSource fKКвартирыПланКвартирBindingSource1;
        private УП01_ИСПП5_Работягова_ААDataSet3TableAdapters.КвартирыTableAdapter квартирыTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документНаПравоСобственностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеПриватизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяПлощадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПланировкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типСанузлаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жилаяПлощадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьКухниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПланаКвартирыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
    }
}