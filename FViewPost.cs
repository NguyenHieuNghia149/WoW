using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using TheGioiViecLam.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;
using TheGioiViecLam.DAO;
using System.IO;

namespace TheGioiViecLam
{
    public partial class FViewPost : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        ImageDao imageDao = new ImageDao();
        public FViewPost(string account)
        {
            InitializeComponent();
            this.account = account;
        }
        private void Load_UCWorkInFor_FromDatabase(string account)
        { 
            panelBody.AutoScroll = true;
            try
            {
                UCWorkInFor uCPosted = new UCWorkInFor();

                conn.Open();
                string query = string.Format("SELECT * FROM Post WHERE Email = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                panelBody.Controls.Clear();
                int y = 0;

                while (reader.Read())
                {
                    string JobName = reader["JobName"].ToString();
                    string WTime = reader["WTime"].ToString();
                    string Cost = reader["Cost"].ToString();
                    string District = reader["District"].ToString();
                    string Experience = reader["Experience"].ToString();
                    string IDP = reader["IDP"].ToString();
                    string WID = reader["WID"].ToString();
                    byte[] b = reader["img"] as byte[];

                    UCWorkInFor ucWorkInFor = new UCWorkInFor();
                    ucWorkInFor.btnDelete.Click += (s, ev) => btnDelete_Click(IDP, s, ev);

                    ucWorkInFor.txtJobName.Text = JobName;
                    ucWorkInFor.txtWTime.Text = WTime;
                    ucWorkInFor.txtCost.Text = Cost;
                    ucWorkInFor.txtLocation.Text = District;
                    ucWorkInFor.txtExperience.Text = Experience;
                    ucWorkInFor.txtIDP.Text = IDP;
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        ucWorkInFor.picturePost.Image = Image.FromStream(ms);
                    }

                    ucWorkInFor.Location = new Point(20, y);
                    y += ucWorkInFor.Height + 5;

                    panelBody.Controls.Add(ucWorkInFor);
                }

                reader.Close();
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
        private void btnDelete_Click(string IDP, object sender, EventArgs e)
        {
            string query = string.Format("DELETE FROM Post WHERE IDP = {0}", IDP);
            db.Execute(query);
            FViewPost_Load(sender, e);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            FPost f = new FPost(account);
            f.Show();
        }

        private void FViewPost_Load(object sender, EventArgs e)
        {
            Load_UCWorkInFor_FromDatabase(account);
        }
    }
}
