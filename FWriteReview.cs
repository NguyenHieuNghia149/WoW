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
using TheArtOfDevHtmlRenderer.Adapters;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FWriteReview : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        private string IDP;
        private string WID;
        public FWriteReview(string IDP, string WID)
        {
            InitializeComponent();
            this.IDP = IDP;
            this.WID = WID;
            btnSend.Click += (s,ev) => btnSend_Click (IDP, WID,s,ev);
        }

        private void btnSend_Click(string IDP, string WID, object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO Review(Review, Rating, IDP, WID) VALUES ('{0}', '{1}', '{2}', '{3}')", txtdetail.Text, guna2RatingStar1.Value, IDP, WID);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công");
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


        private void FWriteReview_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM Post WHERE IDP = '{0}' AND WID = '{1}'", IDP, WID);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables[0].Rows[0];
                    string job = row["JobName"].ToString();
                    tbtJobName.Text = job;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho IDP và WID đã chỉ định.");
                }
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
