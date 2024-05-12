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
    public partial class FCompletedJob : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string account;
        private string status;
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        List<Order> jobs = new List<Order>();
        public FCompletedJob(string account, string status)
        {
           
            InitializeComponent();
            this.account = account;
            this.status = status;
            fPanel.Width = panelMain.Width;
            fPanel.Height = panelMain.Height;
            panelMain.Controls.Add(fPanel);
            jobs = GetData();
            LoadJob();
          
        }

        private void LoadJob()
        {
            fPanel.Controls.Clear();
            if (jobs != null)
            {
                foreach (Order job in jobs)
                {
                    ucAOrder ucJob = new ucAOrder(job);
                    ucJob.Tag = job;
                    ucJob.btndeny.Visible = false;
                    ucJob.btnConfirm.Visible = false;
                    ucJob.btnDone.Visible = false;
                    ucJob.panelMain.BackColor = Color.FromArgb(202, 244, 255);
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
                string sql = string.Format("SELECT Customer.Fullname as fullname, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Post.Email = '{0}' and Customer.CEmail = Orders.CEmail and OStatus = '{1}'", account, status);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order job = new Order();

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
                    jobs.Add(job);
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
                conn.Close();
            }
        }
    }
}
