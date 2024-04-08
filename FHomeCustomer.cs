using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.UserControls;

namespace TheGioiViecLam
{
    public partial class FHomeCustomer : Form
    {
        private string account;
      
        public FHomeCustomer(string account)
        {
            this.account = account;
         //   FDisplay_Customers f = new FDisplay_Customers(account);
            InitializeComponent();
            paneljob.AutoScroll = true;
        }
       
        private void AddForm(Form form)
        {
            FDisplay_Customers f = new FDisplay_Customers(account);
            f.panel_Body.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            f.panel_Body.Container.Add(form);
        }
   
        private void btn_Click(object sender, EventArgs e)
        {
            /*FDisplay_Customers f = new FDisplay_Customers(account);
          
            FSearch form = new FSearch(account);

            AddForm( form);*/

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
