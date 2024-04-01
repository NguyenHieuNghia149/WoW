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
    public partial class FSelectTime : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        private string postID;
        private string account;
        private DateTime date;
        public FSelectTime(DateTime date, string postID, string account)
        {
            this.postID = postID;
            this.account = account;
            this.date = date;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int hours = (int)numericHours.Value;
            int minutes = (int)NumericMinutes.Value;
            string sql = string.Format("insert into Orders(CEmail,IDP,ODate,FromHours,FromMinutes,OStatus) values ('{0}','{1}','{2}','{3}','{4}','{5}')", account, postID, date, hours, minutes, "Unconfirm");
            db.Execute(sql);
            this.Close();
        }
    }
}
