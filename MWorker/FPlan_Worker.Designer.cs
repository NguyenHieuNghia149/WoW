namespace TheGioiViecLam
{
    partial class FPlan_Worker
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReview = new Guna.UI2.WinForms.Guna2Button();
            this.btnDenied = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalender = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCalender = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnReview);
            this.guna2Panel1.Controls.Add(this.btnDenied);
            this.guna2Panel1.Controls.Add(this.btnCompleted);
            this.guna2Panel1.Controls.Add(this.btnCalender);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1061, 42);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnReview
            // 
            this.btnReview.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReview.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnReview.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnReview.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReview.FillColor = System.Drawing.Color.White;
            this.btnReview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnReview.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnReview.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReview.Location = new System.Drawing.Point(428, 5);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnReview.Name = "btnReview";
            this.btnReview.PressedColor = System.Drawing.Color.White;
            this.btnReview.Size = new System.Drawing.Size(133, 33);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Review";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnDenied
            // 
            this.btnDenied.BackColor = System.Drawing.Color.Transparent;
            this.btnDenied.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDenied.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnDenied.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDenied.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDenied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDenied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDenied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDenied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDenied.FillColor = System.Drawing.Color.White;
            this.btnDenied.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnDenied.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnDenied.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDenied.Location = new System.Drawing.Point(287, 4);
            this.btnDenied.Margin = new System.Windows.Forms.Padding(4);
            this.btnDenied.Name = "btnDenied";
            this.btnDenied.PressedColor = System.Drawing.Color.White;
            this.btnDenied.Size = new System.Drawing.Size(133, 33);
            this.btnDenied.TabIndex = 2;
            this.btnDenied.Text = "to Denied";
            this.btnDenied.Click += new System.EventHandler(this.btnDenied_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCompleted.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCompleted.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCompleted.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCompleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleted.FillColor = System.Drawing.Color.Transparent;
            this.btnCompleted.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCompleted.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCompleted.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCompleted.Location = new System.Drawing.Point(146, 4);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(133, 34);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Text = "To Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnCalender
            // 
            this.btnCalender.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCalender.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCalender.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCalender.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCalender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalender.FillColor = System.Drawing.Color.Transparent;
            this.btnCalender.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCalender.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnCalender.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCalender.Location = new System.Drawing.Point(5, 4);
            this.btnCalender.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(133, 33);
            this.btnCalender.TabIndex = 0;
            this.btnCalender.Text = "Calender";
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCalender);
            this.panelMain.Location = new System.Drawing.Point(1, 52);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1061, 666);
            this.panelMain.TabIndex = 3;
            // 
            // panelCalender
            // 
            this.panelCalender.Location = new System.Drawing.Point(34, 4);
            this.panelCalender.Margin = new System.Windows.Forms.Padding(4);
            this.panelCalender.Name = "panelCalender";
            this.panelCalender.Size = new System.Drawing.Size(1023, 647);
            this.panelCalender.TabIndex = 0;
            // 
            // FPlan_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 716);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPlan_Worker";
            this.Text = "FPlan_Worker";
            this.guna2Panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCalender;
        private Guna.UI2.WinForms.Guna2Button btnDenied;
        private Guna.UI2.WinForms.Guna2Button btnCompleted;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelCalender;
        private Guna.UI2.WinForms.Guna2Button btnReview;
    }
}