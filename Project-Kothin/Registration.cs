﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Kothin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void labelWrongEmail_Click(object sender, EventArgs e)
        {
        }

        private void textBoxRegEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxRegEmail.Text;
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

        private void labelRightEmail_Click(object sender, EventArgs e)
        {
        }

        private void textBoxRegPassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegPassword.Text == textBoxRegPassConfirm.Text)
            {
                labelRightPass.Visible = true;
                labelWrongPass.Visible = false;
            }
            else
            {
                labelRightPass.Visible = false;
                labelWrongPass.Visible = true;
            }
        }

        private void textBoxRegPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxRegPhone.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelRightPhone.Visible = true;
                labelWrongPhone.Visible = false;
            }
            else
            {
                labelRightPhone.Visible = false;
                labelWrongPhone.Visible = true;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxRegFullName.Text != "" &&
                textBoxRegPassword.Text != "" &&
                textBoxRegPassConfirm.Text != "" &&
                textRegPostCode.Text != "" &&
                textBoxRegEmail.Text != "" &&
                textBoxRegPhone.Text != "" &&
                textBoxRegAddress.Text != "")
            {
                string FullName = textBoxRegFullName.Text;
                string Phone = textBoxRegPhone.Text;
                string PostCode = textRegPostCode.Text;
                string Address = textBoxRegAddress.Text;
                string Email = textBoxRegEmail.Text;
                string Password = textBoxRegPassword.Text;
                //Recovery Code Generate
                string recoveryCode = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 5);
                string RecoveryCode = recoveryCode;

                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");
                    conn.Open();
                    string query = $"insert into UserInfo (FullName, Phone, Email, Address, PostCode, Password, RecoveryCode) VALUES ('{FullName}','{Phone}','{Email}','{Address}','{PostCode}','{Password}','{RecoveryCode}')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                MessageBox.Show("Registration complete!");
                GenerateRecoveryCode userReg = new GenerateRecoveryCode(recoveryCode);
                userReg.Show();
                //MessageBox.Show("Please note down the recovery code.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check the form again!");
            }
        }

        private void textRegPostCode_TextChanged(object sender, EventArgs e)
        {
            string postCode = textRegPostCode.Text;
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

        private void linkLabelRegBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void labelWrongPass_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelRegClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}