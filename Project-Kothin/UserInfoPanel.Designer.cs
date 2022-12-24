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
            this.radioButEmail = new System.Windows.Forms.RadioButton();
            this.radioButAddress = new System.Windows.Forms.RadioButton();
            this.radioButtpost = new System.Windows.Forms.RadioButton();
            this.radiobuttPass = new System.Windows.Forms.RadioButton();
            this.conPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.labelRegPhone.Location = new System.Drawing.Point(156, 69);
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
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(307, 152);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(293, 35);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(307, 206);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(293, 95);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostcode.Location = new System.Drawing.Point(307, 314);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(293, 35);
            this.textBoxPostcode.TabIndex = 15;
            // 
            // newpass
            // 
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(307, 412);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(293, 35);
            this.newpass.TabIndex = 17;
            // 
            // textBoxConpass
            // 
            this.textBoxConpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConpass.Location = new System.Drawing.Point(307, 453);
            this.textBoxConpass.Name = "textBoxConpass";
            this.textBoxConpass.Size = new System.Drawing.Size(293, 35);
            this.textBoxConpass.TabIndex = 19;
            // 
            // radioButEmail
            // 
            this.radioButEmail.AutoSize = true;
            this.radioButEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButEmail.Location = new System.Drawing.Point(112, 152);
            this.radioButEmail.Name = "radioButEmail";
            this.radioButEmail.Size = new System.Drawing.Size(98, 33);
            this.radioButEmail.TabIndex = 9;
            this.radioButEmail.TabStop = true;
            this.radioButEmail.Text = "Email:";
            this.radioButEmail.UseVisualStyleBackColor = true;
            // 
            // radioButAddress
            // 
            this.radioButAddress.AutoSize = true;
            this.radioButAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButAddress.Location = new System.Drawing.Point(112, 206);
            this.radioButAddress.Name = "radioButAddress";
            this.radioButAddress.Size = new System.Drawing.Size(126, 33);
            this.radioButAddress.TabIndex = 10;
            this.radioButAddress.TabStop = true;
            this.radioButAddress.Text = "Address:";
            this.radioButAddress.UseVisualStyleBackColor = true;
            // 
            // radioButtpost
            // 
            this.radioButtpost.AutoSize = true;
            this.radioButtpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtpost.Location = new System.Drawing.Point(112, 316);
            this.radioButtpost.Name = "radioButtpost";
            this.radioButtpost.Size = new System.Drawing.Size(164, 33);
            this.radioButtpost.TabIndex = 11;
            this.radioButtpost.TabStop = true;
            this.radioButtpost.Text = "Postal code:";
            this.radioButtpost.UseVisualStyleBackColor = true;
            // 
            // radiobuttPass
            // 
            this.radiobuttPass.AutoSize = true;
            this.radiobuttPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttPass.Location = new System.Drawing.Point(102, 412);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxConpass);
            this.Controls.Add(this.conPass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.radiobuttPass);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.radioButtpost);
            this.Controls.Add(this.radioButAddress);
            this.Controls.Add(this.radioButEmail);
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
        private System.Windows.Forms.RadioButton radioButEmail;
        private System.Windows.Forms.RadioButton radioButAddress;
        private System.Windows.Forms.RadioButton radioButtpost;
        private System.Windows.Forms.RadioButton radiobuttPass;
        private System.Windows.Forms.Label conPass;
        private System.Windows.Forms.Button button1;
    }
}