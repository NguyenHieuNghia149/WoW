using System;
using System.Collections;
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
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FSeeReview : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string account;
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public FSeeReview(string account)
        {
            this.account = account;
            InitializeComponent();
            fPanel.Width = panelMain.Width;
            fPanel.Height = panelMain.Height;
            panelMain.Controls.Add(fPanel);
            fPanel.AutoScroll = true;
            load();
        }

        void load()
        {
            try
            {
                fPanel.Controls.Clear();
                conn.Open();
                string query = string.Format("SELECT Review.CEmail as CEmail, Review.Img as img, Review.Rating as rating, Review.Review as review, Post.JobName as Jobname, Customer.Fullname as Fullname FROM Review,Post,Customer where Review.WID = Post.WID and Review.CEmail = Customer.CEmail and Post.Email = '{0}'", account);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    UCreview uc = new UCreview();
                    uc.lblaccount.Text = reader["Fullname"].ToString();
                    uc.txtReview.Text = reader["review"].ToString();
                    uc.RatingStar.Value = Convert.ToInt32(reader["rating"]);
                    byte[] b = reader["img"] as byte[];
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        uc.pictureBox.Image = Image.FromStream(ms);
                    }
                    fPanel.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }
    }
}
