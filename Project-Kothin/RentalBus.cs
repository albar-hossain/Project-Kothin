using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Kothin
{
    public partial class RentalBus : Form
    {
        string fullname = "";
        string phonenum = "";
        string vehicle = "Bus";
        private double balance = 0;
        public RentalBus(string fname, string phn)
        {
            InitializeComponent();
            fullname = fname;
            phonenum = phn;
        }
        public RentalBus()
        {
            InitializeComponent();
        }
        private void boatchoice_Click(object sender, EventArgs e)
        {
            if (Destination.SelectedItem != null &&
                dateTimePicker1.Text != null &&
                carType.SelectedItem != null &&
                classChoose.SelectedItem != null &&
                durationChoose.SelectedItem != null)
            {
                string destination = Destination.Text;
                string date = dateTimePicker1.Value.Date.ToString("d");
                string type = carType.Text;
                string chosenClass = classChoose.Text;
                string duration = durationChoose.Text;

                double typemultiplier = 0.0;
                int classmultiplier = 0;
                int durationmultiplier = 0;
                /*
                Withing Dhaka
                Savar
                Tongi
                Gazipur
                Naraynganj
                Munshiganj
                Mawa

                Sedan
                Micro Bus
                Mini Van

                */
                //Class A
                //Class B
                //Car TYPE
                if (carType.Text == "AC")
                {
                    typemultiplier = 1;
                }
                else if (carType.Text == "Non-AC")
                {
                    typemultiplier = 1.5;
                }
                else
                {
                    typemultiplier = 0.8;
                }

                // Car CLASS
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
                if (Destination.Text == "Withing Dhaka")
                {
                    balance = 2000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Savar")
                {
                    balance = 3000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Tongi")
                {
                    balance = 3000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Gazipur")
                {
                    balance = 4000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Naraynganj")
                {
                    balance = 3500 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else if (Destination.Text == "Munshiganj")
                {
                    balance = 4500 * typemultiplier * classmultiplier * durationmultiplier;
                }
                else
                {
                    balance = 4000 * typemultiplier * classmultiplier * durationmultiplier;
                }
                amount.Text = Convert.ToString(balance);
                phoneRec.Text = phonenum;
                DesRec.Text = destination;
                TypeRec.Text = type;
                ClassRec.Text = chosenClass;
                DepRec.Text = date;
                DurationRec.Text = duration;
                //MessageBox.Show("Boat has been booked!");
                // query part 

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

        private void RentalBus_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
