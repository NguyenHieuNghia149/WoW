using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FSignInforWorkers : Form
    {
        DBConnection db = new DBConnection();
        string account;
        public FSignInforWorkers()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FSignIn form = new FSignIn();   
            form.Show();
            this.Hide();
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
                string sql = "Select * from Worker where WEmail ='" + email + "'  and WPassword = '" + password + "'";
                if (db.LoginWorker(sql).Count > 0)
                {
                    account = email;
                    FDisplay_Workers form = new FDisplay_Workers(email);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your email or passworld is incorrect!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FSignInforWorkers_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            FSignUpforWorkers form = new FSignUpforWorkers();
            form.Show();
            this.Hide();
        }
    }
}
