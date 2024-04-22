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
            this.btnday = new Guna.UI2.WinForms.Guna2Button();
            this.lblbuoichieu = new System.Windows.Forms.Label();
            this.lblbuoisang = new System.Windows.Forms.Label();
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
            this.pnmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(110, 67);
            this.pnmain.TabIndex = 0;
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
            this.btnday.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnday.ForeColor = System.Drawing.Color.Black;
            this.btnday.Location = new System.Drawing.Point(4, 5);
            this.btnday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnday.Name = "btnday";
            this.btnday.Size = new System.Drawing.Size(102, 57);
            this.btnday.TabIndex = 4;
            this.btnday.Text = "day";
            this.btnday.TextOffset = new System.Drawing.Point(-30, -20);
            // 
            // lblbuoichieu
            // 
            this.lblbuoichieu.AutoSize = true;
            this.lblbuoichieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.lblbuoichieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuoichieu.Location = new System.Drawing.Point(13, 44);
            this.lblbuoichieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbuoichieu.Name = "lblbuoichieu";
            this.lblbuoichieu.Size = new System.Drawing.Size(44, 16);
            this.lblbuoichieu.TabIndex = 6;
            this.lblbuoichieu.Text = "label1";
            this.lblbuoichieu.Visible = false;
            // 
            // lblbuoisang
            // 
            this.lblbuoisang.AutoSize = true;
            this.lblbuoisang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.lblbuoisang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuoisang.Location = new System.Drawing.Point(13, 27);
            this.lblbuoisang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbuoisang.Name = "lblbuoisang";
            this.lblbuoisang.Size = new System.Drawing.Size(44, 16);
            this.lblbuoisang.TabIndex = 5;
            this.lblbuoisang.Text = "label1";
            this.lblbuoisang.Visible = false;
            // 
            // ucDayofCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDayofCalender";
            this.Size = new System.Drawing.Size(110, 67);
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
