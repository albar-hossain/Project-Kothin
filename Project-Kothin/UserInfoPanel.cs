using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kothin
{
    public partial class UserInfoPanel : Form
    {
        public string vg;
        public UserInfoPanel()
        {
            InitializeComponent();
        }
        public UserInfoPanel(string username)
        {


            InitializeComponent();
            vg= username;
            fname.Text = username;
           // pnumv.Text = username;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");
                conn.Open();

                string query = $"select FullName from UserInfo where Phone={vg}";


                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val1 = dt.Rows[0]["FullName"].ToString();
               // string val2 = dt.Rows[0]["Phone"].ToString();
                fname.Text = val1;
                pnumv.Text = vg;


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
    }
}
