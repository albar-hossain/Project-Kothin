using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Project_Kothin
{
    public partial class Login : Form
    {
        private static int tryCount = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void labelName_Click(object sender, EventArgs e)
        {
        }

        private void labelPhonePlaceHolder_Click(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword recovery = new ForgotPassword();
            recovery.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkLabelLoginClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            //this.Close();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "admin" && textBoxPassword.Text == "kothin")
            {
                Admin a1 = new Admin();
                a1.Show();
                textBoxPassword.Clear();
                textBoxPhone.Clear();
            }
            else
            {
                string Phone = textBoxPhone.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan

                    conn.Open();

                    string query = $"select Password, FullName, Phone from UserInfo where Phone = {Phone}";
                    //string query = $"select Password from UserInfo where Phone = {Phone}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["Password"].ToString();
                    string phn = dt.Rows[0]["Phone"].ToString();
                    string fname = dt.Rows[0]["FullName"].ToString();

                    if (val == textBoxPassword.Text)
                    {
                        Service p1 = new Service(phn, fname);
                        Ticket t1 = new Ticket("", textBoxPhone.Text);
                        p1.Show();
                        tryCount = 0;
                        textBoxPassword.Clear();
                        textBoxPhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password.");
                        tryCount++;
                    }

                    if (tryCount > 2)
                    {
                        MessageBox.Show("Please Reset Your Password!");
                        ForgotPassword resetPassword = new ForgotPassword();
                        resetPassword.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Phone Number.");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            pictureBoxShowPass.Visible = true;
            pictureBoxHidePass.Visible = false;
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            pictureBoxShowPass.Visible = false;
            pictureBoxHidePass.Visible = true;
        }
    }
}