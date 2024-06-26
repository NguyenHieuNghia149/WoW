﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FFavorite : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public string postID;
        public string account;
        UCWorkInFor uc;
        //private string selectedPostID;
        public FFavorite(string account)
        {
            InitializeComponent();
            this.account = account;
            LoadDataWorkInFor();
        }

        private void FFavorite_Load(object sender, EventArgs e)
        {
            LoadDataWorkInFor();
        }

        private void LoadDataWorkInFor()
        {
            panelmain.AutoScroll= true;
            try
            {
                conn.Open();
                string sql = string.Format("select PostsWithAverageRating.Rating as Rating ,PostsWithAverageRating.img as img,PostsWithAverageRating.IDP as IDP,PostsWithAverageRating.WID as WID, PostsWithAverageRating.JobName as JobName, PostsWithAverageRating.Email as WEmail, PostsWithAverageRating.Cost as Cost,PostsWithAverageRating.Address as Address," +
                    " PostsWithAverageRating.Experience as Experience,PostsWithAverageRating.WTime as Time, PostsWithAverageRating.District as District," +
                    " CEmail from Saves,PostsWithAverageRating where  PostsWithAverageRating.IDP = Saves.IDP and Saves.CEmail = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                panelmain.Controls.Clear();

                int y = 0;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string job = row["JobName"].ToString();
                    string price = row["Cost"].ToString();
                    string experience = row["Experience"].ToString();
                    string location = row["Address"].ToString();
                    string time = row["Time"].ToString();
                    string postID = row["IDP"].ToString();
                    string wid = row["WID"].ToString() ;
                    string wEmail = row["WEmail"].ToString();
                    int Rating = Convert.ToInt32(row["Rating"]);
                    byte[] b = row["img"] as byte[];
                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.panelMain.Click += (s, ev) => ucWorkInFor_Click(wEmail,wid,postID, s, ev);
                    uCWorkInFor.btnDelete.Click += (s, ev) => Delete_Click(postID, s, ev);
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price;
                    uCWorkInFor.txtExperience.Text = experience;
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.txtWTime.Text = time;
                    uCWorkInFor.ratingStar.Value = Rating;
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        uCWorkInFor.picturePost .Image = Image.FromStream(ms);
                    }
                    uCWorkInFor.Location = new Point(50, y);
                    uCWorkInFor.btnSave.Visible = false;
                    uCWorkInFor.btnSave.Enabled = false;
                    y += uCWorkInFor.Height + 10;
                    panelmain.Controls.Add(uCWorkInFor);
                }
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

        private void ucWorkInFor_Click(string wEmail,string wid,string postID, object sender, EventArgs e)
        {
            FWorkdetail form = new FWorkdetail(wEmail,wid, postID, account);
            form.Show();
            if (sender is UCWorkInFor uCWorkInFor)
            {
                // Tạo và hiển thị form FWorkdetail
                
            }
        }
        private void Delete_Click(string postID, object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                conn.Open();

                // Tạo truy vấn SQL để xóa dữ liệu trong bảng Saves với IDP bằng postID
                string sqlDelete = string.Format("DELETE FROM Saves WHERE IDP = '{0}'", postID);

                // Thực thi truy vấn SQL
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                conn.Close();

                // Thông báo cho người dùng rằng dữ liệu đã được xóa thành công
                MessageBox.Show("Dữ liệu đã được xóa thành công.");
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối đã được đóng ngay cả khi có lỗi xảy ra
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            LoadDataWorkInFor();
        }


        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
