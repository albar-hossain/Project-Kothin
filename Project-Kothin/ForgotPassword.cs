using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class ForgotPassword : Form
    {
        private bool IsPasswordValid = false;

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
                    conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");
                    conn.Open();

                    string query = $"select RecoveryCode from UserInfo where Phone = {Phone}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["RecoveryCode"].ToString();

                    if (val == RecoveryCode)
                    {
                        IsPasswordValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Recovery Code.");
                    }
                }
                catch (Exception ex)
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
                    string updateTarget = "Password";
                    //string updateWhome = textBoxUpdateWhom.Text;
                    try
                    {
                        conn = new SqlConnection(@"Data Source=SKRILLEXOMG\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");
                        conn.Open();

                        string query = $"update UserInfo set {updateTarget} = '{updateValue}' where Phone = '{Phone}';";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                        //DataTable dt = ds.Tables[0];
                        //string val = dt.Rows[0]["RecoveryCode"].ToString();
                        MessageBox.Show("Password Reset.");
                        IsPasswordValid = false;
                        this.Hide();
                        //Might add new recovery code after password update
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Phone Number.");
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
    }
}