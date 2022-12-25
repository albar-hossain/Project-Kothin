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
            // TODO: This line of code loads data into the 'porjotonDataSet.TicketInfo' table. You can move, or remove it, as needed.
            //this.ticketInfoTableAdapter1.Fill(this.porjotonDataSet.TicketInfo);
            // TODO: This line of code loads data into the 'porjotonDataSet3.TicketInfo' table. You can move, or remove it, as needed.
            //this.ticketInfoTableAdapter.Fill(this.porjotonDataSet3.TicketInfo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.userInfoTableAdapter.FillBy(this.porjotonDataSet2.UserInfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
