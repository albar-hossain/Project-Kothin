
namespace Project_Kothin
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.SEARCHTRAIN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SEARCHBUS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketlabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SEARCHTRAIN
            // 
            this.SEARCHTRAIN.Location = new System.Drawing.Point(523, 475);
            this.SEARCHTRAIN.Name = "SEARCHTRAIN";
            this.SEARCHTRAIN.Size = new System.Drawing.Size(144, 23);
            this.SEARCHTRAIN.TabIndex = 0;
            this.SEARCHTRAIN.Text = "SEARCH TRAIN";
            this.SEARCHTRAIN.UseVisualStyleBackColor = true;
            this.SEARCHTRAIN.Visible = false;
            this.SEARCHTRAIN.Click += new System.EventHandler(this.SEARCHTRAIN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rajshahi"});
            this.comboBox2.Location = new System.Drawing.Point(693, 283);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departure:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rajshahi"});
            this.comboBox1.Location = new System.Drawing.Point(313, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SEARCHBUS
            // 
            this.SEARCHBUS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SEARCHBUS.Location = new System.Drawing.Point(523, 475);
            this.SEARCHBUS.Name = "SEARCHBUS";
            this.SEARCHBUS.Size = new System.Drawing.Size(144, 23);
            this.SEARCHBUS.TabIndex = 9;
            this.SEARCHBUS.Text = "SEARCH BUS";
            this.SEARCHBUS.UseVisualStyleBackColor = true;
            this.SEARCHBUS.Visible = false;
            this.SEARCHBUS.Click += new System.EventHandler(this.SEARCHBUS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "label1";
            // 
            // ticketlabel
            // 
            this.ticketlabel.AutoSize = true;
            this.ticketlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketlabel.Location = new System.Drawing.Point(977, 71);
            this.ticketlabel.Name = "ticketlabel";
            this.ticketlabel.Size = new System.Drawing.Size(121, 29);
            this.ticketlabel.TabIndex = 11;
            this.ticketlabel.TabStop = true;
            this.ticketlabel.Text = "Welcome,";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 691);
            this.Controls.Add(this.ticketlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SEARCHBUS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SEARCHTRAIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket";
            this.Text = "Train";
            this.Load += new System.EventHandler(this.Train_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEARCHTRAIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SEARCHBUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ticketlabel;
    }
}