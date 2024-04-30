using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheGioiViecLam.model;

namespace TheGioiViecLam.DAO
{
   
    public class JobDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string OrderNum;
        private string account;
        private List<Order> jobs;
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public List<Order> Jobs { get => jobs; set => jobs = value; }



        public List<Order> GetData(string trangthai1, string trangthai2)
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
                    if (job.Status == trangthai1 && job.Status == trangthai2)
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

    }
  
}
