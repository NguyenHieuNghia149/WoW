using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FForgetPassword : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FForgetPassword()
        {
            InitializeComponent();
            lblNofication.Text = "Enter your email to reset password.";
            lblResult.Text = " ";
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string email  = txtEmail.Text.Trim();  
            if(email.Trim() == "")
            {
                MessageBox.Show("Please enter register email.");
            }
            else
            {
                string sql = "SELECT * FROM Account WHERE email = @Email";             
                SqlCommand command = new SqlCommand(sql, conn); 
                command.Parameters.AddWithValue("@Email", email);
                conn.Open(); 
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    lblResult.ForeColor = Color.SteelBlue;
                    lblResult.Text = "Password: " + reader["password"].ToString();
                }
                else
                {
                    lblNofication.ForeColor = Color.Red;
                    lblNofication.Text = "This email is not registered!!";
                }
                conn.Close(); 
            }    
        }
    }
}
