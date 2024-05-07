namespace TheGioiViecLam.UserControls
{
    partial class UCreview
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
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblaccount = new System.Windows.Forms.Label();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox);
            this.panelMain.Controls.Add(this.RatingStar);
            this.panelMain.Controls.Add(this.lblaccount);
            this.panelMain.Controls.Add(this.txtReview);
            this.panelMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(707, 245);
            this.panelMain.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 158);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 83);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // RatingStar
            // 
            this.RatingStar.Location = new System.Drawing.Point(16, 16);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.RatingStar.ReadOnly = true;
            this.RatingStar.Size = new System.Drawing.Size(104, 28);
            this.RatingStar.TabIndex = 12;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblaccount.Location = new System.Drawing.Point(12, 0);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(150, 21);
            this.lblaccount.TabIndex = 11;
            this.lblaccount.Text = "Nguyen Hieu Nghia";
            // 
            // txtReview
            // 
            this.txtReview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.txtReview.BorderRadius = 20;
            this.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReview.DefaultText = "";
            this.txtReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReview.ForeColor = System.Drawing.Color.Black;
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Location = new System.Drawing.Point(3, 51);
            this.txtReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReview.Name = "txtReview";
            this.txtReview.PasswordChar = '\0';
            this.txtReview.PlaceholderText = "";
            this.txtReview.ReadOnly = true;
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(701, 100);
            this.txtReview.TabIndex = 10;
            this.txtReview.TextOffset = new System.Drawing.Point(0, -40);
            // 
            // UCreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCreview";
            this.Size = new System.Drawing.Size(713, 252);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        public System.Windows.Forms.PictureBox pictureBox;
        public Guna.UI2.WinForms.Guna2RatingStar RatingStar;
        public System.Windows.Forms.Label lblaccount;
        public Guna.UI2.WinForms.Guna2TextBox txtReview;
    }
}
