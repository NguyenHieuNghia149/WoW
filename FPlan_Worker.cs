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

namespace TheGioiViecLam
{
    public partial class FPlan_Worker : Form
    {
        #region Peoperties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
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
        public FPlan_Worker(string account)
        {
            this.account = account;
            InitializeComponent();
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
            jobs = GetData();
            AddNumbertoMatrix(ucCalender1.dt.Value);
        }

        private void Btnblock_Click(object sender, EventArgs e)
        {
            
        }

        void Setdefaultjob()
        {
            jobs = new List<Order>();
        }

        void LoadMatrix()
        {
            matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayofColum; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayofWeek; j++)
                {

                    Button btn = new Button() { Width = Cons.datebuttonWidth, Height = Cons.datebuttonHeight };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Cons.margin, oldbtn.Location.Y);
                    btn.Click += Btn_Click;
                    ucCalender1.pnMatrix.Controls.Add(btn);
                    matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldbtn.Location.Y + Cons.datebuttonHeight) };

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
                Button btn = matrix[line][collum];
                btn.Text = i.ToString();
                btn.TextAlign = ContentAlignment.TopLeft;

                // Xóa màu đỏ của ngày trước đó
                if (!isEqualDate(useday, date))
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black; // Đảm bảo màu chữ trở lại màu đen
                }

                if (isEqualDate(useday, DateTime.Now))
                {
                    btn.BackColor = Color.FromArgb(106, 212, 221);
                }
                if (isEqualDate(useday, date))
                {
                    btn.BackColor = Color.FromArgb(255, 32, 78);
                    btn.ForeColor = Color.White;
                }

                // Kiểm tra xem ngày có công việc không
                if (jobs.Any(job => job.Date.Date == useday.Date))
                {
                    btn.BackColor = Color.FromArgb(255, 152, 0); // Màu xanh
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
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
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


        private List<Order> GetData()
        {
            List<Order> jobs = new List<Order>();
            try
            {
                conn.Open();
                string sql = string.Format("SELECT Customer.Fullname as fullname, Customer.CEmail as CEmail, Customer.PhoneNum as phonenumber,Post.IDP as IDpost, Post.JobName as jobname, Post.Cost as cost, Post.Experience as experience, Post.WTime as time, Orders.IDP, OStatus, ODate, FromHours, FromMinutes, Post.Fullname as WorkerName,Customer.CAddress as CAddress FROM Post,Orders, Customer WHERE Post.IDP = Orders.IDP and Post.Email = '{0}' and Customer.CEmail = Orders.CEmail", account);
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
                    job.Customername = reader["fullname"].ToString();
                    job.Phonenumber = reader["phonenumber"].ToString();
                    job.Address = reader["CAddress"].ToString();
                    job.Status = reader["OStatus"].ToString();
                    jobs.Add(job);
                    postID = reader["IDP"].ToString();
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
                conn.Close();
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            FDailyJob dailyJob = new FDailyJob(new DateTime(ucCalender1.dt.Value.Year, ucCalender1.dt.Value.Month, Convert.ToInt32((sender as Button).Text)), postID, account, jobs);
            dailyJob.ShowDialog();

        }

    }
}
