using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class ForgotPassword : Form
    {
        private bool IsPasswordValid = false;
        private bool IsPasswordUpdated = false;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void labelRightEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkLabelResetClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBoxResetNewPassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResetNewPassword.Text == textBoxResetNewPassConfirm.Text)
            {
                labelResetRightPass.Visible = true;
                labelResetWrongPass.Visible = false;
            }
            else
            {
                labelResetRightPass.Visible = false;
                labelResetWrongPass.Visible = true;
            }
        }

        private void textBoxResetPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxResetPhone.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelResetRightPhone.Visible = true;
                labelResetWrongPhone.Visible = false;
            }
            else
            {
                labelResetRightPhone.Visible = false;
                labelResetWrongPhone.Visible = true;
            }
        }

        private void labelResetWrongPass_Click(object sender, EventArgs e)
        {
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
        }

        private void buttonResetPass_Click(object sender, EventArgs e)
        {
            string Phone = textBoxResetPhone.Text;
            string RecoveryCode = textBoxResetRecoveryCode.Text;
            string NewPassword = textBoxResetNewPassword.Text;
            string NewPasswordCheck = textBoxResetNewPassConfirm.Text;

            if (Phone != "" &&
                 RecoveryCode != "" &&
                 NewPassword != "" &&
                 NewPasswordCheck != "" &&
                 NewPassword == NewPasswordCheck)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                       //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan

                    conn.Open();

                    string query = $"select RecoveryCode, Password from UserInfo where Phone = {Phone}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["RecoveryCode"].ToString();
                    string val2 = dt.Rows[0]["Password"].ToString();

                    if (val == RecoveryCode && val2 != NewPassword)
                    {
                        IsPasswordValid = true;
                    }
                    else if (val2 == NewPassword)
                    {
                        MessageBox.Show("New Password Cannot Be old Password.");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Recovery Code.");
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

                if (IsPasswordValid)
                {
                    string updateValue = NewPassword;
                    //string updateTarget = "Password";
                    //string updateWhome = textBoxUpdateWhom.Text;
                    try
                    {
                        conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                        conn.Open();

                        string query = $"update UserInfo set Password = '{updateValue}' where Phone = '{Phone}';";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                        //DataTable dt = ds.Tables[0];
                        //string val = dt.Rows[0]["RecoveryCode"].ToString();
                        IsPasswordUpdated = true;
                        IsPasswordValid = false;
                        MessageBox.Show("Password Reset.");

                        this.Hide();
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

                //Update Recovery code
                if (IsPasswordUpdated)
                {
                    string recoveryCode = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 5);

                    try
                    {
                        conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Albar
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//Azwad
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //Arif
                                                                                                                                           //conn = new SqlConnection(@"Data Source=DESKTOP-BMD47A3\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True"); //risan
                        conn.Open();

                        string query = $"update UserInfo set RecoveryCode = '{recoveryCode}' where Phone = '{Phone}';";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                        GenerateRecoveryCode getNewRecovery = new GenerateRecoveryCode(recoveryCode);
                        getNewRecovery.Show();
                        IsPasswordUpdated = false;
                        //DataTable dt = ds.Tables[0];
                        //string val = dt.Rows[0]["RecoveryCode"].ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not update recovery code.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Check the form again!");
            }
        }

        private void pictureBoxShowPass_Click(object sender, EventArgs e)
        {
            textBoxResetNewPassword.PasswordChar = '*';
            pictureBoxShowPass.Visible = false;
            pictureBoxHidePass.Visible = true;
        }

        private void pictureBoxHidePass_Click(object sender, EventArgs e)
        {
            textBoxResetNewPassword.PasswordChar = '\0';
            pictureBoxShowPass.Visible = true;
            pictureBoxHidePass.Visible = false;
        }

        private void textBoxResetNewPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}