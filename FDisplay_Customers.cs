using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.model;

namespace TheGioiViecLam
{
    public partial class FDisplay_Customers : Form
    {
        public string account;
        public FDisplay_Customers(string account)
        {
            InitializeComponent();
            OpenChildForm(new FHome(account));
            btnHome.Checked = true;
            this.account = account;
            lbl_username.Text = account;
        }
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn form = new FSignIn();
            form.ShowDialog();
            this.Close();
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
        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FHome(account));
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCandidateSupportCenter());
        }

        private void btn_Favorite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FFavorite(account));
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FOrders());
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FProfile_Customers(account));
        }

        private void btn_SignOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn form = new FSignIn();
            form.Show();
            this.Close();
        }

        private void btnRequire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRequirement_Jobs(account));
        }
    }
}
