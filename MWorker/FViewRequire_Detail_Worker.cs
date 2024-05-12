using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TheGioiViecLam.model;
using Guna.UI2.Designer;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FViewRequire_Detail_Worker : Form
    {
        public string account;
        public string ID;
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FViewRequire_Detail_Worker(string ID, string account)
        {
            this.ID = ID;
            this.account = account;
            InitializeComponent();
            LoadIntoTextbox(ID);
            LoadBtn();
        }
        private void LoadIntoTextbox(string ID)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Requirement WHERE RequireID = {0}", ID);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string District = reader["District"].ToString();
                    string FullName = reader["FullName"].ToString();
                    string CGender = reader["CGender"].ToString();
                    string PhoneNum = reader["PhoneNum"].ToString();
                    string CEmail = reader["CEmail"].ToString();
                    string City = reader["City"].ToString();
                    string CAddress = reader["CAddress"].ToString();
                    string Detail = reader["Detail"].ToString();
                    string JobName = reader["JobName"].ToString();

                    txtAddress.Text = CAddress;
                    txtDetail.Text = Detail;
                    txtDistrict.Text = District;
                    txtEmail.Text = CEmail;
                    txtFullname.Text = FullName;
                    txtGender.Text = CGender;
                    txtPhoneNumber.Text = PhoneNum;
                    lblJobName.Text = JobName;
                    txtCity.Text = City;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadBtn()
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT checknum = dbo.fnCheckBook({0},'{1}')", ID, account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int checknum = int.Parse(reader["checknum"].ToString());
                    if(checknum == 1)
                        btnBook.Enabled = false;
                    else
                        btnBook.Enabled = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("INSERT INTO WorkerBook(RequireID,WEmail) VALUES ({0},'{1}')",ID,account);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
                LoadBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
