namespace TheGioiViecLam
{
    partial class FProfile_Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfile_Workers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIncome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPerInf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
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
            this.panel1.Size = new System.Drawing.Size(1404, 656);
            this.panel1.TabIndex = 0;
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 114);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1404, 542);
            this.panel_Body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Separator2);
            this.panel2.Controls.Add(this.btnIncome);
            this.panel2.Controls.Add(this.btnPerInf);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1404, 114);
            this.panel2.TabIndex = 0;
            // 
            // btnIncome
            // 
            this.btnIncome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncome.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnIncome.ImageRotate = 0F;
            this.btnIncome.ImageSize = new System.Drawing.Size(70, 70);
            this.btnIncome.Location = new System.Drawing.Point(210, -8);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIncome.Size = new System.Drawing.Size(113, 116);
            this.btnIncome.TabIndex = 8;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnPerInf
            // 
            this.btnPerInf.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPerInf.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPerInf.Image = ((System.Drawing.Image)(resources.GetObject("btnPerInf.Image")));
            this.btnPerInf.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPerInf.ImageRotate = 0F;
            this.btnPerInf.ImageSize = new System.Drawing.Size(70, 70);
            this.btnPerInf.Location = new System.Drawing.Point(85, -2);
            this.btnPerInf.Name = "btnPerInf";
            this.btnPerInf.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPerInf.Size = new System.Drawing.Size(99, 116);
            this.btnPerInf.TabIndex = 7;
            this.btnPerInf.Click += new System.EventHandler(this.btnPerInf_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(81)))));
            this.guna2Separator2.Location = new System.Drawing.Point(-19, 102);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1396, 16);
            this.guna2Separator2.TabIndex = 15;
            // 
            // FProfile_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 656);
            this.Controls.Add(this.panel1);
            this.Name = "FProfile_Workers";
            this.Text = "FProfile_Workers";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnIncome;
        private Guna.UI2.WinForms.Guna2ImageButton btnPerInf;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}