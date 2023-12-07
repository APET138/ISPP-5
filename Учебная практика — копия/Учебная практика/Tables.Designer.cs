namespace Учебная_практика
{
    partial class Tables
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Abityrient = new System.Windows.Forms.ToolStripLabel();
            this.EGE = new System.Windows.Forms.ToolStripLabel();
            this.Contract = new System.Windows.Forms.ToolStripLabel();
            this.Commission = new System.Windows.Forms.ToolStripLabel();
            this.Proshedshie = new System.Windows.Forms.ToolStripLabel();
            this.PravaDostypa = new System.Windows.Forms.ToolStripLabel();
            this.UniversalTable = new System.Windows.Forms.DataGridView();
            this.ExitToAvtorization = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoAbPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoAbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abityrient,
            this.EGE,
            this.Contract,
            this.Commission,
            this.Proshedshie,
            this.PravaDostypa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(833, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Abityrient
            // 
            this.Abityrient.AutoSize = false;
            this.Abityrient.Name = "Abityrient";
            this.Abityrient.Size = new System.Drawing.Size(100, 22);
            this.Abityrient.Text = "Абитуриент";
            this.Abityrient.Click += new System.EventHandler(this.Abityrient_Click);
            // 
            // EGE
            // 
            this.EGE.AutoSize = false;
            this.EGE.Name = "EGE";
            this.EGE.Size = new System.Drawing.Size(100, 22);
            this.EGE.Text = "ЕГЭ абитуриента";
            this.EGE.Click += new System.EventHandler(this.EGE_Click);
            // 
            // Contract
            // 
            this.Contract.AutoSize = false;
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(100, 22);
            this.Contract.Text = "Контракт";
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // Commission
            // 
            this.Commission.AutoSize = false;
            this.Commission.Name = "Commission";
            this.Commission.Size = new System.Drawing.Size(100, 22);
            this.Commission.Text = "Комиссия";
            this.Commission.Click += new System.EventHandler(this.Commission_Click);
            // 
            // Proshedshie
            // 
            this.Proshedshie.AutoSize = false;
            this.Proshedshie.Name = "Proshedshie";
            this.Proshedshie.Size = new System.Drawing.Size(100, 22);
            this.Proshedshie.Text = "Прошедшие";
            this.Proshedshie.Click += new System.EventHandler(this.Proshedshie_Click);
            // 
            // PravaDostypa
            // 
            this.PravaDostypa.AutoSize = false;
            this.PravaDostypa.Name = "PravaDostypa";
            this.PravaDostypa.Size = new System.Drawing.Size(100, 22);
            this.PravaDostypa.Text = "Права доступа";
            this.PravaDostypa.Click += new System.EventHandler(this.PravaDostypa_Click);
            // 
            // UniversalTable
            // 
            this.UniversalTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.UniversalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UniversalTable.Location = new System.Drawing.Point(12, 28);
            this.UniversalTable.Name = "UniversalTable";
            this.UniversalTable.Size = new System.Drawing.Size(607, 165);
            this.UniversalTable.TabIndex = 1;
            this.UniversalTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UniversalTable_CellClick);
            // 
            // ExitToAvtorization
            // 
            this.ExitToAvtorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.ExitToAvtorization.Location = new System.Drawing.Point(10, 263);
            this.ExitToAvtorization.Name = "ExitToAvtorization";
            this.ExitToAvtorization.Size = new System.Drawing.Size(609, 23);
            this.ExitToAvtorization.TabIndex = 15;
            this.ExitToAvtorization.Text = "Вернуться к авторизации";
            this.ExitToAvtorization.UseVisualStyleBackColor = false;
            this.ExitToAvtorization.Click += new System.EventHandler(this.ExitToAvtorization_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Exit.Location = new System.Drawing.Point(10, 292);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(609, 23);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Create.Location = new System.Drawing.Point(10, 205);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(289, 23);
            this.Create.TabIndex = 17;
            this.Create.Text = "Создать запись";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoAbPicture
            // 
            this.PhotoAbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoAbPicture.Location = new System.Drawing.Point(629, 28);
            this.PhotoAbPicture.Name = "PhotoAbPicture";
            this.PhotoAbPicture.Size = new System.Drawing.Size(200, 200);
            this.PhotoAbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoAbPicture.TabIndex = 19;
            this.PhotoAbPicture.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(629, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Фото абитуриента";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Delete.Location = new System.Drawing.Point(305, 205);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(314, 23);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Update.Location = new System.Drawing.Point(10, 234);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(609, 23);
            this.Update.TabIndex = 25;
            this.Update.Text = "Изменить поле";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(833, 322);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhotoAbPicture);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExitToAvtorization);
            this.Controls.Add(this.UniversalTable);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с таблицами";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoAbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Abityrient;
        private System.Windows.Forms.ToolStripLabel EGE;
        private System.Windows.Forms.ToolStripLabel Contract;
        private System.Windows.Forms.ToolStripLabel Commission;
        private System.Windows.Forms.ToolStripLabel Proshedshie;
        private System.Windows.Forms.ToolStripLabel PravaDostypa;
        private System.Windows.Forms.DataGridView UniversalTable;
        private System.Windows.Forms.Button ExitToAvtorization;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PhotoAbPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
    }
}