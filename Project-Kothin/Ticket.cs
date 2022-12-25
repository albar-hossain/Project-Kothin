using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class Ticket : Form
    {
        public string phone;
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(string id, string username)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;

            SendMessage(this.departurebox.Handle, CB_SETCUEBANNER, 0, "Please select Depurture location...");
            SendMessage(this.destinationbox.Handle, CB_SETCUEBANNER, 0, "Please select Destination...");

            label3.Text = id;
            if (label3.Text == "Train")
            {
                dateTimePicker1.MaxDate = DateTime.Now.AddDays(5);
                SEARCHTRAIN.Visible = true;
            }
            else if (label3.Text == "Bus")
            {
                dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
                SEARCHBUS.Visible = true;
            }
            // ticketlabel.Text = username;
            phone = username;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"select FullName from UserInfo where Phone = {phone}";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["FullName"].ToString();
                ticketlabel.Text = val;
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
            if (departurebox.SelectedIndex != destinationbox.SelectedIndex && departurebox.SelectedIndex != -1 && destinationbox.SelectedIndex != -1)
            {
                string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                Selectseats s1 = new Selectseats(phone, departurebox.Text, destinationbox.Text, date);
                s1.Show();
            }

            if (destinationbox.Text == "" && departurebox.Text == "" || departurebox.Text == destinationbox.Text || departurebox.Text == "" || destinationbox.Text == "")
            {
                MessageBox.Show("Invalid");
            }
        }

        private void Train_Load(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SEARCHBUS_Click(object sender, EventArgs e)
        {
            if (departurebox.SelectedIndex != destinationbox.SelectedIndex && departurebox.SelectedIndex != -1 && destinationbox.SelectedIndex != -1)
            {
                //string date=DateTime.Value.ToString("dd MMM, yyyy hh:mm tt");
                string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                Busseats b1 = new Busseats(phone, departurebox.Text, destinationbox.Text, date);
                b1.Show();
            }

            if (destinationbox.Text == "" && departurebox.Text == "" || departurebox.Text == destinationbox.Text || departurebox.Text == "" || destinationbox.Text == "")
            {
                MessageBox.Show("Invalid");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}