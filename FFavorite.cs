using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string sql = string.Format("select Post.IDP as IDP, Post.JobName as JobName, Post.Cost as Cost," +
                    " Post.Experience as Experience,Post.WTime as Time, post.District as District," +
                    " CEmail from Saves,Post where  Post.IDP = Saves.IDP and Saves.CEmail = 'Nam@gmail.com'", account);
               // string sql = string.Format("Select * from Post where Email = 'Nam@gmail.com' ");
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
                    string location = row["District"].ToString();
                    string time = row["Time"].ToString();
                    string postID = row["IDP"].ToString();
                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(postID, s, ev);
                    uCWorkInFor.btnDelete.Click += (s, ev) => Delete_Click(postID, s, ev);
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price;
                    uCWorkInFor.txtExperience.Text = experience;
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.txtWTime.Text = time;
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

        private void ucWorkInFor_Click(string postID, object sender, EventArgs e)
        {

            if (sender is UCWorkInFor uCWorkInFor)
            {
                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(postID,account);
                form.Show();
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
