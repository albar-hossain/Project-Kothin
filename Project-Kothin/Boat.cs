using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;

namespace Project_Kothin
{
    public partial class Boat : Form
    {
        private static double invoice = 0001d;
        private string fullname = "";
        private string phonenum = "";
        private string vehicle = "Boat";
        private double balance = 0;

        public Boat()
        {
            InitializeComponent();
        }

        public Boat(string fname, string phn)
        {
            InitializeComponent();
            fullname = fname;
            phonenum = phn;
        }

        private void Type_Click(object sender, EventArgs e)
        {
        }

        private void boatchoice_Click(object sender, EventArgs e)
        {
            if (Destination.SelectedItem != null &&
                dateTimePicker1.Text != null &&
                boatType.SelectedItem != null &&
                classChoose.SelectedItem != null &&
                durationChoose.SelectedItem != null)
            {
                string destination = Destination.Text;
                string date = dateTimePicker1.Value.Date.ToString("d");
                string type = boatType.Text;
                string chosenClass = classChoose.Text;
                string duration = durationChoose.Text;

                int typemultiplier = 0;
                int classmultiplier = 0;
                int durationmultiplier = 0;
                //Dhaka to Chandpur to Dhaka
                //Dhaka to Bhola to Dhaka
                //Dhaka to Potuakhali to Dhaka
                //Speed Boat
                //Cruise Ship
                //Trawler Boat
                //Class A
                //Class B
                //BOAT TYPE
                if (boatType.Text == "Speed Boat")
                {
                    typemultiplier = 2;
                }
                else if (boatType.Text == "Trawler Boat")
                {
                    typemultiplier = 1;
                }
                else
                {
                    typemultiplier = 3;
                }

                //BOAT CLASS
                if (classChoose.Text == "Class A")
                {
                    classmultiplier = 2;
                }
                else
                {
                    classmultiplier = 1;
                }

                //Duration
                if (durationChoose.Text == "1 Day")
                {
                    durationmultiplier = 1;
                }
                else if (durationChoose.Text == "2 Days")
                {
                    durationmultiplier = 2;
                }
                else
                {
                    durationmultiplier = 3;
                }

                //balance
                if (Destination.Text == "Dhaka to Chandpur to Dhaka")
                {
                    balance = 10000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Dhaka to Bhola to Dhaka")
                {
                    balance = 15000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else
                {
                    balance = 20000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                amount.Text = Convert.ToString(balance);
                phoneRec.Text = phonenum;
                DesRec.Text = destination;
                TypeRec.Text = type;
                ClassRec.Text = chosenClass;
                DepRec.Text = date;
                DurationRec.Text = duration;
                //MessageBox.Show("Boat has been booked!");

                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                    conn.Open();

                    string query = $"insert into Rental (Fullname,Phone, Vehicle ,Destination, Type, Duration, DepartmentDate, Class, Balance) VALUES ('{fullname}','{phonenum}','{vehicle}','{destination}','{type}','{duration}','{date}','{chosenClass}',{balance});";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Request Done!");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check all the options above!");
            }
        }

        private void Date_Click(object sender, EventArgs e)
        {
        }

        private void Boat1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelLoginClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            var Renderer = new ChromePdfRenderer(); // Instantiates Chrome Renderer
            var pdf = Renderer.RenderHtmlAsPdf($" <div bgcolor=\"#f6f6f6\" style=\"color: #333; height: 100%; width: 100%;\" height=\"100%\" width=\"100%\"> <table bgcolor=\"#f6f6f6\" cellspacing=\"0\" style=\"border-collapse: collapse; padding: 40px; width: 100%;\" width=\"100%\"> <tbody> <tr> <td width=\"5px\" style=\"padding: 0;\"></td><td style=\"clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 10px 0;\"> <table width=\"100%\" cellspacing=\"0\" style=\"border-collapse: collapse;\"> <tbody> <tr> <td style=\"padding: 0;\"> <a href=\"#\" style=\"color: #348eda;\" target=\"_blank\">  </a> </td><td style=\"color: #999; font-size: 12px; padding: 0; text-align: right;\" align=\"right\"> Porjoton Invoice Service<br/> Invoice #{invoice}<br/></td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr> <td width=\"5px\" style=\"padding: 0;\"></td><td bgcolor=\"#FFFFFF\" style=\"border: 1px solid #000; clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 0;\"> <table width=\"100%\" style=\"background: #f9f9f9; border-bottom: 1px solid #eee; border-collapse: collapse; color: #999;\"> <tbody> <tr> <td width=\"50%\" style=\"padding: 20px;\"><strong style=\"color: #333; font-size: 24px;\">BDT {amount.Text}</strong> Paid</td><td align=\"right\" width=\"50%\" style=\"padding: 20px;\">{fullname}<span class=\"il\">{phonenum}</span></td></tr></tbody> </table> </td><td style=\"padding: 0;\"></td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr> <td width=\"5px\" style=\"padding: 0;\"></td><td style=\"border: 1px solid #000; border-top: 0; clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 0;\"> <table cellspacing=\"0\" style=\"border-collapse: collapse; border-left: 1px solid #000; margin: 0 auto; max-width: 600px;\"> <tbody> <tr> <td valign=\"top\" style=\"padding: 20px;\"> <h3 style=\" border-bottom: 1px solid #000; color: #000; font-family: 'Helvetica Neue', Helvetica, Arial, 'Lucida Grande', sans-serif; font-size: 18px; font-weight: bold; line-height: 1.2; margin: 0; margin-bottom: 15px; padding-bottom: 5px; \"> Summary </h3> <table cellspacing=\"0\" style=\"border-collapse: collapse; margin-bottom: 40px;\"> <tbody> <tr> <td style=\"padding: 5px 0;\">Vehicle: </td><td align=\"right\" style=\"padding: 5px 0;\"> {TypeRec.Text}</td></tr><tr> <td style=\"padding: 5px 0;\">Class: </td><td align=\"right\" style=\"padding: 5px 0;\">{ClassRec.Text}</td></tr><tr> <td style=\"padding: 5px 0;\">Amount: </td><td align=\"right\" style=\"padding: 5px 0;\">BDT {amount.Text}</td></tr><tr> <td style=\"border-bottom: 2px solid #000; border-top: 2px solid #000; font-weight: bold; padding: 5px 0;\"> Paid</td><td align=\"right\" style=\"border-bottom: 2px solid #000; border-top: 2px solid #000; font-weight: bold; padding: 5px 0;\"> BDT {amount.Text}</td></tr></tbody> </table> </td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 0;\"></td></tr><tr style=\"color: #666; font-size: 12px;\"> <td width=\"5px\" style=\"padding: 10px 0;\"></td><td style=\"clear: both; display: block; margin: 0 auto; max-width: 600px; padding: 10px 0;\"> <table width=\"100%\" cellspacing=\"0\" style=\"border-collapse: collapse;\"> <tbody> <tr> <td width=\"40%\" valign=\"top\" style=\"padding: 10px 0;\"> <h4 style=\"margin: 0;\">Questions?</h4> <p style=\"color: #666; font-size: 12px; font-weight: normal; margin-bottom: 10px;\"> Please visit our <a href=\"https://github.com/albar-hossain/Project-Kothin\" style=\"color: #666;\" target=\"_blank\"> Support Center </a> with any questions. </p></td><td width=\"10%\" style=\"padding: 10px 0;\">&nbsp;</td><td width=\"40%\" valign=\"top\" align=\"right\" style=\"padding: 10px 0;\"> <h4 style=\"margin: 0;\"><span class=\"il\">Porjoton Ticket & Rental Services</span></h4> <p style=\"color: #666; font-size: 12px; font-weight: normal; margin-bottom: 10px;\"> <a href=\"https://goo.gl/maps/nMbT6TePKn5ENMXe8\">408/1, Kuratoli, 1229</a> </p></td></tr></tbody> </table> </td><td width=\"5px\" style=\"padding: 10px 0;\"></td></tr></tbody> </table> </div>" +
                 " <style>body{margin-top: 100px;}</style>");
            pdf.SaveAs($"D:/{invoice}Boat.pdf"); // Saves our PdfDocument object as a PDF
            invoice++;
        }

        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}