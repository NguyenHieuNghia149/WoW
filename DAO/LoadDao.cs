using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TheGioiViecLam.DAO
{
    internal class LoadDao
    {
        private readonly string connStr;
        private readonly string account;

        public LoadDao(string connStr, string account)
        {
            this.connStr = connStr;
            this.account = account;
        }

        public void LoadHistoryOrder(Label lblJobname, Label lblCost, Label lblTime)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT TOP 1 Post.JobName as jobname, Post.Cost as cost, Orders.ODate as date, Orders.OStatus as status FROM Orders INNER JOIN Post ON Orders.IDP = Post.IDP WHERE CEmail = '{account}' ORDER BY ODate DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblJobname.Text = reader["jobname"].ToString();
                        lblCost.Text = "Cost: " + reader["cost"].ToString();
                        lblTime.Text = "Time: " + reader.GetDateTime(reader.GetOrdinal("date")).ToString();
                    }
                    reader.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        public void LoadFavourite(Label lblJobNameFavourite, Label lblCostFavourite, Label lblNameWorker)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT TOP 1 Post.JobName as jobname, Post.Cost as cost, PoSt.Fullname as fullname FROM Saves INNER JOIN Post ON Saves.IDP = Post.IDP WHERE CEmail = '{account}'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblJobNameFavourite.Text = reader["jobname"].ToString();
                        lblCostFavourite.Text = "Cost: " + reader["cost"].ToString();
                        lblNameWorker.Text = "Worker name: " + reader["fullname"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

    }
}
