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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        public Ticket(string id)
        {
            InitializeComponent();
            label3.Text = id;
            if (label3.Text == "Train")
            {
                SEARCHTRAIN.Visible = true;
            }
            else if (label3.Text == "Bus")
            {
                SEARCHBUS.Visible = true;
            }

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SEARCHTRAIN_Click(object sender, EventArgs e)
        {
            Selectseats s1 = new Selectseats();
            s1.Show();
        }
        private void Train_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busseats b1 = new Busseats();
            b1.Show();
        }
    }
}
