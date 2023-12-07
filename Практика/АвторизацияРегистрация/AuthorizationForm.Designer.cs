namespace Бюро_технической_инвентаризации
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.LoginTextBox1 = new System.Windows.Forms.TextBox();
            this.PassTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HideButtonAuth = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PassPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ShowPasswordAuth = new System.Windows.Forms.Button();
            this.EnterButton = new Бюро_технической_инвентаризации.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox1
            // 
            this.LoginTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.LoginTextBox1.Location = new System.Drawing.Point(145, 222);
            this.LoginTextBox1.Multiline = true;
            this.LoginTextBox1.Name = "LoginTextBox1";
            this.LoginTextBox1.Size = new System.Drawing.Size(226, 36);
            this.LoginTextBox1.TabIndex = 0;
            this.LoginTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox1_KeyPress);
            // 
            // PassTextBox1
            // 
            this.PassTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.PassTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.PassTextBox1.Location = new System.Drawing.Point(145, 276);
            this.PassTextBox1.Multiline = true;
            this.PassTextBox1.Name = "PassTextBox1";
            this.PassTextBox1.Size = new System.Drawing.Size(226, 36);
            this.PassTextBox1.TabIndex = 1;
            this.PassTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Попыток входа: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Авторизация";
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.RegisterLinkLabel.Location = new System.Drawing.Point(12, 422);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(253, 25);
            this.RegisterLinkLabel.TabIndex = 11;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "У вас еще нет аккаунта?";
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // HideButtonAuth
            // 
            this.HideButtonAuth.BackColor = System.Drawing.Color.Transparent;
            this.HideButtonAuth.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Скрыть_пароль;
            this.HideButtonAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideButtonAuth.FlatAppearance.BorderSize = 0;
            this.HideButtonAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HideButtonAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HideButtonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButtonAuth.Location = new System.Drawing.Point(377, 276);
            this.HideButtonAuth.Name = "HideButtonAuth";
            this.HideButtonAuth.Size = new System.Drawing.Size(41, 36);
            this.HideButtonAuth.TabIndex = 24;
            this.HideButtonAuth.UseVisualStyleBackColor = false;
            this.HideButtonAuth.Visible = false;
            this.HideButtonAuth.Click += new System.EventHandler(this.HideButtonAuth_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(438, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(145, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // PassPictureBox
            // 
            this.PassPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.PassPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PassPictureBox.Image = global::Бюро_технической_инвентаризации.Properties.Resources.Пароль;
            this.PassPictureBox.Location = new System.Drawing.Point(107, 276);
            this.PassPictureBox.Name = "PassPictureBox";
            this.PassPictureBox.Size = new System.Drawing.Size(37, 36);
            this.PassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassPictureBox.TabIndex = 15;
            this.PassPictureBox.TabStop = false;
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.LoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginPictureBox.Image")));
            this.LoginPictureBox.Location = new System.Drawing.Point(107, 222);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(37, 36);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPictureBox.TabIndex = 14;
            this.LoginPictureBox.TabStop = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Очистка;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(377, 222);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(41, 36);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ShowPasswordAuth
            // 
            this.ShowPasswordAuth.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordAuth.BackgroundImage = global::Бюро_технической_инвентаризации.Properties.Resources.Показать_пароль;
            this.ShowPasswordAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordAuth.FlatAppearance.BorderSize = 0;
            this.ShowPasswordAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordAuth.Location = new System.Drawing.Point(377, 276);
            this.ShowPasswordAuth.Name = "ShowPasswordAuth";
            this.ShowPasswordAuth.Size = new System.Drawing.Size(41, 36);
            this.ShowPasswordAuth.TabIndex = 25;
            this.ShowPasswordAuth.UseVisualStyleBackColor = false;
            this.ShowPasswordAuth.Click += new System.EventHandler(this.ShowPasswordAuth_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(289, 404);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(169, 48);
            this.EnterButton.TabIndex = 10;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 472);
            this.Controls.Add(this.ShowPasswordAuth);
            this.Controls.Add(this.HideButtonAuth);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassPictureBox);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.LoginTextBox1);
            this.Controls.Add(this.PassTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.RegisterLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox1;
        private System.Windows.Forms.TextBox PassTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundedButton EnterButton;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.PictureBox PassPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button HideButtonAuth;
        private System.Windows.Forms.Button ShowPasswordAuth;
    }
}