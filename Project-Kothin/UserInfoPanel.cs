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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Kothin
{
    public partial class UserInfoPanel : Form
    {

        private String Phone;
        public UserInfoPanel()
        {
            
            InitializeComponent();
        }
        public UserInfoPanel(string phone)
        {


            InitializeComponent();
            Phone= phone;
           // fname.Text = phone;
           // pnumv.Text = username;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");
                conn.Open();

                string query = $"select FullName from UserInfo where Phone={Phone}";


                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val1 = dt.Rows[0]["FullName"].ToString();
               // string val2 = dt.Rows[0]["Phone"].ToString();
                fname.Text = val1;
                pnumv.Text = Phone;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True");//azwad
                //conn = new SqlConnection(@"Data Source=DESKTOP-5NMO71P\SQLEXPRESS;Initial Catalog=Porjoton;Integrated Security=True ");
                conn.Open();

                string query = $"select Email,Address,PostCode,Password from UserInfo where Phone={Phone}";


                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val3 = dt.Rows[0]["Email"].ToString();
                string val4 = dt.Rows[0]["Address"].ToString();
                string val5 = dt.Rows[0]["PostCode"].ToString();
                // string val2 = dt.Rows[0]["Phone"].ToString();
                textBoxEmail.Text = val3;
                textBoxAddress.Text = val4;
                textBoxPostcode.Text = val5;
                //pnumv.Text = Phone;

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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
                

        }


        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-9DIP61O\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
                conn.Open();
                //string updateValue = deleteTextbox.Text;
                // string updateTarget = "";
               // string updateWhome = Phone;

                //if (radioFirstName.Checked) updateTarget = "Fname";
                //else if (radioLastName.Checked) updateTarget = "Lname";
                //else if (radioUserName.Checked) updateTarget = "Uname";
                //else if (radioPassword.Checked) updateTarget = "Password";
                //else updateTarget = "Email";

                string updateEmail = textBoxEmail.Text;
                string updateAddress = textBoxAddress.Text;
                string updatePostcode = textBoxPostcode.Text;
                string updatePhone = pnumv.Text;
                MessageBox.Show(Phone);


                string query = $"update UserInfo set Email = '{updateEmail}', Address = '{updateAddress}', PostCode = '{updatePostcode}' where Phone = '{Phone}';";
                //string query = $"update UserInfo set Email = '{updateEmail}' where Phone = '{Phone}';";
                                   // update UserInfo set Email = 'azwad@gmail.com', Address = 'updateAddress', PostCode = 'updatePostcode' where phone = 01671048227;
                
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

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

        private void viewUpdate_Click(object sender, EventArgs e)
        {
            viewUpdate.Visible= false;
            textBoxEmail.ForeColor= Color.White;
            textBoxEmail.BackColor = Color.DimGray;
            
            textBoxAddress.ForeColor= Color.White;
            textBoxAddress.BackColor = Color.DimGray;
            
            textBoxPostcode.ForeColor= Color.White;
            textBoxPostcode.BackColor = Color.DimGray;
            
            
            textBoxEmail.ReadOnly= false;          
            textBoxAddress.ReadOnly= false;
            textBoxPostcode.ReadOnly= false;
            updatebutton.Visible = true;

        }
    }
}
