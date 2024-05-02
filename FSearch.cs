using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Media;
using TheGioiViecLam.model;
using System.Collections;

namespace TheGioiViecLam
{
    public partial class FSearch : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        UCWorkInFor uc_workinfor = new UCWorkInFor();
        public string postID;
        public string account;
        public string jobfield;
        public FSearch(string account, string jobfield)
        {
            InitializeComponent();
            this.account = account;
            this.jobfield = jobfield;
            paneFilter.Visible = false;
        }

        private void ucWorkInFor_Click(string wid, string postID, object sender, EventArgs e)
        {

            if (sender is UCWorkInFor uCWorkInFor)
            {
                FWorkdetail form = new FWorkdetail(wid, postID, account);
                form.Show();
            }
        }


        private void BtnSave_Click(string postID, object sender, EventArgs e)
        {
            string sql = string.Format("INSERT INTO Saves (IDP, CEmail) VALUES ('{0}', '{1}')", postID, account);
            db.Execute(sql);
            LoadData();
        }
        public void FHome_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            LoadUCThueFromDatabase();
            LoadCitiesIntoComboBox();
        }
        private void LoadCitiesIntoComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT DISTINCT City FROM Cities";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string city = reader["City"].ToString();
                    cbx_cities.Items.Add(city);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadDistrictsIntoComboBox()
        {
            try
            {
                cbx_districts.Items.Clear();
                conn.Open();
                string selectedCity = cbx_cities.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedCity))
                {
                    string query = "SELECT DISTINCT District FROM Cities WHERE City = @City";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@City", selectedCity);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string district = reader["District"].ToString();
                        cbx_districts.Items.Add(district);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadUCThueFromDatabase()
        {
            PanelBottom.AutoScroll = true;

            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM PostsWithAverageRating WHERE JobField = '{0}'", jobfield);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                PanelBottom.Controls.Clear();
                int y = 0;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string Time = row["WTime"].ToString();
                    string job = row["JobName"].ToString();
                    string price = row["Cost"].ToString();
                    string experience = row["Experience"].ToString();
                    string location = row["District"].ToString();
                    string postID = row["IDP"].ToString();
                    string WID = row["WID"].ToString();
                    float Rating = Convert.ToInt32(row["Rating"]);

                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(WID, postID, s, ev);

                    if (CheckIDPInSaves(postID))
                    {
                        uCWorkInFor.btnSave.FillColor = System.Drawing.Color.Gray;
                    }

                    if (uCWorkInFor.btnSave.FillColor == System.Drawing.Color.FromArgb(238, 66, 102))
                    {
                        uCWorkInFor.btnSave.Click += (s, ev) => BtnSave_Click(postID, s, ev);
                    }
                    else
                    {
                        uCWorkInFor.btnSave.Click += (s, ev) => { };
                    }
                    uCWorkInFor.txtWTime.Text = Time;
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price;
                    uCWorkInFor.txtExperience.Text = experience.ToString();
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.txtIDP.Text = postID;
                    uCWorkInFor.btnDelete.Enabled = false;
                    uCWorkInFor.btnDelete.Visible = false;
                    uCWorkInFor.ratingStar.Value = Rating;
                    uCWorkInFor.Location = new Point(50, y);
                    y += uCWorkInFor.Height + 10;
                    PanelBottom.Controls.Add(uCWorkInFor);
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

        private bool CheckIDPInSaves(string postID)
        {
            try
            {
                string sqlStr = string.Format("SELECT COUNT(*) FROM Saves WHERE IDP = '{0}'and CEmail= '{1}'", postID, account);
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
        private void cbx_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_districts.Items.Clear();
            string selectedCity = cbx_cities.SelectedItem.ToString();
            LoadDistrictsIntoComboBox();
        }
        private void cbx_districts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDistrict = cbx_districts.SelectedItem.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.Trim();
            string[] keywords = searchText.Split(' ');

            try
            {
                conn.Open();
                string query = "SELECT * FROM PostsWithAverageRating";
                if (cbx_cities.SelectedItem != null && cbx_districts.SelectedItem != null)
                {
                    query += " WHERE City = @City AND District = @District";
                }
                if (keywords.Length > 0)
                {
                    if (cbx_cities.SelectedItem != null && cbx_districts.SelectedItem != null)
                    {
                        query += " AND (";
                    }
                    else
                    {
                        query += " WHERE (";
                    }

                    for (int i = 0; i < keywords.Length; i++)
                    {
                        if (i > 0)
                            query += " OR ";

                        query += "JobName LIKE @Keyword" + i;
                    }
                    query += ")";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cbx_cities.SelectedItem != null && cbx_districts.SelectedItem != null)
                {
                    cmd.Parameters.AddWithValue("@City", cbx_cities.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@District", cbx_districts.SelectedItem?.ToString());
                }
                for (int i = 0; i < keywords.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@Keyword" + i, "%" + keywords[i] + "%");
                }
                SqlDataReader reader = cmd.ExecuteReader();
                PanelBottom.Controls.Clear();
                int y = 0;
                while (reader.Read())
                {
                    string job = reader["JobName"].ToString();
                    string price = reader["Cost"].ToString();
                    string experience = reader["Experience"].ToString();
                    string location = reader["District"].ToString();
                    string postID = reader["IDP"].ToString(); // Lấy giá trị IDP
                    string WID = reader["WID"].ToString();
                    float Rating = Convert.ToInt32(reader["Rating"]);
                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    if (CheckIDPInSaves(postID))
                    {
                        uCWorkInFor.btnSave.FillColor = System.Drawing.Color.Gray;
                    }
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(WID, postID, s, ev);
                    if (uCWorkInFor.btnSave.FillColor == System.Drawing.Color.FromArgb(238, 66, 102))
                    {
                        uCWorkInFor.btnSave.Click += (s, ev) => BtnSave_Click(postID, s, ev);
                    }
                    else
                    {
                        uCWorkInFor.btnSave.Click += (s, ev) => { };
                    }
                    uCWorkInFor.Click += (s, ev) => ucWorkInFor_Click(WID, postID, s, ev);
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price + "$";
                    uCWorkInFor.txtExperience.Text = experience.ToString();
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.btnDelete.Enabled = false;
                    uCWorkInFor.btnDelete.Visible = false;
                    uCWorkInFor.ratingStar.Value = Rating;
                    uCWorkInFor.Location = new Point(50, y);
                    y += uCWorkInFor.Height + 10;
                    PanelBottom.Controls.Add(uCWorkInFor);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void lbl_Home_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void paneFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            string values = ScrollBar.Value.ToString();
            lblValue.Text = values + "$";
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
