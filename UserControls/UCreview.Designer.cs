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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblaccount = new System.Windows.Forms.Label();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pictureBox);
            this.guna2Panel1.Controls.Add(this.RatingStar);
            this.guna2Panel1.Controls.Add(this.lblaccount);
            this.guna2Panel1.Controls.Add(this.txtReview);
            this.guna2Panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1367, 286);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(26, 198);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 83);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // RatingStar
            // 
            this.RatingStar.Location = new System.Drawing.Point(26, 38);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.Size = new System.Drawing.Size(120, 28);
            this.RatingStar.TabIndex = 12;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Location = new System.Drawing.Point(22, 11);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(181, 24);
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
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Location = new System.Drawing.Point(6, 73);
            this.txtReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReview.Name = "txtReview";
            this.txtReview.PasswordChar = '\0';
            this.txtReview.PlaceholderText = "";
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(1358, 118);
            this.txtReview.TabIndex = 10;
            this.txtReview.TextChanged += new System.EventHandler(this.txtReview_TextChanged);
            // 
            // UCreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCreview";
            this.Size = new System.Drawing.Size(1373, 292);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblaccount;
        public Guna.UI2.WinForms.Guna2TextBox txtReview;
        public System.Windows.Forms.PictureBox pictureBox;
        public Guna.UI2.WinForms.Guna2RatingStar RatingStar;
    }
}
