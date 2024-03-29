using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    public partial class FDisplay_Workers : Form
    {
        public string account;
        public FDisplay_Workers(string account)
        {
            InitializeComponent();
            OpenChildForm(new FProfile_Workers(account));
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

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FProfile_Workers(account));
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPost(account));
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPlan_Worker());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FSignInforWorkers form = new FSignInforWorkers();
            form.Show();
            this.Close();
        }
    }
}
