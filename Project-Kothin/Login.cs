using System;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class Login : Form
    {
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
    }
}