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

namespace Project_Kothin
{
    public partial class Boat : Form
    {
        string fullname = "";
        string phonenum = "";
        string vehicle = "Boat";
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
            if(Destination.SelectedItem!=null && 
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
                if (boatType.Text=="Speed Boat")
                {
                    typemultiplier = 2;
                }
                else if(boatType.Text=="Trawler Boat")
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
                if (Destination.Text== "Dhaka to Chandpur to Dhaka")
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
                    conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");
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
                    MessageBox.Show("Registration complete!");
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
    }
}
