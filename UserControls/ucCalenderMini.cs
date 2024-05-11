using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGioiViecLam.UserControls
{
    public partial class ucCalenderMini : UserControl
    {
        public int SelectedRowIndex { get; private set; }
        public int SelectedColumnIndex { get; private set; }

        public event EventHandler CellClicked;

        public ucCalenderMini()
        {
            InitializeComponent();

        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            // Xác định hàng và cột của ô được bấm
            Button clickedButton = (Button)sender;
            int row = clickedButton.Location.Y / clickedButton.Height;
            int column = clickedButton.Location.X / clickedButton.Width;

            // Cập nhật SelectedRowIndex và SelectedColumnIndex
            SelectedRowIndex = row;
            SelectedColumnIndex = column;

            CellClicked?.Invoke(this, EventArgs.Empty);
            // Gọi phương thức xử lý sự kiện UcCalenderMini_CellClicked
            UcCalenderMini_CellClicked(this, EventArgs.Empty);
        }

        private void UcCalenderMini_CellClicked(object sender, EventArgs e)
        {

        }
    }

}
