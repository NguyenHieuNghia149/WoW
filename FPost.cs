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

namespace TheGioiViecLam
{
    public partial class FPost : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FPost(string account)
        {
            InitializeComponent();
            this.account = account;
            LoadJobNameIntoComboBox();
            LoadPhoneNum(account);
            LoadDistrictIntoComboBox(account);
            LoadCity(account);
            Load_UCWorkInFor_FromDatabase(account);
        }
        private void FPost_Load(object sender, EventArgs e)
        {
            LoadJobNameIntoComboBox();
            LoadDistrictIntoComboBox(account);
            LoadCity(account);
            LoadPhoneNum(account);
            Load_UCWorkInFor_FromDatabase(account);

        }

    
        public void UCWorkInFor_Click(string WID,string IDP, object sender, EventArgs e)
        {
            if (sender is UCWorkInFor uCWorkInFor)
            {
                string postID = uCWorkInFor.txtIDP.Text;
                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(WID,IDP,account);
                form.Show();
            }
        }
        private void LoadJobNameIntoComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT JobName FROM Job";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string JobName = reader["JobName"].ToString();
                    cbboxJobName.Items.Add(JobName);
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
        private void LoadCity(string account)
        {
            try
            {
                conn.Open();

                string query = string.Format("SELECT City FROM Worker WHERE WEmail = '{0}'", account);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string City = reader["City"].ToString();
                    txtCity.Text = City;
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
        private void LoadDistrictIntoComboBox(string account)
        {
            try
            {
                conn.Open();
                string City = txtCity.Text;
                string query = string.Format("SELECT District FROM Worker WHERE City = N'{0}' ", City);
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
        private void Load_UCWorkInFor_FromDatabase(string account)
        {
            panel_Bot.AutoScroll = true; // Tạo thanh cuộn cho panel4

            try
            {

                UCWorkInFor uCPosted = new UCWorkInFor();

                conn.Open();
                string query = string.Format("SELECT * FROM Post WHERE Email = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Điền dữ liệu từ cơ sở dữ liệu vào DataSet
                adapter.Fill(dataSet);

                // Xóa tất cả các UC hiện có trong Panel trước khi thêm UC mới
                panel_Bot.Controls.Clear();

                // Duyệt qua các dòng dữ liệu trong DataSet và tạo UCPosted tương ứng
                int y = 0; // Biến để điều chỉnh vị trí theo trục y của các UC

                while (reader.Read())
                {
                    string JobName = reader["JobName"].ToString();
                    string WTime = reader["WTime"].ToString();
                    string Cost = reader["Cost"].ToString();
                    string District = reader["District"].ToString();
                    string Experience = reader["Experience"].ToString();
                    string IDP = reader["IDP"].ToString();
                    string WID = reader["WID"].ToString();
                    UCWorkInFor ucWorkInFor = new UCWorkInFor();
                    ucWorkInFor.Click += (s, ev) => UCWorkInFor_Click(WID,IDP, s, ev);

                    ucWorkInFor.txtJobName.Text = JobName;
                    ucWorkInFor.txtWTime.Text = WTime;
                    ucWorkInFor.txtCost.Text = Cost;
                    ucWorkInFor.txtLocation.Text = District;
                    ucWorkInFor.txtExperience.Text = Experience;
                    ucWorkInFor.txtIDP.Text = IDP;

                    // Thêm UC vào panel

                    ucWorkInFor.Location = new Point(20, y);
                    y += ucWorkInFor.Height + 5;

                    panel_Bot.Controls.Add(ucWorkInFor);
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

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("EXEC pd_Insert_Post_ N'{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}',N'{6}'",
                    txtIDP.Text, account, cbboxJobName.Text, cbboxWTime.Text, txtCost.Text, txtDetail.Text, cbboxExperience.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
                FPost_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE Post SET JobName='{0}',WTime='{1}',Cost='{2}',Detail='{3}',Experience='{4}',City =N'{6}',District=N'{7}' WHERE IDP ='{5}'",
               cbboxJobName.Text, cbboxWTime.Text, txtCost.Text, txtDetail.Text, cbboxExperience.Text, txtIDP.Text, txtCity.Text, cbboxDistrict.Text);
            db.Execute(query);
            FPost_Load(sender, e);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = string.Format("EXEC pd_delete_Post_Order N'{0}'", txtIDP.Text);
            db.Execute(query);
            FPost_Load(sender, e);
        }

    }
}
