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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void linkLabelLoginClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query2 = $"select FullName,Phone,Email,Address,PostCode,Password,RecoveryCode from UserInfo where FullName ='{textBox1.Text}'";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string del = textBox1.Text;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query = $"Delete From UserInfo Where FullName ='{del}'";

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
            MessageBox.Show("Account Deletation Successful");
            //SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query2 = $"select FullName,Phone,Email,Address,PostCode,Password,RecoveryCode from UserInfo ";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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

        private void ShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query2 = $"select FullName,Phone,Email,Address,PostCode,Password from UserInfo ";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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

        private void linkLabelLoginClose_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query2 = $"select FullName,PhoneNumber,Vehicle,VehicleName,Class,Departure,Destination,Date,Amount from TicketInfo ";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                   //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                conn.Open();

                string query2 = $"select FullName,Phone,Vehicle,Destination,Class,DepartmentDate,Duration,Type,Balance from Rental";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
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
    }
}