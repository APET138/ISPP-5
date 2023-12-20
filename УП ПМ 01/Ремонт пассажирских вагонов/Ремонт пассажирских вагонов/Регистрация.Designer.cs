namespace Ремонт_пассажирских_вагонов
{
    partial class Регистрация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Регистрация));
            this.Фон = new System.Windows.Forms.Panel();
            this.Выйти = new System.Windows.Forms.PictureBox();
            this.Регистрация_label = new System.Windows.Forms.Label();
            this.Подтвердить = new System.Windows.Forms.Button();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Пароль_label = new System.Windows.Forms.Label();
            this.Почта = new System.Windows.Forms.TextBox();
            this.Почта_label = new System.Windows.Forms.Label();
            this.Логин = new System.Windows.Forms.TextBox();
            this.Логин_label = new System.Windows.Forms.Label();
            this.Фон.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).BeginInit();
            this.SuspendLayout();
            // 
            // Фон
            // 
            this.Фон.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон.Controls.Add(this.Выйти);
            this.Фон.Controls.Add(this.Регистрация_label);
            this.Фон.Controls.Add(this.Подтвердить);
            this.Фон.Controls.Add(this.Пароль);
            this.Фон.Controls.Add(this.Пароль_label);
            this.Фон.Controls.Add(this.Почта);
            this.Фон.Controls.Add(this.Почта_label);
            this.Фон.Controls.Add(this.Логин);
            this.Фон.Controls.Add(this.Логин_label);
            this.Фон.Location = new System.Drawing.Point(12, 12);
            this.Фон.Name = "Фон";
            this.Фон.Size = new System.Drawing.Size(200, 267);
            this.Фон.TabIndex = 11;
            // 
            // Выйти
            // 
            this.Выйти.Image = ((System.Drawing.Image)(resources.GetObject("Выйти.Image")));
            this.Выйти.Location = new System.Drawing.Point(176, 0);
            this.Выйти.Name = "Выйти";
            this.Выйти.Size = new System.Drawing.Size(24, 24);
            this.Выйти.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Выйти.TabIndex = 25;
            this.Выйти.TabStop = false;
            this.Выйти.Click += new System.EventHandler(this.Выйти_Click);
            // 
            // Регистрация_label
            // 
            this.Регистрация_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Регистрация_label.ForeColor = System.Drawing.Color.White;
            this.Регистрация_label.Location = new System.Drawing.Point(36, 10);
            this.Регистрация_label.Name = "Регистрация_label";
            this.Регистрация_label.Size = new System.Drawing.Size(129, 39);
            this.Регистрация_label.TabIndex = 23;
            this.Регистрация_label.Text = "Регистрация";
            this.Регистрация_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Подтвердить
            // 
            this.Подтвердить.BackColor = System.Drawing.Color.White;
            this.Подтвердить.FlatAppearance.BorderSize = 0;
            this.Подтвердить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Подтвердить.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Подтвердить.Location = new System.Drawing.Point(50, 203);
            this.Подтвердить.Name = "Подтвердить";
            this.Подтвердить.Size = new System.Drawing.Size(100, 30);
            this.Подтвердить.TabIndex = 19;
            this.Подтвердить.Text = "Подтвердить";
            this.Подтвердить.UseVisualStyleBackColor = false;
            this.Подтвердить.Click += new System.EventHandler(this.Подтвердить_Click);
            // 
            // Пароль
            // 
            this.Пароль.BackColor = System.Drawing.Color.White;
            this.Пароль.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Пароль.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Пароль.Location = new System.Drawing.Point(36, 161);
            this.Пароль.Multiline = true;
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(129, 20);
            this.Пароль.TabIndex = 18;
            this.Пароль.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Пароль_KeyPress);
            // 
            // Пароль_label
            // 
            this.Пароль_label.AutoSize = true;
            this.Пароль_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Пароль_label.ForeColor = System.Drawing.Color.White;
            this.Пароль_label.Location = new System.Drawing.Point(33, 141);
            this.Пароль_label.Name = "Пароль_label";
            this.Пароль_label.Size = new System.Drawing.Size(55, 16);
            this.Пароль_label.TabIndex = 17;
            this.Пароль_label.Text = "Пароль:";
            // 
            // Почта
            // 
            this.Почта.BackColor = System.Drawing.Color.White;
            this.Почта.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Почта.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Почта.Location = new System.Drawing.Point(36, 74);
            this.Почта.Multiline = true;
            this.Почта.Name = "Почта";
            this.Почта.Size = new System.Drawing.Size(129, 20);
            this.Почта.TabIndex = 16;
            this.Почта.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Почта_KeyPress);
            // 
            // Почта_label
            // 
            this.Почта_label.AutoSize = true;
            this.Почта_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Почта_label.ForeColor = System.Drawing.Color.White;
            this.Почта_label.Location = new System.Drawing.Point(33, 54);
            this.Почта_label.Name = "Почта_label";
            this.Почта_label.Size = new System.Drawing.Size(46, 16);
            this.Почта_label.TabIndex = 15;
            this.Почта_label.Text = "Почта:";
            // 
            // Логин
            // 
            this.Логин.BackColor = System.Drawing.Color.White;
            this.Логин.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Логин.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Логин.Location = new System.Drawing.Point(36, 117);
            this.Логин.Multiline = true;
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(129, 20);
            this.Логин.TabIndex = 14;
            this.Логин.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Логин_KeyPress);
            // 
            // Логин_label
            // 
            this.Логин_label.AutoSize = true;
            this.Логин_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Логин_label.ForeColor = System.Drawing.Color.White;
            this.Логин_label.Location = new System.Drawing.Point(33, 97);
            this.Логин_label.Name = "Логин_label";
            this.Логин_label.Size = new System.Drawing.Size(46, 16);
            this.Логин_label.TabIndex = 12;
            this.Логин_label.Text = "Логин:";
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(224, 291);
            this.Controls.Add(this.Фон);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Регистрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт пассажирских вагонов";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseMove);
            this.Фон.ResumeLayout(false);
            this.Фон.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Фон;
        private System.Windows.Forms.TextBox Почта;
        private System.Windows.Forms.Label Почта_label;
        private System.Windows.Forms.TextBox Логин;
        private System.Windows.Forms.Label Логин_label;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.Label Пароль_label;
        private System.Windows.Forms.Button Подтвердить;
        private System.Windows.Forms.Label Регистрация_label;
        private System.Windows.Forms.PictureBox Выйти;
    }
}