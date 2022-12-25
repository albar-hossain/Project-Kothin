namespace Project_Kothin
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.welcomadmintxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabelLoginClose = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.porjotonDataSet1 = new Project_Kothin.PorjotonDataSet1();
            this.porjotonDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjotonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjotonDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomadmintxt
            // 
            this.welcomadmintxt.AutoSize = true;
            this.welcomadmintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomadmintxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.welcomadmintxt.Location = new System.Drawing.Point(472, 9);
            this.welcomadmintxt.Name = "welcomadmintxt";
            this.welcomadmintxt.Size = new System.Drawing.Size(231, 31);
            this.welcomadmintxt.TabIndex = 1;
            this.welcomadmintxt.Text = "Welcome, Admin";
            this.welcomadmintxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by Phone Number:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
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
            this.linkLabelLoginClose.TabIndex = 30;
            this.linkLabelLoginClose.TabStop = true;
            this.linkLabelLoginClose.Text = "❌";
            this.linkLabelLoginClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginClose_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.porjotonDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(189, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 319);
            this.dataGridView1.TabIndex = 31;
            // 
            // porjotonDataSet1
            // 
            this.porjotonDataSet1.DataSetName = "PorjotonDataSet1";
            this.porjotonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porjotonDataSet1BindingSource
            // 
            this.porjotonDataSet1BindingSource.DataSource = this.porjotonDataSet1;
            this.porjotonDataSet1BindingSource.Position = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 730);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabelLoginClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.welcomadmintxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjotonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porjotonDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomadmintxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabelLoginClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource porjotonDataSet1BindingSource;
        private PorjotonDataSet1 porjotonDataSet1;
    }
}