namespace TheGioiViecLam.UserControls
{
    partial class ucCalender
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCalender));
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMatrix = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSunday = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaturday = new Guna.UI2.WinForms.Guna2Button();
            this.btnFriday = new Guna.UI2.WinForms.Guna2Button();
            this.btnThursday = new Guna.UI2.WinForms.Guna2Button();
            this.btnWednesday = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuesday = new Guna.UI2.WinForms.Guna2Button();
            this.btnNexrMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreviousMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonday = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.numericNotify = new System.Windows.Forms.NumericUpDown();
            this.cboxnotify = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnblock = new Guna.UI2.WinForms.Guna2Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNotify)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnMatrix);
            this.pnMain.Controls.Add(this.pnBottom);
            this.pnMain.Location = new System.Drawing.Point(3, 83);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1319, 683);
            this.pnMain.TabIndex = 0;
            // 
            // pnMatrix
            // 
            this.pnMatrix.Location = new System.Drawing.Point(150, 117);
            this.pnMatrix.Name = "pnMatrix";
            this.pnMatrix.Size = new System.Drawing.Size(1031, 532);
            this.pnMatrix.TabIndex = 1;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnSunday);
            this.pnBottom.Controls.Add(this.btnSaturday);
            this.pnBottom.Controls.Add(this.btnFriday);
            this.pnBottom.Controls.Add(this.btnThursday);
            this.pnBottom.Controls.Add(this.btnWednesday);
            this.pnBottom.Controls.Add(this.btnTuesday);
            this.pnBottom.Controls.Add(this.btnNexrMonth);
            this.pnBottom.Controls.Add(this.btnPreviousMonth);
            this.pnBottom.Controls.Add(this.btnMonday);
            this.pnBottom.Location = new System.Drawing.Point(3, 3);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1313, 94);
            this.pnBottom.TabIndex = 0;
            // 
            // btnSunday
            // 
            this.btnSunday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSunday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSunday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSunday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSunday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSunday.ForeColor = System.Drawing.Color.White;
            this.btnSunday.Location = new System.Drawing.Point(1032, 15);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(132, 65);
            this.btnSunday.TabIndex = 15;
            this.btnSunday.Text = "Sunday";
            // 
            // btnSaturday
            // 
            this.btnSaturday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaturday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaturday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaturday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaturday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaturday.ForeColor = System.Drawing.Color.White;
            this.btnSaturday.Location = new System.Drawing.Point(884, 15);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(132, 65);
            this.btnSaturday.TabIndex = 14;
            this.btnSaturday.Text = "Saturday";
            // 
            // btnFriday
            // 
            this.btnFriday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFriday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFriday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFriday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFriday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFriday.ForeColor = System.Drawing.Color.White;
            this.btnFriday.Location = new System.Drawing.Point(737, 15);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(132, 65);
            this.btnFriday.TabIndex = 13;
            this.btnFriday.Text = "Friday";
            // 
            // btnThursday
            // 
            this.btnThursday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThursday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThursday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThursday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThursday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThursday.ForeColor = System.Drawing.Color.White;
            this.btnThursday.Location = new System.Drawing.Point(590, 15);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(132, 65);
            this.btnThursday.TabIndex = 11;
            this.btnThursday.Text = "Thursday";
            // 
            // btnWednesday
            // 
            this.btnWednesday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWednesday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWednesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWednesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWednesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWednesday.ForeColor = System.Drawing.Color.White;
            this.btnWednesday.Location = new System.Drawing.Point(442, 15);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(132, 65);
            this.btnWednesday.TabIndex = 10;
            this.btnWednesday.Text = "Wednesday";
            // 
            // btnTuesday
            // 
            this.btnTuesday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuesday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTuesday.ForeColor = System.Drawing.Color.White;
            this.btnTuesday.Location = new System.Drawing.Point(294, 15);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(132, 65);
            this.btnTuesday.TabIndex = 9;
            this.btnTuesday.Text = "Tuesday";
            // 
            // btnNexrMonth
            // 
            this.btnNexrMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNexrMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNexrMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNexrMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNexrMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNexrMonth.ForeColor = System.Drawing.Color.White;
            this.btnNexrMonth.Location = new System.Drawing.Point(1192, 15);
            this.btnNexrMonth.Name = "btnNexrMonth";
            this.btnNexrMonth.Size = new System.Drawing.Size(108, 65);
            this.btnNexrMonth.TabIndex = 8;
            this.btnNexrMonth.Text = "Next Month";
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviousMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreviousMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreviousMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviousMonth.ForeColor = System.Drawing.Color.White;
            this.btnPreviousMonth.Location = new System.Drawing.Point(13, 15);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(108, 65);
            this.btnPreviousMonth.TabIndex = 7;
            this.btnPreviousMonth.Text = "Previous Month";
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonday.ForeColor = System.Drawing.Color.White;
            this.btnMonday.Location = new System.Drawing.Point(147, 15);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(132, 65);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnblock);
            this.pnTop.Controls.Add(this.dt);
            this.pnTop.Controls.Add(this.btnToday);
            this.pnTop.Controls.Add(this.numericNotify);
            this.pnTop.Controls.Add(this.cboxnotify);
            this.pnTop.Location = new System.Drawing.Point(3, 3);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1255, 62);
            this.pnTop.TabIndex = 1;
            // 
            // numericNotify
            // 
            this.numericNotify.Enabled = false;
            this.numericNotify.Location = new System.Drawing.Point(83, 20);
            this.numericNotify.Name = "numericNotify";
            this.numericNotify.Size = new System.Drawing.Size(120, 22);
            this.numericNotify.TabIndex = 4;
            this.numericNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNotify.ValueChanged += new System.EventHandler(this.numericNotify_ValueChanged);
            // 
            // cboxnotify
            // 
            this.cboxnotify.AutoSize = true;
            this.cboxnotify.Checked = true;
            this.cboxnotify.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxnotify.CheckedState.BorderRadius = 0;
            this.cboxnotify.CheckedState.BorderThickness = 0;
            this.cboxnotify.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxnotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxnotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxnotify.Location = new System.Drawing.Point(3, 17);
            this.cboxnotify.Name = "cboxnotify";
            this.cboxnotify.Size = new System.Drawing.Size(74, 24);
            this.cboxnotify.TabIndex = 3;
            this.cboxnotify.Text = "Notify";
            this.cboxnotify.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxnotify.UncheckedState.BorderRadius = 0;
            this.cboxnotify.UncheckedState.BorderThickness = 0;
            this.cboxnotify.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxnotify.CheckedChanged += new System.EventHandler(this.cboxnotify_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnTop);
            this.guna2Panel1.Controls.Add(this.pnMain);
            this.guna2Panel1.Location = new System.Drawing.Point(10, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1325, 768);
            this.guna2Panel1.TabIndex = 2;
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 60000;
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Notify";
            this.notify.Visible = true;
            // 
            // btnblock
            // 
            this.btnblock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.btnblock.BorderRadius = 10;
            this.btnblock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnblock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnblock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnblock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnblock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(120)))));
            this.btnblock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnblock.ForeColor = System.Drawing.Color.White;
            this.btnblock.Location = new System.Drawing.Point(892, 8);
            this.btnblock.Name = "btnblock";
            this.btnblock.Size = new System.Drawing.Size(149, 36);
            this.btnblock.TabIndex = 8;
            this.btnblock.Text = "Block";
            this.btnblock.Click += new System.EventHandler(this.btnblock_Click);
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(422, 17);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(283, 22);
            this.dt.TabIndex = 7;
            this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnToday.BorderRadius = 10;
            this.btnToday.BorderThickness = 1;
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(726, 8);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(149, 36);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // ucCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucCalender";
            this.Size = new System.Drawing.Size(1344, 799);
            this.pnMain.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNotify)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        public Guna.UI2.WinForms.Guna2Panel pnMatrix;
        public Guna.UI2.WinForms.Guna2Panel pnBottom;
        private Guna.UI2.WinForms.Guna2Button btnSunday;
        private Guna.UI2.WinForms.Guna2Button btnSaturday;
        private Guna.UI2.WinForms.Guna2Button btnFriday;
        private Guna.UI2.WinForms.Guna2Button btnThursday;
        private Guna.UI2.WinForms.Guna2Button btnWednesday;
        private Guna.UI2.WinForms.Guna2Button btnTuesday;
        public Guna.UI2.WinForms.Guna2Button btnNexrMonth;
        public Guna.UI2.WinForms.Guna2Button btnPreviousMonth;
        private Guna.UI2.WinForms.Guna2Button btnMonday;
        public Guna.UI2.WinForms.Guna2Panel pnTop;
        public System.Windows.Forms.NumericUpDown numericNotify;
        public Guna.UI2.WinForms.Guna2CheckBox cboxnotify;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Timer timerNotify;
        public System.Windows.Forms.NotifyIcon notify;
        public Guna.UI2.WinForms.Guna2Button btnblock;
        public System.Windows.Forms.DateTimePicker dt;
        public Guna.UI2.WinForms.Guna2Button btnToday;
    }
}
