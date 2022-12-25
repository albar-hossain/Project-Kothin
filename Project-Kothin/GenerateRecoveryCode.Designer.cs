namespace Project_Kothin
{
    partial class GenerateRecoveryCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateRecoveryCode));
            this.linkLabelRecoveryClose = new System.Windows.Forms.LinkLabel();
            this.labelResetRecoveryCode = new System.Windows.Forms.Label();
            this.textBoxResetRecoveryCode = new System.Windows.Forms.TextBox();
            this.buttonRecoveryCopyClipboard = new System.Windows.Forms.Button();
            this.labelRecoveryCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelRecoveryClose
            // 
            this.linkLabelRecoveryClose.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelRecoveryClose.AutoSize = true;
            this.linkLabelRecoveryClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRecoveryClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecoveryClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRecoveryClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.linkLabelRecoveryClose.Location = new System.Drawing.Point(539, 9);
            this.linkLabelRecoveryClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabelRecoveryClose.Name = "linkLabelRecoveryClose";
            this.linkLabelRecoveryClose.Size = new System.Drawing.Size(47, 31);
            this.linkLabelRecoveryClose.TabIndex = 29;
            this.linkLabelRecoveryClose.TabStop = true;
            this.linkLabelRecoveryClose.Text = "❌";
            this.linkLabelRecoveryClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResetClose_LinkClicked);
            // 
            // labelResetRecoveryCode
            // 
            this.labelResetRecoveryCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResetRecoveryCode.AutoSize = true;
            this.labelResetRecoveryCode.BackColor = System.Drawing.Color.Transparent;
            this.labelResetRecoveryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetRecoveryCode.ForeColor = System.Drawing.Color.Black;
            this.labelResetRecoveryCode.Location = new System.Drawing.Point(13, 63);
            this.labelResetRecoveryCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResetRecoveryCode.Name = "labelResetRecoveryCode";
            this.labelResetRecoveryCode.Size = new System.Drawing.Size(185, 29);
            this.labelResetRecoveryCode.TabIndex = 31;
            this.labelResetRecoveryCode.Text = "Recovery Code:";
            // 
            // textBoxResetRecoveryCode
            // 
            this.textBoxResetRecoveryCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxResetRecoveryCode.BackColor = System.Drawing.Color.Silver;
            this.textBoxResetRecoveryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResetRecoveryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResetRecoveryCode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxResetRecoveryCode.Location = new System.Drawing.Point(208, 65);
            this.textBoxResetRecoveryCode.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResetRecoveryCode.Name = "textBoxResetRecoveryCode";
            this.textBoxResetRecoveryCode.ReadOnly = true;
            this.textBoxResetRecoveryCode.Size = new System.Drawing.Size(164, 29);
            this.textBoxResetRecoveryCode.TabIndex = 30;
            this.textBoxResetRecoveryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResetRecoveryCode.TextChanged += new System.EventHandler(this.textBoxResetRecoveryCode_TextChanged);
            // 
            // buttonRecoveryCopyClipboard
            // 
            this.buttonRecoveryCopyClipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRecoveryCopyClipboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRecoveryCopyClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.buttonRecoveryCopyClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecoveryCopyClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecoveryCopyClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecoveryCopyClipboard.ForeColor = System.Drawing.Color.Black;
            this.buttonRecoveryCopyClipboard.Location = new System.Drawing.Point(382, 66);
            this.buttonRecoveryCopyClipboard.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRecoveryCopyClipboard.Name = "buttonRecoveryCopyClipboard";
            this.buttonRecoveryCopyClipboard.Size = new System.Drawing.Size(147, 29);
            this.buttonRecoveryCopyClipboard.TabIndex = 32;
            this.buttonRecoveryCopyClipboard.Text = "COPY";
            this.buttonRecoveryCopyClipboard.UseVisualStyleBackColor = false;
            this.buttonRecoveryCopyClipboard.Click += new System.EventHandler(this.buttonRecoveryCopyClipboard_Click);
            // 
            // labelRecoveryCode
            // 
            this.labelRecoveryCode.AutoSize = true;
            this.labelRecoveryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecoveryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.labelRecoveryCode.Location = new System.Drawing.Point(173, 127);
            this.labelRecoveryCode.Name = "labelRecoveryCode";
            this.labelRecoveryCode.Size = new System.Drawing.Size(258, 20);
            this.labelRecoveryCode.TabIndex = 33;
            this.labelRecoveryCode.Text = "Note: Save this code for future use.";
            // 
            // GenerateRecoveryCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 170);
            this.Controls.Add(this.labelRecoveryCode);
            this.Controls.Add(this.buttonRecoveryCopyClipboard);
            this.Controls.Add(this.labelResetRecoveryCode);
            this.Controls.Add(this.textBoxResetRecoveryCode);
            this.Controls.Add(this.linkLabelRecoveryClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GenerateRecoveryCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateRecoveryCode";
            this.Load += new System.EventHandler(this.GenerateRecoveryCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelRecoveryClose;
        private System.Windows.Forms.Label labelResetRecoveryCode;
        private System.Windows.Forms.TextBox textBoxResetRecoveryCode;
        private System.Windows.Forms.Button buttonRecoveryCopyClipboard;
        private System.Windows.Forms.Label labelRecoveryCode;
    }
}