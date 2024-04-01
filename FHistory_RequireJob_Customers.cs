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

                UCHistory_Require_Customer ucHis = new UCHistory_Require_Customer();

                conn.Open();
                string query = string.Format("SELECT * FROM Requirement WHERE CEmail = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                adapter.Fill(dataSet);

                panel_His.Controls.Clear();

                int y = 0;

                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    //RequireID,CAddress,JobName,WGender,Cost
                    string RequireID = row["RequireID"].ToString();
                    string CAddress = row["CAddress"].ToString();
                    string JobName = row["JobName"].ToString();
                    string WGender = row["WGender"].ToString();
                    string Cost = row["Cost"].ToString();

                    ucHis.Click += (s, ev) => UCHis_Click(RequireID, s, ev);
                    ucHis.Click += (s, ev) => UCHis_btnDelete_Click(RequireID, s, ev);
                    ucHis.Click += (s, ev) => UCHis_btnEdit_Click(RequireID, s, ev);
                    ucHis.txtCost.Text = Cost;
                    ucHis.txtJobName.Text = JobName;
                    ucHis.txtWGender.Text = WGender;
                    ucHis.txtRequireID.Text = "0000" + RequireID;
                    ucHis.txtLocation.Text = CAddress;

                    // Thêm UC vào panel

                    ucHis.Location = new Point(50, y);
                    y += ucHis.Height + 5;

                    panel_His.Controls.Add(ucHis);
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

        public void UCHis_Click(string IDP, object sender, EventArgs e)
        {
            /*if (sender is UCHistory_Require_Customer ucHis)
            {
                string postID = uCWorkInFor.txtIDP.Text;
                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(IDP);
                form.Show();
            }*/
            MessageBox.Show("tutu t chua lam=)))");
;       }

        public void UCHis_btnDelete_Click(string IDP, object sender, EventArgs e)
        {
            /*if (sender is UCHistory_Require_Customer ucHis)
            {
                string postID = ucHis.txtRequireID.Text;
                int RequireID = Int32.Parse(ucHis.txtRequireID.Text);
                // Tạo và hiển thị form FWorkdetail
                try
                {
                    string query = string.Format("DELETE FROM Requirement WHERE CEmail = '{0}' AND RequireID = '{1}'", account, RequireID);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    db.Execute(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại " + ex);
                }
            }*/
            //MessageBox.Show("tutu t chua lam=)))");
        }

        public void UCHis_btnEdit_Click(string IDP, object sender, EventArgs e)
        {
            /*if (sender is UCHistory_Require_Customer ucHis)
            {
                string postID = uCWorkInFor.txtIDP.Text;
                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(IDP);
                form.Show();
            }*/
            MessageBox.Show("tutu t chua lam=)))");
        }

        private void panel_His_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
