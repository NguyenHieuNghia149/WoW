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
        private string postID;
        private string account;
        private List<Order> jobs;
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public List<Order> Jobs { get => jobs; set => jobs = value; }

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public FDailyJob(DateTime date, string postID, string account, List<Order> jobs)
        {
            InitializeComponent();
            this.date = date;
            this.account = account;
            this.postID = postID;
            this.jobs = jobs;
            fPanel.Width = pnJob.Width;
            //pnJob.Controls.Clear();
            fPanel.Height = pnJob.Height;
            pnJob.Controls.Add(fPanel);
            dt.Value = date;
        }
        void ShowJobBydate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (jobs != null)
            {
                List<Order> todayjob = GetjobByDay(date);
                for (int i = 0; i < todayjob.Count; i++)
                {
                    ucAOrder ajob = new ucAOrder(todayjob[i]);
                    if (!ajob.IsConfirmed || !ajob.IsUnconfirmed)
                    {
                        ajob.Tag = todayjob[i];
                        ajob.btndeny.Click += (s, ev) => ajob_Denied(ajob, s, ev);
                        ajob.btnConfirm.Click += (s, ev) => ajob_Confirmed(postID, s, ev);
                        ajob.btnDone.Click += (s, ev) => ajob_Done(postID, s, ev);
                        LoadJobDetails(ajob, todayjob[i]);

                        fPanel.Controls.Add(ajob);
                    }
                   
                }
            }
        }
        private void LoadJobDetails(ucAOrder ucA,Order job)
        {
            ucA.txtAddress.Text = job.Address;
            ucA.txtCustomer.Text = job.Customername;
            ucA.txtfromHours.Text = job.FromHours;
            ucA.txtfromMinute.Text = job.FromMinutes;
            ucA.txtJob.Text = job.Jobname;
            ucA.txtPhoneNumber.Text = job.Phonenumber;
            ucA.txtStatus.Text = job.Status;
        }

        private void ajob_Done(string postID, object sender, EventArgs e)
        {
            MessageBox.Show(postID);
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Done' WHERE IDP = @PostID AND Odate = @TodayDate";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PostID", postID);
                cmd.Parameters.AddWithValue("@TodayDate", date); 
                int rowsAffected = cmd.ExecuteNonQuery();
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


        private void ajob_Confirmed(string postID, object sender, EventArgs e)
        {
            MessageBox.Show(postID);
            try
            {
                conn.Open();
                string query = "UPDATE Orders SET OStatus = 'Done' WHERE IDP = @PostID AND Odate = @TodayDate";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PostID", postID);
                cmd.Parameters.AddWithValue("@TodayDate", date);
                int rowsAffected = cmd.ExecuteNonQuery();
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


        private void ajob_Denied(ucAOrder uc, object sender, EventArgs e)
        {
            Order deniedJob = uc.Tag as Order;
            if (deniedJob != null)
            {
                // Xóa công việc từ danh sách jobs
                jobs.Remove(deniedJob);
                fPanel.Controls.Remove(uc);
            }
        }
        List<Order> GetjobByDay(DateTime date)
        {
            return jobs.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        private void dt_ValueChanged(object sender, EventArgs e)
        {
            ShowJobBydate((sender as DateTimePicker).Value);
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
