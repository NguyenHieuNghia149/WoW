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
using System.Net;
using TheGioiViecLam.model;

namespace TheGioiViecLam.UserControls
{
    public partial class UCHistory_Require_Customer : UserControl
    {
        DBConnection db = new DBConnection();
        public string account;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public UCHistory_Require_Customer()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int RequireID = Int32.Parse(txtRequireID.Text);

                string query = string.Format("DELETE FROM Requirement WHERE CEmail = '{0}' AND RequireID = '{1}'",account, RequireID);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //@RequireID,@CEmail,@JobName,@CAddress,@WGender,@Cost

                int RequireID = Int32.Parse(txtRequireID.Text);

                string query = string.Format("EXEC pd_Requirement_Update {0},'{1}','{2}','{3}','{4}','{5}'",
                    RequireID, account,txtJobName.Text,txtLocation.Text, txtWGender.Text,txtCost.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                db.Execute(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại " + ex);
            }
        }
    }
}
