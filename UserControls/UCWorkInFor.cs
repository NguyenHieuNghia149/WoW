using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam
{
    
    public partial class UCWorkInFor : UserControl
    {
        public string account;
        public UCWorkInFor()
        {
            InitializeComponent();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            FPost fPost = new FPost(account);
            fPost.cbboxJobName.Text = txtJobName.Text;
            fPost.cbboxWTime.Text = txtWTime.Text;
            fPost.txtCost.Text = txtCost.Text;
            //fPost.txtDetail.Text = 
            //fPost.txtPhoneNum.Text = 
            //fPost.txtCity.Text = 
            //fPost.txtDistrict.Text =
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FPost fPost = new FPost(account);
            fPost.cbboxJobName.Text = txtJobName.Text;
            fPost.cbboxWTime.Text = txtWTime.Text;
            fPost.txtCost.Text = txtCost.Text;
            //fPost.txtDetail.Text = 
            //fPost.txtPhoneNum.Text = 
            //fPost.txtCity.Text = 
            //fPost.txtDistrict.Text =
        }
    }
}
