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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnTomorow = new Guna.UI2.WinForms.Guna2Button();
            this.btnYesterday = new Guna.UI2.WinForms.Guna2Button();
            this.pnJob = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.guna2Button1);
            this.panelTop.Controls.Add(this.dt);
            this.panelTop.Controls.Add(this.btnTomorow);
            this.panelTop.Controls.Add(this.btnYesterday);
            this.panelTop.Location = new System.Drawing.Point(126, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1051, 61);
            this.panelTop.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(615, 9);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 26);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Today";
            // 
            // dt
            // 
            this.dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt.Location = new System.Drawing.Point(235, 9);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(355, 26);
            this.dt.TabIndex = 3;
            // 
            // btnTomorow
            // 
            this.btnTomorow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTomorow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTomorow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTomorow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTomorow.FillColor = System.Drawing.Color.White;
            this.btnTomorow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTomorow.ForeColor = System.Drawing.Color.White;
            this.btnTomorow.Image = global::TheGioiViecLam.Properties.Resources.right_arrow;
            this.btnTomorow.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTomorow.Location = new System.Drawing.Point(984, 0);
            this.btnTomorow.Name = "btnTomorow";
            this.btnTomorow.Size = new System.Drawing.Size(65, 45);
            this.btnTomorow.TabIndex = 2;
            // 
            // btnYesterday
            // 
            this.btnYesterday.BackColor = System.Drawing.Color.Transparent;
            this.btnYesterday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYesterday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYesterday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYesterday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYesterday.FillColor = System.Drawing.Color.White;
            this.btnYesterday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesterday.ForeColor = System.Drawing.Color.White;
            this.btnYesterday.Image = global::TheGioiViecLam.Properties.Resources.left_arrow;
            this.btnYesterday.ImageSize = new System.Drawing.Size(40, 40);
            this.btnYesterday.Location = new System.Drawing.Point(3, 9);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(65, 45);
            this.btnYesterday.TabIndex = 1;
            // 
            // pnJob
            // 
            this.pnJob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnJob.FillColor = System.Drawing.Color.White;
            this.pnJob.Location = new System.Drawing.Point(126, 70);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(1054, 663);
            this.pnJob.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnJob);
            this.guna2Panel1.Controls.Add(this.panelTop);
            this.guna2Panel1.Location = new System.Drawing.Point(-123, -5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1177, 733);
            this.guna2Panel1.TabIndex = 7;
            // 
            // FDailyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 603);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDailyJob";
            this.Text = "FDailyJob";
            this.panelTop.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DateTimePicker dt;
        private Guna.UI2.WinForms.Guna2Button btnTomorow;
        private Guna.UI2.WinForms.Guna2Button btnYesterday;
        public Guna.UI2.WinForms.Guna2Panel pnJob;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}