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
using TheGioiViecLam.DAO;
using System.IO;

namespace TheGioiViecLam
{
    public partial class FPost : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        ImageDao imageDao = new ImageDao();


        public FPost(string account)
        {
            InitializeComponent();
            this.account = account;

        }
        private void FPost_Load(object sender, EventArgs e)
        {
            LoadJobNameIntoComboBox();
           // LoadDistrictIntoComboBox();
            LoadCity();
            LoadPhoneNum(account);
            LoadPID();
        }


        public void UCWorkInFor_Click(string WID, string IDP, object sender, EventArgs e)
        {
            FWorkdetail form = new FWorkdetail(WID, IDP, account);
            form.Show();

            if (sender is UCWorkInFor uCWorkInFor)
            {
                /*string postID = uCWorkInFor.txtIDP.Text;*/

            }
        }
        private void LoadJobNameIntoComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT distinct FieldName FROM JobField";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string JobName = reader["FieldName"].ToString();
                    cbbJobJield.Items.Add(JobName);
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
                    cbbCities.Items.Add(City);
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
                string City = cbbCities.Text;
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
        private void LoadPhoneNum(string account)
        {
            try
            {
                conn.Open();

                string query = string.Format("SELECT PhoneNum FROM Worker WHERE WEmail = '{0}'", account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PhoneNum = reader["PhoneNum"].ToString();
                    txtPhoneNum.Text = PhoneNum;
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

        private void LoadPID()
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT MAX(IDP)+1 AS MAX FROM Post");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string PID = reader["MAX"].ToString();
                    txtIDP.Text = PID;
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
            txtIDP.Visible = false; //ẩn đi ID
        }

        /* private void btnEdit_Click(object sender, EventArgs e)
         {
             string query = string.Format("UPDATE Post SET JobField='{0}',WTime='{1}',Cost='{2}',Detail='{3}',Experience='{4}',City =N'{6}',District=N'{7}',JobName=N'{8}' WHERE IDP ='{5}'",
                cbbJobJield.Text, cbbTime.Text, txtCost.Text, txtDetail.Text, cbbExperience.Text, txtIDP.Text, cbbCities.Text, cbbDistrict.Text, txtJob.Text);
             db.Execute(query);
             FPost_Load(sender, e);

         }*/

        private void cbbCities_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDistrictIntoComboBox();
        }

        private void picturePost_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picturePost.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                byte[] b = imageDao.imageToByteArray(picturePost.Image);
                string query = string.Format("EXEC pd_Insert_Post_ @IDP, @Account, @Job, @Time, @Cost, @Detail, @Experience, @PhoneNum, @Cities, @District, @JobJield, @Image,@Address");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                cmd.Parameters.AddWithValue("@IDP", txtIDP.Text);
                cmd.Parameters.AddWithValue("@Account", account);
                cmd.Parameters.AddWithValue("@Job", txtJob.Text);
                cmd.Parameters.AddWithValue("@Time", cbbTime.Text);
                cmd.Parameters.AddWithValue("@Cost", txtCost.Text);
                cmd.Parameters.AddWithValue("@Detail", txtDetail.Text);
                cmd.Parameters.AddWithValue("@Experience", cbbExperience.Text);
                cmd.Parameters.AddWithValue("@PhoneNum", txtPhoneNum.Text);
                cmd.Parameters.AddWithValue("@Cities", cbbCities.Text);
                cmd.Parameters.AddWithValue("@District", cbbDistrict.Text);
                cmd.Parameters.AddWithValue("@JobJield", cbbJobJield.Text);
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value = b;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfull!!!");
                FPost_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
