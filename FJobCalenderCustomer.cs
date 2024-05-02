﻿using System;
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

namespace TheGioiViecLam
{
    public partial class FJobCalenderCustomer : Form
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

        private string account;
        private string OrderNum;

        public FJobCalenderCustomer(string account)
        {
            this.account = account;
            InitializeComponent();
            RefreshJobs();
        }

        private void RefreshJobs()
        {
            ucCalender1.timerNotify.Start();
            appTime = 0;
            ucCalender1.btnNexrMonth.Click += btnNexrMonth_Click;
            ucCalender1.btnPreviousMonth.Click += btnPreviousMonth_Click;
            ucCalender1.btnToday.Click += btnToday_Click;
            ucCalender1.dt.ValueChanged += dt_ValueChanged;
            ucCalender1.timerNotify.Tick += TimerNotify_Tick;
            ucCalender1.cboxnotify.CheckedChanged += Cboxnotify_CheckedChanged;
            ucCalender1.numericNotify.ValueChanged += NumericNotify_ValueChanged;
            ucCalender1.btnblock.Click += Btnblock_Click;
            LoadMatrix();

            AddNumbertoMatrix(ucCalender1.dt.Value);

        }
        private void Btnblock_Click(object sender, EventArgs e)
        {

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
                int jobCountForMorning = CountJobForDay(useday, 11, 59);
                int jobCountForAfter = CountJobForAfter(useday, 18, 59);
                // Xóa màu đỏ của ngày trước đó
                if (!isEqualDate(useday, date))
                {
                    control.btnday.FillColor = Color.White;
                    control.btnday.ForeColor = Color.Black; // Đảm bảo màu chữ trở lại màu đen
                }
                if (useday.DayOfWeek == DayOfWeek.Sunday)
                {
                    control.btnday.ForeColor = Color.FromArgb(220, 107, 25); // Đổi màu chữ để dễ đọc
                }
                if (isEqualDate(useday, DateTime.Now))
                {
                    control.btnday.FillColor = Color.FromArgb(106, 212, 221);
                }
                if (isEqualDate(useday, date)) // ngay danh daus
                {
                    control.btnday.FillColor = Color.FromArgb(255, 32, 78);
                    control.btnday.ForeColor = Color.White;
                }

                if (jobCountForMorning > 0)
                {
                    control.lblbuoisang.Visible = true;
                    control.lblbuoisang.Text = "7:00 - 11:00: " + jobCountForMorning.ToString();
                    control.btnday.FillColor = Color.FromArgb(227, 254, 247);
                }
                if (jobCountForAfter > 0)
                {
                    control.lblbuoichieu.Visible = true;
                    control.lblbuoichieu.Text = "12:00 - 18:00: " + jobCountForMorning.ToString();
                    control.btnday.FillColor = Color.FromArgb(227, 254, 247);
                }

                if (collum >= 6)
                {
                    line++;
                }
                useday = useday.AddDays(1);
            }
        }

        int CountJobForDay(DateTime date, int startshours, int startsminutes)
        {
            return jobs.Count(job =>
                job.Date.Date == date.Date &&
                int.Parse(job.FromHours) <= startshours &&
                int.Parse(job.FromMinutes) <= startsminutes);
        }
        int CountJobForAfter(DateTime date, int startshours, int startsminutes)
        {
            return jobs.Count(job =>
                job.Date.Date == date.Date &&
                int.Parse(job.FromHours) <= startshours &&
                int.Parse(job.FromHours) >= 12 &&
                int.Parse(job.FromMinutes) <= startsminutes);
        }
        int GetJobCountForDate(DateTime date)
        {
            return jobs.Count(job => job.Date.Date == date.Date);
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
        private void NumericNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)ucCalender1.numericNotify.Value;
        }

        private void Cboxnotify_CheckedChanged(object sender, EventArgs e)
        {
            ucCalender1.numericNotify.Enabled = ucCalender1.cboxnotify.Checked;
        }

        private void TimerNotify_Tick(object sender, EventArgs e)
        {
            if (ucCalender1.cboxnotify.Checked) // Kiểm tra xem ô đánh dấu đã được chọn hay không
            {
                appTime++;
                if (appTime >= Cons.notifyTime)
                {
                    DateTime currentDay = DateTime.Now;
                    List<Order> todayJob = jobs.Where(p => p.Date.Date == currentDay.Date).ToList();
                    if (todayJob.Count > 0)
                    {
                        ucCalender1.notify.ShowBalloonTip(Cons.notifyTimeOut, "Lich Cong Viec", string.Format("Ban co {0} cong viec trong ngay hom nay", todayJob.Count), ToolTipIcon.Info);
                    }
                    appTime = 0;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}