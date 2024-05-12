namespace TheGioiViecLam
{
    partial class FViewPost
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 55);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(982, 698);
            this.panelBody.TabIndex = 3;
            // 
            // btnPost
            // 
            this.btnPost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnPost.BorderRadius = 18;
            this.btnPost.BorderThickness = 2;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnPost.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnPost.Location = new System.Drawing.Point(817, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(134, 32);
            this.btnPost.TabIndex = 47;
            this.btnPost.Text = "Post now";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 55);
            this.panel1.TabIndex = 2;
            // 
            // FViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FViewPost";
            this.Text = "FViewPost";
            this.Load += new System.EventHandler(this.FViewPost_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        public Guna.UI2.WinForms.Guna2Button btnPost;
        private System.Windows.Forms.Panel panel1;
    }
}