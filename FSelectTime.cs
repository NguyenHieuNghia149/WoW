using Guna.UI2.WinForms;
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

namespace TheGioiViecLam
{
    public partial class FSelectTime : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        private string postID;
        private string account;
        private string WEmail;
        private List<List<ucDayMini>> matrix;
        private int SelectedRowIndex { get; set; }
        private int SelectedColumnIndex { get; set; }
        public List<List<ucDayMini>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dayofWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public FSelectTime( string postID, string account, string wEmail)
        {
            this.postID = postID;
            this.account = account;
            this.WEmail = wEmail;
            InitializeComponent();
            ucCalenderMini1.Click += UcCalenderMini_CellClicked;
            LoadMatrix();
            ucCalenderMini1.dt.ValueChanged += dt_ValueChanged;
            ucCalenderMini1.btnNext.Click += BtnNext_Click;
            ucCalenderMini1.btnPrevious.Click += BtnPrevious_Click;
            ucCalenderMini1.btnToday.Click += BtnToday_Click;
            AddNumbertoMatrix(ucCalenderMini1.dt.Value);

            // Add click event handler to each button
            foreach (var row in matrix)
            {
                foreach (var button in row)
                {
                    button.btnday.Click += btnday_Click;
                }
            }
        }
        private void UcCalenderMini_CellClicked(object sender, EventArgs e)
        {
            // Chúng ta cần xác định ô ngày đã được bấm
            ucCalenderMini clickedCalendar = (ucCalenderMini)sender;

            // Cập nhật SelectedRowIndex và SelectedColumnIndex của ucCalenderMini
            SelectedRowIndex = clickedCalendar.SelectedRowIndex;
            SelectedColumnIndex = clickedCalendar.SelectedColumnIndex;

            // Sau đó bạn có thể sử dụng hoặc cập nhật SelectedRowIndex và SelectedColumnIndex theo nhu cầu của bạn.
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ucCalenderMini1.dt.Value = ucCalenderMini1.dt.Value.AddMonths(-1);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ucCalenderMini1.dt.Value = ucCalenderMini1.dt.Value.AddMonths(+1);
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            AddNumbertoMatrix((sender as DateTimePicker).Value);
        }

        void LoadMatrix()
        {
            matrix = new List<List<ucDayMini>>();
            for (int i = 0; i < Cons.DayofColum; i++)
            {
                matrix.Add(new List<ucDayMini>());
                for (int j = 0; j < Cons.DayofWeek; j++)
                {
                    ucDayMini newControl = new ucDayMini();
                    newControl.Location = new Point(j * (newControl.Width + Cons.marginMini), i * (newControl.Height + Cons.marginMini));
                    ucCalenderMini1.panelMain.Controls.Add(newControl);
                    matrix[i].Add(newControl);
                }
            }
            SetDefaultDate();
        }

