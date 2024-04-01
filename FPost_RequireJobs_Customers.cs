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
            LoadIntoTxtBox(account);
            LoadJobNameIntoComboBox(account);
            LoadRequireID(account);
        }

        private void LoadIntoTxtBox(string account) //City,Address,District
        {
            try
            {
                conn.Open();

                string query = string.Format("SELECT * FROM Customer WHERE CEmail = '{0}'", account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string City = reader["City"].ToString();
                    string District = reader["District"].ToString();
                    string Address = reader["CAddress"].ToString();
                    txtCity.Text = City;
                    txtDistrict.Text = District;
                    txtAddress.Text = Address;
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
        
        private void LoadJobNameIntoComboBox(string account)
        {
            try
            {
                conn.Open();
                string City = txtCity.Text;
                string query = string.Format("SELECT JobName FROM Job");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string District = reader["JobName"].ToString();
                    cbboxJobName.Items.Add(District);
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

        private void LoadRequireID(string account)
        {
            try
            {
                conn.Open();
                string City = txtCity.Text;
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
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            try
            {
                //int result = Int32.Parse(input);
                //@RequireID,@CEmail,@JobName,@Detail,@WGender,@Cost
                int RequireID = Int32.Parse(txtRequireID.Text);

                string query = string.Format("EXEC pd_Requirement_Insert '{0}','{1}','{2}','{3}','{4}','{5}'",
                    RequireID, account, cbboxJobName.Text, txtDetail.Text, cbboxGender.Text, txtCost.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
                LoadRequireID(account);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
        }
    }
}
