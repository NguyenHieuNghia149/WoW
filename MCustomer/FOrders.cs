using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            LoadOrders("Unconfirm                                                                                           ");
            btnInOrder.Checked = true;
        }

        private ucHistoryOrderCustomer CreateUCOrderFromDataRow(DataRow row)
        {
            ucHistoryOrderCustomer uc = new ucHistoryOrderCustomer();;
            uc.lblJobField.Text = row["JobField"].ToString();
            uc.lbljobname.Text =  "JobName: " +row["jobname"].ToString();
            uc.lblCost.Text = row["cost"].ToString();
            uc.lblstatus.Text = row["OStatus"].ToString();
            uc.lblHours.Text = row["FromHours"].ToString();
            uc.lblMinutes.Text = row["FromMinutes"].ToString();
            byte[] b = row["img"] as byte[];
            if (b != null)
            {
                MemoryStream ms = new MemoryStream(b);
                uc.picturebox.Image = Image.FromStream(ms);
            }

            string WID = row["WID"].ToString();
            string IDP = row["IDP"].ToString();
            string WEmail = row["WEmail"].ToString();
            switch (uc.lblstatus.Text)
            {
                case "Confirmed                                                                                           ":
                    uc.lblstatus.ForeColor = Color.FromArgb(0, 122, 204);
                    uc.btnReview.Visible = false;
                    uc.btnReview.Enabled = false;
                    uc.btnAgain.Visible = false;
                    uc.btnAgain.Enabled = false;
                    uc.btnbomb.Click += (s, ev) => btnbomb_Click(IDP, uc, ev);
                    break;
                case "Unconfirm                                                                                           ":
                    uc.lblstatus.ForeColor = Color.FromArgb(255, 201, 74);
                    uc.btnReview.Visible = false;
                    uc.btnReview.Enabled= false;
                    uc.btnAgain.Visible = false;
                    uc.btnAgain.Enabled= false;
                    uc.btnbomb.Click += (s, ev) => btnbomb_Click(IDP, uc, ev);
                    break;
                case "Deny                                                                                                ":
                    uc.lblstatus.ForeColor = Color.FromArgb(255, 32, 78);
                    uc.btnbomb.Visible = false;
                    uc.btnAgain.Click += (s, ev) => btnAgain_Click(account, IDP, WEmail, s, ev);
                    uc.btnReview.Click += (s, ev) => btnreview_Click(account, IDP,WID,uc,ev);
                    break;
                case "Done                                                                                                ":
                    uc.lblstatus.ForeColor = Color.FromArgb(255, 32, 78);
                    uc.btnbomb.Enabled = false;
                    //uc.btnAgain.Click += (s, ev) => btnagain_Click();
                    uc.btnReview.Click += (s, ev) => btnreview_Click(account, IDP,WID,uc,ev);
                    uc.btnAgain.Click += (s, ev) => btnAgain_Click(account, IDP, WEmail, s, ev);
                    break;
                default:
                    // Xử lý trạng thái khác nếu cần
                    break;
            }

            return uc;
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            LoadOrders("Unconfirm                                                                                           ");
        }

        private void btnComfirmed_Click(object sender, EventArgs e)
        {
            LoadOrders("Confirmed                                                                                           ");
        }

        private void btncompleted_Click(object sender, EventArgs e)
        {
            LoadOrders("Done                                                                                                ");
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            LoadOrders("Deny                                                                                                ");
        }

        private void LoadOrders(string status)
        {
            fPanel.AutoScroll = true;

            try
            {
                fPanel.Controls.Clear();

                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname, Post.WID as WID, Customer.PhoneNum as phonenumber," +
                    " Post.JobName as jobname,Post.Email as WEmail, Post.Cost as cost, Post.Experience as experience, Post.WTime as time,Post.JobField as JobField,Post.img as img," +
                    " Orders.IDP as IDP, OStatus, ODate, FromHours, FromMinutes, Customer.Fullname as CIDWorkerName, Customer.CID FROM Post " +
                    " INNER JOIN Orders ON Post.IDP = Orders.IDP " +
                    " INNER JOIN Customer ON Customer.CEmail = Orders.CEmail " +
                    " WHERE Orders.CEmail = '{0}' AND Orders.OStatus ='{1}'", account, status);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ucHistoryOrderCustomer uc = CreateUCOrderFromDataRow(row);

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

        public void btnbomb_Click(string IDP, ucHistoryOrderCustomer uc, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show(IDP, account);
                string query = string.Format("DELETE FROM Orders WHERE IDP = '{0}' AND CEmail = '{1}'", IDP, account);
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
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

        public void btnAgain_Click(string account, string IDP, string WEmail, object sender, EventArgs e)
        {
            FSelectTime form = new FSelectTime(IDP,account,WEmail);
            form.ShowDialog();
        }
        public void btnreview_Click(string account, string IDP, string WID, object sender, EventArgs e)
        {
            FWriteReview fWriteReview = new FWriteReview(account ,IDP, WID);
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
