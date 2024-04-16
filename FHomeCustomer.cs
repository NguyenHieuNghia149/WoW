using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FHomeCustomer : Form
    {
        private string account;
        private FDisplay_Customers FDisplay_Customers;
        public FHomeCustomer(string account, FDisplay_Customers fDisplay_Customers)
        {
            this.account = account;
            InitializeComponent();
            paneljob.AutoScroll = true;
            this.FDisplay_Customers = fDisplay_Customers;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch();
        }

        private void btnMyPost_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.OpenChildForm(new FHistory_RequireJob_Customers(account));
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.OpenChildForm(new FPost_RequireJobs_Customers(account));
        }
    }
}
