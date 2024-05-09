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

namespace TheGioiViecLam.UserControls
{
    public partial class ucAOrder : UserControl
    {
        private Order job;
        /* private event EventHandler denied;
         public event EventHandler Denied
         {
             add { denied += value; }
             remove { denied -= value; }
         }
         private event EventHandler confirmed;
         public event EventHandler Confirmed
         {
             add { confirmed += value; }
             remove { confirmed -= value; }
         }
         private event EventHandler done;
         public event EventHandler Done
         {
             add { done += value; }
             remove { done -= value; }
         }*/
        public bool IsConfirmed { get; private set; }
        public bool IsUnconfirmed { get; private set; }

        public ucAOrder(Order job)
        {
            InitializeComponent();
            this.job = job;
            ShowInfor();

        }

        void ShowInfor()
        {
            txtAddress.Text = job.Address;
            txtCustomer.Text = job.Customername;
            txtfromHours.Text = job.FromHours;
            txtfromMinute.Text = job.FromMinutes;
            txtJob.Text = job.Jobname;
            txtPhoneNumber.Text = job.Phonenumber;
            txtStatus.Text = job.Status;
        }

        private void btndeny_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {

        }
    }
}
