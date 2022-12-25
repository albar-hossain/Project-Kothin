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

namespace Project_Kothin
{
    public partial class Service : Form
    {
        public string phone;
        public string fullName;
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public Service()
        {
            InitializeComponent();

            SendMessage(this.Ticketbox.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
        }

        public Service(string username, string fullname)
        {
            InitializeComponent();
            SendMessage(this.Ticketbox.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
            linkLabel1.Text = username;
            phone = username;
            fullName = fullname;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select FullName from UserInfo where Phone={linkLabel1.Text}";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["FullName"].ToString();
                linkLabel1.Text = val;
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            labelTicket.Visible = false;
            labelRental.Visible = false;
            Ticketbox.Visible = false;
            rentalBox.Visible = false;
            SubmitButton.Visible = false;
            rentalSubmit.Visible = false;
            BackButton.Visible = false;
            rentalSubmit.Visible = false;
            pictureBoxTicket.Visible = true;
            pictureBoxRental.Visible = true;
            labelService.Text = "Services:";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Ticketbox.Text == "")
            {
                MessageBox.Show("Invalid");
            }
            if (Ticketbox.Text == "Train")
            {
                Ticket it = new Ticket(Ticketbox.Text, phone);
                it.Show();
            }
            else if (Ticketbox.Text == "Bus")
            {
                Ticket it = new Ticket(Ticketbox.Text, phone);
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
        }

        private void rentalSubmit_Click(object sender, EventArgs e)
        {
            if (rentalBox.Text == "")
            {
                MessageBox.Show("Invalid");
            }
            if (rentalBox.Text == "Car")
            {
                Car it = new Car(fullName, phone);
                it.Show();
            }
            else if (rentalBox.Text == "Boat")
            {
                Boat it = new Boat(fullName, phone);
                it.Show();
            }
            else if (rentalBox.Text == "Bus")
            {
                RentalBus it = new RentalBus(fullName, phone);
                it.Show();
            }
        }

        private void rentalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInfoPanel u1 = new UserInfoPanel(phone);
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

        private void pictureBoxTicket_Click(object sender, EventArgs e)
        {
            labelService.Text = "Ticket Booking Services";

            labelTicket.Visible = true;
            Ticketbox.Visible = true;
            SubmitButton.Visible = true;
            BackButton.Visible = true;
            pictureBoxTicket.Visible = true;
            pictureBoxRental.Visible = false;
        }

        private void pictureBoxRental_Click(object sender, EventArgs e)
        {
            labelService.Text = "Rental Services";
            labelRental.Visible = true;
            rentalBox.Visible = true;
            rentalSubmit.Visible = true;
            BackButton.Visible = true;
            pictureBoxRental.Visible = true;
            pictureBoxTicket.Visible = false;
        }

        private void labelRental_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}