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

namespace TheGioiViecLam
{
    public partial class FRequirement_Jobs : Form
    {
       
        public string account;
        public FRequirement_Jobs(string account)
        {
            InitializeComponent();
            OpenChildForm(new FPost_RequireJobs_Customers(account));
            this.account = account;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPost_RequireJobs_Customers(account));
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FHistory_RequireJob_Customers(account));
        }
    }
}
