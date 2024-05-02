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
            this.ChartSalary = new Guna.Charts.WinForms.GunaChart();
            this.cCharge = new Guna.Charts.WinForms.GunaLineDataset();
            this.SuspendLayout();
            // 
            // ChartSalary
            // 
            this.ChartSalary.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.cCharge});
            chartFont1.FontName = "Arial";
            this.ChartSalary.Legend.LabelFont = chartFont1;
            this.ChartSalary.Location = new System.Drawing.Point(12, 2);
            this.ChartSalary.Name = "ChartSalary";
            this.ChartSalary.Size = new System.Drawing.Size(779, 492);
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
            // FSalary_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 566);
            this.Controls.Add(this.ChartSalary);
            this.Name = "FSalary_Worker";
            this.Text = "Nhap";
            this.Load += new System.EventHandler(this.Nhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.Charts.WinForms.GunaChart ChartSalary;
        public Guna.Charts.WinForms.GunaLineDataset cCharge;
    }
}