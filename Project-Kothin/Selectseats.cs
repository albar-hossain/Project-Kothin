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
    public partial class Selectseats : Form
    {
        private bool flag = true;
        private double balance =0;


        public Selectseats()
        {
            InitializeComponent();
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
            
            if(flag==true)
            {
                A1.BackColor = Color.Green;
                if (comboBox3.Text == "Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                flag = false;
            }
            else 
            {
                
                A1.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0&&comboBox3.Text=="Snigdha")
                {
                    balance-=500;
                    amount.Text = Convert.ToString(balance);
                }
                else if(balance==0||balance<0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag =true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                A2.BackColor = Color.Green;
                if(comboBox3.Text=="Snigdha")
                {
                    balance += 500;
                    amount.Text = Convert.ToString(balance);
                }
                flag = false;
            }
            else
            {

                A2.BackColor = Color.FromKnownColor(KnownColor.Control);
                if (balance != 0 && comboBox3.Text == "Snigdha")
                {
                    balance -= 500;
                    amount.Text = Convert.ToString(balance);
                }
                else if (balance == 0 || balance < 0)
                {
                    balance = 0;
                    amount.Text = Convert.ToString(balance);
                }
                flag = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                C2.BackColor = Color.Green;
                flag = false;
            }
            else
            {
                C2.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void BackButton_Click(object sender, EventArgs e)
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
            Express.Visible = true;
            BackButton1.Visible = false;
            Seats.Visible = false;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                B1.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                B1.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;

            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                B2.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                B2.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;

            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                C1.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                C1.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                D1.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                D1.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;

            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                D2.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                D2.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                E1.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                E1.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;
            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                E2.BackColor = Color.Green;
                flag = false;
            }
            else
            {

                E2.BackColor = Color.FromKnownColor(KnownColor.Control);
                flag = true;
               
            }
        }

        private void BookTrain_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Successful!"); 
            
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
    }
}
