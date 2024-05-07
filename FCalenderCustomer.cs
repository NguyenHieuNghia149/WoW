using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGioiViecLam.model;
using TheGioiViecLam.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TheGioiViecLam
{
    public partial class FCalenderCustomer : Form
    {
        #region Peoperties
        Control control = new ucDayofCalender();
        private List<List<ucDayofCalender>> matrix;

        public List<List<ucDayofCalender>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }


        private int appTime;

        private List<string> dayofWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);


        public int AppTime { get => appTime; set => appTime = value; }

        // calendercs calendercs = new calendercs();
        List<Order> jobs = new List<Order>();
        private string postID;
        private string account;
        private DateTime currentDate;
        public FCalenderCustomer(string postID, string account)
        {
            InitializeComponent();
            this.postID = postID;
            this.account = account;
            ucCalender1.timerNotify.Start();
            appTime = 0;
            ucCalender1.btnNexrMonth.Click += btnNexrMonth_Click;
            ucCalender1.btnPreviousMonth.Click += btnPreviousMonth_Click;
            ucCalender1.btnToday.Click += btnToday_Click;
            ucCalender1.dt.ValueChanged += dt_ValueChanged;
          
            LoadMatrix();
            ucCalender1.btnblock.Visible = false;
            //jobs = GetData();

        }

        void Setdefaultjob()
        {
            jobs = new List<Order>();
        }

        void LoadMatrix()
        {
            matrix = new List<List<ucDayofCalender>>();
            for (int i = 0; i < Cons.DayofColum; i++)
            {

                matrix.Add(new List<ucDayofCalender>());
                for (int j = 0; j < Cons.DayofWeek; j++)
                {
                    ucDayofCalender newControl = new ucDayofCalender();
                    newControl.Location = new Point(j * (newControl.Width + Cons.margin), i * (newControl.Height + Cons.margin));
                    ucCalender1.pnMatrix.Controls.Add(newControl);
                    matrix[i].Add(newControl);
                }
            }
            SetDefaultDate();
        }
        private int DayofMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddNumbertoMatrix(DateTime date)
        {
            ClearMatrix();
            DateTime today = DateTime.Today; // Lưu trữ ngày hiện tại
            DateTime useday = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayofMonth(date); i++)
            {
                int collum = dayofWeek.IndexOf(useday.DayOfWeek.ToString());
                ucDayofCalender control = matrix[line][collum];
                control.btnday.Text = i.ToString();
                control.btnday.Click += Btn_Click;
                control.lblbuoisang.Visible = false;
                control.lblbuoichieu.Visible = false;   

                // Xóa màu đỏ của ngày trước đó
                if (!isEqualDate(useday, date))
                {
                    control.btnday.FillColor = Color.White;
                    control.btnday.ForeColor = Color.Black; // Đảm bảo màu chữ trở lại màu đen
                }
                if (useday.DayOfWeek == DayOfWeek.Sunday)
                {
                    // control.btnday.FillColor = Color.Yellow; // Đổi màu cho ngày Chủ nhật
                    control.btnday.ForeColor = Color.FromArgb(220, 107, 25); // Đổi màu chữ để dễ đọc
                }
                if (isEqualDate(useday, DateTime.Now))
                {
                    control.btnday.FillColor = Color.FromArgb(106, 212, 221);
                }
           
                if (isEqualDate(useday, date))
                {
                    control.btnday.FillColor = Color.FromArgb(255, 32, 78);
                    control.btnday.ForeColor = Color.White;
                }

                if (collum >= 6)
                {
                    line++;
                }
                useday = useday.AddDays(1);
            }
        }



        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Control control = matrix[i][j];
                    (control as ucDayofCalender).btnday.Text = "";
                    (control as ucDayofCalender).btnday.FillColor = Color.White;
                }
            }
        }
        void SetDefaultDate()
        {
            ucCalender1.dt.Value = DateTime.Now;

        }
        private void dt_ValueChanged(object sender, EventArgs e)
        {
            AddNumbertoMatrix((sender as DateTimePicker).Value);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            ucCalender1.dt.Value = ucCalender1.dt.Value.AddMonths(-1);
        }

        private void btnNexrMonth_Click(object sender, EventArgs e)
        {
            ucCalender1.dt.Value = ucCalender1.dt.Value.AddMonths(1);

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Control).Text))
                return;
            FSelectTime selectTime = new FSelectTime(new DateTime(ucCalender1.dt.Value.Year, ucCalender1.dt.Value.Month, Convert.ToInt32((sender as Control).Text)), postID, account);
            selectTime.ShowDialog();

        }


    }
}
