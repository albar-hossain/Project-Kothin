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
        public Service()
        {
            InitializeComponent();
            Ticketbox.SelectedIndex = 0;  
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
            Ticketbox.Visible = false;
            SubmitButton.Visible = false;
            BackButton.Visible = false;
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
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
    }
}
