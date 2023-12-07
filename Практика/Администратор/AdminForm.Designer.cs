namespace Бюро_технической_инвентаризации
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveButtonAdmin = new System.Windows.Forms.Button();
            this.EditButtonAdmin = new System.Windows.Forms.Button();
            this.AddButtonAdmin = new System.Windows.Forms.Button();
            this.RefreshButtonAdmin = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Иванченко_ИВAdminDataSet = new Бюро_технической_инвентаризации.УП01_ИСПП5_Иванченко_ИВAdminDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AdminCancelButton = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Бюро_технической_инвентаризации.УП01_ИСПП5_Иванченко_ИВAdminDataSetTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Иванченко_ИВAdminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RemoveButtonAdmin);
            this.panel1.Controls.Add(this.EditButtonAdmin);
            this.panel1.Controls.Add(this.AddButtonAdmin);
            this.panel1.Controls.Add(this.RefreshButtonAdmin);
            this.panel1.Controls.Add(this.UsersDataGrid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.AdminCancelButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 426);
            this.panel1.TabIndex = 13;
            // 
            // RemoveButtonAdmin
            // 
            this.RemoveButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButtonAdmin.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Очистка;
            this.RemoveButtonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveButtonAdmin.FlatAppearance.BorderSize = 0;
            this.RemoveButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButtonAdmin.Location = new System.Drawing.Point(927, 29);
            this.RemoveButtonAdmin.Name = "RemoveButtonAdmin";
            this.RemoveButtonAdmin.Size = new System.Drawing.Size(34, 39);
            this.RemoveButtonAdmin.TabIndex = 31;
            this.RemoveButtonAdmin.UseVisualStyleBackColor = false;
            this.RemoveButtonAdmin.Click += new System.EventHandler(this.RemoveButtonAdmin_Click);
            // 
            // EditButtonAdmin
            // 
            this.EditButtonAdmin.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Редактирование;
            this.EditButtonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButtonAdmin.FlatAppearance.BorderSize = 0;
            this.EditButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.EditButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButtonAdmin.Location = new System.Drawing.Point(887, 29);
            this.EditButtonAdmin.Name = "EditButtonAdmin";
            this.EditButtonAdmin.Size = new System.Drawing.Size(34, 39);
            this.EditButtonAdmin.TabIndex = 30;
            this.EditButtonAdmin.UseVisualStyleBackColor = true;
            this.EditButtonAdmin.Click += new System.EventHandler(this.EditButtonAdmin_Click);
            // 
            // AddButtonAdmin
            // 
            this.AddButtonAdmin.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Добавить;
            this.AddButtonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButtonAdmin.FlatAppearance.BorderSize = 0;
            this.AddButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButtonAdmin.Location = new System.Drawing.Point(836, 26);
            this.AddButtonAdmin.Name = "AddButtonAdmin";
            this.AddButtonAdmin.Size = new System.Drawing.Size(45, 45);
            this.AddButtonAdmin.TabIndex = 29;
            this.AddButtonAdmin.UseVisualStyleBackColor = true;
            this.AddButtonAdmin.Click += new System.EventHandler(this.AddButtonAdmin_Click);
            // 
            // RefreshButtonAdmin
            // 
            this.RefreshButtonAdmin.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Обновление;
            this.RefreshButtonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButtonAdmin.FlatAppearance.BorderSize = 0;
            this.RefreshButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RefreshButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButtonAdmin.Location = new System.Drawing.Point(795, 26);
            this.RefreshButtonAdmin.Name = "RefreshButtonAdmin";
            this.RefreshButtonAdmin.Size = new System.Drawing.Size(45, 45);
            this.RefreshButtonAdmin.TabIndex = 28;
            this.RefreshButtonAdmin.UseVisualStyleBackColor = true;
            this.RefreshButtonAdmin.Click += new System.EventHandler(this.RefreshButtonAdmin_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AutoGenerateColumns = false;
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UsersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rightsDataGridViewTextBoxColumn,
            this.famnamDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.UsersDataGrid.DataSource = this.usersBindingSource;
            this.UsersDataGrid.Location = new System.Drawing.Point(3, 83);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.RowHeadersWidth = 51;
            this.UsersDataGrid.RowTemplate.Height = 24;
            this.UsersDataGrid.Size = new System.Drawing.Size(976, 281);
            this.UsersDataGrid.TabIndex = 27;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "ID Пользователя";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 75;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 85;
            // 
            // rightsDataGridViewTextBoxColumn
            // 
            this.rightsDataGridViewTextBoxColumn.DataPropertyName = "Rights";
            this.rightsDataGridViewTextBoxColumn.HeaderText = "Права";
            this.rightsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rightsDataGridViewTextBoxColumn.Name = "rightsDataGridViewTextBoxColumn";
            this.rightsDataGridViewTextBoxColumn.Width = 78;
            // 
            // famnamDataGridViewTextBoxColumn
            // 
            this.famnamDataGridViewTextBoxColumn.DataPropertyName = "Famnam";
            this.famnamDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.famnamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.famnamDataGridViewTextBoxColumn.Name = "famnamDataGridViewTextBoxColumn";
            this.famnamDataGridViewTextBoxColumn.Width = 95;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 62;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 99;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 136;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource;
            // 
            // уП01ИСПП5ИванченкоИВAdminDataSetBindingSource
            // 
            this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource.DataSource = this.уП01_ИСПП5_Иванченко_ИВAdminDataSet;
            this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource.Position = 0;
            // 
            // уП01_ИСПП5_Иванченко_ИВAdminDataSet
            // 
            this.уП01_ИСПП5_Иванченко_ИВAdminDataSet.DataSetName = "УП01_ИСПП5_Иванченко_ИВAdminDataSet";
            this.уП01_ИСПП5_Иванченко_ИВAdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Бюро_технической_инвентаризации.Properties.Resources.БТИ;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(82, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Пользователи";
            // 
            // AdminCancelButton
            // 
            this.AdminCancelButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AdminCancelButton.FlatAppearance.BorderSize = 0;
            this.AdminCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminCancelButton.ForeColor = System.Drawing.Color.Transparent;
            this.AdminCancelButton.Location = new System.Drawing.Point(36, 380);
            this.AdminCancelButton.Name = "AdminCancelButton";
            this.AdminCancelButton.Size = new System.Drawing.Size(96, 25);
            this.AdminCancelButton.TabIndex = 2;
            this.AdminCancelButton.Text = "Отмена";
            this.AdminCancelButton.UseVisualStyleBackColor = false;
            this.AdminCancelButton.Click += new System.EventHandler(this.AdminCancelButton_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01ИСПП5ИванченкоИВAdminDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Иванченко_ИВAdminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AdminCancelButton;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.BindingSource уП01ИСПП5ИванченкоИВAdminDataSetBindingSource;
        private УП01_ИСПП5_Иванченко_ИВAdminDataSet уП01_ИСПП5_Иванченко_ИВAdminDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private УП01_ИСПП5_Иванченко_ИВAdminDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button RemoveButtonAdmin;
        public System.Windows.Forms.Button EditButtonAdmin;
        public System.Windows.Forms.Button AddButtonAdmin;
        private System.Windows.Forms.Button RefreshButtonAdmin;
    }
}