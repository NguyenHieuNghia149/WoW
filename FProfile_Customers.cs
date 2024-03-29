using System;
using System.Collections;
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
    public partial class FProfile_Customers : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public string account;
        public FProfile_Customers(string account)
        {
            InitializeComponent();
            LoadInformation(account);
            this.account = account;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadInformation(string account)
        {
            try
            {
                conn.Open();
                string sql = string.Format("select * From Customer Where CEmail = '{0}'", account);
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string email = reader["CEmail"].ToString();
                    string fullname = reader["Fullname"].ToString();
                    string gender = reader["Gender"].ToString();
                    string birthday = reader["CBirthday"].ToString();
                    string city = reader["City"].ToString();
                    string District = reader["District"].ToString();
                    string phonenumer = reader["PhoneNum"].ToString();
                    string address = reader["CAddress"].ToString();
                    string id = reader["CID"].ToString();

                    txtEmail.Text = email;
                    txtFullname.Text = fullname;
                    txtGender.Text = gender;
                    txtAddress.Text = address;
                    txtID.Text = id;
                    txtPhoneNumber.Text = phonenumer;
                    txtDistrict.Text = District;
                    cbCity.Text = city;
                    dtBirtthday.Text = birthday;
                }
                reader.Close();


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


    }
}
