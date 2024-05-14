using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TheGioiViecLam.UserControls
{
    public partial class ucDayofCalender : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DateTime Date { get; private set; }
        public string account;

        public ucDayofCalender(DateTime Date, string account)
        {
            InitializeComponent();
            this.Date = Date;
            this.account = account;
            CheckIfDaySelected(Date);
        }

        private void cbBreakMorning_Click(object sender, EventArgs e)
        {
            if (cbBreakMorning.Checked)
            {
                SaveBusyOption(Date, 1);
                cbBreakAfternoon.Checked = false;
                cbBreakFullDay.Checked = false;
            }
            else
            {
                DeleteBusyOption(Date);
            }
            CheckIfDaySelected(Date);
        }

        private void cbBreakAfternoon_Click(object sender, EventArgs e)
        {
            if (cbBreakAfternoon.Checked)
            {
                SaveBusyOption(Date, 2);
                cbBreakMorning.Checked = false;
                cbBreakFullDay.Checked = false;
            }
            else
            {
                DeleteBusyOption(Date);
            }
            CheckIfDaySelected(Date);
        }

        private void cbBreakFullDay_Click(object sender, EventArgs e)
        {
            if (cbBreakFullDay.Checked)
            {
                SaveBusyOption(Date, 3);
                cbBreakMorning.Checked = false;
                cbBreakAfternoon.Checked = false;
            }
            else
            {
                DeleteBusyOption(Date);
            }
            CheckIfDaySelected(Date);
        }

        private void SaveBusyOption(DateTime date, int option)
        {
            try
            {
                conn.Open();
                string sql = @"IF EXISTS (SELECT * FROM BusyDay WHERE Date = @Date AND WEmail = @Email)
                BEGIN
                    UPDATE BusyDay SET OptionType = @Option WHERE Date = @Date AND WEmail = @Email
                END
                ELSE
                BEGIN
                    INSERT INTO BusyDay (Date, OptionType, WEmail) VALUES (@Date, @Option, @Email)
                END";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Option", option);
                command.Parameters.AddWithValue("@Email", account);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteBusyOption(DateTime date)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM BusyDay WHERE Date = @Date AND WEmail = @Email";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Email", account);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CheckIfDaySelected(DateTime date)
        {
            try
            {
                conn.Open();
                string sql = "SELECT OptionType FROM BusyDay WHERE Date = @Date AND WEmail = @Email";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Email", account);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int optionType = Convert.ToInt32(reader["OptionType"]);
                    // Dựa vào optionType, kiểm tra và tích các checkbox tương ứng
                    switch (optionType)
                    {
                        case 1:
                            cbBreakMorning.Checked = true;
                            this.BackColor = Color.FromArgb(195, 255, 147);
                            break;
                        case 2:
                            cbBreakAfternoon.Checked = true;
                            this.BackColor = Color.FromArgb(255, 175, 97);
                            break;
                        case 3:
                            cbBreakFullDay.Checked = true;
                            this.BackColor = Color.FromArgb(21, 52, 72);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    cbBreakMorning.Checked = false;
                    cbBreakAfternoon.Checked = false;
                    cbBreakFullDay.Checked = false;
                    this.BackColor = DefaultBackColor;
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
        }
    }
}