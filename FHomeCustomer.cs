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
            Familyandcare.AutoScroll = true;
            this.FDisplay_Customers = fDisplay_Customers;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.OpenChildForm(new FPost_RequireJobs_Customers(account));
        }
        private void Repairandmaintenance_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00002             ");
        } 
        private void Electricians_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00003             ");
        }
        private void Cleaningservice_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00001             ");
        }
        private void Mechanics_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00004             ");
        }
        private void Carpentry_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00005             ");
        }
        private void Plumbing_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00006             ");
        }
        private void Transport_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00007             ");
        }
        private void Digitalandtechnology_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00008             ");
        }
        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF00009             ");
        }
        private void financialandaccounting_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("JF000010            ");
        }
    }
}
                                           