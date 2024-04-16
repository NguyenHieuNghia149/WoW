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
    public partial class FHistory_RequireJob_Customers : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FlowLayoutPanel fpanel = new FlowLayoutPanel();
        public FHistory_RequireJob_Customers(string account)
        {
            this.account = account;
            InitializeComponent();
        }
        /* public FHistory_RequireJob_Customers(string account)
         {
             this.account = account;
             InitializeComponent();
             Load_UCHistoryRequire_FromDatabase(account);
         }*/

        private void FHistory_RequireJob_Customers_Load(object sender, EventArgs e)
        {
            Load_UCHistoryRequire_FromDatabase(account);
        }

        private void Load_UCHistoryRequire_FromDatabase(string account)
        {
            panel_His.AutoScroll = true; // Tạo thanh cuộn

            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Requirement WHERE CEmail = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                adapter.Fill(dataSet);

                panel_His.Controls.Clear();

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

                    panel_His.Controls.Add(ucHis);
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
            FHistory_RequireJob_Customers_Load(sender, e);
        }
        public void UCHis_btnViewDetail_Click(string RequireID, object sender, EventArgs e)
        {

            UCHistory_Require_Customer ucHis = new UCHistory_Require_Customer();
            FRequire_Detail form = new FRequire_Detail(RequireID);
            form.ShowDialog();
        }
    }
}
