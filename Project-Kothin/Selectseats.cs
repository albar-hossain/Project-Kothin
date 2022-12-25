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
using System.Data.SqlClient;
using IronPdf;

namespace Project_Kothin
{
    public partial class Selectseats : Form
    {
        public string phone;
        private static double invoice = 0001d;
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

        public Selectseats(string username, string departure, string destination, string time)
        {
            InitializeComponent();
            phone = username;
            linkLabel1.Text = username;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select FullName from UserInfo where Phone = {linkLabel1.Text}";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["FullName"].ToString();
                linkLabel1.Text = val;
                nom.Text = phone;
                dest.Text = destination;
                depa.Text = departure;
                dot.Text = time;
                label4.Text = "TRAIN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
                tronName.Text = Express.Text;
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
            string name = linkLabel1.Text;
            string number = nom.Text;
            string type = label4.Text;
            string Tname = tronName.Text;
            string Tclass = closs.Text;
            string Department = depa.Text;
            string destination = dest.Text;
            string date = dot.Text;
            string balance = amount.Text;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();
                string query = $"insert into TicketInfo (FullName, PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date, Amount) VALUES ('{name}','{number}','{type}','{Tname}','{Tclass}','{Department}','{destination}','{date}','{balance}')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

        private void pdf_Click(object sender, EventArgs e)
        {
            var Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer
            var pdf = Renderer.RenderHtmlAsPdf($" <div bgcolor=\"#f6f6f6\" style=\"color: #333; height: 100%; width: 100%;\" height=\"100%\" width=\"100%\"> <table bgcolor=\"#f6f6f6\" cellspacing=\"0\" style=\"border-collapse: collapse; padding: 40px; width: 100%;\" width=\"100%\"> <tbody> <tr> <td width=\"5px\" style=\"padding: 0;\"></td><td style=\"clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 10px 0;\"> <table width=\"100%\" cellspacing=\"0\" style=\"border-collapse: collapse;\"> <tbody> <tr> <td style=\"padding: 0;\"> <a href=\"#\" style=\"color: #348eda;\" target=\"_blank\">  </a> </td><td style=\"color: #999; font-size: 12px; padding: 0; text-align: right;\" align=\"right\"> Porjoton Invoice Service<br/> Invoice #{invoice}<br/> {dot.Text}</td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr> <td width=\"5px\" style=\"padding: 0;\"></td><td bgcolor=\"#FFFFFF\" style=\"border: 1px solid #000; clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 0;\"> <table width=\"100%\" style=\"background: #f9f9f9; border-bottom: 1px solid #eee; border-collapse: collapse; color: #999;\"> <tbody> <tr> <td width=\"50%\" style=\"padding: 20px;\"><strong style=\"color: #333; font-size: 24px;\">BDT {amount.Text}</strong> Paid</td><td align=\"right\" width=\"50%\" style=\"padding: 20px;\">{linkLabel1.Text}<br>{dot.Text}<br> <span class=\"il\">{nom.Text}</span></td></tr></tbody> </table> </td><td style=\"padding: 0;\"></td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr> <td width=\"5px\" style=\"padding: 0;\"></td><td style=\"border: 1px solid #000; border-top: 0; clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 0;\"> <table cellspacing=\"0\" style=\"border-collapse: collapse; border-left: 1px solid #000; margin: 0 auto; max-width: 600px;\"> <tbody> <tr> <td valign=\"top\" style=\"padding: 20px;\"> <h3 style=\" border-bottom: 1px solid #000; color: #000; font-family: 'Helvetica Neue', Helvetica, Arial, 'Lucida Grande', sans-serif; font-size: 18px; font-weight: bold; line-height: 1.2; margin: 0; margin-bottom: 15px; padding-bottom: 5px; \"> Summary </h3> <table cellspacing=\"0\" style=\"border-collapse: collapse; margin-bottom: 40px;\"> <tbody> <tr> <td style=\"padding: 5px 0;\">Vehicle: </td><td align=\"right\" style=\"padding: 5px 0;\">{label4.Text}</td></tr><tr> <td style=\"padding: 5px 0;\">Class: </td><td align=\"right\" style=\"padding: 5px 0;\"> {closs.Text}</td></tr><tr> <td style=\"padding: 5px 0;\">Amount: </td><td align=\"right\" style=\"padding: 5px 0;\">BDT {amount.Text}</td></tr><tr> <td style=\"border-bottom: 2px solid #000; border-top: 2px solid #000; font-weight: bold; padding: 5px 0;\"> Paid</td><td align=\"right\" style=\"border-bottom: 2px solid #000; border-top: 2px solid #000; font-weight: bold; padding: 5px 0;\"> BDT {amount.Text}</td></tr></tbody> </table> </td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr style=\"color: #666; font-size: 12px;\"> <td width=\"5px\" style=\"padding: 10px 0;\"></td><td style=\"clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 10px 0;\"> <table width=\"100%\" cellspacing=\"0\" style=\"border-collapse: collapse;\"> <tbody> <tr> <td width=\"40%\" valign=\"top\" style=\"padding: 10px 0;\"> <h4 style=\"margin: 0;\">Questions?</h4> <p style=\"color: #666; font-size: 12px; font-weight: normal; margin-bottom: 10px;\"> Please visit our <a href=\"https://github.com/albar-hossain/Project-Kothin\" style=\"color: #666;\" target=\"_blank\"> Support Center </a> with any questions. </p></td><td width=\"10%\" style=\"padding: 10px 0;\">&nbsp;</td><td width=\"40%\" valign=\"top\" align=\"right\" style=\"padding: 10px 0;\"> <h4 style=\"margin: 0;\"><span class=\"il\">Porjoton Ticket & Rental Services</span></h4> <p style=\"color: #666; font-size: 12px; font-weight: normal; margin-bottom: 10px;\"> <a href=\"https://goo.gl/maps/nMbT6TePKn5ENMXe8\">408/1, Kuratoli, 1229</a> </p></td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 10px 0;\"></td></tr></tbody> </table> </div>" +
                " <style>body{margin-top: 100px;}</style>");
            pdf.SaveAs($"D:/{invoice}Train.pdf"); // Saves our PdfDocument object as a PDF
            invoice++;
        }

        private void name_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void trainName_Click(object sender, EventArgs e)
        {
        }

        private void class_label_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void datentime_Click(object sender, EventArgs e)
        {
        }

        private void Totalamount_Click(object sender, EventArgs e)
        {
        }

        private void amount_Click_1(object sender, EventArgs e)
        {
        }

        private void dot_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void dest_Click(object sender, EventArgs e)
        {
        }

        private void nom_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tronName_Click(object sender, EventArgs e)
        {
        }

        private void closs_Click(object sender, EventArgs e)
        {
        }

        private void depa_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelLoginClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}