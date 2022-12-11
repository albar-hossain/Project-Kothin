using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class Boat1 : Form
    {
        private double balance = 0;
        private int dur = 0;
        public Boat1()
        {
            InitializeComponent();
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
                //MessageBox.Show("Boat has been booked!");
                

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
