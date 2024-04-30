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
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FDailyJob : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string OrderNum;
        private string account;
        private List<Order> jobs;
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public List<Order> Jobs { get => jobs; set => jobs = value; }

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public FDailyJob(DateTime date, string account, List<Order> jobs,string OrderNum)
        {
            InitializeComponent();
            this.date = date;
            this.account = account;
            this.jobs = jobs;
            this.OrderNum = OrderNum;
            fPanel.Width = pnJob.Width;
            fPanel.Height = pnJob.Height;
            pnJob.Controls.Add(fPanel);
            dt.Value = date;
            ShowJobByDate(date);
        }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (jobs != null)
            {
                List<Order> todayJobs = GetJobsByDay(date);              
                foreach (Order job in todayJobs)
                {
                    ucAOrder ucJob = new ucAOrder(job);
                    ucJob.Tag = job;
                    ucJob.btndeny.Click += (s, ev) => ajob_Denied(s, ev, OrderNum);
                    ucJob.btnConfirm.Click += (s, ev) => ajob_Confirmed(s, ev, OrderNum);
                    ucJob.btnDone.Click += (s, ev) => ajob_Done(s, ev, OrderNum);
                    fPanel.Controls.Add(ucJob);
                }
            }
        }
        private List<Order> GetData()
        {
            List<Order> jobs = new List<Order>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Post.Email = '{0}' and Customer.CEmail = Orders.CEmail", account);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order job = new Order();

                    // Kiểm tra xem cột có giá trị null không trước khi chuyển đổi kiểu dữ liệu
                    if (!reader.IsDBNull(reader.GetOrdinal("ODate")))
                    {
                        job.Date = reader.GetDateTime(reader.GetOrdinal("ODate"));
                    }
                    job.CEmail = reader["CEmail"].ToString();
                    job.Workername = reader["WorkerName"].ToString();
                    job.Jobname = reader["jobname"].ToString();
                    job.FromHours = reader["FromHours"].ToString();
                    job.FromMinutes = reader["FromMinutes"].ToString();
                    job.Cost = reader["cost"].ToString();
                    job.Customername = reader["fullname"].ToString();
                    job.Phonenumber = reader["phonenumber"].ToString();
                    job.Address = reader["CAddress"].ToString();
                    job.Status = reader["OStatus"].ToString();

                    // Kiểm tra xem trạng thái là "Unconfirm" hay không
                    if (job.Status == "Unconfirm                                                                                           " && job.Status == "Confirmed                                                                                           ")
                    {
                        jobs.Add(job); // Chỉ thêm công việc vào danh sách nếu trạng thái là "Unconfirm"
                    }
                }
                reader.Close();
                return jobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối sau khi sử dụng xong
            }
        }

        private void LoadJobDetails(ucAOrder ucJob, Order job)
        {
            ucJob.txtAddress.Text = job.Address;
            ucJob.txtCustomer.Text = job.Customername;
            ucJob.txtfromHours.Text = job.FromHours;
            ucJob.txtfromMinute.Text = job.FromMinutes;
            ucJob.txtJob.Text = job.Jobname;
            ucJob.txtPhoneNumber.Text = job.Phonenumber;
            ucJob.txtStatus.Text = job.Status;
        }

        private void ajob_Done( object sender, EventArgs e,string OrderNum)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Done' WHERE OrderNum = @OrderNum";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                jobs = GetData();
                ShowJobByDate(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            }
        }


        private void ajob_Confirmed( object sender, EventArgs e, string OrderNum)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Confirmed' WHERE OrderNum = @OrderNum ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                jobs = GetData();
                ShowJobByDate(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            }
        }

        private void ajob_Denied( object sender, EventArgs e, string OrderNum)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Deny' WHERE OrderNum = @OrderNum ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                jobs = GetData();
                ShowJobByDate(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            }
        }

        private List<Order> GetJobsByDay(DateTime date)
        {
            return jobs.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dt.Value = dt.Value.AddDays(-1);
        }

        private void btnTomorow_Click(object sender, EventArgs e)
        {
            dt.Value = dt.Value.AddDays(1);
        }

        private void mnToday_Click(object sender, EventArgs e)
        {
            dt.Value = DateTime.Now;
        }

        private void pnJob_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
