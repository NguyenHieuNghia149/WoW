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
            OpenChildForm(new FHomeCustomer(account,this));
            //OpenChildForm(new FSearch(account));
            this.account = account;
            btnhome.Checked = true;
            FHomeCustomer f = new FHomeCustomer(account,this);
            f.btnPost.Click += BtnPost_Click;
        }
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn form = new FSignIn();
            form.ShowDialog();
            this.Close();
        }
        public Form currentFormChild;
        public void OpenChildForm(Form childForm)
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
        public void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FHomeCustomer(account, this));
        }
        public void ReplaceFHome_CustomerWithFSearch()
        {
            // Tạo một instance của form FSearch
            FSearch fSearch = new FSearch(account);

            // Đặt kích thước và vị trí của form FSearch trùng với form FHomeCustomer
            fSearch.Size = currentFormChild.Size;
            fSearch.Location = currentFormChild.Location;
            currentFormChild.Close();
            // Hiển thị form FSearch
            OpenChildForm(fSearch);
            panel_Body.Controls.Add(currentFormChild);

            // Thay thế form FHomeCustomer bằng form FSearch trong panel của FDisplay_Customers
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
            OpenChildForm(new FOrders(account));
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

        private void AddForm()
        {
            FHomeCustomer f = new FHomeCustomer(account, this);
            f.btnPost.Click += BtnPost_Click;
           
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRequirement_Jobs(account));


        }

        private void FDisplay_Customers_Load(object sender, EventArgs e)
        {

        }

       
    }
}
