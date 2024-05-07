using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FHomeWorker : Form
    {
        private string account;
        private FDisplay_Workers FDisplay_Workers;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FHomeWorker(string account, FDisplay_Workers fDisplay_Workers)
        {
            this.account = account;
            InitializeComponent();
            this.FDisplay_Workers = fDisplay_Workers;
            Load();
        }
      
        private void FHomeWorker_Load(object sender, EventArgs e)
        {

        }

        private void panelHistoryOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCalender_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.btnPlan.Checked = true;
            FDisplay_Workers.OpenChildForm(new FPlan_Worker(account));
        }

        private void panelSeeReview_Click(object sender, EventArgs e)
        {

        }

        private void panelStatific_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.OpenChildForm(new FSalary_Worker(account));
            FDisplay_Workers.btnStatific.Checked = true;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.OpenChildForm(new FViewPost(account));

            FDisplay_Workers.btnPost.Checked = true;
        }

        private void btnfindjob_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.OpenChildForm(new FViewRequire_Worker(account));
            FDisplay_Workers.btnSearchRequire.Checked = true;
        }

        private void panelHistoryOrder_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Load()
        {
            try
            {
                conn.Open();
                string query = string.Format("Select top 1 Orders.ODate as date, Orders.FromHours as fromhour, Orders.FromMinutes as fromminutes, Orders.OStatus as status, Customer.Fullname as CustomerName, Post.JobName as JobName, Post.Cost as cost From Orders,Post,Customer where Orders.IDP = Post.IDP and Orders.CEmail = Customer.CEmail and Post.Email = '{0}' and Orders.OStatus = 'Done' ORDER BY Orders.ODate DESC",account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblCustomerName.Text = "Customer:" + reader["CustomerName"].ToString();
                    lblCost.Text = "Cost:" + reader["Cost"].ToString();
                    lblJobName.Text = reader["JobName"].ToString();
                    lblTime.Text = "Time: " + (reader.GetDateTime(reader.GetOrdinal("date"))).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void panelRecent_Click(object sender, EventArgs e)
        {

        }
    }
}
