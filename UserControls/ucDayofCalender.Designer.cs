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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelOption = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBreakFullDay = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBreakAfternoon = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBreakMorning = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.btnOptionn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbuoichieu = new System.Windows.Forms.Label();
            this.lblbuoisang = new System.Windows.Forms.Label();
            this.btnday = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelOption);
            this.panelMain.Controls.Add(this.btnOptionn);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.lblbuoichieu);
            this.panelMain.Controls.Add(this.lblbuoisang);
            this.panelMain.Controls.Add(this.btnday);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(110, 67);
            this.panelMain.TabIndex = 0;
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.label4);
            this.panelOption.Controls.Add(this.cbBreakFullDay);
            this.panelOption.Controls.Add(this.label3);
            this.panelOption.Controls.Add(this.cbBreakAfternoon);
            this.panelOption.Controls.Add(this.label2);
            this.panelOption.Controls.Add(this.cbBreakMorning);
            this.panelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOption.Location = new System.Drawing.Point(6, 22);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(90, 38);
            this.panelOption.TabIndex = 9;
            this.panelOption.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Break full day";
            // 
            // cbBreakFullDay
            // 
            this.cbBreakFullDay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakFullDay.CheckedState.BorderRadius = 2;
            this.cbBreakFullDay.CheckedState.BorderThickness = 0;
            this.cbBreakFullDay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakFullDay.Location = new System.Drawing.Point(3, 27);
            this.cbBreakFullDay.Name = "cbBreakFullDay";
            this.cbBreakFullDay.Size = new System.Drawing.Size(11, 10);
            this.cbBreakFullDay.TabIndex = 5;
            this.cbBreakFullDay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakFullDay.UncheckedState.BorderRadius = 2;
            this.cbBreakFullDay.UncheckedState.BorderThickness = 0;
            this.cbBreakFullDay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakFullDay.Click += new System.EventHandler(this.cbBreakFullDay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Break Afternoon";
            // 
            // cbBreakAfternoon
            // 
            this.cbBreakAfternoon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakAfternoon.CheckedState.BorderRadius = 2;
            this.cbBreakAfternoon.CheckedState.BorderThickness = 0;
            this.cbBreakAfternoon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakAfternoon.Location = new System.Drawing.Point(3, 15);
            this.cbBreakAfternoon.Name = "cbBreakAfternoon";
            this.cbBreakAfternoon.Size = new System.Drawing.Size(11, 10);
            this.cbBreakAfternoon.TabIndex = 3;
            this.cbBreakAfternoon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakAfternoon.UncheckedState.BorderRadius = 2;
            this.cbBreakAfternoon.UncheckedState.BorderThickness = 0;
            this.cbBreakAfternoon.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakAfternoon.Click += new System.EventHandler(this.cbBreakAfternoon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Break Moring";
            // 
            // cbBreakMorning
            // 
            this.cbBreakMorning.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakMorning.CheckedState.BorderRadius = 2;
            this.cbBreakMorning.CheckedState.BorderThickness = 0;
            this.cbBreakMorning.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBreakMorning.Location = new System.Drawing.Point(3, 3);
            this.cbBreakMorning.Name = "cbBreakMorning";
            this.cbBreakMorning.Size = new System.Drawing.Size(11, 10);
            this.cbBreakMorning.TabIndex = 1;
            this.cbBreakMorning.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakMorning.UncheckedState.BorderRadius = 2;
            this.cbBreakMorning.UncheckedState.BorderThickness = 0;
            this.cbBreakMorning.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbBreakMorning.Click += new System.EventHandler(this.cbBreakMorning_Click);
            // 
            // btnOptionn
            // 
            this.btnOptionn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOptionn.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnOptionn.Image = global::TheGioiViecLam.Properties.Resources.option;
            this.btnOptionn.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOptionn.ImageRotate = 0F;
            this.btnOptionn.ImageSize = new System.Drawing.Size(15, 15);
            this.btnOptionn.Location = new System.Drawing.Point(93, 7);
            this.btnOptionn.Name = "btnOptionn";
            this.btnOptionn.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnOptionn.Size = new System.Drawing.Size(10, 18);
            this.btnOptionn.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::TheGioiViecLam.Properties.Resources.option1;
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
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
            // ucDayofCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDayofCalender";
            this.Size = new System.Drawing.Size(110, 67);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel panelMain;
        public System.Windows.Forms.Label lblbuoichieu;
        public System.Windows.Forms.Label lblbuoisang;
        public Guna.UI2.WinForms.Guna2Button btnday;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ImageButton btnOptionn;
        public Guna.UI2.WinForms.Guna2Panel panelOption;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbBreakFullDay;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbBreakAfternoon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbBreakMorning;
    }
}
