namespace TheGioiViecLam
{
    partial class FDailyJob
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnJob = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnTomorow = new Guna.UI2.WinForms.Guna2Button();
            this.btnYesterday = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnToday = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnJob
            // 
            this.pnJob.Location = new System.Drawing.Point(3, 67);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(1297, 663);
            this.pnJob.TabIndex = 1;
            this.pnJob.Paint += new System.Windows.Forms.PaintEventHandler(this.pnJob_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnJob);
            this.guna2Panel1.Controls.Add(this.panelTop);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1303, 733);
            this.guna2Panel1.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dt);
            this.panelTop.Controls.Add(this.btnTomorow);
            this.panelTop.Controls.Add(this.btnYesterday);
            this.panelTop.Location = new System.Drawing.Point(3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1297, 61);
            this.panelTop.TabIndex = 0;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(517, 9);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(355, 22);
            this.dt.TabIndex = 3;
            this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // btnTomorow
            // 
            this.btnTomorow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTomorow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTomorow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTomorow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTomorow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTomorow.ForeColor = System.Drawing.Color.White;
            this.btnTomorow.Location = new System.Drawing.Point(1095, 9);
            this.btnTomorow.Name = "btnTomorow";
            this.btnTomorow.Size = new System.Drawing.Size(184, 45);
            this.btnTomorow.TabIndex = 2;
            this.btnTomorow.Text = "tomorrow";
            this.btnTomorow.Click += new System.EventHandler(this.btnTomorow_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYesterday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYesterday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYesterday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYesterday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesterday.ForeColor = System.Drawing.Color.White;
            this.btnYesterday.Location = new System.Drawing.Point(21, 9);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(211, 45);
            this.btnYesterday.TabIndex = 1;
            this.btnYesterday.Text = "yesterday";
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnToday});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnToday
            // 
            this.mnToday.Name = "mnToday";
            this.mnToday.Size = new System.Drawing.Size(63, 24);
            this.mnToday.Text = "Today";
            this.mnToday.Click += new System.EventHandler(this.mnToday_Click);
            // 
            // FDailyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 786);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FDailyJob";
            this.Text = "FDailyJob";
            this.guna2Panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel pnJob;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.DateTimePicker dt;
        private Guna.UI2.WinForms.Guna2Button btnTomorow;
        private Guna.UI2.WinForms.Guna2Button btnYesterday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnToday;
    }
}