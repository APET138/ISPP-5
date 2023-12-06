namespace WindowsFormsApp5
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.б_АЮ_Учебная_ПрактикаDataSet = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.UsersTableAdapter();
            this.Пользователи = new System.Windows.Forms.Button();
            this.Здания = new System.Windows.Forms.Button();
            this.Помещения = new System.Windows.Forms.Button();
            this.СоставнаяЧасть = new System.Windows.Forms.Button();
            this.Выход = new System.Windows.Forms.Button();
            this.Отделка = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // б_АЮ_Учебная_ПрактикаDataSet
            // 
            this.б_АЮ_Учебная_ПрактикаDataSet.DataSetName = "Б_АЮ_Учебная_ПрактикаDataSet";
            this.б_АЮ_Учебная_ПрактикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Пользователи
            // 
            this.Пользователи.BackColor = System.Drawing.Color.Aquamarine;
            this.Пользователи.Location = new System.Drawing.Point(13, 23);
            this.Пользователи.Name = "Пользователи";
            this.Пользователи.Size = new System.Drawing.Size(235, 23);
            this.Пользователи.TabIndex = 0;
            this.Пользователи.Text = "Пользователи";
            this.Пользователи.UseVisualStyleBackColor = false;
            this.Пользователи.Click += new System.EventHandler(this.Пользователи_Click);
            // 
            // Здания
            // 
            this.Здания.BackColor = System.Drawing.Color.Aquamarine;
            this.Здания.Location = new System.Drawing.Point(12, 64);
            this.Здания.Name = "Здания";
            this.Здания.Size = new System.Drawing.Size(235, 23);
            this.Здания.TabIndex = 1;
            this.Здания.Text = "Здание";
            this.Здания.UseVisualStyleBackColor = false;
            this.Здания.Click += new System.EventHandler(this.Здания_Click);
            // 
            // Помещения
            // 
            this.Помещения.BackColor = System.Drawing.Color.Aquamarine;
            this.Помещения.Location = new System.Drawing.Point(13, 112);
            this.Помещения.Name = "Помещения";
            this.Помещения.Size = new System.Drawing.Size(235, 23);
            this.Помещения.TabIndex = 2;
            this.Помещения.Text = "Помещение";
            this.Помещения.UseVisualStyleBackColor = false;
            this.Помещения.Click += new System.EventHandler(this.Помещения_Click);
            // 
            // СоставнаяЧасть
            // 
            this.СоставнаяЧасть.BackColor = System.Drawing.Color.Aquamarine;
            this.СоставнаяЧасть.Location = new System.Drawing.Point(13, 157);
            this.СоставнаяЧасть.Name = "СоставнаяЧасть";
            this.СоставнаяЧасть.Size = new System.Drawing.Size(235, 23);
            this.СоставнаяЧасть.TabIndex = 3;
            this.СоставнаяЧасть.Text = "Составная часть помещения";
            this.СоставнаяЧасть.UseVisualStyleBackColor = false;
            this.СоставнаяЧасть.Click += new System.EventHandler(this.СоставнаяЧасть_Click);
            // 
            // Выход
            // 
            this.Выход.BackColor = System.Drawing.Color.Aquamarine;
            this.Выход.Location = new System.Drawing.Point(12, 234);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(235, 23);
            this.Выход.TabIndex = 4;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = false;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // Отделка
            // 
            this.Отделка.BackColor = System.Drawing.Color.Aquamarine;
            this.Отделка.Location = new System.Drawing.Point(12, 196);
            this.Отделка.Name = "Отделка";
            this.Отделка.Size = new System.Drawing.Size(235, 23);
            this.Отделка.TabIndex = 5;
            this.Отделка.Text = "Отделка";
            this.Отделка.UseVisualStyleBackColor = false;
            this.Отделка.Click += new System.EventHandler(this.Отделка_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(260, 312);
            this.Controls.Add(this.Отделка);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.СоставнаяЧасть);
            this.Controls.Add(this.Помещения);
            this.Controls.Add(this.Здания);
            this.Controls.Add(this.Пользователи);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Б_АЮ_Учебная_ПрактикаDataSet б_АЮ_Учебная_ПрактикаDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Б_АЮ_Учебная_ПрактикаDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button Пользователи;
        private System.Windows.Forms.Button Здания;
        private System.Windows.Forms.Button Помещения;
        private System.Windows.Forms.Button СоставнаяЧасть;
        private System.Windows.Forms.Button Выход;
        private System.Windows.Forms.Button Отделка;
    }
}