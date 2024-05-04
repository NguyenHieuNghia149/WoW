using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FWriteReview : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string account;
        private string IDP;
        private string WID;
        ImageDao imageDao = new ImageDao();

        public FWriteReview(string account ,string IDP, string WID)
        {
            InitializeComponent();
            this.IDP = IDP;
            this.WID = WID;
            this.account = account;
            btnSend.Click += (s,ev) => btnSend_Click (account, IDP, WID,s,ev);
        }

        private void btnSend_Click(string account, string IDP, string WID, object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                byte[] b = imageDao.imageToByteArray(pictureboxPost.Image);
                string sqlStr = string.Format("INSERT INTO Review(Review, Rating, IDP, WID, CEmail,Img) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}',@img)", txtdetail.Text, guna2RatingStar1.Value, IDP, WID,account);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.Add("@img", SqlDbType.VarBinary, -1).Value = b;
                cmd.ExecuteNonQuery();
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
                    byte[] b = row["img"] as byte[];
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        ptReview.Image = Image.FromStream(ms);
                    }
                    txtJobName.Text = job;
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

       

        private void pictureboxPost_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureboxPost.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
    }
}
