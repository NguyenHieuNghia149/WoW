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
namespace TheGioiViecLam
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void Execute(string SQL)
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
                //throw new Exception();
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
                    string email = dataReder.GetString(2);
                    string password = dataReder.GetString(3);
                    accounts.Add(new Customer(email, password));
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
                    string email = dataReder.GetString(2);
                    string password = dataReder.GetString(3);
                    accounts.Add(new Worker(email, password));
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

    }


}
