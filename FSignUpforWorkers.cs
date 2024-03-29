using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FSignUpforWorkers : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FSignUpforWorkers()
        {
            InitializeComponent();
        }
        private bool CheckPassword(string pass) // kiem tra password
        {

            return Regex.IsMatch(pass, @"^(?=.*[a-zA-Z0-9])(?=.*[!@#?$%^&*()-+]).{6,24}$");
        }

        private bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_]{3,20}@gmail.com(.vn|)$");
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string passwordconfirm = txtPasswordConfirm.Text;
            string id = txtID.Text;
            string fullname = txtFullname.Text;
            string gender = txtGender.Text;
            DateTime birthday = dtBirthday.Value;
            string city = txtCity.Text;
            string district = txtDistrict.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhoneNumber.Text;
            if (!CheckPassword(password))
            {
                MessageBox.Show("Please inter password must contain at least 6 characters. Combination of symbols, numbers, uppercase letters, lowercase letters.");
                return;
            }

            if (passwordconfirm != password)
            {
                MessageBox.Show("Please confirm the correct password.");
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Please enter email in correct format.");
                return;
            }

            if (db.Login("Select * from Customer where WEmail = '" + email + "'").Count() != 0)
            {
                MessageBox.Show("Email is exist!!");
                return;
            }

            try
            {
                string sql = string.Format("INSERT INTO Worker(WID,WEmail,WPassword,Fullname,Gender,Birthday,City,District,Phonenum,WAddress) VALUES('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", id, email, password, fullname, gender, birthday, city, district, phonenumber, address);
                db.Execute(sql);
                FSignInforWorkers form = new FSignInforWorkers();
                form.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("The email is already registered, please register another email!");
            }
        }
    }
}
