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

namespace TheGioiViecLam
{
    public partial class FFavorite : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public string postID;
        public string account;
        UCWorkInFor uc;
        //private string selectedPostID;
        public FFavorite(string account)
        {
            InitializeComponent();
            //this.postID = postID; 
            this.account = account;
            /*  uc = new UCWorkInFor();
              Controls.Add(uc);
              uc.Dock = DockStyle.Fill;
              uc.AutoScroll = true;*/
            LoadDataWorkInFor();
        }

        private void FFavorite_Load(object sender, EventArgs e)
        {
            LoadDataWorkInFor();
        }

        private void LoadDataWorkInFor()
        {
            panelmain.AutoScroll= true;
            try
            {
                conn.Open();
                string sql = string.Format("select Post.IDP as IDP, Post.JobName as JobName, Post.Cost as Cost, Post.Experience as Experience,Post.WTime as Time, post.District as District, CEmail from Saves,Post where  Post.IDP = Saves.IDP and Saves.CEmail = 'Nam@gmail.com'", account);
               // string sql = string.Format("Select * from Post where Email = 'Nam@gmail.com' ");
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                panelmain.Controls.Clear();

                int y = 0;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string job = row["JobName"].ToString();
                    string price = row["Cost"].ToString();
                    string experience = row["Experience"].ToString();
                    string location = row["District"].ToString();
                    string time = row["Time"].ToString();
                    string postID = row["IDP"].ToString();
                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(postID, s, ev);

                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price;
                    uCWorkInFor.txtExperience.Text = experience;
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.txtWTime.Text = time;
                    uCWorkInFor.Location = new Point(50, y);
                    uCWorkInFor.btnSave.FillColor= Color.White;
                    y += uCWorkInFor.Height + 10;
                    panelmain.Controls.Add(uCWorkInFor);
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

        private void ucWorkInFor_Click(string postID, object sender, EventArgs e)
        {

            if (sender is UCWorkInFor uCWorkInFor)
            {
                // Tạo và hiển thị form FWorkdetail
                FWorkdetail form = new FWorkdetail(postID);
                form.Show();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FJop_Information form = new FJop_Information();
          //  form.ShowDialog();
            //this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //FJop_Information form = new FJop_Information();
           // form.ShowDialog();
            //this.Close();
        }
    }
}
