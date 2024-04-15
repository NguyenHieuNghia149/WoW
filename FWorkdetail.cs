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
        public FWorkdetail(string postID, string account)
        {
            InitializeComponent();
            selectedPostID = postID;
            ucW = new UCWork_Detail(); // Khởi tạo UserControl
            panel1.Controls.Add(ucW); // Thêm UserControl vào form
            ucW.Dock = DockStyle.Fill; // Cho phép UserControl lấp đầy toàn bộ kích thước của form
            ucW.btnBook.Click += BtnBook_Click;
            this.account = account;
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
                    byte[] b = reader["img"] as byte[];
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        ucW.ptbox.Image = Image.FromStream(ms);
                    }

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
                string sqlStr = string.Format("SELECT * FROM Review");   
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                int y = 0; // Biến để điều chỉnh vị trí theo trục y của các UC
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string Rating = row["Rating"].ToString();
                    string Review = row["Review"].ToString();
                    string Img = row["Img"].ToString();
                    UCreview uCreview = new UCreview();
                    uCreview.txtReview.Text = Review;
                    uCreview.RatingStar.Text = Rating;
                    // Đặt vị trí cho UC
                    uCreview.Location = new Point(50, y);
                    y += uCreview.Height + 10; // Tăng y để tránh chồng chéo
                    panelReview.Controls.Add(uCreview);

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
