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
    public partial class UCWork_Detail : UserControl
    {
        public string acccount;
        public UCWork_Detail()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FConfirm form = new FConfirm();
            form.ShowDialog();
            form.Close();
        }
        
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FDisplay_Customers form = new FDisplay_Customers(acccount);
            form.ShowDialog();
        }

    }
}
