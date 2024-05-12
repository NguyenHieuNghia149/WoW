using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FForgetPassword : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        private string table;
        public FForgetPassword( string table)
        {
            InitializeComponent();
            lblNofication.Text = "Enter your email to reset password.";
            lblResult.Text = " ";
            this.table = table;
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string Email;
            string Password;
            if (table == "Customer")
            {
                Email = "CEmail";
                Password = "CPassword";
            }
            else
            {
                Email = "WEmail";
                Password = "WPassword";
            }
            string email = txtEmail.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Please enter register email.");
            }
            else
            {
                conn.Open();
                // You don't need to use single quotes around table and column names in SQL
                string query = string.Format("SELECT * FROM {0} WHERE {1} = @Email", table, Email);
                SqlCommand cmd = new SqlCommand(query, conn);
                // Use SqlParameter to avoid SQL injection and to handle special characters in the email
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblResult.ForeColor = Color.SteelBlue;
                    lblResult.Text = "Password: " + reader[Password].ToString();
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
