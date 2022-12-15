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
    public partial class Ticket : Form
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        public Ticket()
        {
            InitializeComponent();
        }
        public Ticket(string id)
        {
            InitializeComponent();
            SendMessage(this.comboBox1.Handle, CB_SETCUEBANNER, 0, "Please select Depurture location...");
            SendMessage(this.comboBox2.Handle, CB_SETCUEBANNER, 0, "Please select Destination...");

            label3.Text = id;
            if (label3.Text == "Train")
            {
                SEARCHTRAIN.Visible = true;
            }
            else if (label3.Text == "Bus")
            {
                SEARCHBUS.Visible = true;
            }

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SEARCHTRAIN_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                Selectseats s1 = new Selectseats();
                s1.Show();
            }

            if (comboBox2.Text == "" && comboBox1.Text == "" || comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Invalid");
            }


        }
        private void Train_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SEARCHBUS_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            { 
                Busseats b1 = new Busseats();
                b1.Show();
            }

            if (comboBox2.Text == ""&& comboBox1.Text =="" || comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Invalid");
            }
            
        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
