namespace TheGioiViecLam.UserControls
{
    partial class ucDayMini
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
            this.btnday = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnday
            // 
            this.btnday.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnday.FillColor = System.Drawing.Color.White;
            this.btnday.Font = new System.Drawing.Font("Tahoma", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnday.ForeColor = System.Drawing.Color.Black;
            this.btnday.Location = new System.Drawing.Point(1, 1);
            this.btnday.Name = "btnday";
            this.btnday.Size = new System.Drawing.Size(40, 28);
            this.btnday.TabIndex = 6;
            this.btnday.Text = "1";
            this.btnday.TextOffset = new System.Drawing.Point(-10, -5);
            this.btnday.Click += new System.EventHandler(this.btnday_Click);
            // 
            // ucDayMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnday);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDayMini";
            this.Size = new System.Drawing.Size(42, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnday;
    }
}
