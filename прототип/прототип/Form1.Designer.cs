namespace прототип
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.выйти_PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundBtn1 = new прототип.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.выйти_PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // выйти_PictureBox1
            // 
            this.выйти_PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("выйти_PictureBox1.Image")));
            this.выйти_PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("выйти_PictureBox1.InitialImage")));
            this.выйти_PictureBox1.Location = new System.Drawing.Point(824, -1);
            this.выйти_PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.выйти_PictureBox1.Name = "выйти_PictureBox1";
            this.выйти_PictureBox1.Size = new System.Drawing.Size(33, 31);
            this.выйти_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.выйти_PictureBox1.TabIndex = 25;
            this.выйти_PictureBox1.TabStop = false;
            this.выйти_PictureBox1.Click += new System.EventHandler(this.выйти_PictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 501);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(860, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(29, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Задание номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(54, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.roundBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.roundBtn1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundBtn1.Location = new System.Drawing.Point(329, 464);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Radius = 10;
            this.roundBtn1.Size = new System.Drawing.Size(185, 61);
            this.roundBtn1.TabIndex = 28;
            this.roundBtn1.Text = "Перейти к заданию";
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(856, 839);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.выйти_PictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.выйти_PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox выйти_PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundBtn roundBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

