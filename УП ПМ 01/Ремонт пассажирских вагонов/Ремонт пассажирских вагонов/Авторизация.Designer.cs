namespace Ремонт_пассажирских_вагонов
{
    partial class Авторизация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.Фон = new System.Windows.Forms.Panel();
            this.Выйти = new System.Windows.Forms.PictureBox();
            this.Авторизация_label = new System.Windows.Forms.Label();
            this.Показать_Пароль = new System.Windows.Forms.Button();
            this.Войти_Как_Гость = new System.Windows.Forms.Button();
            this.Регистрация = new System.Windows.Forms.Button();
            this.Войти = new System.Windows.Forms.Button();
            this.Логин = new System.Windows.Forms.TextBox();
            this.Логин_label = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Пароль_label = new System.Windows.Forms.Label();
            this.Фон.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).BeginInit();
            this.SuspendLayout();
            // 
            // Фон
            // 
            this.Фон.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Фон.Controls.Add(this.Выйти);
            this.Фон.Controls.Add(this.Авторизация_label);
            this.Фон.Controls.Add(this.Показать_Пароль);
            this.Фон.Controls.Add(this.Войти_Как_Гость);
            this.Фон.Controls.Add(this.Регистрация);
            this.Фон.Controls.Add(this.Войти);
            this.Фон.Controls.Add(this.Логин);
            this.Фон.Controls.Add(this.Логин_label);
            this.Фон.Controls.Add(this.Пароль);
            this.Фон.Controls.Add(this.Пароль_label);
            this.Фон.Location = new System.Drawing.Point(12, 12);
            this.Фон.Name = "Фон";
            this.Фон.Size = new System.Drawing.Size(200, 267);
            this.Фон.TabIndex = 10;
            // 
            // Выйти
            // 
            this.Выйти.Image = ((System.Drawing.Image)(resources.GetObject("Выйти.Image")));
            this.Выйти.Location = new System.Drawing.Point(176, 0);
            this.Выйти.Name = "Выйти";
            this.Выйти.Size = new System.Drawing.Size(24, 24);
            this.Выйти.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Выйти.TabIndex = 24;
            this.Выйти.TabStop = false;
            this.Выйти.Click += new System.EventHandler(this.Выйти_Click);
            // 
            // Авторизация_label
            // 
            this.Авторизация_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация_label.ForeColor = System.Drawing.Color.White;
            this.Авторизация_label.Location = new System.Drawing.Point(36, 10);
            this.Авторизация_label.Name = "Авторизация_label";
            this.Авторизация_label.Size = new System.Drawing.Size(129, 39);
            this.Авторизация_label.TabIndex = 22;
            this.Авторизация_label.Text = "Авторизация";
            this.Авторизация_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Показать_Пароль
            // 
            this.Показать_Пароль.BackColor = System.Drawing.Color.White;
            this.Показать_Пароль.FlatAppearance.BorderSize = 0;
            this.Показать_Пароль.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Показать_Пароль.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Показать_Пароль.Location = new System.Drawing.Point(36, 143);
            this.Показать_Пароль.Name = "Показать_Пароль";
            this.Показать_Пароль.Size = new System.Drawing.Size(129, 25);
            this.Показать_Пароль.TabIndex = 21;
            this.Показать_Пароль.Text = "Показать пароль";
            this.Показать_Пароль.UseVisualStyleBackColor = false;
            this.Показать_Пароль.Click += new System.EventHandler(this.Показать_Пароль_Click);
            // 
            // Войти_Как_Гость
            // 
            this.Войти_Как_Гость.BackColor = System.Drawing.Color.White;
            this.Войти_Как_Гость.FlatAppearance.BorderSize = 0;
            this.Войти_Как_Гость.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Войти_Как_Гость.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Войти_Как_Гость.Location = new System.Drawing.Point(8, 222);
            this.Войти_Как_Гость.Name = "Войти_Как_Гость";
            this.Войти_Как_Гость.Size = new System.Drawing.Size(184, 30);
            this.Войти_Как_Гость.TabIndex = 20;
            this.Войти_Как_Гость.Text = "Войти как гость";
            this.Войти_Как_Гость.UseVisualStyleBackColor = false;
            this.Войти_Как_Гость.Click += new System.EventHandler(this.Войти_Как_Гость_Click);
            // 
            // Регистрация
            // 
            this.Регистрация.BackColor = System.Drawing.Color.White;
            this.Регистрация.FlatAppearance.BorderSize = 0;
            this.Регистрация.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Регистрация.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Регистрация.Location = new System.Drawing.Point(102, 186);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(90, 30);
            this.Регистрация.TabIndex = 19;
            this.Регистрация.Text = "Регистрация";
            this.Регистрация.UseVisualStyleBackColor = false;
            this.Регистрация.Click += new System.EventHandler(this.Регистрация_Click);
            // 
            // Войти
            // 
            this.Войти.BackColor = System.Drawing.Color.White;
            this.Войти.FlatAppearance.BorderSize = 0;
            this.Войти.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Войти.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Войти.Location = new System.Drawing.Point(8, 186);
            this.Войти.Name = "Войти";
            this.Войти.Size = new System.Drawing.Size(90, 30);
            this.Войти.TabIndex = 18;
            this.Войти.Text = "Войти";
            this.Войти.UseVisualStyleBackColor = false;
            this.Войти.Click += new System.EventHandler(this.Войти_Click);
            // 
            // Логин
            // 
            this.Логин.BackColor = System.Drawing.Color.White;
            this.Логин.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Логин.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.Location = new System.Drawing.Point(36, 74);
            this.Логин.Multiline = true;
            this.Логин.Name = "Логин";
            this.Логин.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Логин.Size = new System.Drawing.Size(129, 20);
            this.Логин.TabIndex = 16;
            this.Логин.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Логин_KeyPress);
            // 
            // Логин_label
            // 
            this.Логин_label.AutoSize = true;
            this.Логин_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Логин_label.ForeColor = System.Drawing.Color.White;
            this.Логин_label.Location = new System.Drawing.Point(33, 54);
            this.Логин_label.Name = "Логин_label";
            this.Логин_label.Size = new System.Drawing.Size(46, 16);
            this.Логин_label.TabIndex = 15;
            this.Логин_label.Text = "Логин:";
            // 
            // Пароль
            // 
            this.Пароль.BackColor = System.Drawing.Color.White;
            this.Пароль.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Пароль.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(36, 117);
            this.Пароль.Multiline = true;
            this.Пароль.Name = "Пароль";
            this.Пароль.PasswordChar = '*';
            this.Пароль.Size = new System.Drawing.Size(129, 20);
            this.Пароль.TabIndex = 14;
            this.Пароль.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Пароль_KeyPress);
            // 
            // Пароль_label
            // 
            this.Пароль_label.AutoSize = true;
            this.Пароль_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Пароль_label.ForeColor = System.Drawing.Color.White;
            this.Пароль_label.Location = new System.Drawing.Point(33, 97);
            this.Пароль_label.Name = "Пароль_label";
            this.Пароль_label.Size = new System.Drawing.Size(55, 16);
            this.Пароль_label.TabIndex = 12;
            this.Пароль_label.Text = "Пароль:";
            // 
            // Авторизация
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
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт пассажирских вагонов";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Авторизация_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Авторизация_MouseMove);
            this.Фон.ResumeLayout(false);
            this.Фон.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Фон;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.Label Пароль_label;
        private System.Windows.Forms.TextBox Логин;
        private System.Windows.Forms.Label Логин_label;
        private System.Windows.Forms.Button Войти_Как_Гость;
        private System.Windows.Forms.Button Регистрация;
        private System.Windows.Forms.Button Войти;
        private System.Windows.Forms.Button Показать_Пароль;
        private System.Windows.Forms.Label Авторизация_label;
        private System.Windows.Forms.PictureBox Выйти;
    }
}

