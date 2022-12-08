namespace Project_Kothin
{
    partial class Service
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
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonRental = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTicket
            // 
            this.buttonTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.Location = new System.Drawing.Point(145, 193);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(75, 38);
            this.buttonTicket.TabIndex = 0;
            this.buttonTicket.Text = "Ticket";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRental.Location = new System.Drawing.Point(145, 237);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Size = new System.Drawing.Size(75, 40);
            this.buttonRental.TabIndex = 1;
            this.buttonRental.Text = "Rental";
            this.buttonRental.UseVisualStyleBackColor = true;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(141, 150);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(96, 24);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Services:";
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicket.Location = new System.Drawing.Point(325, 150);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(72, 24);
            this.labelTicket.TabIndex = 3;
            this.labelTicket.Text = "Ticket:";
            this.labelTicket.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Train",
            "Bus"});
            this.comboBox1.Location = new System.Drawing.Point(329, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(552, 360);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 35);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(329, 237);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.buttonRental);
            this.Controls.Add(this.buttonTicket);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}

