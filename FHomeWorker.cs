using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FHomeWorker : Form
    {
        private string account;
        private FDisplay_Workers FDisplay_Workers;

        public FHomeWorker(string account, FDisplay_Workers fDisplay_Workers)
        {
            this.account = account;
            InitializeComponent();
            this.FDisplay_Workers = fDisplay_Workers;
        }
      
        private void FHomeWorker_Load(object sender, EventArgs e)
        {

        }

        private void panelHistoryOrder_Click(object sender, EventArgs e)
        {

        }

        private void panelCalender_Click(object sender, EventArgs e)
        {

        }

        private void panelSeeReview_Click(object sender, EventArgs e)
        {

        }

        private void panelStatific_Click(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.OpenChildForm(new FPost(account));
            FDisplay_Workers.btnPost.Enabled = true;
        }

        private void btnfindjob_Click(object sender, EventArgs e)
        {
            FDisplay_Workers.OpenChildForm(new FViewRequire_Worker(account));
            FDisplay_Workers.btnSearchRequire.Enabled = true;
        }
    }
}
