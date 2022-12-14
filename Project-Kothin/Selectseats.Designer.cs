
namespace Project_Kothin
{
    partial class Selectseats
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
            this.Express = new System.Windows.Forms.ComboBox();
            this.Selection = new System.Windows.Forms.Label();
            this.SEARCH = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.E1 = new System.Windows.Forms.Button();
            this.E2 = new System.Windows.Forms.Button();
            this.Seats = new System.Windows.Forms.GroupBox();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.BookTrain = new System.Windows.Forms.Button();
            this.Totalamount = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.Label();
            this.Seats.SuspendLayout();
            this.SuspendLayout();
            // 
            // Express
            // 
            this.Express.FormattingEnabled = true;
            this.Express.Items.AddRange(new object[] {
            "PADMA EXPRESS",
            "UPABAN EXPRESS",
            "SAGARDARI EXPRESS",
            "CHITTRA EXPRESS"});
            this.Express.Location = new System.Drawing.Point(52, 240);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(143, 21);
            this.Express.TabIndex = 0;
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.Location = new System.Drawing.Point(48, 213);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(265, 24);
            this.Selection.TabIndex = 1;
            this.Selection.Text = "Select Your Preferred Train";
            this.Selection.Click += new System.EventHandler(this.label1_Click);
            // 
            // SEARCH
            // 
            this.SEARCH.Location = new System.Drawing.Point(52, 267);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(75, 23);
            this.SEARCH.TabIndex = 2;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = true;
            this.SEARCH.Click += new System.EventHandler(this.button1_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A1.Location = new System.Drawing.Point(19, 84);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 23);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Visible = false;
            this.A1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A2.Location = new System.Drawing.Point(159, 84);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 23);
            this.A2.TabIndex = 1;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Visible = false;
            this.A2.Click += new System.EventHandler(this.button3_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B1.Location = new System.Drawing.Point(19, 147);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 24);
            this.B1.TabIndex = 2;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Visible = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B2.Location = new System.Drawing.Point(159, 147);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 3;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Visible = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C1.Location = new System.Drawing.Point(19, 205);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 23);
            this.C1.TabIndex = 4;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Visible = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C2.Location = new System.Drawing.Point(159, 205);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 23);
            this.C2.TabIndex = 5;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Visible = false;
            this.C2.Click += new System.EventHandler(this.button7_Click);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D1.Location = new System.Drawing.Point(19, 265);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(75, 23);
            this.D1.TabIndex = 6;
            this.D1.Text = "D1";
            this.D1.UseVisualStyleBackColor = false;
            this.D1.Visible = false;
            this.D1.Click += new System.EventHandler(this.D1_Click);
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D2.Location = new System.Drawing.Point(159, 265);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(75, 23);
            this.D2.TabIndex = 7;
            this.D2.Text = "D2";
            this.D2.UseVisualStyleBackColor = false;
            this.D2.Visible = false;
            this.D2.Click += new System.EventHandler(this.D2_Click);
            // 
            // E1
            // 
            this.E1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E1.Location = new System.Drawing.Point(19, 326);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(75, 23);
            this.E1.TabIndex = 8;
            this.E1.Text = "E1";
            this.E1.UseVisualStyleBackColor = false;
            this.E1.Visible = false;
            this.E1.Click += new System.EventHandler(this.E1_Click);
            // 
            // E2
            // 
            this.E2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.E2.Location = new System.Drawing.Point(159, 326);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(75, 23);
            this.E2.TabIndex = 9;
            this.E2.Text = "E2";
            this.E2.UseVisualStyleBackColor = false;
            this.E2.Visible = false;
            this.E2.Click += new System.EventHandler(this.E2_Click);
            // 
            // Seats
            // 
            this.Seats.Controls.Add(this.E2);
            this.Seats.Controls.Add(this.E1);
            this.Seats.Controls.Add(this.D2);
            this.Seats.Controls.Add(this.D1);
            this.Seats.Controls.Add(this.C2);
            this.Seats.Controls.Add(this.C1);
            this.Seats.Controls.Add(this.B2);
            this.Seats.Controls.Add(this.B1);
            this.Seats.Controls.Add(this.A2);
            this.Seats.Controls.Add(this.A1);
            this.Seats.Location = new System.Drawing.Point(338, 12);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(247, 401);
            this.Seats.TabIndex = 3;
            this.Seats.TabStop = false;
            this.Seats.Text = "Seats";
            this.Seats.Visible = false;
            this.Seats.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BackButton1
            // 
            this.BackButton1.Location = new System.Drawing.Point(681, 403);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(107, 35);
            this.BackButton1.TabIndex = 6;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = true;
            this.BackButton1.Visible = false;
            this.BackButton1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BookTrain
            // 
            this.BookTrain.Location = new System.Drawing.Point(430, 419);
            this.BookTrain.Name = "BookTrain";
            this.BookTrain.Size = new System.Drawing.Size(75, 23);
            this.BookTrain.TabIndex = 7;
            this.BookTrain.Text = "Book";
            this.BookTrain.UseVisualStyleBackColor = true;
            this.BookTrain.Visible = false;
            this.BookTrain.Click += new System.EventHandler(this.BookTrain_Click);
            // 
            // Totalamount
            // 
            this.Totalamount.AutoSize = true;
            this.Totalamount.Location = new System.Drawing.Point(49, 343);
            this.Totalamount.Name = "Totalamount";
            this.Totalamount.Size = new System.Drawing.Size(72, 13);
            this.Totalamount.TabIndex = 8;
            this.Totalamount.Text = "Total amount:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(127, 343);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(13, 13);
            this.amount.TabIndex = 9;
            this.amount.Text = "0";
            this.amount.Click += new System.EventHandler(this.amount_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Snigdha",
            "AC_berth",
            "Shovon"});
            this.comboBox3.Location = new System.Drawing.Point(52, 162);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(49, 136);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(58, 20);
            this.Class.TabIndex = 11;
            this.Class.Text = "Class:";
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Selectseats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.Totalamount);
            this.Controls.Add(this.BookTrain);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Express);
            this.Name = "Selectseats";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Selectseats_Load);
            this.Seats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Express;
        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button D1;
        private System.Windows.Forms.Button D2;
        private System.Windows.Forms.Button E1;
        private System.Windows.Forms.Button E2;
        private System.Windows.Forms.GroupBox Seats;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.Button BookTrain;
        private System.Windows.Forms.Label Totalamount;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Class;
    }
}