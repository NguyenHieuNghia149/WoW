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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartSalary = new Guna.Charts.WinForms.GunaChart();
            this.cCharge = new Guna.Charts.WinForms.GunaLineDataset();
            this.gunaPieDataset1 = new Guna.Charts.WinForms.GunaPieDataset();
            this.chartPost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblMaxCharge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblMaxJob = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPost)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartSalary
            // 
            this.ChartSalary.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.cCharge});
            chartFont1.FontName = "Arial";
            this.ChartSalary.Legend.LabelFont = chartFont1;
            this.ChartSalary.Location = new System.Drawing.Point(2, 150);
            this.ChartSalary.Name = "ChartSalary";
            this.ChartSalary.Size = new System.Drawing.Size(517, 341);
            this.ChartSalary.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.ChartSalary.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.ChartSalary.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.ChartSalary.Tooltips.TitleFont = chartFont4;
            this.ChartSalary.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.ChartSalary.XAxes.Ticks = tick1;
            this.ChartSalary.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.ChartSalary.YAxes.Ticks = tick2;
            this.ChartSalary.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.ChartSalary.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.ChartSalary.ZAxes.Ticks = tick3;
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
            // chartPost
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPost.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPost.Legends.Add(legend1);
            this.chartPost.Location = new System.Drawing.Point(537, 161);
            this.chartPost.Name = "chartPost";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartPost.Series.Add(series1);
            this.chartPost.Size = new System.Drawing.Size(418, 315);
            this.chartPost.TabIndex = 4;
            this.chartPost.Text = "chart1";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lblMaxCharge);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(56, 23);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(402, 121);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            // 
            // lblMaxCharge
            // 
            this.lblMaxCharge.AutoSize = true;
            this.lblMaxCharge.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxCharge.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharge.ForeColor = System.Drawing.Color.White;
            this.lblMaxCharge.Location = new System.Drawing.Point(15, 67);
            this.lblMaxCharge.Name = "lblMaxCharge";
            this.lblMaxCharge.Size = new System.Drawing.Size(41, 34);
            this.lblMaxCharge.TabIndex = 1;
            this.lblMaxCharge.Text = "0 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highest:";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.lblMaxJob);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(553, 23);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(402, 121);
            this.guna2CustomGradientPanel2.TabIndex = 6;
            // 
            // lblMaxJob
            // 
            this.lblMaxJob.AutoSize = true;
            this.lblMaxJob.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxJob.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxJob.ForeColor = System.Drawing.Color.White;
            this.lblMaxJob.Location = new System.Drawing.Point(14, 67);
            this.lblMaxJob.Name = "lblMaxJob";
            this.lblMaxJob.Size = new System.Drawing.Size(41, 34);
            this.lblMaxJob.TabIndex = 2;
            this.lblMaxJob.Text = "0 ";
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
            // FSalary_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 566);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.chartPost);
            this.Controls.Add(this.ChartSalary);
            this.Name = "FSalary_Worker";
            this.Text = "Nhap";
            this.Load += new System.EventHandler(this.Nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPost)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.Charts.WinForms.GunaChart ChartSalary;
        public Guna.Charts.WinForms.GunaLineDataset cCharge;
        private Guna.Charts.WinForms.GunaPieDataset gunaPieDataset1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPost;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblMaxCharge;
        private System.Windows.Forms.Label lblMaxJob;
        private System.Windows.Forms.Label label2;
    }
}