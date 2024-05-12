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
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FDailyJob : Form
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string OrderNum;
        private string account;
        private string CEmail;
        private CalenderDao calenderDao;

        private List<Order> jobs;
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public List<Order> Jobs { get => jobs; set => jobs = value; }

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public FDailyJob(DateTime date, string account, List<Order> jobs,string OrderNum,string CEmail)
        {
            InitializeComponent();
            this.date = date;
            this.account = account;
            this.jobs = jobs;
            this.OrderNum = OrderNum;
            this.CEmail = CEmail;
            fPanel.Width = pnJob.Width;
            fPanel.Height = pnJob.Height;
            pnJob.Controls.Add(fPanel);
            calenderDao = new CalenderDao(account);

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
                    ucJob.btndeny.Click += (s, ev) => ajob_Denied(s, ev, OrderNum,CEmail);
                    ucJob.btnConfirm.Click += (s, ev) => ajob_Confirmed(s, ev, OrderNum,CEmail);
                    ucJob.btnDone.Click += (s, ev) => ajob_Done(s, ev, OrderNum,CEmail);

                    fPanel.Controls.Add(ucJob);
                }
            }
        }
        private void ajob_Done( object sender, EventArgs e,string OrderNum,string CEmail)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Done' WHERE OrderNum = @OrderNum and CEmail = @CEmail";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                cmd.Parameters.AddWithValue("@CEmail", CEmail);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                jobs = calenderDao.GetData();
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

        private void ajob_Confirmed( object sender, EventArgs e, string OrderNum, string CEmail)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Confirmed' WHERE OrderNum = @OrderNum and CEmail = @CEmail ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                cmd.Parameters.AddWithValue("@CEmail", CEmail);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                jobs = calenderDao.GetData();
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
        private void ajob_Denied( object sender, EventArgs e, string OrderNum, string CEmail)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Deny' WHERE OrderNum = @OrderNum and CEmail = @CEmail";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderNum", OrderNum);
                cmd.Parameters.AddWithValue("@CEmail", CEmail);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                jobs = calenderDao.GetData();
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
