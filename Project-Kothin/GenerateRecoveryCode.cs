using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class GenerateRecoveryCode : Form
    {
        public GenerateRecoveryCode()
        {
            InitializeComponent();
        }

        public GenerateRecoveryCode(string RecoveryCode)
        {
            InitializeComponent();
            textBoxResetRecoveryCode.Text = RecoveryCode;
        }

        private void linkLabelResetClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBoxResetRecoveryCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonRecoveryCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResetRecoveryCode.Text);
            MessageBox.Show("Copied To Clipboard.");
            this.Close();
        }

        private void GenerateRecoveryCode_Load(object sender, EventArgs e)
        {
        }
    }
}