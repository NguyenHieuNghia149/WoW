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
            LoadOrders("Unconfirm");
            btnInOrder.Checked = true;
        }

        private UCOrders CreateUCOrderFromDataRow(DataRow row)
        {
            UCOrders uc = new UCOrders();
            uc.txtJobName.Text = row["jobname"].ToString();
            uc.txtCost.Text = row["cost"].ToString();
            uc.txtExperience.Text = row["experience"].ToString();
            uc.txtIDP.Text = row["IDP"].ToString();
            uc.txtHours.Text = row["FromHours"].ToString();
            uc.txtMinutes.Text = row["FromMinutes"].ToString();
            uc.lbl_Status.Text = row["OStatus"].ToString();

            switch (uc.lbl_Status.Text)
            {
                case "Confirmed":
                    uc.lbl_Status.ForeColor = Color.FromArgb(0, 122, 204);
                    break;
                case "Unconfirm                                                                                           ":
                    uc.lbl_Status.ForeColor = Color.FromArgb(255, 201, 74);
                    string WID = row["WID"].ToString();
                    uc.btnBomb.Click += (s, ev) => btnBomb_Click(WID, uc, ev);
                    break;
                case "Deny":
                    uc.lbl_Status.ForeColor = Color.FromArgb(255, 32, 78);
                    break;
                case "Done                                                                                                ":
                    if (CheckReview(row["IDP"].ToString(), row["WID"].ToString()))
                    {
                        uc.btnBomb.FillColor = Color.Gray;
                    }
                    uc.lbl_Status.ForeColor = Color.FromArgb(144, 210, 109);
                    uc.btnBomb.Text = "Evaluate";
                    if (uc.btnBomb.FillColor == Color.FromArgb(94, 148, 255))
                    {
                        uc.btnBomb.Click += (s, ev) => btnEvaluate_Click(row["CID"].ToString(), row["IDP"].ToString(), row["WID"].ToString(), uc, ev);
                    }
                    else
                    {
                        uc.btnBomb.Click += (s, ev) => { }; // Gán một sự kiện trống
                    }
                    break;
                default:
                    // Xử lý trạng thái khác nếu cần
                    break;
            }

            return uc;
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            LoadOrders("Unconfirm");
        }

        private void btnComfirmed_Click(object sender, EventArgs e)
        {
            LoadOrders("Confirmed");
        }

        private void btncompleted_Click(object sender, EventArgs e)
        {
            LoadOrders("Done");
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            LoadOrders("Deny");
        }

        private void LoadOrders(string status)
        {
            fPanel.AutoScroll = true;

            try
            {
                fPanel.Controls.Clear();

                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname, Post.WID as WID, Customer.PhoneNum as phonenumber," +
                    " Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time," +
                    " Orders.IDP as IDP, OStatus, ODate, FromHours, FromMinutes, Customer.Fullname as CIDWorkerName, Customer.CID FROM Post " +
                    " INNER JOIN Orders ON Post.IDP = Orders.IDP " +
                    " INNER JOIN Customer ON Customer.CEmail = Orders.CEmail " +
                    " WHERE Orders.CEmail = '{0}' AND Orders.OStatus ='{1}'", account, status);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    UCOrders uc = CreateUCOrderFromDataRow(row);
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


        private bool CheckReview(string IDP, string WID)
        {
            try
            {
                string sqlStr = string.Format("SELECT COUNT(*) FROM Review WHERE IDP = '{0}' and WID ='{1}'", IDP, WID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        public void btnBomb_Click(string WID, object sender, EventArgs e)
        {
            try
            {
                if (sender is UCOrders uc)
                {
                    conn.Open();
                    string IDP = uc.txtIDP.Text;
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
                LoadOrders("Unconfirm");
            }
        }

        public void btnEvaluate_Click(string CID, string IDP, string WID, object sender, EventArgs e)
        {
            FWriteReview fWriteReview = new FWriteReview(CID, IDP, WID);
            fWriteReview.Show();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
