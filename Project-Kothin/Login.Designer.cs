﻿namespace Project_Kothin
{
    partial class Login
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
            this.labelLoginPhone = new System.Windows.Forms.Label();
            this.labelLoginPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.linkLabelLoginBack = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoginClose = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelLoginPhone
            // 
            this.labelLoginPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginPhone.AutoSize = true;
            this.labelLoginPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPhone.ForeColor = System.Drawing.Color.White;
            this.labelLoginPhone.Location = new System.Drawing.Point(360, 207);
            this.labelLoginPhone.Name = "labelLoginPhone";
            this.labelLoginPhone.Size = new System.Drawing.Size(118, 37);
            this.labelLoginPhone.TabIndex = 0;
            this.labelLoginPhone.Text = "Phone:";
            this.labelLoginPhone.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelLoginPass
            // 
            this.labelLoginPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginPass.AutoSize = true;
            this.labelLoginPass.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPass.ForeColor = System.Drawing.Color.White;
            this.labelLoginPass.Location = new System.Drawing.Point(311, 280);
            this.labelLoginPass.Name = "labelLoginPass";
            this.labelLoginPass.Size = new System.Drawing.Size(167, 37);
            this.labelLoginPass.TabIndex = 1;
            this.labelLoginPass.Text = "Password:";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(559, 118);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(115, 42);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.Color.Silver;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPhone.Location = new System.Drawing.Point(484, 214);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(265, 29);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.Silver;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPassword.Location = new System.Drawing.Point(484, 288);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(265, 29);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(57)))));
            this.linkLabelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(174)))), ((int)(((byte)(102)))));
            this.linkLabelRegister.Location = new System.Drawing.Point(480, 413);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(67, 20);
            this.linkLabelRegister.TabIndex = 5;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Sign-Up";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(121)))), ((int)(((byte)(4)))));
            this.linkLabelForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))));
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(612, 413);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(138, 20);
            this.linkLabelForgotPassword.TabIndex = 6;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(484, 347);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(266, 34);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1014, 620);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(164, 44);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelLoginBack
            // 
            this.linkLabelLoginBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(66)))));
            this.linkLabelLoginBack.AutoSize = true;
            this.linkLabelLoginBack.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLoginBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLoginBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(127)))), ((int)(((byte)(99)))));
            this.linkLabelLoginBack.Location = new System.Drawing.Point(12, 9);
            this.linkLabelLoginBack.Name = "linkLabelLoginBack";
            this.linkLabelLoginBack.Size = new System.Drawing.Size(43, 37);
            this.linkLabelLoginBack.TabIndex = 28;
            this.linkLabelLoginBack.TabStop = true;
            this.linkLabelLoginBack.Text = "🡰";
            this.linkLabelLoginBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginBack_LinkClicked);
            // 
            // linkLabelLoginClose
            // 
            this.linkLabelLoginClose.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLoginClose.AutoSize = true;
            this.linkLabelLoginClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLoginClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLoginClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.linkLabelLoginClose.Location = new System.Drawing.Point(1138, 9);
            this.linkLabelLoginClose.Name = "linkLabelLoginClose";
            this.linkLabelLoginClose.Size = new System.Drawing.Size(49, 33);
            this.linkLabelLoginClose.TabIndex = 29;
            this.linkLabelLoginClose.TabStop = true;
            this.linkLabelLoginClose.Text = "❌";
            this.linkLabelLoginClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginClose_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_Kothin.Properties.Resources.KothinBGM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1215, 730);
            this.Controls.Add(this.linkLabelLoginClose);
            this.Controls.Add(this.linkLabelLoginBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelLoginPass);
            this.Controls.Add(this.labelLoginPhone);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1215, 730);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginPhone;
        private System.Windows.Forms.Label labelLoginPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel linkLabelLoginBack;
        private System.Windows.Forms.LinkLabel linkLabelLoginClose;
    }
}