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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private string postID;
        private string account;
        private string OrderNum;
        private string CEmail;
        private DateTime currentDate;
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
            LoadMatrix();

            AddNumbertoMatrix(ucCalender1.dt.Value);
            jobs = GetData();
        }
        private void Btnblock_Click(object sender, EventArgs e)
        {

        }
        private void Cboxnotify_CheckedChanged(object sender, EventArgs e)
        {
          //  ucCalender1.numericNotify.Enabled = ucCalender1.cboxnotify.Checked;
        }
        private void NumericNotify_ValueChanged(object sender, EventArgs e)
        {
          //  Cons.notifyTime = (int)ucCalender1.numericNotify.Value;
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
                if (jobCountForMorning > 0)
                {
                    control.lblbuoisang.Visible = true;
                    control.lblbuoisang.Text = "7:00 - 11:00: " + jobCountForMorning.ToString();
                    control.btnday.FillColor = Color.FromArgb(227, 254, 247);
                    control.btnday.ForeColor = Color.Black;
                }
                if (jobCountForAfter > 0)
                {
                    control.lblbuoichieu.Visible = true;
                    control.lblbuoichieu.Text = "12:00 - 18:00: " + jobCountForAfter.ToString();
                    control.btnday.FillColor = Color.FromArgb(227, 254, 247);
                    control.btnday.ForeColor = Color.Black;
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
        private List<Order> GetData()
        {
            List<Order> jobs = new List<Order>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname,Orders.OrderNum as OrderNum, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, Orders.OStatus, Orders.ODate, Orders.FromHours, Orders.FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Orders.CEmail = '{0}' and Customer.CEmail = Orders.CEmail", account);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {   
                    Order job = new Order();

                    // Kiểm tra xem cột có giá trị null không trước khi chuyển đổi kiểu dữ liệu
                    if (!reader.IsDBNull(reader.GetOrdinal("ODate")))
                    {
                        job.Date = reader.GetDateTime(reader.GetOrdinal("ODate"));
                    }
                    job.CEmail = reader["CEmail"].ToString();
                    job.Workername = reader["WorkerName"].ToString();
                    job.Jobname = reader["jobname"].ToString();
                    job.FromHours = reader["FromHours"].ToString();
                    job.FromMinutes = reader["FromMinutes"].ToString();
                    job.Cost = reader["cost"].ToString();
                    job.Customername = reader["WorkerName"].ToString();
                    job.Phonenumber = reader["phonenumber"].ToString();
                    job.Address = reader["CAddress"].ToString();
                    job.Status = reader["OStatus"].ToString();
                    jobs.Add(job);
                    /*                    if (job.Status == "Unconfirm                                                                                           " || job.Status == "Confirmed                                                                                           ")
                                        {
                                            jobs.Add(job); // Chỉ thêm công việc vào danh sách nếu trạng thái là "Unconfirm"
                                        }*/

                }
                reader.Close();
                return jobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối sau khi sử dụng xong
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
        private void ucCalender1_Load(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty((sender as Control).Text))
                return;

            // Kiểm tra trong danh sách xem cửa sổ đã tồn tại hay chưa
            FDailyJob existingForm = dailyJobForms.FirstOrDefault(form => form.Date == new DateTime(ucCalender1.dt.Value.Year, ucCalender1.dt.Value.Month, Convert.ToInt32((sender as Control).Text)));
            if (existingForm != null && !existingForm.IsDisposed)
            {
                existingForm.WindowState = FormWindowState.Normal; // Đưa cửa sổ đã tồn tại lên phía trước
                existingForm.Focus();
            }
            else
            {
                // Tạo một cửa sổ mới và thêm vào danh sách
                FDailyJob newForm = new FDailyJob(new DateTime(ucCalender1.dt.Value.Year, ucCalender1.dt.Value.Month, Convert.ToInt32((sender as Control).Text)), account, jobs, OrderNum,CEmail);
                newForm.FormClosed += DailyJobForm_FormClosed; // Xử lý sự kiện khi cửa sổ đóng
                newForm.ShowDialog();
                dailyJobForms.Add(newForm);
            }
        }
        private void DailyJobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDailyJob closedForm = sender as FDailyJob;
            dailyJobForms.Remove(closedForm); // Xóa cửa sổ đã đóng khỏi danh sách
        }
        private List<FDailyJob> dailyJobForms = new List<FDailyJob>();

    }
}
