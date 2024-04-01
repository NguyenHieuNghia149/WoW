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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRequirement_Jobs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnHistory = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel_Body);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 856);
            this.panel1.TabIndex = 1;
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 114);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1303, 742);
            this.panel_Body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Separator2);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 114);
            this.panel2.TabIndex = 0;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.guna2Separator2.Location = new System.Drawing.Point(-19, 102);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1396, 16);
            this.guna2Separator2.TabIndex = 15;
            // 
            // btnHistory
            // 
            this.btnHistory.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHistory.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHistory.ImageRotate = 0F;
            this.btnHistory.ImageSize = new System.Drawing.Size(70, 70);
            this.btnHistory.Location = new System.Drawing.Point(210, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHistory.Size = new System.Drawing.Size(113, 116);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpload.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpload.ImageRotate = 0F;
            this.btnUpload.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUpload.Location = new System.Drawing.Point(85, -2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpload.Size = new System.Drawing.Size(99, 116);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // FRequirement_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 856);
            this.Controls.Add(this.panel1);
            this.Name = "FRequirement_Jobs";
            this.Text = "FRequirement_Jobs";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpload;
    }
}