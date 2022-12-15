using System;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class ForgotPassword : Form
    {
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
    }
}