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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.labelService = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.Ticketbox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.labelRental = new System.Windows.Forms.Label();
            this.rentalBox = new System.Windows.Forms.ComboBox();
            this.rentalSubmit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoginBack = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoginClose = new System.Windows.Forms.LinkLabel();
            this.pictureBoxTicket = new System.Windows.Forms.PictureBox();
            this.pictureBoxRental = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRental)).BeginInit();
            this.SuspendLayout();
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.BackColor = System.Drawing.Color.Transparent;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(543, 259);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(96, 24);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Services:";
            this.labelService.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.BackColor = System.Drawing.Color.Transparent;
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicket.Location = new System.Drawing.Point(775, 374);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(72, 24);
            this.labelTicket.TabIndex = 3;
            this.labelTicket.Text = "Ticket:";
            this.labelTicket.Visible = false;
            // 
            // Ticketbox
            // 
            this.Ticketbox.BackColor = System.Drawing.SystemColors.Window;
            this.Ticketbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ticketbox.FormattingEnabled = true;
            this.Ticketbox.IntegralHeight = false;
            this.Ticketbox.Items.AddRange(new object[] {
            "Train",
            "Bus"});
            this.Ticketbox.Location = new System.Drawing.Point(779, 417);
            this.Ticketbox.Name = "Ticketbox";
            this.Ticketbox.Size = new System.Drawing.Size(141, 21);
            this.Ticketbox.TabIndex = 4;
            this.Ticketbox.Visible = false;
            this.Ticketbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1024, 613);
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
            this.SubmitButton.Location = new System.Drawing.Point(547, 619);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // labelRental
            // 
            this.labelRental.AutoSize = true;
            this.labelRental.BackColor = System.Drawing.Color.Transparent;
            this.labelRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRental.Location = new System.Drawing.Point(307, 402);
            this.labelRental.Name = "labelRental";
            this.labelRental.Size = new System.Drawing.Size(75, 24);
            this.labelRental.TabIndex = 7;
            this.labelRental.Text = "Rental:";
            this.labelRental.Visible = false;
            this.labelRental.Click += new System.EventHandler(this.labelRental_Click);
            // 
            // rentalBox
            // 
            this.rentalBox.BackColor = System.Drawing.SystemColors.Window;
            this.rentalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentalBox.FormattingEnabled = true;
            this.rentalBox.IntegralHeight = false;
            this.rentalBox.Items.AddRange(new object[] {
            "Car",
            "Boat",
            "Bus"});
            this.rentalBox.Location = new System.Drawing.Point(311, 445);
            this.rentalBox.Name = "rentalBox";
            this.rentalBox.Size = new System.Drawing.Size(141, 21);
            this.rentalBox.TabIndex = 8;
            this.rentalBox.Visible = false;
            this.rentalBox.SelectedIndexChanged += new System.EventHandler(this.rentalBox_SelectedIndexChanged);
            // 
            // rentalSubmit
            // 
            this.rentalSubmit.Location = new System.Drawing.Point(547, 619);
            this.rentalSubmit.Name = "rentalSubmit";
            this.rentalSubmit.Size = new System.Drawing.Size(75, 23);
            this.rentalSubmit.TabIndex = 9;
            this.rentalSubmit.Text = "Submit";
            this.rentalSubmit.UseVisualStyleBackColor = true;
            this.rentalSubmit.Visible = false;
            this.rentalSubmit.Click += new System.EventHandler(this.rentalSubmit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(975, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 29);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Welcome,";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.linkLabelLoginBack.TabIndex = 29;
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
            this.linkLabelLoginClose.TabIndex = 30;
            this.linkLabelLoginClose.TabStop = true;
            this.linkLabelLoginClose.Text = "❌";
            this.linkLabelLoginClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginClose_LinkClicked);
            // 
            // pictureBoxTicket
            // 
            this.pictureBoxTicket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTicket.Image = global::Project_Kothin.Properties.Resources.ticket_er_chobi;
            this.pictureBoxTicket.Location = new System.Drawing.Point(235, 322);
            this.pictureBoxTicket.Name = "pictureBoxTicket";
            this.pictureBoxTicket.Size = new System.Drawing.Size(260, 258);
            this.pictureBoxTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTicket.TabIndex = 31;
            this.pictureBoxTicket.TabStop = false;
            this.pictureBoxTicket.Click += new System.EventHandler(this.pictureBoxTicket_Click);
            // 
            // pictureBoxRental
            // 
            this.pictureBoxRental.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRental.Image = global::Project_Kothin.Properties.Resources.rental_er_sobi__2_;
            this.pictureBoxRental.Location = new System.Drawing.Point(695, 335);
            this.pictureBoxRental.Name = "pictureBoxRental";
            this.pictureBoxRental.Size = new System.Drawing.Size(328, 210);
            this.pictureBoxRental.TabIndex = 32;
            this.pictureBoxRental.TabStop = false;
            this.pictureBoxRental.Click += new System.EventHandler(this.pictureBoxRental_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 730);
            this.Controls.Add(this.rentalBox);
            this.Controls.Add(this.labelRental);
            this.Controls.Add(this.linkLabelLoginClose);
            this.Controls.Add(this.linkLabelLoginBack);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rentalSubmit);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Ticketbox);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.pictureBoxTicket);
            this.Controls.Add(this.pictureBoxRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.ComboBox Ticketbox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label labelRental;
        private System.Windows.Forms.ComboBox rentalBox;
        private System.Windows.Forms.Button rentalSubmit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelLoginBack;
        private System.Windows.Forms.LinkLabel linkLabelLoginClose;
        private System.Windows.Forms.PictureBox pictureBoxTicket;
        private System.Windows.Forms.PictureBox pictureBoxRental;
    }
}

