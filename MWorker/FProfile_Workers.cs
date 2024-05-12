using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FProfile_Workers : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public string account;
        ImageDao imageDao = new ImageDao();
        public FProfile_Workers(string account)
        {
            InitializeComponent();
          
            this.account = account;
            Load_AllTxtBox(account);
            LoadCityIntoComboBox();
        }
        private void LoadDistrictIntoComboBox()
        {
            try
            {
                cbboxDistrict.Items.Clear();
                conn.Open();
                string City = cbboxCity.Text;
                string query = string.Format("SELECT distinct District  FROM Cities WHERE City = N'{0}' ", City);
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
        private void LoadCityIntoComboBox()
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

        private void Load_AllTxtBox(string account)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Worker WHERE WEmail = '{0}' ", account);

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
                    byte[] b = reader["img"] as byte[];
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        pictureBox.Image = Image.FromStream(ms);
                    }
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
          

        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnPostImage_Click(object sender, EventArgs e)
        {
            byte[] b = imageDao.imageToByteArray(pictureBox.Image);
            conn.Open();
            string query = string.Format("Update Worker set img = @image where WEmail = @account");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@image", b);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = imageDao.imageToByteArray(pictureBox.Image);
                conn.Open();
                string query = string.Format("Update Worker set WID = @ID, Fullname = @Fullname, Gender = @Gender, Birthday = @Birthday, City = @City, District = @District, PhoneNum = @Phonenumber, WAddress = @Address, img = @img where WEmail = @account");
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", txtWID.Text);
                cmd.Parameters.AddWithValue("@Fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Gender", cbboxGender.Text);
                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@City", cbboxCity.Text);
                cmd.Parameters.AddWithValue("@District", cbboxDistrict.Text);
                cmd.Parameters.AddWithValue("@Phonenumber", txtPhoneNum.Text);
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

        private void cbboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDistrictIntoComboBox();
        }
    }
}
