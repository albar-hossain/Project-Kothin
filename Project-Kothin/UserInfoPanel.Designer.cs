﻿namespace Project_Kothin
{
    partial class UserInfoPanel
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
            this.labelRegFullName = new System.Windows.Forms.Label();
            this.labelRegPhone = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.pnumv = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.textBoxConpass = new System.Windows.Forms.TextBox();
            this.conPass = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.viewUpdate = new System.Windows.Forms.Button();
            this.linkLabelRegClose = new System.Windows.Forms.LinkLabel();
            this.labelWrongZip = new System.Windows.Forms.Label();
            this.labelRightZip = new System.Windows.Forms.Label();
            this.labelWrongEmail = new System.Windows.Forms.Label();
            this.labelRightEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelConPassWrong = new System.Windows.Forms.Label();
            this.labelConPassRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegFullName
            // 
            this.labelRegFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegFullName.AutoSize = true;
            this.labelRegFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelRegFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegFullName.ForeColor = System.Drawing.Color.Black;
            this.labelRegFullName.Location = new System.Drawing.Point(156, 40);
            this.labelRegFullName.Name = "labelRegFullName";
            this.labelRegFullName.Size = new System.Drawing.Size(130, 29);
            this.labelRegFullName.TabIndex = 5;
            this.labelRegFullName.Text = "Full Name:";
            // 
            // labelRegPhone
            // 
            this.labelRegPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegPhone.AutoSize = true;
            this.labelRegPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelRegPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegPhone.ForeColor = System.Drawing.Color.Black;
            this.labelRegPhone.Location = new System.Drawing.Point(155, 69);
            this.labelRegPhone.Name = "labelRegPhone";
            this.labelRegPhone.Size = new System.Drawing.Size(89, 29);
            this.labelRegPhone.TabIndex = 6;
            this.labelRegPhone.Text = "Phone:";
            // 
            // fname
            // 
            this.fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.Color.Transparent;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.fname.Location = new System.Drawing.Point(292, 40);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(79, 29);
            this.fname.TabIndex = 7;
            this.fname.Text = "fname";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // pnumv
            // 
            this.pnumv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnumv.AutoSize = true;
            this.pnumv.BackColor = System.Drawing.Color.Transparent;
            this.pnumv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnumv.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.pnumv.Location = new System.Drawing.Point(292, 69);
            this.pnumv.Name = "pnumv";
            this.pnumv.Size = new System.Drawing.Size(73, 29);
            this.pnumv.TabIndex = 8;
            this.pnumv.Text = "pnum";
            this.pnumv.Click += new System.EventHandler(this.pnumv_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(307, 152);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(344, 35);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(307, 206);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(344, 95);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostcode.Location = new System.Drawing.Point(307, 314);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.ReadOnly = true;
            this.textBoxPostcode.Size = new System.Drawing.Size(344, 35);
            this.textBoxPostcode.TabIndex = 15;
            this.textBoxPostcode.TextChanged += new System.EventHandler(this.textBoxPostcode_TextChanged);
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(307, 412);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(293, 35);
            this.newpass.TabIndex = 17;
            this.newpass.Visible = false;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            // 
            // textBoxConpass
            // 
            this.textBoxConpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxConpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConpass.Location = new System.Drawing.Point(307, 453);
            this.textBoxConpass.Name = "textBoxConpass";
            this.textBoxConpass.PasswordChar = '*';
            this.textBoxConpass.Size = new System.Drawing.Size(293, 35);
            this.textBoxConpass.TabIndex = 19;
            this.textBoxConpass.Visible = false;
            this.textBoxConpass.TextChanged += new System.EventHandler(this.textBoxConpass_TextChanged);
            // 
            // conPass
            // 
            this.conPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conPass.AutoSize = true;
            this.conPass.BackColor = System.Drawing.Color.Transparent;
            this.conPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass.ForeColor = System.Drawing.Color.Black;
            this.conPass.Location = new System.Drawing.Point(74, 456);
            this.conPass.Name = "conPass";
            this.conPass.Size = new System.Drawing.Size(216, 29);
            this.conPass.TabIndex = 18;
            this.conPass.Text = "Confirm Password:";
            this.conPass.Visible = false;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(626, 592);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(116, 48);
            this.updatebutton.TabIndex = 20;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Visible = false;
            this.updatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(164, 152);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 29);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(156, 209);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(108, 29);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Address:";
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostCode.Location = new System.Drawing.Point(155, 317);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(146, 29);
            this.labelPostCode.TabIndex = 23;
            this.labelPostCode.Text = "Postal code:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(1019, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete account☹ ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewUpdate
            // 
            this.viewUpdate.Location = new System.Drawing.Point(352, 531);
            this.viewUpdate.Name = "viewUpdate";
            this.viewUpdate.Size = new System.Drawing.Size(161, 52);
            this.viewUpdate.TabIndex = 25;
            this.viewUpdate.Text = "Click to Update any details ";
            this.viewUpdate.UseVisualStyleBackColor = true;
            this.viewUpdate.Click += new System.EventHandler(this.viewUpdate_Click);
            // 
            // linkLabelRegClose
            // 
            this.linkLabelRegClose.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelRegClose.AutoSize = true;
            this.linkLabelRegClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRegClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRegClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.linkLabelRegClose.Location = new System.Drawing.Point(1140, 9);
            this.linkLabelRegClose.Name = "linkLabelRegClose";
            this.linkLabelRegClose.Size = new System.Drawing.Size(47, 31);
            this.linkLabelRegClose.TabIndex = 34;
            this.linkLabelRegClose.TabStop = true;
            this.linkLabelRegClose.Text = "❌";
            this.linkLabelRegClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegClose_LinkClicked);
            // 
            // labelWrongZip
            // 
            this.labelWrongZip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWrongZip.AutoSize = true;
            this.labelWrongZip.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongZip.ForeColor = System.Drawing.Color.Red;
            this.labelWrongZip.Location = new System.Drawing.Point(657, 324);
            this.labelWrongZip.Name = "labelWrongZip";
            this.labelWrongZip.Size = new System.Drawing.Size(25, 20);
            this.labelWrongZip.TabIndex = 35;
            this.labelWrongZip.Text = "❌";
            this.labelWrongZip.Visible = false;
            this.labelWrongZip.Click += new System.EventHandler(this.labelWrongZip_Click);
            // 
            // labelRightZip
            // 
            this.labelRightZip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRightZip.AutoSize = true;
            this.labelRightZip.BackColor = System.Drawing.Color.Transparent;
            this.labelRightZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightZip.ForeColor = System.Drawing.Color.Lime;
            this.labelRightZip.Location = new System.Drawing.Point(657, 324);
            this.labelRightZip.Name = "labelRightZip";
            this.labelRightZip.Size = new System.Drawing.Size(25, 20);
            this.labelRightZip.TabIndex = 36;
            this.labelRightZip.Text = "✔";
            this.labelRightZip.Visible = false;
            this.labelRightZip.Click += new System.EventHandler(this.labelRightZip_Click);
            // 
            // labelWrongEmail
            // 
            this.labelWrongEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWrongEmail.AutoSize = true;
            this.labelWrongEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongEmail.ForeColor = System.Drawing.Color.Red;
            this.labelWrongEmail.Location = new System.Drawing.Point(657, 159);
            this.labelWrongEmail.Name = "labelWrongEmail";
            this.labelWrongEmail.Size = new System.Drawing.Size(25, 20);
            this.labelWrongEmail.TabIndex = 37;
            this.labelWrongEmail.Text = "❌";
            this.labelWrongEmail.Visible = false;
            // 
            // labelRightEmail
            // 
            this.labelRightEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRightEmail.AutoSize = true;
            this.labelRightEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelRightEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRightEmail.ForeColor = System.Drawing.Color.Lime;
            this.labelRightEmail.Location = new System.Drawing.Point(657, 159);
            this.labelRightEmail.Name = "labelRightEmail";
            this.labelRightEmail.Size = new System.Drawing.Size(25, 20);
            this.labelRightEmail.TabIndex = 38;
            this.labelRightEmail.Text = "✔";
            this.labelRightEmail.Visible = false;
            this.labelRightEmail.Click += new System.EventHandler(this.labelRightEmail_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Password:";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Click to update password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelConPassWrong
            // 
            this.labelConPassWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConPassWrong.AutoSize = true;
            this.labelConPassWrong.BackColor = System.Drawing.Color.Transparent;
            this.labelConPassWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConPassWrong.ForeColor = System.Drawing.Color.Red;
            this.labelConPassWrong.Location = new System.Drawing.Point(606, 463);
            this.labelConPassWrong.Name = "labelConPassWrong";
            this.labelConPassWrong.Size = new System.Drawing.Size(25, 20);
            this.labelConPassWrong.TabIndex = 42;
            this.labelConPassWrong.Text = "❌";
            this.labelConPassWrong.Visible = false;
            this.labelConPassWrong.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelConPassRight
            // 
            this.labelConPassRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConPassRight.AutoSize = true;
            this.labelConPassRight.BackColor = System.Drawing.Color.Transparent;
            this.labelConPassRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConPassRight.ForeColor = System.Drawing.Color.Lime;
            this.labelConPassRight.Location = new System.Drawing.Point(606, 463);
            this.labelConPassRight.Name = "labelConPassRight";
            this.labelConPassRight.Size = new System.Drawing.Size(25, 20);
            this.labelConPassRight.TabIndex = 43;
            this.labelConPassRight.Text = "✔";
            this.labelConPassRight.Visible = false;
            // 
            // UserInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 691);
            this.Controls.Add(this.labelConPassRight);
            this.Controls.Add(this.labelConPassWrong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWrongZip);
            this.Controls.Add(this.linkLabelRegClose);
            this.Controls.Add(this.viewUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.textBoxConpass);
            this.Controls.Add(this.conPass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pnumv);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.labelRegPhone);
            this.Controls.Add(this.labelRegFullName);
            this.Controls.Add(this.labelRightEmail);
            this.Controls.Add(this.labelWrongEmail);
            this.Controls.Add(this.labelRightZip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfoPanel";
            this.Text = "UserInfoPanel";
            this.Load += new System.EventHandler(this.UserInfoPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegFullName;
        private System.Windows.Forms.Label labelRegPhone;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label pnumv;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox textBoxConpass;
        private System.Windows.Forms.Label conPass;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewUpdate;
        private System.Windows.Forms.LinkLabel linkLabelRegClose;
        private System.Windows.Forms.Label labelWrongZip;
        private System.Windows.Forms.Label labelRightZip;
        private System.Windows.Forms.Label labelWrongEmail;
        private System.Windows.Forms.Label labelRightEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelConPassWrong;
        private System.Windows.Forms.Label labelConPassRight;
    }
}