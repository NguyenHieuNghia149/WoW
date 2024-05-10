namespace TheGioiViecLam
{
    partial class FSalary_Worker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.Charts.WinForms.ChartFont chartFont41 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont42 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont43 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont44 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid16 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick16 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont45 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid17 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick17 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont46 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid18 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel6 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont47 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick18 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont48 = new Guna.Charts.WinForms.ChartFont();
            this.cCharge = new Guna.Charts.WinForms.GunaLineDataset();
            this.gunaPieDataset1 = new Guna.Charts.WinForms.GunaPieDataset();
            this.lblYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxJob = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chartPost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxCharge = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ChartSalary = new Guna.Charts.WinForms.GunaChart();
            this.panelStatific = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPost)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panelStatific.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCharge
            // 
            this.cCharge.BorderColor = System.Drawing.Color.Empty;
            this.cCharge.FillColor = System.Drawing.Color.Empty;
            this.cCharge.Label = "Charge";
            this.cCharge.TargetChart = this.ChartSalary;
            // 
            // gunaPieDataset1
            // 
            this.gunaPieDataset1.Label = "Pie1";
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(105)))), ((int)(((byte)(182)))));
            this.lblYear.Location = new System.Drawing.Point(191, 14);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(201, 51);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "YEAR";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Most booked:";
            // 
            // lblMaxJob
            // 
            this.lblMaxJob.AutoSize = true;
            this.lblMaxJob.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxJob.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxJob.ForeColor = System.Drawing.Color.White;
            this.lblMaxJob.Location = new System.Drawing.Point(225, 13);
            this.lblMaxJob.Name = "lblMaxJob";
            this.lblMaxJob.Size = new System.Drawing.Size(41, 34);
            this.lblMaxJob.TabIndex = 2;
            this.lblMaxJob.Text = "0 ";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.lblMaxJob);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(633, 125);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(418, 72);
            this.guna2CustomGradientPanel2.TabIndex = 10;
            // 
            // chartPost
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPost.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPost.Legends.Add(legend6);
            this.chartPost.Location = new System.Drawing.Point(633, 215);
            this.chartPost.Name = "chartPost";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "s1";
            this.chartPost.Series.Add(series6);
            this.chartPost.Size = new System.Drawing.Size(418, 341);
            this.chartPost.TabIndex = 8;
            this.chartPost.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(105)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // lblMaxCharge
            // 
            this.lblMaxCharge.AutoSize = true;
            this.lblMaxCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxCharge.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(105)))), ((int)(((byte)(182)))));
            this.lblMaxCharge.Location = new System.Drawing.Point(154, 13);
            this.lblMaxCharge.Name = "lblMaxCharge";
            this.lblMaxCharge.Size = new System.Drawing.Size(41, 34);
            this.lblMaxCharge.TabIndex = 1;
            this.lblMaxCharge.Text = "0 ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblMaxCharge);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(105)))), ((int)(((byte)(182)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(14, 125);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(530, 72);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // ChartSalary
            // 
            this.ChartSalary.BackColor = System.Drawing.Color.Transparent;
            this.ChartSalary.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.cCharge});
            chartFont41.FontName = "Arial";
            this.ChartSalary.Legend.LabelFont = chartFont41;
            this.ChartSalary.Location = new System.Drawing.Point(14, 215);
            this.ChartSalary.Name = "ChartSalary";
            this.ChartSalary.Size = new System.Drawing.Size(530, 341);
            this.ChartSalary.TabIndex = 7;
            chartFont42.FontName = "Arial";
            chartFont42.Size = 12;
            chartFont42.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.ChartSalary.Title.Font = chartFont42;
            chartFont43.FontName = "Arial";
            this.ChartSalary.Tooltips.BodyFont = chartFont43;
            chartFont44.FontName = "Arial";
            chartFont44.Size = 9;
            chartFont44.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.ChartSalary.Tooltips.TitleFont = chartFont44;
            this.ChartSalary.XAxes.GridLines = grid16;
            chartFont45.FontName = "Arial";
            tick16.Font = chartFont45;
            this.ChartSalary.XAxes.Ticks = tick16;
            this.ChartSalary.YAxes.GridLines = grid17;
            chartFont46.FontName = "Arial";
            tick17.Font = chartFont46;
            this.ChartSalary.YAxes.Ticks = tick17;
            this.ChartSalary.ZAxes.GridLines = grid18;
            chartFont47.FontName = "Arial";
            pointLabel6.Font = chartFont47;
            this.ChartSalary.ZAxes.PointLabels = pointLabel6;
            chartFont48.FontName = "Arial";
            tick18.Font = chartFont48;
            this.ChartSalary.ZAxes.Ticks = tick18;
            // 
            // panelStatific
            // 
            this.panelStatific.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panelStatific.BorderRadius = 20;
            this.panelStatific.BorderThickness = 1;
            this.panelStatific.Controls.Add(this.chartPost);
            this.panelStatific.Controls.Add(this.ChartSalary);
            this.panelStatific.Controls.Add(this.guna2CustomGradientPanel2);
            this.panelStatific.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelStatific.Controls.Add(this.lblYear);
            this.panelStatific.Controls.Add(this.btnPrevious);
            this.panelStatific.Controls.Add(this.btnNext);
            this.panelStatific.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panelStatific.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panelStatific.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panelStatific.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panelStatific.Location = new System.Drawing.Point(12, 12);
            this.panelStatific.Name = "panelStatific";
            this.panelStatific.Size = new System.Drawing.Size(1071, 584);
            this.panelStatific.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::TheGioiViecLam.Properties.Resources.next_button__1_;
            this.btnPrevious.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPrevious.Location = new System.Drawing.Point(74, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 45);
            this.btnPrevious.TabIndex = 49;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::TheGioiViecLam.Properties.Resources.next_button;
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(422, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 45);
            this.btnNext.TabIndex = 48;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FSalary_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 629);
            this.Controls.Add(this.panelStatific);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FSalary_Worker";
            this.Text = "Nhap";
            this.Load += new System.EventHandler(this.Nhap_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPost)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panelStatific.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.Charts.WinForms.GunaLineDataset cCharge;
        private Guna.Charts.WinForms.GunaPieDataset gunaPieDataset1;
        private System.Windows.Forms.Label lblYear;
        public Guna.Charts.WinForms.GunaChart ChartSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxJob;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxCharge;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelStatific;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}