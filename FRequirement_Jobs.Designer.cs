namespace TheGioiViecLam
{
    partial class FRequirement_Jobs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel_Body);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 640);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.Location = new System.Drawing.Point(0, 67);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1039, 573);
            this.panel_Body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 65);
            this.panel2.TabIndex = 0;
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
            this.btnPost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnPost.Location = new System.Drawing.Point(837, 15);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(180, 45);
            this.btnPost.TabIndex = 46;
            this.btnPost.Text = "Post now";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // FRequirement_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 641);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRequirement_Jobs";
            this.Text = "FRequirement_Jobs";
            this.Load += new System.EventHandler(this.FRequirement_Jobs_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2Button btnPost;
    }
}