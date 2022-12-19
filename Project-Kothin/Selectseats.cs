using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class Selectseats : Form
    {
        private bool flag1 = true;
        private bool flag2 = true;
        private bool flag3 = true;
        private bool flag4 = true;
        private bool flag5 = true;
        private bool flag6 = true;
        private bool flag7 = true;
        private bool flag8 = true;
        private bool flag9 = true;
        private bool flag10 = true;
        private double balance = 0;

        public Selectseats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                A1.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag1 = false;
            }
            else
            {
                A1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag1 = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag2 == true)
            {
                A2.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag2 = false;
            }
            else
            {
                A2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag2 = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag3 == true)
            {
                C2.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag3 = false;
            }
            else
            {
                C2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag3 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (classSelection.Text == "" && Express.Text == "" || classSelection.Text == "" || Express.Text == "")
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                tronName.Text = Express.Name;
                closs.Text = classSelection.Text;
                BookTrain.Visible = true;
                A1.Visible = true;
                A2.Visible = true;
                B1.Visible = true;
                B2.Visible = true;
                C1.Visible = true;
                C2.Visible = true;
                D1.Visible = true;
                D2.Visible = true;
                E1.Visible = true;
                E2.Visible = true;
                BackButton1.Visible = true;
                Seats.Visible = true;
                SEARCH.Visible = false;

                Selection.Visible = false;
                Express.Visible = false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BookTrain.Visible = false;
            A1.Visible = false;
            A2.Visible = false;
            B1.Visible = false;
            B2.Visible = false;
            C1.Visible = false;
            C2.Visible = false;
            D1.Visible = false;
            D2.Visible = false;
            E1.Visible = false;
            E2.Visible = false;
            SEARCH.Visible = true;
            Selection.Visible = true;
            Express.Visible = true;
            BackButton1.Visible = false;
            Seats.Visible = false;
            balance = 0;
            amount.Text = Convert.ToString(balance);
            A1.BackColor = Color.FromKnownColor(KnownColor.Control);
            A2.BackColor = Color.FromKnownColor(KnownColor.Control);
            B1.BackColor = Color.FromKnownColor(KnownColor.Control);
            B2.BackColor = Color.FromKnownColor(KnownColor.Control);
            C1.BackColor = Color.FromKnownColor(KnownColor.Control);
            C2.BackColor = Color.FromKnownColor(KnownColor.Control);
            D1.BackColor = Color.FromKnownColor(KnownColor.Control);
            D2.BackColor = Color.FromKnownColor(KnownColor.Control);
            E1.BackColor = Color.FromKnownColor(KnownColor.Control);
            E2.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (flag4 == true)
            {
                B1.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag4 = false;
            }
            else
            {
                B1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag4 = true;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (flag5 == true)
            {
                B2.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag5 = false;
            }
            else
            {
                B2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag5 = true;
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (flag6 == true)
            {
                C1.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag6 = false;
            }
            else
            {
                C1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag6 = true;
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (flag7 == true)
            {
                D1.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag7 = false;
            }
            else
            {
                D1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag7 = true;
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (flag8 == true)
            {
                D2.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag8 = false;
            }
            else
            {
                D2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag8 = true;
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (flag9 == true)
            {
                E1.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag9 = false;
            }
            else
            {
                E1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag9 = true;
            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (flag10 == true)
            {
                E2.BackColor = Color.Green;
                if (classSelection.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "AC_berth")
                {
                    balance += 1500;
                    amount.Text = Convert.ToString(balance);
                }
                if (classSelection.Text == "Shovon")
                {
                    balance += 300;
                    amount.Text = Convert.ToString(balance);
                }
                flag10 = false;
            }
            else
            {
                E2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && classSelection.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                if (balance != 0 && classSelection.Text == "AC_berth")
                {
                    balance -= 1500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && classSelection.Text == "Shovon")
                {
                    balance -= 300;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag10 = true;
            }
        }

        private void BookTrain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful!");
            //Login loginTrain = new Login();
            //loginTrain.Show();
            Document document = new Document();
            //PdfWriter.GetInstance(document, new FileStream("E:/a.pdf", FileMode.Create));
            PdfWriter.GetInstance(document, new FileStream("C:\\Users\\azwad\\OneDrive - American International University-Bangladesh\\Desktop\\project pdfs/b.pdf", FileMode.Create));
            document.Open();
            //Paragraph p = new Paragraph(Name.Text);
            Paragraph pp = new Paragraph("Reciept");
            Paragraph p1 = new Paragraph(nom.Text + " " + tronName.Text);
            Paragraph p2 = new Paragraph(class_label.Text + " " + closs.Text);
            //Paragraph p3 = new Paragraph(PhoneNumber.Text);
            Paragraph p4 = new Paragraph(Totalamount.Text + " " + amount.Text);
            //document.Add(p);
            document.Add(pp);
            document.Add(p1);
            document.Add(p2);
            //document.Add(p3);
            document.Add(p4);
            document.Close();
        }

        private void Selectseats_Load(object sender, EventArgs e)
        {
        }

        private void Class_Click(object sender, EventArgs e)
        {
        }

        private void amount_Click(object sender, EventArgs e)
        {
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            string filename = "C:\\Users\\azwad\\OneDrive - American International University-Bangladesh\\Desktop\\project pdfs/b.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}