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
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FPlan_Worker : Form
    {
        private string account;
        public FPlan_Worker(string account)
        {
            this.account = account;
            InitializeComponent();
            btnCalender.Checked = true;
            LoadFormCalender(account);   
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            LoadFormCalender(account);
        }

        void LoadFormCalender(string account)
        {
            FCalenderWorker form = new FCalenderWorker(account);
            panelCalender.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelCalender.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            FCompletedJob form = new FCompletedJob(account, "Done                                                                                                ");
            panelCalender.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelCalender.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            FCompletedJob form = new FCompletedJob(account, "Deny                                                                                                ");
            panelCalender.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelCalender.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            FSeeReview form = new FSeeReview(account);
            panelCalender.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelCalender.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
    }
}
