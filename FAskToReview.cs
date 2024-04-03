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
    public partial class FAskToReview : Form
    {
        public FAskToReview()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FWriteReview form = new FWriteReview();
            //form.ShowDialog();
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
