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
    public partial class FProfile_Workers : Form
    {
        public string account;
        public FProfile_Workers(string account)
        {
            InitializeComponent();
            OpenChildForm(new FPerInf_Worker(account));
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
        private void btnPerInf_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPerInf_Worker(account));
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FIncome());
        }
    }
}
