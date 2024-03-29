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
using System.Windows.Media;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FHome : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        UCWorkInFor uc_workinfor = new UCWorkInFor();
        public string postID;
        public string account;
        public FHome(string account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void ucWorkInFor_Click(string postID, object sender, EventArgs e)
        {
            
            if (sender is UCWorkInFor uCWorkInFor)
            {

                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(postID);
                form.Show();

            }
            
        }


        private void BtnSave_Click(string postID, object sender, EventArgs e)
        {
            

                string sql = string.Format("insert into Saves(IDP,CEmail) Values('{0}', '{1}') ", postID, account);
                db.Execute(sql);
                //showuCWorkinFor(postID);
            
        }
        
        public void FHome_Load(object sender, EventArgs e)
        {
            LoadData();          
        }
        private void LoadData()
        {
            // Đặt mã xử lý logic ở đây, ví dụ:
            LoadUCThueFromDatabase();
            LoadCitiesIntoComboBox();
        }
        private void LoadCitiesIntoComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT City FROM dbo.Post";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string city = reader["City"].ToString();
                    cbx_cities.Items.Add(city);
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
        private void LoadDistrictsIntoComboBox()
        {
            try
            {
                conn.Open();
                string selectedCity = cbx_cities.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedCity))
                {
                    string query = "SELECT DISTINCT District FROM dbo.Worker WHERE City = @City";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@City", selectedCity);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string district = reader["District"].ToString();
                        cbx_districts.Items.Add(district);
                    }

                    reader.Close();
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
        private void LoadUCThueFromDatabase()
        {
            PanelBottom.AutoScroll = true; // Tạo thanh cuộn cho panel4

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM Post");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dataSet = new DataSet();

                // Điền dữ liệu từ cơ sở dữ liệu vào DataSet
                adapter.Fill(dataSet);

                // Xóa tất cả các UC hiện có trong Panel trước khi thêm UC mới
                PanelBottom.Controls.Clear();

                // Duyệt qua các dòng dữ liệu trong DataSet và tạo UCThue tương ứng
                int y = 0; // Biến để điều chỉnh vị trí theo trục y của các UC
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string Time = row["WTime"].ToString();
                    string job = row["JobName"].ToString();
                    string price = row["Cost"].ToString();
                    string experience = row["Experience"].ToString();
                    string location = row["District"].ToString();
                    string postID = row["IDP"].ToString(); // Lấy giá trị IDP
                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(postID, s, ev);
                    uCWorkInFor.btnSave.Click += (s, ev) => BtnSave_Click(postID, s, ev);
                    uCWorkInFor.txtWTime.Text = Time;
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price;
                    uCWorkInFor.txtExperience.Text = experience.ToString();
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.txtIDP.Text = postID;
                    // Đặt vị trí cho UC
                    uCWorkInFor.Location = new Point(50, y);
                    y += uCWorkInFor.Height + 10; // Tăng y để tránh chồng chéo
                    PanelBottom.Controls.Add(uCWorkInFor);
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
        private void cbx_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = cbx_cities.SelectedItem.ToString();
            LoadDistrictsIntoComboBox();
        }
        private void cbx_districts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDistrict = cbx_districts.SelectedItem.ToString();    
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.Trim();

            // Phân tách thông tin tìm kiếm thành các từ ngữ
            string[] keywords = searchText.Split(' ');

            try
            {
                conn.Open();

                // Tạo câu truy vấn SQL dựa trên thông tin được chọn từ comboboxes và các từ ngữ tìm kiếm
                string query = "SELECT * FROM dbo.Post WHERE City = @City AND District = @District AND (";
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (i > 0)
                        query += " OR ";

                    query += "JobName LIKE @Keyword" + i;
                }
                query += ")";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@City", cbx_cities.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@District", cbx_districts.SelectedItem?.ToString());

                for (int i = 0; i < keywords.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@Keyword" + i, "%" + keywords[i] + "%");
                }

                SqlDataReader reader = cmd.ExecuteReader();

                // Xóa tất cả các UC hiện có trên panel trước khi thêm các UC mới
                PanelBottom.Controls.Clear();

                int y = 0;
                while (reader.Read())
                {
                    string job = reader["JobName"].ToString();
                    string price = reader["Cost"].ToString();
                    string experience = reader["Experience"].ToString();
                    string location = reader["District"].ToString();
                    string postID = reader["WID"].ToString(); // Lấy giá trị IDP


                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(postID, s, ev);
                    uCWorkInFor.btnSave.Click += (s, ev) => BtnSave_Click(postID, s, ev);

                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price + "$";
                    uCWorkInFor.txtExperience.Text = experience.ToString();
                    uCWorkInFor.txtLocation.Text = location;


                    // Đặt vị trí cho UC
                    uCWorkInFor.Location = new Point(50, y);
                    y += uCWorkInFor.Height + 10; // Tăng y để tránh chồng chéo
                    PanelBottom.Controls.Add(uCWorkInFor);
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

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
