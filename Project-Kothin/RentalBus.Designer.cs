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
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(645, 480);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(19, 20);
            this.amount.TabIndex = 43;
            this.amount.Text = "0";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(560, 480);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(79, 20);
            this.Cost.TabIndex = 42;
            this.Cost.Text = "Balance:";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(799, 310);
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
            this.durationChoose.Location = new System.Drawing.Point(900, 315);
            this.durationChoose.Name = "durationChoose";
            this.durationChoose.Size = new System.Drawing.Size(121, 21);
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
            this.classChoose.Size = new System.Drawing.Size(121, 21);
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
            this.carType.Size = new System.Drawing.Size(121, 21);
            this.carType.TabIndex = 38;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
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
            "Withing Dhaka",
            "Savar",
            "Tongi",
            "Gazipur",
            "Naraynganj",
            "Munshiganj",
            "Mawa"});
            this.Destination.Location = new System.Drawing.Point(225, 310);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(121, 21);
            this.Destination.TabIndex = 32;
            // 
            // boatchoice
            // 
            this.boatchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatchoice.Location = new System.Drawing.Point(564, 418);
            this.boatchoice.Name = "boatchoice";
            this.boatchoice.Size = new System.Drawing.Size(75, 23);
            this.boatchoice.TabIndex = 31;
            this.boatchoice.Text = "Submit";
            this.boatchoice.UseVisualStyleBackColor = true;
            this.boatchoice.Click += new System.EventHandler(this.boatchoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bus";
            // 
            // RentalBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 691);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalBus";
            this.Text = "Form1";
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
    }
}