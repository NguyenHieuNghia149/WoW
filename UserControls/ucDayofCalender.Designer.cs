namespace TheGioiViecLam.UserControls
{
    partial class ucDayofCalender
    {
        //// <summary> 
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
            this.pnmain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblbuoichieu = new System.Windows.Forms.Label();
            this.lblbuoisang = new System.Windows.Forms.Label();
            this.btnday = new Guna.UI2.WinForms.Guna2Button();
            this.pnmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.lblbuoichieu);
            this.pnmain.Controls.Add(this.lblbuoisang);
            this.pnmain.Controls.Add(this.btnday);
            this.pnmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmain.Location = new System.Drawing.Point(0, 0);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(150, 92);
            this.pnmain.TabIndex = 0;
            // 
            // lblbuoichieu
            // 
            this.lblbuoichieu.AutoSize = true;
            this.lblbuoichieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.lblbuoichieu.Location = new System.Drawing.Point(6, 56);
            this.lblbuoichieu.Name = "lblbuoichieu";
            this.lblbuoichieu.Size = new System.Drawing.Size(44, 16);
            this.lblbuoichieu.TabIndex = 3;
            this.lblbuoichieu.Text = "label1";
            this.lblbuoichieu.Visible = false;
            // 
            // lblbuoisang
            // 
            this.lblbuoisang.AutoSize = true;
            this.lblbuoisang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.lblbuoisang.Location = new System.Drawing.Point(6, 35);
            this.lblbuoisang.Name = "lblbuoisang";
            this.lblbuoisang.Size = new System.Drawing.Size(44, 16);
            this.lblbuoisang.TabIndex = 2;
            this.lblbuoisang.Text = "label1";
            this.lblbuoisang.Visible = false;
            // 
            // btnday
            // 
            this.btnday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.btnday.BorderThickness = 1;
            this.btnday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnday.FillColor = System.Drawing.Color.White;
            this.btnday.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnday.ForeColor = System.Drawing.Color.Black;
            this.btnday.Location = new System.Drawing.Point(3, 3);
            this.btnday.Name = "btnday";
            this.btnday.Size = new System.Drawing.Size(144, 86);
            this.btnday.TabIndex = 0;
            this.btnday.Text = "day";
            this.btnday.TextOffset = new System.Drawing.Point(-40, -23);
            // 
            // DayofCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnmain);
            this.Name = "DayofCalender";
            this.Size = new System.Drawing.Size(150, 92);
            this.pnmain.ResumeLayout(false);
            this.pnmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel pnmain;
        public System.Windows.Forms.Label lblbuoichieu;
        public System.Windows.Forms.Label lblbuoisang;
        public Guna.UI2.WinForms.Guna2Button btnday;
    }
}
