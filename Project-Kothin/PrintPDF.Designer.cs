namespace Project_Kothin
{
    partial class PrintPDF
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
            this.buttonPrintPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrintPdf
            // 
            this.buttonPrintPdf.Location = new System.Drawing.Point(197, 147);
            this.buttonPrintPdf.Name = "buttonPrintPdf";
            this.buttonPrintPdf.Size = new System.Drawing.Size(252, 141);
            this.buttonPrintPdf.TabIndex = 0;
            this.buttonPrintPdf.Text = "PRINT PDF";
            this.buttonPrintPdf.UseVisualStyleBackColor = true;
            this.buttonPrintPdf.Click += new System.EventHandler(this.buttonPrintPdf_Click);
            // 
            // PrintPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrintPdf);
            this.Name = "PrintPDF";
            this.Text = "PrintPDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintPdf;
    }
}