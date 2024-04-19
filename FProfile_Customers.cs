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
using TheGioiViecLam.model;

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
            MessageBox.Show(account);
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
                    txtDistrict.Text = District;
                    cbCity.Text = city;
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

        private void imagebtnPostImage_Click(object sender, EventArgs e)
        {
            byte[] b = imageToByteArray(pictureBox.Image);
            conn.Open();
            string query = string.Format("Update Customer set img = @image where CEmail = @account");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@image", b);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //Chuyen  anh sang byte
        byte[] imageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        //Chuyen file anh asng byte[]
        byte[] PathtoByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            Image img = Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }


        Image byteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        
    }
}
