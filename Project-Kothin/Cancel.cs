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
        private string Phone;

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
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
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
            CancelBus.Visible = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
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
                label4.Text = dt.Rows[0]["Vehicle"].ToString();
                tronName.Text = dt.Rows[0]["VehicleName"].ToString();
                closs.Text = dt.Rows[0]["Class"].ToString();
                depa.Text = dt.Rows[0]["Departure"].ToString();
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

        private void buttonContrain_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
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
            CancelTrain.Visible = false;
        }

        private void CancelBus_Click(object sender, EventArgs e)
        {
            CancelTrain.Visible = false;
            CancelBus.Visible = false;
            buttonContrain.Visible = false;
            buttonConbus.Visible = true;
            buttonCancelTicket.Visible = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
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
            //buttonContrain.Visible = true;
            label6.Visible = true;
            label2.Visible = true;
            bus.Visible = true;
            label7.Visible = true;
            departurelabel.Visible = true;
            destinationlabel.Visible = true;
            label1.Visible = true;
            total.Visible = true;

            label5.Visible = true;
            type.Visible = true;
            bos.Visible = true;
            label3.Visible = true;
            dep.Visible = true;
            des.Visible = true;
            dateandtime.Visible = true;
            label8.Visible = true;
            //buttonCancelTicket.Visible = true;
        }

        private void buttonConbus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"Delete From TicketInfo Where PhoneNumber ='{Phone}' and Vehicle= 'BUS'";

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
            buttonConbus.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            bus.Visible = false;
            label7.Visible = false;
            departurelabel.Visible = false;
            destinationlabel.Visible = false;
            label1.Visible = false;
            total.Visible = false;

            label5.Visible = false;
            type.Visible = false;
            bos.Visible = false;
            label3.Visible = false;
            dep.Visible = false;
            des.Visible = false;
            dateandtime.Visible = false;
            label8.Visible = false;
            CancelBus.Visible = false;
            buttonContrain.Visible = false;
            buttonCancelTicket.Visible = true;
        }

        private void buttonCancelRental_Click(object sender, EventArgs e)
        {
            buttonCancelRental.Visible = false;
            buttonCancelBus.Visible = true;
            buttonCancleBoat.Visible = true;
            buttonCancleCar.Visible = true;
        }

        private void buttonCancelBus_Click(object sender, EventArgs e)
        {
            buttonCancelBus.Visible = true;
            buttonCancleCar.Visible = false;
            buttonCancleBoat.Visible = false;
            phoneRec.Visible = true;
            DesRec.Visible = true;
            TypeRec.Visible = true;
            ClassRec.Visible = true;
            DepRec.Visible = true;
            DurationRec.Visible = true;
            DecBalance.Visible = true;
            labelRentalPhone.Visible = true;
            labelRentalDestination.Visible = true;
            labelRentalType.Visible = true;
            labelRentalClass.Visible = true;
            labelRentalDepartureDate.Visible = true;
            labelRentalDuration.Visible = true;
            labelRentalBalance.Visible = true;
            buttonCancelconRent.Visible = true;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select Phone, Destination, Type, Class, DepartmentDate, Duration, Balance from Rental where Phone = '{Phone}' and Vehicle= 'BUS'";
                //select PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date Amount from TicketInfo where PhoneNumber = '01728935121'and vehicle = 'BUS';
                //MessageBox.Show(Phone);

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                phoneRec.Text = dt.Rows[0]["Phone"].ToString();
                DesRec.Text = dt.Rows[0]["Destination"].ToString();
                TypeRec.Text = dt.Rows[0]["Type"].ToString();
                ClassRec.Text = dt.Rows[0]["Class"].ToString();
                DepRec.Text = dt.Rows[0]["DepartmentDate"].ToString();
                DurationRec.Text = dt.Rows[0]["Duration"].ToString();
                //dateandtime.Text = dt.Rows[0]["Date"].ToString();
                DecBalance.Text = dt.Rows[0]["Balance"].ToString();
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

        private void buttonCancleBoat_Click(object sender, EventArgs e)
        {
            buttonCancelBus.Visible = false;
            buttonCancleCar.Visible = false;
            buttonCancleBoat.Visible = true;
            phoneRec.Visible = true;
            DesRec.Visible = true;
            TypeRec.Visible = true;
            ClassRec.Visible = true;
            DepRec.Visible = true;
            DurationRec.Visible = true;
            DecBalance.Visible = true;
            labelRentalPhone.Visible = true;
            labelRentalDestination.Visible = true;
            labelRentalType.Visible = true;
            labelRentalClass.Visible = true;
            labelRentalDepartureDate.Visible = true;
            labelRentalDuration.Visible = true;
            labelRentalBalance.Visible = true;
            buttonCancelconRent.Visible = true;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select Phone, Destination, Type, Class, DepartmentDate, Duration, Balance from Rental where Phone = '{Phone}' and Vehicle= 'Boat'";
                //select PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date Amount from TicketInfo where PhoneNumber = '01728935121'and vehicle = 'BUS';
                //MessageBox.Show(Phone);

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                phoneRec.Text = dt.Rows[0]["Phone"].ToString();
                DesRec.Text = dt.Rows[0]["Destination"].ToString();
                TypeRec.Text = dt.Rows[0]["Type"].ToString();
                ClassRec.Text = dt.Rows[0]["Class"].ToString();
                DepRec.Text = dt.Rows[0]["DepartmentDate"].ToString();
                DurationRec.Text = dt.Rows[0]["Duration"].ToString();
                //dateandtime.Text = dt.Rows[0]["Date"].ToString();
                DecBalance.Text = dt.Rows[0]["Balance"].ToString();
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

        private void buttonCancleCar_Click(object sender, EventArgs e)
        {
            buttonCancelBus.Visible = false;
            buttonCancleCar.Visible = true;
            buttonCancleBoat.Visible = false;
            phoneRec.Visible = true;
            DesRec.Visible = true;
            TypeRec.Visible = true;
            ClassRec.Visible = true;
            DepRec.Visible = true;
            DurationRec.Visible = true;
            DecBalance.Visible = true;
            labelRentalPhone.Visible = true;
            labelRentalDestination.Visible = true;
            labelRentalType.Visible = true;
            labelRentalClass.Visible = true;
            labelRentalDepartureDate.Visible = true;
            labelRentalDuration.Visible = true;
            labelRentalBalance.Visible = true;
            buttonCancelconRent.Visible = true;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select Phone, Destination, Type, Class, DepartmentDate, Duration, Balance from Rental where Phone = '{Phone}' and Vehicle= 'Car'";
                //select PhoneNumber, Vehicle, VehicleName, Class, Departure, Destination, Date Amount from TicketInfo where PhoneNumber = '01728935121'and vehicle = 'BUS';
                //MessageBox.Show(Phone);

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                phoneRec.Text = dt.Rows[0]["Phone"].ToString();
                DesRec.Text = dt.Rows[0]["Destination"].ToString();
                TypeRec.Text = dt.Rows[0]["Type"].ToString();
                ClassRec.Text = dt.Rows[0]["Class"].ToString();
                DepRec.Text = dt.Rows[0]["DepartmentDate"].ToString();
                DurationRec.Text = dt.Rows[0]["Duration"].ToString();
                //dateandtime.Text = dt.Rows[0]["Date"].ToString();
                DecBalance.Text = dt.Rows[0]["Balance"].ToString();
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

        private void buttonCancelconRent_Click(object sender, EventArgs e)
        {
            if (buttonCancelBus.Visible)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                    conn.Open();

                    string query = $"Delete From Rental Where Phone ='{Phone}' and Vehicle= 'Bus'";

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
                MessageBox.Show("Rental Cancelation Successful");
                buttonCancelBus.Visible = true;
                buttonCancleCar.Visible = true;
                buttonCancleBoat.Visible = true;
                phoneRec.Visible = false;
                DesRec.Visible = false;
                TypeRec.Visible = false;
                ClassRec.Visible = false;
                DepRec.Visible = false;
                DurationRec.Visible = false;
                DecBalance.Visible = false;
                labelRentalPhone.Visible = false;
                labelRentalDestination.Visible = false;
                labelRentalType.Visible = false;
                labelRentalClass.Visible = false;
                labelRentalDepartureDate.Visible = false;
                labelRentalDuration.Visible = false;
                labelRentalBalance.Visible = false;
            }
            else if (buttonCancleBoat.Visible)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                    conn.Open();

                    string query = $"Delete From Rental Where Phone ='{Phone}' and Vehicle= 'Boat'";

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
                MessageBox.Show("Rental Cancelation Successful");
                buttonCancelBus.Visible = true;
                buttonCancleCar.Visible = true;
                buttonCancleBoat.Visible = true;
                phoneRec.Visible = false;
                DesRec.Visible = false;
                TypeRec.Visible = false;
                ClassRec.Visible = false;
                DepRec.Visible = false;
                DurationRec.Visible = false;
                DecBalance.Visible = false;
                labelRentalPhone.Visible = false;
                labelRentalDestination.Visible = false;
                labelRentalType.Visible = false;
                labelRentalClass.Visible = false;
                labelRentalDepartureDate.Visible = false;
                labelRentalDuration.Visible = false;
                labelRentalBalance.Visible = false;
            }
            else if (buttonCancleCar.Visible)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                    conn.Open();

                    string query = $"Delete From Rental Where Phone ='{Phone}' and Vehicle= 'Car'";

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
                MessageBox.Show("Rental Cancelation Successful");
                buttonCancelBus.Visible = true;
                buttonCancleCar.Visible = true;
                buttonCancleBoat.Visible = true;
                phoneRec.Visible = false;
                DesRec.Visible = false;
                TypeRec.Visible = false;
                ClassRec.Visible = false;
                DepRec.Visible = false;
                DurationRec.Visible = false;
                DecBalance.Visible = false;
                labelRentalPhone.Visible = false;
                labelRentalDestination.Visible = false;
                labelRentalType.Visible = false;
                labelRentalClass.Visible = false;
                labelRentalDepartureDate.Visible = false;
                labelRentalDuration.Visible = false;
                labelRentalBalance.Visible = false;
            }
            buttonCancelconRent.Visible = false;
        }

        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}