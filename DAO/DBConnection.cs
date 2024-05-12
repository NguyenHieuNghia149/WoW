using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Core.Entities;
using TheGioiViecLam.model;
using System.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TheGioiViecLam
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
       
        public void  Execute(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQL, conn);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("successful");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error" + ex);
            }
            finally 
            {
                conn.Close();
            }
        }

        public DataTable GetDataTable(string sql)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
            finally
            {
                conn.Close();   
            }
        }
        public List<Customer> Login(string SQL) // Kiem tra tai khoan
        {
            List<Customer> accounts = new List<Customer>();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQL, conn);
                SqlDataReader dataReder = sqlCommand.ExecuteReader();
                while (dataReder.Read())
                {
                    string ID = dataReder.GetString(1); // Giả sử ID khách hàng là cột đầu tiên trong kết quả truy vấn
                    string email = dataReder.GetString(2);
                    string password = dataReder.GetString(3);
                    string fullname = dataReder.GetString(4);
                    string gender = dataReder.GetString(5);
                    DateTime birthday = dataReder.GetDateTime(6);
                    string city = dataReder.GetString(7);
                    string district = dataReder.GetString(8);
                    string phoneNumber = dataReder.GetString(9);
                    string address = dataReder.GetString(10);

                    Image image = dataReder.IsDBNull(11) ? null : Image.FromStream(dataReder.GetStream(10));

                    accounts.Add(new Customer(ID, email, password, fullname, gender, birthday, city, district, phoneNumber, address, image));
                }
                return accounts;
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



        public List<Worker> LoginWorker(string SQL) 
        {   
            List<Worker> accounts = new List<Worker>();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(SQL, conn);
                SqlDataReader dataReder = sqlCommand.ExecuteReader();
                while (dataReder.Read())
                {
                    string ID = dataReder.GetString(1); // Giả sử ID khách hàng là cột đầu tiên trong kết quả truy vấn
                    string email = dataReder.GetString(2);
                    string password = dataReder.GetString(3);
                    string fullname = dataReder.GetString(4);
                    string gender = dataReder.GetString(5);
                    DateTime birthday = dataReder.GetDateTime(6);
                    string city = dataReder.GetString(7);
                    string district = dataReder.GetString(8);
                    string phoneNumber = dataReder.GetString(9);
                    string address = dataReder.GetString(10);
                    accounts.Add(new Worker(ID, email, password, fullname, gender, birthday, city, district, phoneNumber, address));
                }
                return accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
            finally
            {
                conn.Close();

            }
        }
        public void AddCustomer(Customer customer)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO Customer (CID, CEmail, CPassword, Fullname, Gender, CBirthday, City, District, Phonenum, CAddress, img) " +
                             "VALUES (@CID, @CEmail, @CPassword, @Fullname, @Gender, @CBirthday, @City, @District, @Phonenum, @CAddress, @img)";

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@CID", customer.ID);
                sqlCommand.Parameters.AddWithValue("@CEmail", customer.Email);
                sqlCommand.Parameters.AddWithValue("@CPassword", customer.Password);
                sqlCommand.Parameters.AddWithValue("@Fullname", customer.Fullname);
                sqlCommand.Parameters.AddWithValue("@Gender", customer.Gender);
                sqlCommand.Parameters.AddWithValue("@CBirthday", customer.Birthday);
                sqlCommand.Parameters.AddWithValue("@City", customer.City);
                sqlCommand.Parameters.AddWithValue("@District", customer.District);
                sqlCommand.Parameters.AddWithValue("@Phonenum", customer.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@CAddress", customer.Address);
                // Chuyển đổi hình ảnh thành mảng byte và thêm vào tham số
                sqlCommand.Parameters.AddWithValue("@img", ImageToByteArray(customer.Image));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Customer added successfully!");
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
        public void AddWorker(Worker worker)
{
    try
    {
        conn.Open();
        string sql = "INSERT INTO Worker (WID, WEmail, WPassword, Fullname, Gender, Birthday, City, District, Phonenum, WAddress) " +
                     "VALUES (@WID, @WEmail, @WPassword, @Fullname, @Gender, @Birthday, @City, @District, @Phonenum, @WAddress)";
        
        SqlCommand sqlCommand = new SqlCommand(sql, conn);
        sqlCommand.Parameters.AddWithValue("@WID", worker.ID);
        sqlCommand.Parameters.AddWithValue("@WEmail", worker.Email);
        sqlCommand.Parameters.AddWithValue("@WPassword", worker.Password);
        sqlCommand.Parameters.AddWithValue("@Fullname", worker.Fullname);
        sqlCommand.Parameters.AddWithValue("@Gender", worker.Gender);
        sqlCommand.Parameters.AddWithValue("@Birthday", worker.Birthday);
        sqlCommand.Parameters.AddWithValue("@City", worker.City);
        sqlCommand.Parameters.AddWithValue("@District", worker.District);
        sqlCommand.Parameters.AddWithValue("@Phonenum", worker.PhoneNumber);
        sqlCommand.Parameters.AddWithValue("@WAddress", worker.Address);

        if (sqlCommand.ExecuteNonQuery() > 0)
        {
            MessageBox.Show("Worker added successfully!");
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


        // Phương thức chuyển đổi hình ảnh thành mảng byte
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }

    }
}
