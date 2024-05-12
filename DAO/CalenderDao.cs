using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using TheGioiViecLam.model;

namespace TheGioiViecLam.DAO
{
    internal class CalenderDao
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private List<Order> jobs = new List<Order>();
        private string account;
        private string OrderNum;
        private string CEmail;

        public CalenderDao(string account)
        {
            this.account = account;
            GetData(); // Load dữ liệu khi khởi tạo
        }

        public int CountJobForDay(DateTime date, int startshours, int startsminutes)
        {
            return jobs.Count(job =>
                job.Date.Date == date.Date &&
                int.Parse(job.FromHours) <= startshours &&
                int.Parse(job.FromMinutes) <= startsminutes);
        }

        public int CountJobForAfter(DateTime date, int startshours, int startsminutes)
        {
            return jobs.Count(job =>
                job.Date.Date == date.Date &&
                int.Parse(job.FromHours) <= startshours &&
                int.Parse(job.FromHours) >= 12 &&
                int.Parse(job.FromMinutes) <= startsminutes);
        }

        public List<Order> GetData()
        {
            List<Order> jobs = new List<Order>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname,Orders.OrderNum as OrderNum, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Post.Email = '{0}' and Customer.CEmail = Orders.CEmail", account);
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
                    OrderNum = reader["OrderNum"].ToString();
                    CEmail = reader["CEmail"].ToString();
                    if (job.Status == "Unconfirm                                                                                           " || job.Status == "Confirmed                                                                                           ")
                    {
                        jobs.Add(job);
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
    }
}
