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
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FOrders : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        private string account;
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        public FOrders(string account)
        {
            this.account = account;
            InitializeComponent();
            fPanel.Width = panel_Body.Width;
            fPanel.Height = panel_Body.Height;
            panel_Body.Controls.Add(fPanel);
            loadDataForUc();
        }



        void loadDataForUc()
        {
            fPanel.AutoScroll = true;

            try
            {
                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname,Post.WID as WID, Customer.PhoneNum as phonenumber," +
                    " Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time," +
                    " Orders.IDP as IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CID as CID FROM Post,Orders," +
                    " Customer WHERE Post.IDP = Orders.IDP and Orders.CEmail = '{0}' and Customer.CEmail = Orders.CEmail", account);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                fPanel.Controls.Clear();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string jobname = row["jobname"].ToString(); ;
                    string cost = row["cost"].ToString();
                    string experiece = row["experience"].ToString();
                    string time = row["time"].ToString();
                    string status = row["OStatus"].ToString();
                    string IDP = row["IDP"].ToString();
                    string hours = row["FromHours"].ToString();
                    string minutes = row["FromMinutes"].ToString();
                    string WID = row["WID"].ToString() ;
                    string CID = row["CID"].ToString();
                    // string address = row[""]
                    UCOrders uc = new UCOrders();
                    uc.txtJobName.Text = jobname;
                    uc.txtCost.Text = cost;
                    uc.txtExperience.Text = experiece;
                    uc.txtIDP.Text = IDP;
                    uc.txtHours.Text = hours;
                    uc.txtMinutes.Text = minutes;
                    uc.lbl_Status.Text = status;
                    
                    if (uc.lbl_Status.Text == "Confirmed")
                    {

                        uc.lbl_Status.ForeColor = Color.FromArgb(0, 122, 204);
                    }
                    if (uc.lbl_Status.Text == "Unconfirm                                         ")
                    {
                        uc.lbl_Status.ForeColor = Color.FromArgb(255, 201, 74);
                        uc.btnBomb.Click += (s, ev) => btnBomb_Click(WID,uc, ev);

                    }
                    if (uc.lbl_Status.Text == "Deny")
                    {
                        uc.lbl_Status.ForeColor = Color.FromArgb(255, 32, 78);

                    }
                    if (uc.lbl_Status.Text == "Done                                              ")
                    {
                        if (CheckReview(IDP, WID))
                        {
                            uc.btnBomb.FillColor = System.Drawing.Color.Gray;
                        }
                        uc.lbl_Status.ForeColor = Color.FromArgb(144, 210, 109);
                        uc.btnBomb.Text = "Evaluate";
                        if (uc.btnBomb.FillColor == System.Drawing.Color.FromArgb(94, 148, 255))
                        {
                            uc.btnBomb.Click += (s, ev) => btnEvaluate_Click(CID, IDP, WID, uc, ev);
                        }
                        else
                        {
                            uc.btnBomb.Click += (s, ev) => { }; // Gán một sự kiện trống
                        }

                    }
                    fPanel.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool CheckReview(string IDP,string WID)
        {
            try
            {
                string sqlStr = string.Format("SELECT COUNT(*) FROM Review WHERE IDP = '{0}' and WID ='{1}'", IDP,WID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
            finally
            {
            }
        }
        public void btnBomb_Click(string WID,object sender, EventArgs e)
        {
            try
            {
                if (sender is UCOrders uc)
                {

                        conn.Open();
                        string IDP = uc.txtIDP.Text; // Lấy IDP từ UC
                        string query = string.Format("DELETE FROM Orders WHERE IDP = '{0}'", IDP);
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

                loadDataForUc(); // Load lại form sau khi xóa dữ liệu

            }
        }
        public void btnEvaluate_Click(string CID, string IDP,string WID,object sender, EventArgs e)
        {
            FWriteReview fWriteReview = new FWriteReview(CID,IDP,WID);
            fWriteReview.Show();
        }
    }
}
