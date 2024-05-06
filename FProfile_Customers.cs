using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Shapes;
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FProfile_Customers : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public string account;
        ImageDao imageDao = new ImageDao();
        public FProfile_Customers(string account)
        {
            InitializeComponent();
            LoadInformation(account);
            this.account = account;
            LoadCity();
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
                    
                
                    byte[] b = reader["img"] as byte[];
                    if(b != null) {
                        MemoryStream ms = new MemoryStream(b);
                        pictureBox.Image = Image.FromStream(ms);
                    }

                    txtEmail.Text = email;
                    txtFullname.Text = fullname;
                    txtGender.Text = gender;
                    txtAddress.Text = address;
                    txtID.Text = id;
                    txtPhoneNumber.Text = phonenumer;
                    cbbDistrict.Text = District;
                    cbbCity.Text = city;
                    dtBirthday.Text = birthday;
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = imageDao.imageToByteArray(pictureBox.Image);
                conn.Open();
                string query = string.Format("Update Customer set CID = @ID, Fullname = @Fullname, Gender = @Gender, CBirthday = @Birthday, City = @City, District = @District, PhoneNum = @Phonenumber, CAddress = @Address, img = @img where CEmail = @account");
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID",txtID.Text);
                cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Birthday", dtBirthday.Value);
                cmd.Parameters.AddWithValue("@City", cbbCity.Text);
                cmd.Parameters.AddWithValue("@District", cbbDistrict.Text);
                cmd.Parameters.AddWithValue("@Phonenumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@img", b);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Sucessfull");
                conn.Close();
            }
        }
        private void LoadCity()
        {
            try
            {
                conn.Open();

                string query = string.Format("SELECT distinct  City FROM Cities");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string City = reader["City"].ToString();
                    cbbCity.Items.Add(City);
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
        private void LoadDistrictIntoComboBox()
        {
            try
            {
                cbbDistrict.Items.Clear();
                conn.Open();
                string City = cbbCity.Text;
                string query = string.Format("SELECT distinct District  FROM Cities WHERE City = N'{0}' ", City);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string District = reader["District"].ToString();
                    cbbDistrict.Items.Add(District);
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

        private void cbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDistrictIntoComboBox();
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
