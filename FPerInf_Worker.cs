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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheGioiViecLam
{
    public partial class FPerInf_Worker : Form
    {
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        
        public FPerInf_Worker(string account)
        {
            InitializeComponent();
            this.account = account;
            Load_AllTxtBox(account);
            LoadDistrictIntoComboBox(account);
            LoadCityIntoComboBox(account);
        }

        private void FPerInf_Worker_Load(object sender, EventArgs e)
        {

        }

        private void LoadDistrictIntoComboBox(string account)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT DISTINCT District FROM Worker WHERE WEmail = '{0}' " , account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string District = reader["District"].ToString();
                    cbboxDistrict.Items.Add(District);
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
        private void LoadCityIntoComboBox(string account)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT DISTINCT City FROM Worker WHERE WEmail = '{0}' " , account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string City = reader["City"].ToString();
                    cbboxCity.Items.Add(City);
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
        
       private void Load_AllTxtBox(string account) //khong hien cac combo box
       {
            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Worker WHERE WEmail = '{0}' " , account);

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string FullName = reader["FullName"].ToString();
                    string WID = reader["WID"].ToString();
                    string Gender = reader["Gender"].ToString();
                    string PhoneNum = reader["PhoneNum"].ToString();
                    string Birthday = reader["Birthday"].ToString();
                    string City = reader["City"].ToString();
                    string District = reader["District"].ToString();
                    string Email = reader["WEmail"].ToString();
                    string Address = reader["WAddress"].ToString();

                    txtFullName.Text = FullName;
                    txtWID.Text = WID;
                    cbboxGender.Text = Gender;
                    txtPhoneNum.Text = PhoneNum;
                    dtpBirthday.Text = Birthday;
                    cbboxCity.Text = City;
                    cbboxDistrict.Text = District;
                    txtEmail.Text = Email;
                    txtAddress.Text = Address;
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) 
        {
            string query = string.Format("UPDATE Worker SET FullName=N'{0}',Gender='{1}',PhoneNum='{2}',Birthday='{3}',City=N'{4}',District=N'{5}',WAddress='{6}',WID ='{7}' WHERE WEmail = '{8}'",
                txtFullName.Text, cbboxGender.Text, txtPhoneNum.Text, dtpBirthday.Value, cbboxCity.Text, cbboxDistrict.Text, txtAddress.Text, txtWID.Text, account);
            db.Execute(query);
            
        }
    }
}
