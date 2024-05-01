using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TheGioiViecLam.model;
using Guna.UI2.Designer;
using TheGioiViecLam.UserControls;
using System.Globalization;

namespace TheGioiViecLam
{
    public partial class FSalary_Worker : Form
    {
        public string account;
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FSalary_Worker(string account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                var date = new DateTime(2024, i, 1);
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(date.Month);
                int value = SelectValue(account,i);
                cCharge.DataPoints.Add(monthName, value);

                /*var charts = cCharge;
                charts.DataPoints.Clear();
                charts.DataPoints.Add(monthName, value1);*/
            }
            ChartSalary.Update();
        }

        private int SelectValue(string account, int month)
        {
            int n = 0;
            try
            {
                conn.Open();
                string query = string.Format("SELECT SumSalary = dbo.fnSelectSalary('{0}','{1}')", account, month);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["SumSalary"] != DBNull.Value)
                    {
                        n = int.Parse(reader["SumSalary"].ToString());
                    }
                }
                ChartSalary.Update();
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
            return n;
        }
    }
}
