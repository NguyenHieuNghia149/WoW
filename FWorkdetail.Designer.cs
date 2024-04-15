namespace TheGioiViecLam
{
    partial class FWorkdetail
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
            this.panelReview = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReview
            // 
            this.panelReview.AutoScroll = true;
            this.panelReview.Location = new System.Drawing.Point(0, 811);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(1373, 244);
            this.panelReview.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelReview);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 1055);
            this.panel1.TabIndex = 0;
            // 
            // FWorkdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "FWorkdetail";
            this.Text = "FWorkdetail";
            this.Load += new System.EventHandler(this.FWorkdetail_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelReview;
        private Guna.UI2.WinForms.Guna2Panel panel1;
    }
}