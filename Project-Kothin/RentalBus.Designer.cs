namespace Project_Kothin
{
    partial class RentalBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalBus));
            this.amount = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.durationChoose = new System.Windows.Forms.ComboBox();
            this.classChoose = new System.Windows.Forms.ComboBox();
            this.carType = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.boatchoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneRec = new System.Windows.Forms.Label();
            this.DesRec = new System.Windows.Forms.Label();
            this.TypeRec = new System.Windows.Forms.Label();
            this.ClassRec = new System.Windows.Forms.Label();
            this.DepRec = new System.Windows.Forms.Label();
            this.DurationRec = new System.Windows.Forms.Label();
            this.linkLabelLoginClose = new System.Windows.Forms.LinkLabel();
            this.pdf = new System.Windows.Forms.Button();
            this.linkLabelLoginBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(929, 486);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(13, 13);
            this.amount.TabIndex = 43;
            this.amount.Text = "0";
            // 
            // Cost
            // 
            this.Cost.BackColor = System.Drawing.Color.Transparent;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(860, 484);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(64, 20);
            this.Cost.TabIndex = 42;
            this.Cost.Text = "Balance:";
            this.Cost.Click += new System.EventHandler(this.Cost_Click);
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.BackColor = System.Drawing.Color.Transparent;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(795, 307);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(85, 24);
            this.Duration.TabIndex = 41;
            this.Duration.Text = "Duration:";
            // 
            // durationChoose
            // 
            this.durationChoose.FormattingEnabled = true;
            this.durationChoose.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days"});
            this.durationChoose.Location = new System.Drawing.Point(886, 308);
            this.durationChoose.Name = "durationChoose";
            this.durationChoose.Size = new System.Drawing.Size(128, 21);
            this.durationChoose.TabIndex = 40;
            // 
            // classChoose
            // 
            this.classChoose.FormattingEnabled = true;
            this.classChoose.Items.AddRange(new object[] {
            "Class A",
            "Class B"});
            this.classChoose.Location = new System.Drawing.Point(564, 364);
            this.classChoose.Name = "classChoose";
            this.classChoose.Size = new System.Drawing.Size(150, 21);
            this.classChoose.TabIndex = 39;
            // 
            // carType
            // 
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "AC",
            "Non-AC",
            "Mini Bus"});
            this.carType.Location = new System.Drawing.Point(564, 310);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(150, 21);
            this.carType.TabIndex = 38;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.BackColor = System.Drawing.Color.Transparent;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(488, 359);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(60, 24);
            this.Class.TabIndex = 37;
            this.Class.Text = "Class:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.BackColor = System.Drawing.Color.Transparent;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(490, 305);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(58, 24);
            this.Type.TabIndex = 36;
            this.Type.Text = "Type:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(70, 357);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(139, 24);
            this.Date.TabIndex = 34;
            this.Date.Text = "Departing Date:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.BackColor = System.Drawing.Color.Transparent;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(102, 310);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(107, 24);
            this.DestinationLabel.TabIndex = 33;
            this.DestinationLabel.Text = "Destination:";
            // 
            // Destination
            // 
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "Within Dhaka",
            "Savar",
            "Tongi",
            "Gazipur",
            "Naraynganj",
            "Munshiganj",
            "Mawa"});
            this.Destination.Location = new System.Drawing.Point(225, 310);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(200, 21);
            this.Destination.TabIndex = 32;
            // 
            // boatchoice
            // 
            this.boatchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatchoice.Location = new System.Drawing.Point(546, 647);
            this.boatchoice.Name = "boatchoice";
            this.boatchoice.Size = new System.Drawing.Size(139, 37);
            this.boatchoice.TabIndex = 31;
            this.boatchoice.Text = "Submit";
            this.boatchoice.UseVisualStyleBackColor = true;
            this.boatchoice.Click += new System.EventHandler(this.boatchoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(883, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Phone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(861, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Destination: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(889, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Type: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(886, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Class: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(871, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Duration: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(839, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Departing Date: ";
            // 
            // phoneRec
            // 
            this.phoneRec.AutoSize = true;
            this.phoneRec.BackColor = System.Drawing.Color.Transparent;
            this.phoneRec.Location = new System.Drawing.Point(929, 361);
            this.phoneRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.phoneRec.Name = "phoneRec";
            this.phoneRec.Size = new System.Drawing.Size(13, 13);
            this.phoneRec.TabIndex = 50;
            this.phoneRec.Text = "0";
            this.phoneRec.Click += new System.EventHandler(this.label8_Click);
            // 
            // DesRec
            // 
            this.DesRec.AutoSize = true;
            this.DesRec.BackColor = System.Drawing.Color.Transparent;
            this.DesRec.Location = new System.Drawing.Point(929, 381);
            this.DesRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DesRec.Name = "DesRec";
            this.DesRec.Size = new System.Drawing.Size(13, 13);
            this.DesRec.TabIndex = 51;
            this.DesRec.Text = "0";
            this.DesRec.Click += new System.EventHandler(this.label9_Click);
            // 
            // TypeRec
            // 
            this.TypeRec.AutoSize = true;
            this.TypeRec.BackColor = System.Drawing.Color.Transparent;
            this.TypeRec.Location = new System.Drawing.Point(929, 401);
            this.TypeRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TypeRec.Name = "TypeRec";
            this.TypeRec.Size = new System.Drawing.Size(13, 13);
            this.TypeRec.TabIndex = 52;
            this.TypeRec.Text = "0";
            // 
            // ClassRec
            // 
            this.ClassRec.AutoSize = true;
            this.ClassRec.BackColor = System.Drawing.Color.Transparent;
            this.ClassRec.Location = new System.Drawing.Point(929, 423);
            this.ClassRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ClassRec.Name = "ClassRec";
            this.ClassRec.Size = new System.Drawing.Size(13, 13);
            this.ClassRec.TabIndex = 53;
            this.ClassRec.Text = "0";
            // 
            // DepRec
            // 
            this.DepRec.AutoSize = true;
            this.DepRec.BackColor = System.Drawing.Color.Transparent;
            this.DepRec.Location = new System.Drawing.Point(929, 446);
            this.DepRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DepRec.Name = "DepRec";
            this.DepRec.Size = new System.Drawing.Size(13, 13);
            this.DepRec.TabIndex = 54;
            this.DepRec.Text = "0";
            // 
            // DurationRec
            // 
            this.DurationRec.AutoSize = true;
            this.DurationRec.BackColor = System.Drawing.Color.Transparent;
            this.DurationRec.Location = new System.Drawing.Point(929, 466);
            this.DurationRec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DurationRec.Name = "DurationRec";
            this.DurationRec.Size = new System.Drawing.Size(13, 13);
            this.DurationRec.TabIndex = 55;
            this.DurationRec.Text = "0";
            // 
            // linkLabelLoginClose
            // 
            this.linkLabelLoginClose.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLoginClose.AutoSize = true;
            this.linkLabelLoginClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLoginClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLoginClose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.linkLabelLoginClose.Location = new System.Drawing.Point(1154, 9);
            this.linkLabelLoginClose.Name = "linkLabelLoginClose";
            this.linkLabelLoginClose.Size = new System.Drawing.Size(49, 33);
            this.linkLabelLoginClose.TabIndex = 56;
            this.linkLabelLoginClose.TabStop = true;
            this.linkLabelLoginClose.Text = "❌";
            this.linkLabelLoginClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginClose_LinkClicked);
            // 
            // pdf
            // 
            this.pdf.Location = new System.Drawing.Point(907, 552);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(142, 23);
            this.pdf.TabIndex = 57;
            this.pdf.Text = "Download Invoice";
            this.pdf.UseVisualStyleBackColor = true;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
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
            this.linkLabelLoginBack.TabIndex = 87;
            this.linkLabelLoginBack.TabStop = true;
            this.linkLabelLoginBack.Text = "🡰";
            this.linkLabelLoginBack.Visible = false;
            this.linkLabelLoginBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginBack_LinkClicked);
            // 
            // RentalBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 730);
            this.Controls.Add(this.linkLabelLoginBack);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.linkLabelLoginClose);
            this.Controls.Add(this.DurationRec);
            this.Controls.Add(this.DepRec);
            this.Controls.Add(this.ClassRec);
            this.Controls.Add(this.TypeRec);
            this.Controls.Add(this.DesRec);
            this.Controls.Add(this.phoneRec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.durationChoose);
            this.Controls.Add(this.classChoose);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.boatchoice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(370, 215);
            this.Name = "RentalBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.RentalBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.ComboBox durationChoose;
        private System.Windows.Forms.ComboBox classChoose;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.Button boatchoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phoneRec;
        private System.Windows.Forms.Label DesRec;
        private System.Windows.Forms.Label TypeRec;
        private System.Windows.Forms.Label ClassRec;
        private System.Windows.Forms.Label DepRec;
        private System.Windows.Forms.Label DurationRec;
        private System.Windows.Forms.LinkLabel linkLabelLoginClose;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.LinkLabel linkLabelLoginBack;
    }
}