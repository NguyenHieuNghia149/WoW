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

namespace TheGioiViecLam
{
    public partial class FPost_RequireJobs_Customers : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FPost_RequireJobs_Customers()
        {
            InitializeComponent();
        }
        public FPost_RequireJobs_Customers(string account)
        {
            this.account = account;
            InitializeComponent();
            LoadJobNameIntoComboBox(account);
            LoadRequireID();
        }

        private void LoadJobNameIntoComboBox(string account)
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT JobName FROM Job");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string District = reader["JobName"].ToString();
                    //cbbJobName.Items.Add(District);
                }

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
        }
        private void LoadRequireID()
        {
            try
            {
                conn.Open();
                string query = string.Format("SELECT MAX(RequireID)+1 AS MAX FROM Requirement");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string RequireID = reader["MAX"].ToString();
                    txtRequireID.Text = RequireID;
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            txtRequireID.Visible = false; //ẩn đi ID
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
          /*  if (cbboxJobName.Text == "" || txtDetail.Text == "")
            {
                MessageBox.Show("You haven't fill enough information");
            }
            else
            {
                try
                {
                    int RequireID = int.Parse(txtRequireID.Text);
                    string query = string.Format("EXEC pd_Requirement_Insert '{0}','{1}','{2}','{3}'",
                    RequireID, account, cbboxJobName.Text, txtDetail.Text);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    db.Execute(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại " + ex);
                }

            }*/
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtDetail.Text = "";
           // cbboxJobName.Text = "";
        }
    }
}
