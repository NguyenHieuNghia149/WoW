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
        private List<List<ucDayMini>> matrix;

        public List<List<ucDayMini>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dayofWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public FSelectTime( string postID, string account)
        {
            this.postID = postID;
            this.account = account;
            InitializeComponent();
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
                    // If it is, move to the next month
                    useday = useday.AddMonths(1);
                    line = 0; // Reset the line counter

                    // Loop until the end of the next month (or until the next Sunday)
                    while (useday.DayOfWeek != DayOfWeek.Sunday)
                    {
                        collum = dayofWeek.IndexOf(useday.DayOfWeek.ToString());
                        control = matrix[line][collum];
                        control.btnday.Text = "";
                        control.btnday.FillColor = Color.LightGray; // Set color for next month's days

                        if (collum >= 6)
                        {
                            line++;
                        }
                        useday = useday.AddDays(1);
                    }
                }
            }

            // Check if the current date is the last day of the month

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
            string sql = string.Format("insert into Orders(CEmail,IDP,ODate,FromHours,FromMinutes,OStatus) values ('{0}','{1}','{2}','{3}','{4}','{5}')", account, postID, ucCalenderMini1.dt.Value, hours, minutes, "Unconfirm");
            db.Execute(sql);
            this.Close();
        }

        private void FSelectTime_Load(object sender, EventArgs e)
        {

        }
    }
}
