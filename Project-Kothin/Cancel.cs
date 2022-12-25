using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_Kothin
{
    public partial class Cancel : Form
    {
        string Phone;
        public Cancel()
        {
            InitializeComponent();
        }
        public Cancel(string phone)
        {
            InitializeComponent();
             Phone = phone; 
        }

        private void Cancel_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void buttonCancelTicket_Click(object sender, EventArgs e)
        {
            CancelBus.Visible = true;
            CancelTrain.Visible = true;
            buttonCancelTicket.Visible = false;
        }

        private void CancelTrain_Click(object sender, EventArgs e)
        {   
            CancelTrain.Visible = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                  // conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"select PhoneNumber, Vehicle,VehicleName,Class,Departure,Destination,Date,Amount from TicketInfo where PhoneNumber = '{Phone}' and Vehicle= 'TRAIN'";
                //select PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date Amount from TicketInfo where PhoneNumber = '01728935121'and vehicle = 'BUS';
                //MessageBox.Show(Phone);
                
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                
                DataTable dt = ds.Tables[0];
                nom.Text = dt.Rows[0]["PhoneNumber"].ToString();
                label4.Text = dt.Rows[0]["Vehicle"].ToString() ;
                tronName.Text = dt.Rows[0]["VehicleName"].ToString();
                closs.Text = dt.Rows[0]["Class"].ToString();
                depa.Text  = dt.Rows[0]["Departure"].ToString();
                dest.Text = dt.Rows[0]["Destination"].ToString();
               dot.Text = dt.Rows[0]["Date"].ToString();
                amount.Text = dt.Rows[0]["Amount"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            buttonContrain.Visible = true;
            name.Visible= true;
            VehicleType.Visible = true;
            trainName.Visible= true;
            class_label.Visible= true;
            Departure.Visible= true;
            Destination.Visible= true;
            datentime.Visible= true;
            Totalamount.Visible= true;
            
            nom.Visible= true;
            label4.Visible= true;
            tronName.Visible= true;
            closs.Visible= true;
            depa.Visible= true;
            dest.Visible= true;
            dot.Visible= true;
            amount.Visible= true;

        }

        private void buttonContrain_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                 // conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"Delete From TicketInfo Where PhoneNumber ='{Phone}' and Vehicle= 'TRAIN'";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("Ticket Cancelation Successful");
            buttonContrain.Visible = false;
            name.Visible = false;
            VehicleType.Visible = false;
            trainName.Visible = false;
            class_label.Visible = false;
            Departure.Visible = false;
            Destination.Visible = false;
            datentime.Visible = false;
            Totalamount.Visible = false;

            nom.Visible = false;
            label4.Visible = false;
            tronName.Visible = false;
            closs.Visible = false;
            depa.Visible = false;
            dest.Visible = false;
            dot.Visible = false;
            amount.Visible = false;
            CancelTrain.Visible = true;
            buttonCancelTicket.Visible = true;

        }

        private void CancelBus_Click(object sender, EventArgs e)
        {
            CancelTrain.Visible = false;
            buttonConbus.Visible= true;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                 // conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"select PhoneNumber, Vehicle,VehicleName,Class,Departure,Destination,Date,Amount from TicketInfo where PhoneNumber = '{Phone}' and Vehicle= 'BUS'";
                //select PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date Amount from TicketInfo where PhoneNumber = '01728935121'and vehicle = 'BUS';
                //MessageBox.Show(Phone);

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                label5.Text = dt.Rows[0]["PhoneNumber"].ToString();
                type.Text = dt.Rows[0]["Vehicle"].ToString();
                label3.Text = dt.Rows[0]["VehicleName"].ToString();
                bos.Text = dt.Rows[0]["Class"].ToString();
                dep.Text = dt.Rows[0]["Departure"].ToString();
                des.Text = dt.Rows[0]["Destination"].ToString();
                dateandtime.Text = dt.Rows[0]["Date"].ToString();
                label8.Text = dt.Rows[0]["Amount"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            buttonContrain.Visible = true;
            name.Visible = true;
            VehicleType.Visible = true;
            trainName.Visible = true;
            class_label.Visible = true;
            Departure.Visible = true;
            Destination.Visible = true;
            datentime.Visible = true;
            Totalamount.Visible = true;

            nom.Visible = true;
            label4.Visible = true;
            tronName.Visible = true;
            closs.Visible = true;
            depa.Visible = true;
            dest.Visible = true;
            dot.Visible = true;
            amount.Visible = true;

        }
    }
}
