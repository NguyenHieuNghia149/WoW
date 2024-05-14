using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TheGioiViecLam.model;
using Guna.UI2.Designer;
using TheGioiViecLam.UserControls;
using System.Globalization;
using System.Windows.Media;
using System.Drawing.Printing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TheGioiViecLam
{
    public partial class FSalary_Worker : Form
    {
        public string account;
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        int year;
        public FSalary_Worker(string account)
        {
            this.account = account;
            InitializeComponent();

        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            year = date.Year;
            lblYear.Text = year.ToString();
            LoadMaxCostInYear(year);
            LoadTotalCost(year);
            LoadPieChart(account, year);
            LoadLineChart(year);
            LoadMaxJob(year);
        }
        private void LoadPieChart(string account, int year)
        {
            chartPost.Series["s1"].Points.Clear();
            chartPost.Titles.Clear();
            chartPost.Titles.Add("My Post");

            try
            {
                conn.Open();
                string query1 = string.Format("select count(JobName) as N from Post where Email = '{0}'  ", account);
                string query2 = string.Format("select distinct JobName from Post where Email = '{0}'", account);

                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);

                SqlDataReader reader1 = cmd1.ExecuteReader();
                SqlDataReader reader2 = cmd2.ExecuteReader();

                int n = 0;
                while (reader1.Read())
                {
                    if (reader1["N"] != DBNull.Value)
                    {
                        n = int.Parse(reader1["N"].ToString());
                    }
                }
                reader1.Close();
                if (n != 0)
                {
                    while (reader2.Read())
                    {
                        int percent = 100 / n;
                        string JobName = reader2["JobName"].ToString();
                        chartPost.Series["s1"].Points.AddXY(JobName, percent.ToString());
                    }
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
        private void LoadLineChart(int year)
        {
            cCharge.DataPoints.Clear();
            for (int i = 1; i <= 12; i++)
            {
                var date = new DateTime(year, i, 1);
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(date.Month);
                int value = SelectValue(account, i, year);
                cCharge.DataPoints.Add(monthName, value);
            }
            ChartSalary.Update();
        }
        private int SelectValue(string account, int month,int year)
        {
            int n = 0;
            try
            {
                conn.Open();
                string query = string.Format("SELECT SumSalary = dbo.fnSelectSalary('{0}','{1}','{2}')", account, month, year);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["SumSalary"] != DBNull.Value)
                    {
                        n = int.Parse(reader["SumSalary"].ToString());
                    }
                }
                ChartSalary.Update();
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
            return n;


        }
        private void LoadTotalCost(int year)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT MAX = dbo.fnSelectMaxSalary('{0}','{1}')", account, year);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    lblTotal.Text = reader["MAX"].ToString() + "$";
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
        private void LoadMaxCostInYear(int year)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT MAX(CAST(Cost AS INT)) AS Cost FROM Post INNER JOIN Orders ON Post.IDP = Orders.IDP WHERE Post.Email = '{0}' AND Orders.OStatus = 'Done' AND YEAR(Orders.ODate) = '{1}' ", account,year);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string count = reader["Cost"].ToString();
                    lblMaxCharge.Text = count + "$";
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
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            year--;
            lblYear.Text = year.ToString();
            UpdateChart(year);
            LoadTotalCost(year);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            year++;
            lblYear.Text =  year.ToString();
            UpdateChart(year);
            LoadTotalCost(year);
        }
        private void UpdateChart(int year)
        {
            LoadPieChart(account,year);
            LoadLineChart(year);
            LoadMaxJob(year);
            LoadMaxCostInYear(year);
        }
        private void LoadMaxJob(int year)
        {

            try
            {
                conn.Open();
                string query = string.Format("SELECT count(*) as n from Orders,Post where Orders.IDP = Post.IDP and Post.Email = '{0}' and Orders.OStatus = 'Done' and YEAR(Orders.ODate) = '{1}' ", account, year);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   string count = reader["n"].ToString();
                   lblMaxJob.Text = count;
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
    }
}
