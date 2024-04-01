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
    }
}
