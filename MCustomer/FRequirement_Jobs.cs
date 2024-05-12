using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FRequirement_Jobs : Form
    {
       
        public string account;
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FlowLayoutPanel fpanel = new FlowLayoutPanel();
        public FRequirement_Jobs(string account)
        {
            InitializeComponent();
            this.account = account;
            Load_UCHistoryRequire_FromDatabase(account);
        }
        private void Load_UCHistoryRequire_FromDatabase(string account)
        {
            panel_Body.AutoScroll = true; // Tạo thanh cuộn
            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Requirement WHERE CEmail = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                adapter.Fill(dataSet);

                panel_Body.Controls.Clear();

                int y = 0, x = 25, count = 1;

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string RequireID = row["RequireID"].ToString();
                    string Detail = row["Detail"].ToString();
                    string JobName = row["JobName"].ToString();
                    string CAddress = row["CAddress"].ToString();

                    UCHistory_Require_Customer ucHis = new UCHistory_Require_Customer(); //phải tạo UC trong vòng lặp

                    ucHis.btnDelete.Click += (s, ev) => UCHis_btnDelete_Click(RequireID, s, ev); //delete
                    ucHis.btnViewDetail.Click += (s, ev) => UCHis_btnViewDetail_Click(RequireID, s, ev); //view detail
                    ucHis.txtRequireID.Visible = false;

                    ucHis.txtRequireID.Text = "0000" + RequireID;
                    ucHis.txtDetail.Text = Detail;
                    ucHis.lblJobName.Text = JobName;
                    ucHis.txtCAddress.Text = CAddress;


                    // Thêm UC vào panel                 
                    ucHis.Location = new Point(x, y);
                    x += ucHis.Width + 5;

                    if (count % 2 == 0)
                    {
                        y += ucHis.Height + 5;
                        x = 25;
                    }

                    panel_Body.Controls.Add(ucHis);
                    count++;
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

        public void UCHis_btnDelete_Click(string RequireID, object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("DELETE FROM Requirement WHERE CEmail = '{0}' AND RequireID = {1}", account, RequireID);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
            FRequirement_Jobs_Load(sender, e);
        }
        public void UCHis_btnViewDetail_Click(string RequireID, object sender, EventArgs e)
        {
            FRequire_Detail form = new FRequire_Detail(RequireID);
            form.ShowDialog();
        }

        private void FRequirement_Jobs_Load(object sender, EventArgs e)
        {
            Load_UCHistoryRequire_FromDatabase(account);

        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            FPost_RequireJobs_Customers form = new FPost_RequireJobs_Customers(account);
            //this.Hide();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}