        void SetDefaultDate()
        {
            ucCalenderMini1.dt.Value = DateTime.Now;
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
            DateTime today = DateTime.Today;
            DateTime useday = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayofMonth(date); i++)
            {
                int collum = dayofWeek.IndexOf(useday.DayOfWeek.ToString());
                ucDayMini control = matrix[line][collum];
                control.btnday.Text = i.ToString();
                control.btnday.Tag = i;

                // Kiểm tra trong cơ sở dữ liệu xem có bản ghi tương ứng với ngày hiện tại không
                if (IsDateBusy(useday))
                {
                    // Nếu có, đổi màu sắc của ô ngày dựa trên OptionType
                    int option = GetOptionTypeForDate(useday);
                    switch (option)
                    {
                        case 1:
                            control.btnday.FillColor = Color.FromArgb(195, 255, 147); 
                            break;
                        case 2:
                            control.btnday.FillColor = Color.FromArgb(255, 175, 97);
                            break;
                        case 3:
                            control.btnday.FillColor = Color.FromArgb(21, 52, 72);
                            break;
                        default:

                            break;
                    }
                }
                if (useday == today)
                {
                    control.btnday.FillColor = Color.FromArgb(205, 232, 229);
                }
                if (collum >= 6)
                {
                    line++;
                }
                useday = useday.AddDays(1);

                if (useday.Day == DayofMonth(useday))
                {
                    // Nếu là ngày cuối cùng của tháng, kiểm tra và thêm các ô ngày cho tháng tiếp theo
                    AddNextMonthDays(ref useday, ref line);
                }
            }
        }
        bool IsDateBusy(DateTime date)
        {
            bool result = false;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM BusyDay WHERE Date = @Date AND WEmail = @Email";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Email", WEmail);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    result = true; // Có bản ghi tương ứng với ngày và email trong cơ sở dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }


        // Lấy OptionType cho ngày từ cơ sở dữ liệu
        int GetOptionTypeForDate(DateTime date)
        {
            int option = 0;
            try
            {
                conn.Open();
                string sql = "SELECT OptionType FROM BusyDay WHERE Date = @Date";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Date", date);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    option = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return option;
        }

        // Thêm các ô ngày cho tháng tiếp theo nếu ngày hiện tại là ngày cuối cùng của tháng
        void AddNextMonthDays(ref DateTime useday, ref int line)
        {
            useday = useday.AddMonths(1); // Chuyển sang tháng tiếp theo
            line = 0; // Đặt lại số dòng về 0

            // Lặp qua đến khi gặp ngày Chủ Nhật hoặc hết tháng
            while (useday.DayOfWeek != DayOfWeek.Sunday)
            {
                int collum = dayofWeek.IndexOf(useday.DayOfWeek.ToString());
                ucDayMini control = matrix[line][collum];
                control.btnday.Text = "";
                control.btnday.FillColor = Color.LightGray; // Thiết lập màu xám cho các ô ngày của tháng sau

                if (collum >= 6)
                {
                    line++;
                }
                useday = useday.AddDays(1); // Chuyển sang ngày tiếp theo
            }
        }


        private void btnday_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            int selectedDay = Convert.ToInt32(clickedButton.Text);

            ucCalenderMini1.dt.Value = new DateTime(ucCalenderMini1.dt.Value.Year, ucCalenderMini1.dt.Value.Month, selectedDay);

            clickedButton.FillColor = Color.FromArgb(116, 105, 182);
            clickedButton.ForeColor = Color.FromArgb(255, 230, 230);
        }

        void ClearMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Control control = matrix[i][j];
                    (control as ucDayMini).btnday.Text = "";
                    (control as ucDayMini).btnday.FillColor = Color.White;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int hours = (int)numericHours.Value;
            int minutes = (int)NumericMinutes.Value;
            DateTime selectedDate = ucCalenderMini1.dt.Value;

            // Thực hiện truy vấn để lấy OptionType từ cơ sở dữ liệu
            int option = GetOptionTypeForDate(selectedDate);

            // Kiểm tra OptionType và thực hiện xử lý tương ứng
            switch (option)
            {
                case 1:
                    if (hours >= 7 && hours <= 11)
                    {
                        MessageBox.Show("Không thể chọn từ 7h đến 11h vì đang có lịch hẹn.", "Thông báo");
                        return;
                    }
                    break;
                case 2:
                    if (hours >= 13 && hours <= 19)
                    {
                        MessageBox.Show("Không thể chọn từ 13h đến 19h vì đang có lịch hẹn.", "Thông báo");
                        return;
                    }
                    break;
                case 3:
                    MessageBox.Show("Không thể chọn vào ngày này vì đã bị khóa.", "Thông báo");
                    return;
                default:
                    break;
            }

            // Kiểm tra các giờ không được chọn mặc định
            if (hours < 7 || (hours >= 11 && hours < 13) || hours >= 19)
            {
                MessageBox.Show("Không thể chọn vào khung giờ này.", "Thông báo");
                return;
            }

            // Thực hiện lưu thông tin đặt lịch vào cơ sở dữ liệu
            try
            {
                conn.Open();
                string sql = "INSERT INTO Orders (CEmail, IDP, ODate, FromHours, FromMinutes, OStatus) VALUES (@CEmail, @IDP, @ODate, @FromHours, @FromMinutes, @OStatus)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@CEmail", account);
                command.Parameters.AddWithValue("@IDP", postID);
                command.Parameters.AddWithValue("@ODate", selectedDate);
                command.Parameters.AddWithValue("@FromHours", hours);
                command.Parameters.AddWithValue("@FromMinutes", minutes);
                command.Parameters.AddWithValue("@OStatus", "Unconfirm");
                command.ExecuteNonQuery();

                // Thông báo thành công
                MessageBox.Show("Đặt lịch thành công.", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Đóng form
            this.Close();
        }

        private void FSelectTime_Load(object sender, EventArgs e)
        {

        }
    }
}
