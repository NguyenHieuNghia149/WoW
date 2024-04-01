using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Security.Principal;

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
            Controls.Add(ucW); // Thêm UserControl vào form
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
                    ucW.txtCity.Text = reader["City"].ToString() ;
                    ucW.txtAddress.Text = reader["District"].ToString();
                    ucW.txtPhone.Text = reader["PhoneNum"].ToString();

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
        }
    }
}
