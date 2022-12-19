﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Xml.Linq;

namespace Project_Kothin
{
    public partial class Busseats : Form
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
        private int balance = 0;

        public Busseats()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Selection_Click(object sender, EventArgs e)
        {
        }

        private void Totalamount_Click(object sender, EventArgs e)
        {
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            if (Class_name.Text == "" && Bus_name.Text == "" || Class_name.Text == "" || Bus_name.Text == "")
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                closs.Text = Class_name.Text;
                bos.Text = Bus_name.Text;
                BookBus.Visible = true;
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
            }
        }

        private void amount_Click(object sender, EventArgs e)
        {
        }

        private void Express_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                A1.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag1 = false;
            }
            else
            {
                A1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void A2_Click(object sender, EventArgs e)
        {
            if (flag2 == true)
            {
                A2.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag2 = false;
            }
            else
            {
                A2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void B1_Click(object sender, EventArgs e)
        {
            if (flag3 == true)
            {
                B1.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag3 = false;
            }
            else
            {
                B1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void B2_Click(object sender, EventArgs e)
        {
            if (flag4 == true)
            {
                B2.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag4 = false;
            }
            else
            {
                B2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void C1_Click(object sender, EventArgs e)
        {
            if (flag5 == true)
            {
                C1.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag5 = false;
            }
            else
            {
                C1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void C2_Click(object sender, EventArgs e)
        {
            if (flag6 == true)
            {
                C2.BackColor = Color.Green;
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag6 = false;
            }
            else
            {
                C2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag7 = false;
            }
            else
            {
                D1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag8 = false;
            }
            else
            {
                D2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag9 = false;
            }
            else
            {
                E1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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
                if (Class_name.Text == "AC")
                {
                    balance += 2500;
                    amount.Text = Convert.ToString(balance);
                }
                if (Class_name.Text == "Non-AC")
                {
                    balance += 700;
                    amount.Text = Convert.ToString(balance);
                }

                flag10 = false;
            }
            else
            {
                E2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && Class_name.Text == "AC")
                {
                    balance -= 2500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }

                if (balance != 0 && Class_name.Text == "Non-AC")
                {
                    balance -= 700;
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

        private void BackButton1_Click(object sender, EventArgs e)
        {
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
            Bus_name.Visible = true;
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

        private void Busseats_Load(object sender, EventArgs e)
        {
        }

        private void BookTrain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful!");
            //Login loginbus = new Login();
            //loginbus.Show();

            Document document = new Document();
            //PdfWriter.GetInstance(document, new FileStream("E:/b.pdf", FileMode.Create));
            PdfWriter.GetInstance(document, new FileStream("L:/[AIUB] Assignments/Aiub cse lab/5th Sem Lab/Project-Kothin/Project-Kothin/PDF/Bus_Ticket.pdf", FileMode.Create));

            document.Open();
            //Paragraph p = new Paragraph(Name.Text);
            Paragraph pp = new Paragraph("Reciept");
            Paragraph p1 = new Paragraph(bus.Text + " " + bos.Text);
            Paragraph p2 = new Paragraph(class_label.Text + " " + closs.Text);
            //Paragraph p3 = new Paragraph(PhoneNumber.Text);
            Paragraph p4 = new Paragraph(total.Text + " " + amount.Text);
            //document.Add(p);
            document.Add(pp);
            document.Add(p1);
            document.Add(p2);
            //document.Add(p3);
            document.Add(p4);
            document.Close();
        }

        private void closs_Click(object sender, EventArgs e)
        {
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            string filename = "L:/[AIUB] Assignments/Aiub cse lab/5th Sem Lab/Project-Kothin/Project-Kothin/PDF/Bus_Ticket.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}