namespace Project_Kothin
{
    partial class Boat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boat));
            this.label1 = new System.Windows.Forms.Label();
            this.boatchoice = new System.Windows.Forms.Button();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.boatType = new System.Windows.Forms.ComboBox();
            this.classChoose = new System.Windows.Forms.ComboBox();
            this.durationChoose = new System.Windows.Forms.ComboBox();
            this.Duration = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.DurationRec = new System.Windows.Forms.Label();
            this.DepRec = new System.Windows.Forms.Label();
            this.ClassRec = new System.Windows.Forms.Label();
            this.TypeRec = new System.Windows.Forms.Label();
            this.DesRec = new System.Windows.Forms.Label();
            this.phoneRec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1751, 626);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boat";
            // 
            // boatchoice
            // 
            this.boatchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatchoice.Location = new System.Drawing.Point(1773, 1218);
            this.boatchoice.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.boatchoice.Name = "boatchoice";
            this.boatchoice.Size = new System.Drawing.Size(238, 65);
            this.boatchoice.TabIndex = 1;
            this.boatchoice.Text = "Submit";
            this.boatchoice.UseVisualStyleBackColor = true;
            this.boatchoice.Click += new System.EventHandler(this.boatchoice_Click);
            // 
            // Destination
            // 
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "Dhaka to Chandpur to Dhaka",
            "Dhaka to Bhola to Dhaka",
            "Dhaka to Potuakhali to Dhaka"});
            this.Destination.Location = new System.Drawing.Point(712, 851);
            this.Destination.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(374, 45);
            this.Destination.TabIndex = 2;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(323, 851);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(332, 65);
            this.DestinationLabel.TabIndex = 3;
            this.DestinationLabel.Text = "Destination:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(222, 985);
            this.Date.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(429, 65);
            this.Date.TabIndex = 5;
            this.Date.Text = "Departing Date:";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(712, 996);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(625, 44);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(1539, 837);
            this.Type.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(172, 65);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type:";
            this.Type.Click += new System.EventHandler(this.Type_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(1533, 990);
            this.Class.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(188, 65);
            this.Class.TabIndex = 9;
            this.Class.Text = "Class:";
            // 
            // boatType
            // 
            this.boatType.FormattingEnabled = true;
            this.boatType.Items.AddRange(new object[] {
            "Speed Boat",
            "Cruise Ship",
            "Trawler Boat"});
            this.boatType.Location = new System.Drawing.Point(1773, 851);
            this.boatType.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.boatType.Name = "boatType";
            this.boatType.Size = new System.Drawing.Size(374, 45);
            this.boatType.TabIndex = 10;
            // 
            // classChoose
            // 
            this.classChoose.FormattingEnabled = true;
            this.classChoose.Items.AddRange(new object[] {
            "Class A",
            "Class B"});
            this.classChoose.Location = new System.Drawing.Point(1773, 1005);
            this.classChoose.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.classChoose.Name = "classChoose";
            this.classChoose.Size = new System.Drawing.Size(374, 45);
            this.classChoose.TabIndex = 11;
            // 
            // durationChoose
            // 
            this.durationChoose.FormattingEnabled = true;
            this.durationChoose.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days"});
            this.durationChoose.Location = new System.Drawing.Point(2812, 860);
            this.durationChoose.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.durationChoose.Name = "durationChoose";
            this.durationChoose.Size = new System.Drawing.Size(374, 45);
            this.durationChoose.TabIndex = 12;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(2492, 845);
            this.Duration.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(261, 65);
            this.Duration.TabIndex = 13;
            this.Duration.Text = "Duration:";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(3037, 1237);
            this.Cost.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(219, 55);
            this.Cost.TabIndex = 14;
            this.Cost.Text = "Balance:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(3306, 1237);
            this.amount.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(52, 55);
            this.amount.TabIndex = 15;
            this.amount.Text = "0";
            this.amount.Click += new System.EventHandler(this.label2_Click);
            // 
            // DurationRec
            // 
            this.DurationRec.AutoSize = true;
            this.DurationRec.BackColor = System.Drawing.Color.Transparent;
            this.DurationRec.Location = new System.Drawing.Point(3252, 1156);
            this.DurationRec.Name = "DurationRec";
            this.DurationRec.Size = new System.Drawing.Size(35, 37);
            this.DurationRec.TabIndex = 83;
            this.DurationRec.Text = "0";
            // 
            // DepRec
            // 
            this.DepRec.AutoSize = true;
            this.DepRec.BackColor = System.Drawing.Color.Transparent;
            this.DepRec.Location = new System.Drawing.Point(3252, 1098);
            this.DepRec.Name = "DepRec";
            this.DepRec.Size = new System.Drawing.Size(35, 37);
            this.DepRec.TabIndex = 82;
            this.DepRec.Text = "0";
            // 
            // ClassRec
            // 
            this.ClassRec.AutoSize = true;
            this.ClassRec.BackColor = System.Drawing.Color.Transparent;
            this.ClassRec.Location = new System.Drawing.Point(2727, 1274);
            this.ClassRec.Name = "ClassRec";
            this.ClassRec.Size = new System.Drawing.Size(35, 37);
            this.ClassRec.TabIndex = 81;
            this.ClassRec.Text = "0";
            // 
            // TypeRec
            // 
            this.TypeRec.AutoSize = true;
            this.TypeRec.BackColor = System.Drawing.Color.Transparent;
            this.TypeRec.Location = new System.Drawing.Point(2727, 1212);
            this.TypeRec.Name = "TypeRec";
            this.TypeRec.Size = new System.Drawing.Size(35, 37);
            this.TypeRec.TabIndex = 80;
            this.TypeRec.Text = "0";
            // 
            // DesRec
            // 
            this.DesRec.AutoSize = true;
            this.DesRec.BackColor = System.Drawing.Color.Transparent;
            this.DesRec.Location = new System.Drawing.Point(2727, 1156);
            this.DesRec.Name = "DesRec";
            this.DesRec.Size = new System.Drawing.Size(35, 37);
            this.DesRec.TabIndex = 79;
            this.DesRec.Text = "0";
            // 
            // phoneRec
            // 
            this.phoneRec.AutoSize = true;
            this.phoneRec.BackColor = System.Drawing.Color.Transparent;
            this.phoneRec.Location = new System.Drawing.Point(2727, 1098);
            this.phoneRec.Name = "phoneRec";
            this.phoneRec.Size = new System.Drawing.Size(35, 37);
            this.phoneRec.TabIndex = 78;
            this.phoneRec.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3014, 1098);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 37);
            this.label7.TabIndex = 77;
            this.label7.Text = "Departing Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3107, 1156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 37);
            this.label6.TabIndex = 76;
            this.label6.Text = "Duration: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(2621, 1274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 75;
            this.label5.Text = "Class: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(2631, 1212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 37);
            this.label4.TabIndex = 74;
            this.label4.Text = "Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2541, 1156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 73;
            this.label3.Text = "Destination: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2609, 1098);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 72;
            this.label2.Text = "Phone: ";
            // 
            // Boat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(3797, 1967);
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
            this.Controls.Add(this.boatType);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.boatchoice);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Boat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boat";
            this.Load += new System.EventHandler(this.Boat1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boatchoice;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox boatType;
        private System.Windows.Forms.ComboBox classChoose;
        private System.Windows.Forms.ComboBox durationChoose;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label DurationRec;
        private System.Windows.Forms.Label DepRec;
        private System.Windows.Forms.Label ClassRec;
        private System.Windows.Forms.Label TypeRec;
        private System.Windows.Forms.Label DesRec;
        private System.Windows.Forms.Label phoneRec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}