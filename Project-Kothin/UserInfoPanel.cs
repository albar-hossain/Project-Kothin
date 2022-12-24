﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class UserInfoPanel : Form
    {
        private string oldPass;
        private string oldEmail;
        private string oldAddress;
        private string oldPostCode;
        private String Phone;

        public UserInfoPanel()
        {
            InitializeComponent();
        }

        public UserInfoPanel(string phone)
        {
            InitializeComponent();
            Phone = phone;
            // fname.Text = phone;
            // pnumv.Text = username;

            SqlConnection conn = null;
            try
            {
                //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                 conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"select FullName from UserInfo where Phone={Phone}";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val1 = dt.Rows[0]["FullName"].ToString();
                // string val2 = dt.Rows[0]["Phone"].ToString();
                fname.Text = val1;
                pnumv.Text = Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //SqlConnection conn = null;
            try
            {
               // conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"select Email,Address,PostCode,Password from UserInfo where Phone={Phone}";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val3 = dt.Rows[0]["Email"].ToString();
                string val4 = dt.Rows[0]["Address"].ToString();
                string val5 = dt.Rows[0]["PostCode"].ToString();
                string valpass = dt.Rows[0]["Password"].ToString();

                // string val2 = dt.Rows[0]["Phone"].ToString();
                newpass.Text = valpass;
                textBoxEmail.Text = val3;
                textBoxAddress.Text = val4;
                textBoxPostcode.Text = val5;
                oldPass = valpass;
                oldEmail = val3;
                oldAddress = val4;
                oldPostCode = val5;
                
                //pnumv.Text = Phone;
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

        private void fname_Click(object sender, EventArgs e)
        {
        }

        private void UserInfoPanel_Load(object sender, EventArgs e)
        {
        }

        private void pnumv_Click(object sender, EventArgs e)
        {
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (email.Contains("@") && email.Contains("."))
            {
                labelRightEmail.Visible = true;
                labelWrongEmail.Visible = false;
            }
            else
            {
                labelRightEmail.Visible = false;
                labelWrongEmail.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (

                (textBoxPostcode.Text != "" && textBoxPostcode.Text != oldPostCode) ||
                (textBoxEmail.Text != "" && textBoxEmail.Text != oldEmail) ||
                (textBoxAddress.Text != "" && textBoxAddress.Text != oldAddress)
                //||(newpass.Text!=""&& newpass.Text!=oldPass && newpass.Text==conPass.Text)
                )
            {
                SqlConnection conn = null;
                try
                {
                    // conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");
                    conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");
                    conn.Open();

                    string updatedpass = newpass.Text;
                    string updateEmail = textBoxEmail.Text;
                    string updateAddress = textBoxAddress.Text;
                    string updatePostcode = textBoxPostcode.Text;
                    string updatePhone = pnumv.Text;
                    //MessageBox.Show(Phone);

                    string query = $"update UserInfo set Email = '{updateEmail}', Address = '{updateAddress}', PostCode = '{updatePostcode}' where Phone = '{Phone}';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

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
                MessageBox.Show("Information Updated.");
            }
            else
            {
                MessageBox.Show("Information Invalid or old Information was used");
            }
        }

        private void viewUpdate_Click(object sender, EventArgs e)
        {
            viewUpdate.Visible = false;
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.BackColor = Color.DimGray;

            textBoxAddress.ForeColor = Color.White;
            textBoxAddress.BackColor = Color.DimGray;

            textBoxPostcode.ForeColor = Color.White;
            textBoxPostcode.BackColor = Color.DimGray;

            textBoxEmail.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
            textBoxPostcode.ReadOnly = false;

            updatebutton.Visible = true;
        }

        private void linkLabelRegClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBoxPostcode_TextChanged(object sender, EventArgs e)
        {
            string postCode = textBoxPostcode.Text;
            if (postCode.Length == 4)
            {
                labelRightZip.Visible = true;
                labelWrongZip.Visible = false;
            }
            else
            {
                labelRightZip.Visible = false;
                labelWrongZip.Visible = true;
            }
        }

        private void labelWrongZip_Click(object sender, EventArgs e)
        {
        }

        private void labelRightEmail_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                // conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif                                                                                                                 // conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");//arif
                conn.Open();

                string query = $"Delete From UserInfo Where Phone ={Phone}";

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
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newpass.ForeColor = Color.White;

            newpass.BackColor = Color.DimGray;
            label1.Visible = true;
            conPass.Visible = true;
            newpass.Visible = true;
            textBoxConpass.Visible = true;
            textBoxConpass.ForeColor = Color.White;
            textBoxConpass.BackColor = Color.DimGray;
            viewUpdate.Visible = false;

            updatebutton.Visible = true;
            button1.Visible = false;
        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelRightZip_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBoxConpass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConpass.Text == newpass.Text)
            {
                labelConPassRight.Visible = true;
                labelConPassWrong.Visible = false;
            }
            else
            {
                labelConPassRight.Visible = false;
                labelConPassWrong.Visible = true;
            }
        }
    }
}