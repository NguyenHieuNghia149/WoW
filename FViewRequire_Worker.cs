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
using System.Data.SqlClient;
using TheGioiViecLam.UserControls;
using System.IO;
using TheGioiViecLam.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace TheGioiViecLam
{
    public partial class FViewRequire_Worker : Form
    {
        public string account;
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FlowLayoutPanel fpanel = new FlowLayoutPanel();

        public FViewRequire_Worker(string account)
        {
            this.account = account;
            InitializeComponent();
            LoadCitiesIntoComboBox();


        }

        private void LoadUCRequire_FromDatabase()
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

                int y = 0, x = 25, count = 1;

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string RequireID = row["RequireID"].ToString();
                    string Detail = row["Detail"].ToString();
                    string JobName = row["JobName"].ToString();
                    string CAddress = row["CAddress"].ToString();

                    UCHistory_Require_Customer ucHis = new UCHistory_Require_Customer(); //phải tạo UC trong vòng lặp

                    ucHis.btnViewDetail.Click += (s, ev) => UCHis_btnViewDetail_Click(RequireID, account, s, ev); //view detail
                    ucHis.txtRequireID.Visible = false;

                    ucHis.txtRequireID.Text = "0000" + RequireID;
                    ucHis.txtDetail.Text = Detail;
                    ucHis.lblJobName.Text = JobName;
                    ucHis.txtCAddress.Text = CAddress;


                    // Thêm UC vào panel                 
                    ucHis.Location = new Point(x, y);
                    x += ucHis.Width + 5;

                    if (count % 2 == 0)
                    {
                        y += ucHis.Height + 5;
                        x = 25;
                    }

                    panel_View.Controls.Add(ucHis);
                    ucHis.btnDelete.Enabled = false;
                    ucHis.btnDelete.Visible = false; //ẩn đi button Delete
                    count++;
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
            LoadUCRequire_FromDatabase();
        }

        private void UCHis_btnViewDetail_Click(string RequireID, string account, object sender, EventArgs e)
        {
            FViewRequire_Detail_Worker form = new FViewRequire_Detail_Worker(RequireID, account);
            form.ShowDialog();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.Trim();
            string[] keywords = searchText.Split(' ');

            try
            {
                conn.Open();
                string query = "SELECT * FROM Requirement";
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
                panel_View.Controls.Clear();
                int y = 0;
                while (reader.Read())
                {
                    string RequireID = reader["RequireID"].ToString();
                    string Detail = reader["Detail"].ToString();
                    string JobName = reader["JobName"].ToString();
                    string CAddress = reader["CAddress"].ToString();


                    UCHistory_Require_Customer ucHis = new UCHistory_Require_Customer(); //phải tạo UC trong vòng lặp

                    ucHis.btnViewDetail.Click += (s, ev) => UCHis_btnViewDetail_Click(RequireID, account, s, ev); //view detail
                    ucHis.txtRequireID.Visible = false;

                    ucHis.txtRequireID.Text = "0000" + RequireID;
                    ucHis.txtDetail.Text = Detail;
                    ucHis.lblJobName.Text = JobName;
                    ucHis.txtCAddress.Text = CAddress;

                    panel_View.Controls.Add(ucHis);
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
    }
}
