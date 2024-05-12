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
using System.Collections;
using TheGioiViecLam.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;

namespace TheGioiViecLam
{
    public partial class FPost_RequireJobs_Customers : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FPost_RequireJobs_Customers()
        {
            InitializeComponent();
        }
        public FPost_RequireJobs_Customers(string account)
        {
            this.account = account;
            InitializeComponent();
            LoadRequireID();
            LoadAddressAndPhonenum(account);
        }

        private void LoadRequireID()
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT MAX(RequireID)+1 AS MAX FROM Requirement");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string RequireID = reader["MAX"].ToString();
                    txtRequireID.Text = RequireID;
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
            txtRequireID.Visible = false; //ẩn đi ID
        }
        private void LoadAddressAndPhonenum(string account)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Customer WHERE CEmail = '" + account + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PhoneNum = reader["PhoneNum"].ToString();
                    string Address = reader["CAddress"].ToString();
                    txtNumberPhone.Text = PhoneNum;
                    txtAddress.Text = Address;  
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void lblPost_Click(object sender, EventArgs e)
        {
            if (txtJobName.Text == "" || txtDetail.Text == "")
            {
                MessageBox.Show("You haven't fill enough information");
            }
            else
            {
                try
                {
                    int RequireID = int.Parse(txtRequireID.Text);
                    string query = string.Format("EXEC pd_Requirement_Insert '{0}','{1}','{2}','{3}'",
                    RequireID, account, txtJobName.Text, txtDetail.Text);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    db.Execute(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
