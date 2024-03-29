namespace TheGioiViecLam
{
    partial class FOrders
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.ucWorkInFor1 = new TheGioiViecLam.UCWorkInFor();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel_Body.Controls.Add(this.ucWorkInFor1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1303, 856);
            this.panel_Body.TabIndex = 3;
            // 
            // ucWorkInFor1
            // 
            this.ucWorkInFor1.BackColor = System.Drawing.Color.White;
            this.ucWorkInFor1.Location = new System.Drawing.Point(69, 34);
            this.ucWorkInFor1.Name = "ucWorkInFor1";
            this.ucWorkInFor1.Size = new System.Drawing.Size(1122, 290);
            this.ucWorkInFor1.TabIndex = 4;
            // 
            // FOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 856);
            this.Controls.Add(this.panel_Body);
            this.Name = "FOrders";
            this.Text = "FOrders";
            this.panel_Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Body;
        private UCWorkInFor ucWorkInFor1;
    }
}