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
    public partial class Service : Form
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        public Service()
        {
            InitializeComponent();
            
            SendMessage(this.Ticketbox.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            labelService.Visible = false;
            buttonTicket.Visible = false;
            buttonRental.Visible = false;
            labelTicket.Visible = true;
            Ticketbox.Visible = true;
            SubmitButton.Visible = true;
            BackButton.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            labelService.Visible = true;
            buttonTicket.Visible = true;
            buttonRental.Visible = true;
            labelTicket.Visible = false;
            labelRental.Visible = false;
            Ticketbox.Visible = false;
            rentalBox.Visible = false;
            SubmitButton.Visible = false;
            rentalSubmit.Visible = false;
            BackButton.Visible = false;
            rentalSubmit.Visible = false;


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(Ticketbox.Text=="")
            {
                MessageBox.Show("Invalid");
            }
            if (Ticketbox.Text == "Train")
            {
                Ticket it = new Ticket(Ticketbox.Text);
                it.Show();
            }
            else if(Ticketbox.Text=="Bus")
            {
                Ticket it = new Ticket(Ticketbox.Text);
                it.Show();
            }
            
        }

        private void SEARCHTRAIN_Click(object sender, EventArgs e)
        {
            Selectseats s1 = new Selectseats();
            s1.Show();
        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            labelService.Visible = false;
            buttonTicket.Visible = false;
            buttonRental.Visible = false;
            labelRental.Visible = true;
            rentalBox.Visible = true;
            rentalSubmit.Visible = true;
            BackButton.Visible = true;
        }

        private void rentalSubmit_Click(object sender, EventArgs e)
        {
            if (rentalBox.Text == "")
            {
                MessageBox.Show("Invalid");
            }
            if (rentalBox.Text == "Car")
            {
                Car it = new Car();
                it.Show();
            }
            else if (rentalBox.Text == "Boat")
            {
                Boat it = new Boat();
                it.Show();
            }
            else if (rentalBox.Text == "Bus")
            {
                RentalBus it = new RentalBus();
                it.Show();
            }

        }

        private void rentalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInfoPanel u1 = new UserInfoPanel();
            u1.Show();
        }

        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkLabelLoginClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
