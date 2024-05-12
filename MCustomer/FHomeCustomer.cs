using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.DAO;
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FHomeCustomer : Form
    {
        private string account;
        private LoadDao loadDao;

        private FDisplay_Customers FDisplay_Customers;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public FHomeCustomer(string account, FDisplay_Customers fDisplay_Customers)
        {
            this.account = account;
            InitializeComponent();
            Familyandcare.AutoScroll = true;
            this.FDisplay_Customers = fDisplay_Customers;
            loadDao = new LoadDao(Properties.Settings.Default.connStr, account);
            loadDao.LoadHistoryOrder(lblJobname, lblCost, lblTime);
            loadDao.LoadFavourite(lblJobNameFavourite, lblCostFavourite, lblNameWorker);
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Repair and maintenance                                                                              ");
        }



        private void btnPost_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.OpenChildForm(new FRequirement_Jobs(account));
            FDisplay_Customers.btnPost.Checked = true;
        }

        private void panelElectrician_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Electricians                                                                                        ");
        }

        private void panelCleaning_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Cleaning service                                                                                                                                                                            ");
        }

        private void panelMechanics_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Mechanics                                                                                           ");

        }

        private void panelCarpentry_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Carpentry                                                                                           ");
        }

        private void panelPlumber_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Plumbing                                                                                            ");
        }

        private void panelStansport_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Transport                                                                                           ");
        }

        private void panelDigital_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Digital and Technology                                                                              ");
        }

        private void panelFamily_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Family and Care                                                                                     ");
        }

        private void panelFinancial_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Financial and accounting                                                                            ");
        }

        private void paneRepair_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Repair and maintenance                                                                              ");
        }

        private void panelRepair_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Repair and maintenance                                                                              ");

        }

        private void panelDifferent_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.ReplaceFHome_CustomerWithFSearch("Different                                                                              ");

        }

        private void panelHistory_Click(object sender, EventArgs e)
        {
            FDisplay_Customers.OpenChildForm(new FOrders(account));
            FDisplay_Customers.btnorders.Checked = true;
        }
    }
}
