﻿namespace УП01_ИСПП5_Швидко_ИА
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
            this.Логин_textBox5 = new System.Windows.Forms.TextBox();
            this.Логин_label7 = new System.Windows.Forms.Label();
            this.Пароль_textBox4 = new System.Windows.Forms.TextBox();
            this.Пароль_label8 = new System.Windows.Forms.Label();
            this.Подтвердить_roundBtn1 = new Ремонт_пассажирских_вагонов.RoundBtn();
            this.Вернуться_roundBtn2 = new Ремонт_пассажирских_вагонов.RoundBtn();
            this.Фон_panel1 = new System.Windows.Forms.Panel();
            this.Почта_label3 = new System.Windows.Forms.Label();
            this.Почта_textBox2 = new System.Windows.Forms.TextBox();
            this.Регистрация_label1 = new System.Windows.Forms.Label();
            this.Выйти_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Фон_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.Логин_textBox5.Location = new System.Drawing.Point(142, 5);
            this.Логин_textBox5.Name = "textBox5";
            this.Логин_textBox5.Size = new System.Drawing.Size(153, 20);
            this.Логин_textBox5.TabIndex = 17;
            // 
            // label7
            // 
            this.Логин_label7.AutoSize = true;
            this.Логин_label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Логин_label7.Location = new System.Drawing.Point(10, 6);
            this.Логин_label7.Name = "label7";
            this.Логин_label7.Size = new System.Drawing.Size(46, 16);
            this.Логин_label7.TabIndex = 18;
            this.Логин_label7.Text = "Логин";
            // 
            // textBox4
            // 
            this.Пароль_textBox4.Location = new System.Drawing.Point(142, 41);
            this.Пароль_textBox4.Name = "textBox4";
            this.Пароль_textBox4.Size = new System.Drawing.Size(153, 20);
            this.Пароль_textBox4.TabIndex = 20;
            this.Пароль_textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Пароль_KeyPress);
            // 
            // label8
            // 
            this.Пароль_label8.AutoSize = true;
            this.Пароль_label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Пароль_label8.Location = new System.Drawing.Point(10, 41);
            this.Пароль_label8.Name = "label8";
            this.Пароль_label8.Size = new System.Drawing.Size(56, 16);
            this.Пароль_label8.TabIndex = 19;
            this.Пароль_label8.Text = "Пароль";
            // 
            // roundBtn1
            // 
            this.Подтвердить_roundBtn1.BackColor = System.Drawing.Color.LightYellow;
            this.Подтвердить_roundBtn1.Location = new System.Drawing.Point(135, 190);
            this.Подтвердить_roundBtn1.Name = "roundBtn1";
            this.Подтвердить_roundBtn1.Radius = 10;
            this.Подтвердить_roundBtn1.Size = new System.Drawing.Size(134, 31);
            this.Подтвердить_roundBtn1.TabIndex = 23;
            this.Подтвердить_roundBtn1.Text = "Подтвердить";
            this.Подтвердить_roundBtn1.Click += new System.EventHandler(this.Кнопка_подтверждения_Click);
            // 
            // roundBtn2
            // 
            this.Вернуться_roundBtn2.BackColor = System.Drawing.Color.LightYellow;
            this.Вернуться_roundBtn2.Location = new System.Drawing.Point(5, 4);
            this.Вернуться_roundBtn2.Name = "roundBtn2";
            this.Вернуться_roundBtn2.Radius = 10;
            this.Вернуться_roundBtn2.Size = new System.Drawing.Size(75, 26);
            this.Вернуться_roundBtn2.TabIndex = 24;
            this.Вернуться_roundBtn2.Text = "Вернуться";
            this.Вернуться_roundBtn2.Click += new System.EventHandler(this.Вернуться_Click);
            // 
            // panel1
            // 
            this.Фон_panel1.BackColor = System.Drawing.Color.LightYellow;
            this.Фон_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Фон_panel1.Controls.Add(this.Почта_label3);
            this.Фон_panel1.Controls.Add(this.Почта_textBox2);
            this.Фон_panel1.Controls.Add(this.Логин_textBox5);
            this.Фон_panel1.Controls.Add(this.Пароль_label8);
            this.Фон_panel1.Controls.Add(this.Пароль_textBox4);
            this.Фон_panel1.Controls.Add(this.Логин_label7);
            this.Фон_panel1.Location = new System.Drawing.Point(52, 60);
            this.Фон_panel1.Name = "panel1";
            this.Фон_panel1.Size = new System.Drawing.Size(307, 110);
            this.Фон_panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.Почта_label3.AutoSize = true;
            this.Почта_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Почта_label3.Location = new System.Drawing.Point(10, 77);
            this.Почта_label3.Name = "label3";
            this.Почта_label3.Size = new System.Drawing.Size(48, 16);
            this.Почта_label3.TabIndex = 24;
            this.Почта_label3.Text = "Почта";
            // 
            // textBox2
            // 
            this.Почта_textBox2.Location = new System.Drawing.Point(142, 76);
            this.Почта_textBox2.Name = "textBox2";
            this.Почта_textBox2.Size = new System.Drawing.Size(153, 20);
            this.Почта_textBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.Регистрация_label1.AutoSize = true;
            this.Регистрация_label1.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Регистрация_label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Регистрация_label1.Location = new System.Drawing.Point(112, 11);
            this.Регистрация_label1.Name = "label1";
            this.Регистрация_label1.Size = new System.Drawing.Size(198, 39);
            this.Регистрация_label1.TabIndex = 26;
            this.Регистрация_label1.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.Выйти_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.Выйти_pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.Выйти_pictureBox1.Location = new System.Drawing.Point(393, -2);
            this.Выйти_pictureBox1.Name = "pictureBox1";
            this.Выйти_pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.Выйти_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Выйти_pictureBox1.TabIndex = 27;
            this.Выйти_pictureBox1.TabStop = false;
            this.Выйти_pictureBox1.Click += new System.EventHandler(this.выйти_Click);
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(417, 248);
            this.Controls.Add(this.Выйти_pictureBox1);
            this.Controls.Add(this.Регистрация_label1);
            this.Controls.Add(this.Фон_panel1);
            this.Controls.Add(this.Вернуться_roundBtn2);
            this.Controls.Add(this.Подтвердить_roundBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Регистрация";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseMove);
            this.Фон_panel1.ResumeLayout(false);
            this.Фон_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Логин_textBox5;
        private System.Windows.Forms.Label Логин_label7;
        private System.Windows.Forms.TextBox Пароль_textBox4;
        private System.Windows.Forms.Label Пароль_label8;
        private Ремонт_пассажирских_вагонов.RoundBtn Подтвердить_roundBtn1;
        private Ремонт_пассажирских_вагонов.RoundBtn Вернуться_roundBtn2;
        private System.Windows.Forms.Panel Фон_panel1;
        private System.Windows.Forms.Label Регистрация_label1;
        private System.Windows.Forms.Label Почта_label3;
        private System.Windows.Forms.TextBox Почта_textBox2;
        private System.Windows.Forms.PictureBox Выйти_pictureBox1;
    }
}