using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using TheGioiViecLam.model;
namespace TheGioiViecLam
{
    public partial class FSignIn : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FSignIn()
        {
            InitializeComponent();
           
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Please inter your account!");

            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Please inter your password!");

            }
            else
            {
                string sql = "Select * from Customer where CEmail ='" + email + "'  and CPassword = '" + password + "'";
                if (db.Login(sql).Count > 0)
                {
                    FDisplay_Customers form = new FDisplay_Customers(email);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your email or password is incorrect!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }
   

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            FSignUp form = new FSignUp();
            form.Show();
            this.Hide();
        }

        private void lblFGpassword_Click(object sender, EventArgs e)
        {
            FForgetPassword form = new FForgetPassword();
            form.Show();
            this.Hide();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            FSignInforWorkers form = new FSignInforWorkers();
            form.Show();
            this.Hide();
        }

      
    }
}
