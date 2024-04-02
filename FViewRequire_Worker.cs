using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.UserControls;
using System.Data.SqlClient;

namespace TheGioiViecLam
{
    public partial class FViewRequire_Worker : Form
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FViewRequire_Worker(string account)
        {
            this.account = account;
            InitializeComponent();
            LoadUCRequire_FromDatabase(account);
        }

        private void LoadUCRequire_FromDatabase(string account)
        {
            panel_View.AutoScroll = true; // Tạo thanh cuộn

            try
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Requirement");
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                adapter.Fill(dataSet);

                panel_View.Controls.Clear();

                int y = 0;

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    //RequireID,CAddress,JobName,WGender,Cost
                    string RequireID = row["RequireID"].ToString();
                    string CAddress = row["CAddress"].ToString();
                    string JobName = row["JobName"].ToString();
                    string WGender = row["WGender"].ToString();
                    string Cost = row["Cost"].ToString();

                    UCView_Require_Worker ucView = new UCView_Require_Worker(); //phải tạo UC trong vòng lặp

                    //.Click += (s, ev) => UCView_Click(RequireID, s, ev); //show chi tiết công việc
                    //ucHis.btnDelete.Click += (s, ev) => UCHis_btnDelete_Click(RequireID, s, ev); //delete

                    //uCWorkInFor.btnSave.Click += (s, ev) => BtnSave_Click(postID, s, ev);

                    ucView.txtCost.Text = Cost;
                    ucView.txtJobName.Text = JobName;
                    ucView.txtWGender.Text = WGender;
                    ucView.txtRequireID.Text = "0000" + RequireID;
                    ucView.txtLocation.Text = CAddress;

                    // Thêm UC vào panel

                    ucView.Location = new Point(50, y);
                    y += ucView.Height + 5;

                    panel_View.Controls.Add(ucView);
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

        private void FViewRequire_Worker_Load(object sender, EventArgs e)
        {
            LoadUCRequire_FromDatabase(account);
        }
    }
}
