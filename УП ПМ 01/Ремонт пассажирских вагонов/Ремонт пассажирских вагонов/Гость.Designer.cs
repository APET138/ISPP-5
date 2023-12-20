namespace Ремонт_пассажирских_вагонов
{
    partial class Гость
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Гость));
            this.Примечание_label = new System.Windows.Forms.Label();
            this.Фон1 = new System.Windows.Forms.Panel();
            this.Ремонт_Пассажирских_Вагонов_label = new System.Windows.Forms.Label();
            this.Таблица = new System.Windows.Forms.DataGridView();
            this.Выйти = new System.Windows.Forms.PictureBox();
            this.Бригады = new System.Windows.Forms.Button();
            this.Ремонтные_Работы = new System.Windows.Forms.Button();
            this.Вагоны = new System.Windows.Forms.Button();
            this.Вернуться = new System.Windows.Forms.Button();
            this.Фон2 = new System.Windows.Forms.Panel();
            this.Поиск_label = new System.Windows.Forms.Label();
            this.Поиск = new System.Windows.Forms.TextBox();
            this.Фон3 = new System.Windows.Forms.Panel();
            this.Режим_Гостя_label = new System.Windows.Forms.Label();
            this.Фото_Вагона = new System.Windows.Forms.PictureBox();
            this.Фон4 = new System.Windows.Forms.Panel();
            this.Фотография_Вагона_label = new System.Windows.Forms.Label();
            this.Фон1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Таблица)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).BeginInit();
            this.Фон2.SuspendLayout();
            this.Фон3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Фото_Вагона)).BeginInit();
            this.Фон4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Примечание_label
            // 
            this.Примечание_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Примечание_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Примечание_label.ForeColor = System.Drawing.Color.White;
            this.Примечание_label.Location = new System.Drawing.Point(393, 35);
            this.Примечание_label.Name = "Примечание_label";
            this.Примечание_label.Size = new System.Drawing.Size(660, 25);
            this.Примечание_label.TabIndex = 16;
            this.Примечание_label.Text = "ПРИМЕЧАНИЕ: в режиме гостя вы не можете изменять или редактировать поля и строки " +
    "таблиц.";
            this.Примечание_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Фон1
            // 
            this.Фон1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон1.Controls.Add(this.Ремонт_Пассажирских_Вагонов_label);
            this.Фон1.Location = new System.Drawing.Point(12, 7);
            this.Фон1.Name = "Фон1";
            this.Фон1.Size = new System.Drawing.Size(355, 22);
            this.Фон1.TabIndex = 47;
            // 
            // Ремонт_Пассажирских_Вагонов_label
            // 
            this.Ремонт_Пассажирских_Вагонов_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ремонт_Пассажирских_Вагонов_label.ForeColor = System.Drawing.Color.White;
            this.Ремонт_Пассажирских_Вагонов_label.Location = new System.Drawing.Point(0, 0);
            this.Ремонт_Пассажирских_Вагонов_label.Name = "Ремонт_Пассажирских_Вагонов_label";
            this.Ремонт_Пассажирских_Вагонов_label.Size = new System.Drawing.Size(357, 23);
            this.Ремонт_Пассажирских_Вагонов_label.TabIndex = 0;
            this.Ремонт_Пассажирских_Вагонов_label.Text = "Ремонт пассажирских вагонов";
            this.Ремонт_Пассажирских_Вагонов_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Таблица
            // 
            this.Таблица.AllowUserToOrderColumns = true;
            this.Таблица.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Таблица.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Таблица.BackgroundColor = System.Drawing.Color.White;
            this.Таблица.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Таблица.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Таблица.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Таблица.Location = new System.Drawing.Point(12, 61);
            this.Таблица.Name = "Таблица";
            this.Таблица.ReadOnly = true;
            this.Таблица.Size = new System.Drawing.Size(826, 438);
            this.Таблица.TabIndex = 46;
            this.Таблица.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Таблица_CellClick);
            // 
            // Выйти
            // 
            this.Выйти.Image = ((System.Drawing.Image)(resources.GetObject("Выйти.Image")));
            this.Выйти.Location = new System.Drawing.Point(1040, 0);
            this.Выйти.Name = "Выйти";
            this.Выйти.Size = new System.Drawing.Size(24, 24);
            this.Выйти.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Выйти.TabIndex = 54;
            this.Выйти.TabStop = false;
            this.Выйти.Click += new System.EventHandler(this.Выйти_Click);
            // 
            // Бригады
            // 
            this.Бригады.BackColor = System.Drawing.Color.White;
            this.Бригады.FlatAppearance.BorderSize = 0;
            this.Бригады.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Бригады.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Бригады.Location = new System.Drawing.Point(310, 35);
            this.Бригады.Name = "Бригады";
            this.Бригады.Size = new System.Drawing.Size(77, 25);
            this.Бригады.TabIndex = 53;
            this.Бригады.Text = "Бригады";
            this.Бригады.UseVisualStyleBackColor = false;
            this.Бригады.Click += new System.EventHandler(this.Бригады_Click);
            // 
            // Ремонтные_Работы
            // 
            this.Ремонтные_Работы.BackColor = System.Drawing.Color.White;
            this.Ремонтные_Работы.FlatAppearance.BorderSize = 0;
            this.Ремонтные_Работы.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ремонтные_Работы.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Ремонтные_Работы.Location = new System.Drawing.Point(173, 35);
            this.Ремонтные_Работы.Name = "Ремонтные_Работы";
            this.Ремонтные_Работы.Size = new System.Drawing.Size(131, 25);
            this.Ремонтные_Работы.TabIndex = 50;
            this.Ремонтные_Работы.Text = "Ремонтные работы";
            this.Ремонтные_Работы.UseVisualStyleBackColor = false;
            this.Ремонтные_Работы.Click += new System.EventHandler(this.Ремонтные_Работы_Click);
            // 
            // Вагоны
            // 
            this.Вагоны.BackColor = System.Drawing.Color.White;
            this.Вагоны.FlatAppearance.BorderSize = 0;
            this.Вагоны.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Вагоны.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Вагоны.Location = new System.Drawing.Point(106, 35);
            this.Вагоны.Name = "Вагоны";
            this.Вагоны.Size = new System.Drawing.Size(61, 25);
            this.Вагоны.TabIndex = 49;
            this.Вагоны.Text = "Вагоны";
            this.Вагоны.UseVisualStyleBackColor = false;
            this.Вагоны.Click += new System.EventHandler(this.Вагоны_Click);
            // 
            // Вернуться
            // 
            this.Вернуться.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Вернуться.FlatAppearance.BorderSize = 0;
            this.Вернуться.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Вернуться.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Вернуться.ForeColor = System.Drawing.Color.White;
            this.Вернуться.Location = new System.Drawing.Point(12, 35);
            this.Вернуться.Name = "Вернуться";
            this.Вернуться.Size = new System.Drawing.Size(88, 25);
            this.Вернуться.TabIndex = 48;
            this.Вернуться.Text = "Вернуться";
            this.Вернуться.UseVisualStyleBackColor = false;
            this.Вернуться.Click += new System.EventHandler(this.Вернуться_Click);
            // 
            // Фон2
            // 
            this.Фон2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон2.Controls.Add(this.Поиск_label);
            this.Фон2.Location = new System.Drawing.Point(374, 7);
            this.Фон2.Name = "Фон2";
            this.Фон2.Size = new System.Drawing.Size(54, 22);
            this.Фон2.TabIndex = 55;
            // 
            // Поиск_label
            // 
            this.Поиск_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Поиск_label.ForeColor = System.Drawing.Color.White;
            this.Поиск_label.Location = new System.Drawing.Point(0, 0);
            this.Поиск_label.Name = "Поиск_label";
            this.Поиск_label.Size = new System.Drawing.Size(54, 22);
            this.Поиск_label.TabIndex = 0;
            this.Поиск_label.Text = "Поиск";
            this.Поиск_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Поиск
            // 
            this.Поиск.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Поиск.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Поиск.Location = new System.Drawing.Point(434, 7);
            this.Поиск.Multiline = true;
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(214, 22);
            this.Поиск.TabIndex = 56;
            this.Поиск.TextChanged += new System.EventHandler(this.Поиск_TextChanged);
            // 
            // Фон3
            // 
            this.Фон3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон3.Controls.Add(this.Режим_Гостя_label);
            this.Фон3.Location = new System.Drawing.Point(654, 7);
            this.Фон3.Name = "Фон3";
            this.Фон3.Size = new System.Drawing.Size(380, 22);
            this.Фон3.TabIndex = 61;
            // 
            // Режим_Гостя_label
            // 
            this.Режим_Гостя_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Режим_Гостя_label.ForeColor = System.Drawing.Color.White;
            this.Режим_Гостя_label.Location = new System.Drawing.Point(0, 0);
            this.Режим_Гостя_label.Name = "Режим_Гостя_label";
            this.Режим_Гостя_label.Size = new System.Drawing.Size(380, 23);
            this.Режим_Гостя_label.TabIndex = 0;
            this.Режим_Гостя_label.Text = "Режим Гостя";
            this.Режим_Гостя_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Фото_Вагона
            // 
            this.Фото_Вагона.BackColor = System.Drawing.Color.White;
            this.Фото_Вагона.Location = new System.Drawing.Point(844, 92);
            this.Фото_Вагона.Name = "Фото_Вагона";
            this.Фото_Вагона.Size = new System.Drawing.Size(209, 210);
            this.Фото_Вагона.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Фото_Вагона.TabIndex = 68;
            this.Фото_Вагона.TabStop = false;
            // 
            // Фон4
            // 
            this.Фон4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Фон4.Controls.Add(this.Фотография_Вагона_label);
            this.Фон4.Location = new System.Drawing.Point(844, 61);
            this.Фон4.Name = "Фон4";
            this.Фон4.Size = new System.Drawing.Size(209, 28);
            this.Фон4.TabIndex = 67;
            // 
            // Фотография_Вагона_label
            // 
            this.Фотография_Вагона_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Фотография_Вагона_label.ForeColor = System.Drawing.Color.White;
            this.Фотография_Вагона_label.Location = new System.Drawing.Point(0, 0);
            this.Фотография_Вагона_label.Name = "Фотография_Вагона_label";
            this.Фотография_Вагона_label.Size = new System.Drawing.Size(209, 28);
            this.Фотография_Вагона_label.TabIndex = 0;
            this.Фотография_Вагона_label.Text = "Фотография вагона";
            this.Фотография_Вагона_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Гость
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1064, 511);
            this.Controls.Add(this.Фон3);
            this.Controls.Add(this.Фон2);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.Фон1);
            this.Controls.Add(this.Таблица);
            this.Controls.Add(this.Выйти);
            this.Controls.Add(this.Бригады);
            this.Controls.Add(this.Ремонтные_Работы);
            this.Controls.Add(this.Вагоны);
            this.Controls.Add(this.Вернуться);
            this.Controls.Add(this.Примечание_label);
            this.Controls.Add(this.Фото_Вагона);
            this.Controls.Add(this.Фон4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Гость";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт пассажирских вагонов";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Гость_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Гость_MouseMove);
            this.Фон1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Таблица)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Выйти)).EndInit();
            this.Фон2.ResumeLayout(false);
            this.Фон3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Фото_Вагона)).EndInit();
            this.Фон4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Примечание_label;
        private System.Windows.Forms.Panel Фон1;
        private System.Windows.Forms.Label Ремонт_Пассажирских_Вагонов_label;
        private System.Windows.Forms.DataGridView Таблица;
        private System.Windows.Forms.PictureBox Выйти;
        private System.Windows.Forms.Button Бригады;
        private System.Windows.Forms.Button Ремонтные_Работы;
        private System.Windows.Forms.Button Вагоны;
        private System.Windows.Forms.Button Вернуться;
        private System.Windows.Forms.Panel Фон2;
        private System.Windows.Forms.Label Поиск_label;
        private System.Windows.Forms.TextBox Поиск;
        private System.Windows.Forms.Panel Фон3;
        private System.Windows.Forms.Label Режим_Гостя_label;
        private System.Windows.Forms.PictureBox Фото_Вагона;
        private System.Windows.Forms.Panel Фон4;
        private System.Windows.Forms.Label Фотография_Вагона_label;
    }
}