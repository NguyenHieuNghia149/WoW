using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TheGioiViecLam.model;
using System.Windows;

namespace TheGioiViecLam.DAO
{
    public class OrderDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<Order> jobs = new List<Order>();

        public List<Order> GetData(string account, string OrderNum, string CEmail)
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
                conn.Close(); 
            }
        }
    }
}
