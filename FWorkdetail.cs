using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Security.Principal;
using System.IO;
using System.Drawing;
using System.Data;
using TheGioiViecLam.UserControls;
namespace TheGioiViecLam
{
    public partial class FWorkdetail : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        UCWork_Detail ucW; // Khai báo UserControl
        private string selectedPostID;
        private string account;
        private string wid;
        public FWorkdetail(string wid,string postID, string account)
        {
            InitializeComponent();
            selectedPostID = postID;
            ucW = new UCWork_Detail(); // Khởi tạo UserControl
            panel1.Controls.Add(ucW); // Thêm UserControl vào form
            ucW.Dock = DockStyle.Fill; // Cho phép UserControl lấp đầy toàn bộ kích thước của form
            ucW.btnBook.Click += BtnBook_Click;
            this.account = account;
            this.wid = wid;
        }
        private void BtnBook_Click(object sender, EventArgs e)
        {
            FCalenderCustomer form = new FCalenderCustomer(selectedPostID, account);
            form.ShowDialog();
        }
        private void FWorkdetail_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM dbo.Post WHERE IDP = @PostID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PostID", selectedPostID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ucW.txtWork.Text = reader["JobName"].ToString();
                    ucW.txtName.Text = reader["Fullname"].ToString();
                    ucW.txtExperience.Text = reader["Experience"].ToString();
                    ucW.txtTime.Text = reader["WTime"].ToString();
                    ucW.txtCost.Text = reader["Cost"].ToString();
                    ucW.txtWorkDetail.Text = reader["Detail"].ToString();
                    ucW.txtEmail.Text = reader["Email"].ToString();
                    ucW.txtCity.Text = reader["City"].ToString();
                    ucW.txtAddress.Text = reader["District"].ToString();
                    ucW.txtPhone.Text = reader["PhoneNum"].ToString();
/*                    byte[] b = reader["img"] as byte[];
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        ucW.ptbox.Image = Image.FromStream(ms);
                    }*/
                    // Gán dữ liệu cho các TextBox khác tại đây
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                string sqlStr1 = "SELECT Round(AVG(Rating),0) AS rating FROM Review WHERE IDP = @IDP";
                SqlCommand cmd1 = new SqlCommand(sqlStr1, conn);
                cmd1.Parameters.AddWithValue("@IDP", selectedPostID);
                object averageRating = cmd1.ExecuteScalar();
                if (averageRating != DBNull.Value)
                {
                    ucW.lblNumberReview.Text = averageRating.ToString();
                    ucW.ratingStar.Value = Convert.ToInt32(averageRating);
                }
                else
                {
                    ucW.lblNumberReview.Text = "N/A";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                string sqlStr2 = @"SELECT Review.Rating, Review.Review, Review.Img, Customer.Fullname
                  FROM Review
                  INNER JOIN Customer ON Review.CEmail = Customer.CEmail
                  WHERE Review.CEmail = @CEmail AND Review.IDP = @IDP AND Review.WID = @WID";
                SqlCommand cmd2 = new SqlCommand(sqlStr2, conn);
                cmd2.Parameters.AddWithValue("@CEmail", account);
                cmd2.Parameters.AddWithValue("@IDP", selectedPostID);
                cmd2.Parameters.AddWithValue("@WID", wid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd2); // Đổi từ sqlStr thành cmd2
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                int y = 690; // Biến để điều chỉnh vị trí theo trục y của các UC
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    int Rating = Convert.ToInt32(row["Rating"]);
                    string Review = row["Review"].ToString();
                    string Img = row["Img"].ToString();
                    string name = row["Fullname"].ToString();
                    UCreview uCreview = new UCreview();
                    uCreview.txtReview.Text = Review;
                    uCreview.RatingStar.Value = Rating;
                    uCreview.lblaccount.Text = name;
                    uCreview.Location = new Point(0, y);
                    y += uCreview.Height + 7; // Tăng y để tránh chồng chéo
                    panel1.Controls.Add(uCreview);
                    uCreview.BringToFront();
                }
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
    }
}