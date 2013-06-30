namespace PresentationClient
{
    partial class Form1
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.NicknameTextbox = new System.Windows.Forms.TextBox();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.AdsPanel = new System.Windows.Forms.Panel();
            this.RegistrationPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RegistrationMovePanel = new System.Windows.Forms.Panel();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.RegistrationPanel.SuspendLayout();
            this.RegistrationMovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.NicknameLabel);
            this.LoginPanel.Controls.Add(this.PasswordTextbox);
            this.LoginPanel.Controls.Add(this.NicknameTextbox);
            this.LoginPanel.Location = new System.Drawing.Point(315, 35);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(185, 110);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(95, 66);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(8, 42);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(6, 16);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.NicknameLabel.TabIndex = 2;
            this.NicknameLabel.Text = "Nickname:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextbox.Location = new System.Drawing.Point(70, 40);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox.TabIndex = 1;
            // 
            // NicknameTextbox
            // 
            this.NicknameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NicknameTextbox.Location = new System.Drawing.Point(70, 14);
            this.NicknameTextbox.Name = "NicknameTextbox";
            this.NicknameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NicknameTextbox.TabIndex = 0;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(500, 35);
            this.HeadPanel.TabIndex = 1;
            // 
            // AdsPanel
            // 
            this.AdsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdsPanel.Location = new System.Drawing.Point(0, 350);
            this.AdsPanel.Name = "AdsPanel";
            this.AdsPanel.Size = new System.Drawing.Size(500, 100);
            this.AdsPanel.TabIndex = 5;
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegistrationPanel.Controls.Add(this.panel6);
            this.RegistrationPanel.Controls.Add(this.RegistrationMovePanel);
            this.RegistrationPanel.Location = new System.Drawing.Point(0, 35);
            this.RegistrationPanel.Name = "RegistrationPanel";
            this.RegistrationPanel.Size = new System.Drawing.Size(314, 275);
            this.RegistrationPanel.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(410, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(65, 100);
            this.panel6.TabIndex = 0;
            // 
            // RegistrationMovePanel
            // 
            this.RegistrationMovePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RegistrationMovePanel.Controls.Add(this.RegistrationLabel);
            this.RegistrationMovePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegistrationMovePanel.Location = new System.Drawing.Point(290, 0);
            this.RegistrationMovePanel.Name = "RegistrationMovePanel";
            this.RegistrationMovePanel.Size = new System.Drawing.Size(24, 275);
            this.RegistrationMovePanel.TabIndex = 0;
            this.RegistrationMovePanel.Click += new System.EventHandler(this.RegistrationMovePanel_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegistrationLabel.Location = new System.Drawing.Point(3, 37);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(18, 16);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.Text = "R";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.RegistrationPanel);
            this.Controls.Add(this.AdsPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegistrationPanel.ResumeLayout(false);
            this.RegistrationMovePanel.ResumeLayout(false);
            this.RegistrationMovePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox NicknameTextbox;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Panel AdsPanel;
        private System.Windows.Forms.Panel RegistrationPanel;
        private System.Windows.Forms.Panel RegistrationMovePanel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Panel panel6;
    }
}

