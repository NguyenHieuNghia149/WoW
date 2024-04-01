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
                    ajob.Denied += ajob_Denied;
                    ajob.Confirmed += ajob_Confirmed;
                    ajob.Done += ajob_Done;

                    fPanel.Controls.Add(ajob);
                }
            }
        }
        private void ajob_Done(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ajob_Confirmed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ajob_Denied(object sender, EventArgs e)
        {
            ucAOrder uc = sender as ucAOrder;
            // string sql = string.Format("Update Orders set OStatus = 'DENIED' Where IDP = '{0}' and ODate = '{1}' ");
            fPanel.Controls.Remove(uc);
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
    }
}
