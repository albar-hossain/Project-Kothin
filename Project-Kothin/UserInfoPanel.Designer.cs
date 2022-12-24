namespace Project_Kothin
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
            this.radiobuttPass = new System.Windows.Forms.RadioButton();
            this.conPass = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.viewUpdate = new System.Windows.Forms.Button();
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
            this.textBoxEmail.Size = new System.Drawing.Size(293, 35);
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
            this.textBoxAddress.Size = new System.Drawing.Size(293, 95);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostcode.Location = new System.Drawing.Point(307, 314);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.ReadOnly = true;
            this.textBoxPostcode.Size = new System.Drawing.Size(293, 35);
            this.textBoxPostcode.TabIndex = 15;
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(307, 412);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(293, 35);
            this.newpass.TabIndex = 17;
            // 
            // textBoxConpass
            // 
            this.textBoxConpass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxConpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConpass.Location = new System.Drawing.Point(307, 453);
            this.textBoxConpass.Name = "textBoxConpass";
            this.textBoxConpass.Size = new System.Drawing.Size(293, 35);
            this.textBoxConpass.TabIndex = 19;
            // 
            // radiobuttPass
            // 
            this.radiobuttPass.AutoSize = true;
            this.radiobuttPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttPass.Location = new System.Drawing.Point(99, 414);
            this.radiobuttPass.Name = "radiobuttPass";
            this.radiobuttPass.Size = new System.Drawing.Size(174, 33);
            this.radiobuttPass.TabIndex = 16;
            this.radiobuttPass.TabStop = true;
            this.radiobuttPass.Text = "Update Pass:";
            this.radiobuttPass.UseVisualStyleBackColor = true;
            // 
            // conPass
            // 
            this.conPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conPass.AutoSize = true;
            this.conPass.BackColor = System.Drawing.Color.Transparent;
            this.conPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass.ForeColor = System.Drawing.Color.Black;
            this.conPass.Location = new System.Drawing.Point(70, 459);
            this.conPass.Name = "conPass";
            this.conPass.Size = new System.Drawing.Size(216, 29);
            this.conPass.TabIndex = 18;
            this.conPass.Text = "Confirm Password:";
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
            this.button2.Location = new System.Drawing.Point(1012, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete account";
            this.button2.UseVisualStyleBackColor = true;
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
            // UserInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 691);
            this.Controls.Add(this.viewUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPostCode);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.textBoxConpass);
            this.Controls.Add(this.conPass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.radiobuttPass);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pnumv);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.labelRegPhone);
            this.Controls.Add(this.labelRegFullName);
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
        private System.Windows.Forms.RadioButton radiobuttPass;
        private System.Windows.Forms.Label conPass;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewUpdate;
    }
}