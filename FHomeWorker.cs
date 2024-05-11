using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;
namespace TheGioiViecLam
{
    public partial class FHomeWorker : Form
    {
        private string account;
        private FDisplay_Workers FDisplay_Workers;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        int month, year;
        public FHomeWorker(string account, FDisplay_Workers fDisplay_Workers)
        {
            this.account = account;
            InitializeComponent();
            this.FDisplay_Workers = fDisplay_Workers;
            Load();
            ReloadProgressBars(month, year);
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

            DateTime date = DateTime.Now;
            month = date.Month;
            year = date.Year;
            
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month-1];
            lblDate.Text = monthname + " " + year;

        }

        private void panelRecent_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lblDate.Text = monthname + " " + year;
            ReloadProgressBars(month, year);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lblDate.Text = monthname + " " + year;
            ReloadProgressBars(month, year);
        }

        private void ReloadProgressBars(int month, int year)
        {
            LoadStatitic(new List<Guna2VProgressBar> { pbMonday }, 2, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbTuesday }, 3, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbWednesday }, 4, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbThusday }, 5, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbFriday }, 6, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbSaturday }, 7, month, year);
            LoadStatitic(new List<Guna2VProgressBar> { pbSunday }, 1, month, year);
        }

        private void LoadStatitic(List<Guna2VProgressBar> progressBarList, int day, int months, int years)
        {
            try
            {
                conn.Open();
                foreach (var progressBar in progressBarList)
                {
                    progressBar.Value = 0;
                }
                    string query = string.Format("    SELECT   DATEPART(dw, Orders.ODate) AS DayOfWeek,    COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Orders, Post WHERE Orders.IDP = Post.IDP AND Post.Email = '{0}' AND (Orders.OStatus = 'Done') AND MONTH(Orders.ODate) = '{1}' AND YEAR(Orders.ODate) = '{2}') AS Percentage FROM    Orders, Post WHERE     Orders.IDP = Post.IDP     AND Post.Email = '{0}'    AND (Orders.OStatus = 'Done')   AND MONTH(Orders.ODate) = '{1}'   AND YEAR(Orders.ODate) = '{2}' GROUP BY   DATEPART(dw, Orders.ODate)", account, months, years);
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int dayOfWeek = Convert.ToInt32(reader["DayOfWeek"]);
                        double percentage = Convert.ToDouble(reader["Percentage"]);

                        if (dayOfWeek == day)
                        {
                         
                            foreach (var progressBar in progressBarList)
                            {
                                progressBar.Value = (int)percentage;
                                if (percentage <= 20)
                                {
                                    progressBar.ProgressColor = Color.FromArgb(243, 208, 215);
                                    progressBar.ProgressColor2 = Color.FromArgb(255, 230, 230);
                                }
                                else if (percentage > 20 && percentage < 50)
                                {
                                    progressBar.ProgressColor = Color.FromArgb(225, 175, 209);
                                    progressBar.ProgressColor2 = Color.FromArgb(225, 175, 209);
                                }
                                else if(percentage == 100)
                                {
                                    progressBar.ProgressColor = Color.FromArgb(116, 105, 182);
                                    progressBar.ProgressColor2 = Color.FromArgb(116, 105, 182);
                                }
                                else
                                {
                                    progressBar.ProgressColor = Color.FromArgb(116, 105, 182);
                                    progressBar.ProgressColor2 = Color.FromArgb(173, 136, 198);
                                }
                            }
                        }
                    }
                    reader.Close();
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



    }
}
