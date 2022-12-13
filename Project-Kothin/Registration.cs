using System;
using System.Windows.Forms;

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
            if (textBoxRegFullName.Text != null &&
                textBoxRegPassword.Text != null &&
                textBoxRegPassConfirm.Text != null &&
                textRegPostCode.Text != null &&
                textBoxRegEmail.Text != null &&
                textBoxRegPhone.Text != null &&
                textBoxRegAddress.Text != null)
            {
                MessageBox.Show("Registration complete!");
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