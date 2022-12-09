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
            comboBox1.SelectedIndex = 0;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelService.Visible = false;
            buttonTicket.Visible = false;
            buttonRental.Visible = false;
            labelTicket.Visible = true;
            comboBox1.Visible = true;
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
            comboBox1.Visible = false;
            SubmitButton.Visible = false;
            BackButton.Visible = false;
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Train")
            {
                Ticket it = new Ticket();
                it.Show();
            }
        }

        private void SEARCHTRAIN_Click(object sender, EventArgs e)
        {
            Selectseats s1 = new Selectseats();
            s1.Show();
        }
    }
}
