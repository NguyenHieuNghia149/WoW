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
using System.IO;
using Guna.UI2.WinForms;
using Guna.Charts.WinForms;

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
        public int cost;
        public float review;
        public string status;
        public FSearch(string account, string jobfield)
        {
            InitializeComponent();
            this.account = account;
            this.jobfield = jobfield;
            paneFilter.Visible = false;
        }

        private void ucWorkInFor_Click(string wid, string postID, object sender, EventArgs e)
        {
            FWorkdetail form = new FWorkdetail(wid, postID, account);
            form.Show();
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
                string sqlStr = string.Format("SELECT * FROM PostsWithAverageRating WHERE FieldName = '{0}'", jobfield);
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
                    string location = row["Address"].ToString();
                    string postID = row["IDP"].ToString();
                    string WID = row["WID"].ToString();
                    float Rating = Convert.ToInt32(row["Rating"]);
                    byte[] b = row["img"] as byte[];

                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.panelMain.Click += (s, ev) => ucWorkInFor_Click(WID, postID, s, ev);

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
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        uCWorkInFor.picturePost.Image = Image.FromStream(ms);
                    }
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
                query += " AND Cost < @Cost";
                query += " AND Rating >= @Rating";

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
                cmd.Parameters.AddWithValue("@Cost", cost);
                cmd.Parameters.AddWithValue("@Rating", review);

                SqlDataReader reader = cmd.ExecuteReader();
                PanelBottom.Controls.Clear();
                int y = 0;
                while (reader.Read())
                {
                    string job = reader["JobName"].ToString();
                    string price = reader["Cost"].ToString();
                    string experience = reader["Experience"].ToString();
                    string location = reader["Address"].ToString();
                    string postID = reader["IDP"].ToString(); // Lấy giá trị IDP
                    string WID = reader["WID"].ToString();
                    float Rating = Convert.ToInt32(reader["Rating"]);
                    byte[] b = reader["img"] as byte[];

                    UCWorkInFor uCWorkInFor = new UCWorkInFor();
                    uCWorkInFor.panelMain.Click += (s, ev) => ucWorkInFor_Click(WID, postID, s, ev);
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
                    uCWorkInFor.txtJobName.Text = job;
                    uCWorkInFor.txtCost.Text = price + "$";
                    uCWorkInFor.txtExperience.Text = experience.ToString();
                    uCWorkInFor.txtLocation.Text = location;
                    uCWorkInFor.btnDelete.Enabled = false;
                    uCWorkInFor.btnDelete.Visible = false;
                    uCWorkInFor.ratingStar.Value = Rating;
                    if (b != null)
                    {
                        MemoryStream ms = new MemoryStream(b);
                        uCWorkInFor.picturePost.Image = Image.FromStream(ms);
                    }
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
            if (paneFilter.Visible == false)
            {
                paneFilter.Visible = true;
            }
            else
            {
                paneFilter.Visible = false;
            }
        }
        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            string values = ScrollBar.Value.ToString();
            lblValue.Text = values + "$";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string numberString = lblValue.Text.Replace("$", "").Trim();
            if (!string.IsNullOrEmpty(numberString))
            {
                if (int.TryParse(numberString, out int costValue))
                {
                    cost = costValue;
                    MessageBox.Show("done!");
                }
                else
                {
                    MessageBox.Show("Invalid cost value!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No numeric value found!");
                return;
            }

            // Gán giá trị float cho các CheckBox trong paneFilter
            cb1.Tag = 1f;
            cb2.Tag = 2f;
            cb3.Tag = 3f;
            cb4.Tag = 4f;
            cb5.Tag = 5f;

            // Khi các checkbox được chọn, gán giá trị review tương ứng
            if (cb1.Checked)
            {
                review = float.Parse(cb1.Tag.ToString());
            }
            else if (cb2.Checked)
            {
                review = float.Parse(cb2.Tag.ToString());
            }
            else if (cb3.Checked)
            {
                review = float.Parse(cb3.Tag.ToString());
            }
            else if (cb4.Checked)
            {
                review = float.Parse(cb4.Tag.ToString());
            }
            else if (cb5.Checked)
            {
                review = float.Parse(cb5.Tag.ToString());
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện CheckedChanged của các CheckBox ở đây
            if (sender is CheckBox selectedCheckBox && selectedCheckBox.Checked)
            {
                // Duyệt qua tất cả các CheckBox trên Form
                foreach (Control control in paneFilter.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != selectedCheckBox)
                    {
                        // Hủy chọn các CheckBox khác
                        checkBox.Checked = false;
                    }
                }
            }
            else if (sender is CheckBox deselectedCheckBox && !deselectedCheckBox.Checked)
            {
                // Nếu checkbox hiện tại đã được chọn trước đó và người dùng chọn lại, không làm gì cả
            }
        }

    }
}
