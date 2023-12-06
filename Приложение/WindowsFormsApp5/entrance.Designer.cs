namespace WindowsFormsApp5
{
    partial class entrance
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entrance));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.б_АЮ_Учебная_ПрактикаDataSet = new WindowsFormsApp5.Б_АЮ_Учебная_ПрактикаDataSet();
            this.Вход = new System.Windows.Forms.Button();
            this.Выйти = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.СкрытьПароль = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.б_АЮ_Учебная_ПрактикаDataSet;
            this.bindingSource1.Position = 0;
            // 
            // б_АЮ_Учебная_ПрактикаDataSet
            // 
            this.б_АЮ_Учебная_ПрактикаDataSet.DataSetName = "Б_АЮ_Учебная_ПрактикаDataSet";
            this.б_АЮ_Учебная_ПрактикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Вход
            // 
            this.Вход.BackColor = System.Drawing.Color.Aquamarine;
            this.Вход.ForeColor = System.Drawing.Color.Black;
            this.Вход.Location = new System.Drawing.Point(30, 172);
            this.Вход.Name = "Вход";
            this.Вход.Size = new System.Drawing.Size(75, 23);
            this.Вход.TabIndex = 0;
            this.Вход.Text = "Войти";
            this.Вход.UseVisualStyleBackColor = false;
            this.Вход.Click += new System.EventHandler(this.Вход_Click_1);
            // 
            // Выйти
            // 
            this.Выйти.BackColor = System.Drawing.Color.Aquamarine;
            this.Выйти.ForeColor = System.Drawing.Color.Black;
            this.Выйти.Location = new System.Drawing.Point(143, 172);
            this.Выйти.Name = "Выйти";
            this.Выйти.Size = new System.Drawing.Size(75, 23);
            this.Выйти.TabIndex = 1;
            this.Выйти.Text = "Выйти";
            this.Выйти.UseVisualStyleBackColor = false;
            this.Выйти.Click += new System.EventHandler(this.Выйти_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // СкрытьПароль
            // 
            this.СкрытьПароль.AutoSize = true;
            this.СкрытьПароль.BackColor = System.Drawing.Color.Transparent;
            this.СкрытьПароль.Location = new System.Drawing.Point(121, 108);
            this.СкрытьПароль.Name = "СкрытьПароль";
            this.СкрытьПароль.Size = new System.Drawing.Size(80, 17);
            this.СкрытьПароль.TabIndex = 6;
            this.СкрытьПароль.Text = "checkBox1";
            this.СкрытьПароль.UseVisualStyleBackColor = false;
            this.СкрытьПароль.CheckedChanged += new System.EventHandler(this.СкрытьПароль_CheckedChanged);
            // 
            // entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(250, 241);
            this.Controls.Add(this.СкрытьПароль);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Выйти);
            this.Controls.Add(this.Вход);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "entrance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.entrance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.б_АЮ_Учебная_ПрактикаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Б_АЮ_Учебная_ПрактикаDataSet б_АЮ_Учебная_ПрактикаDataSet;
        private System.Windows.Forms.Button Вход;
        private System.Windows.Forms.Button Выйти;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox СкрытьПароль;
    }
}

