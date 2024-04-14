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
            this.ucCalender1 = new TheGioiViecLam.UserControls.ucCalender();
            this.SuspendLayout();
            // 
            // ucCalender1
            // 
            this.ucCalender1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucCalender1.Location = new System.Drawing.Point(12, 66);
            this.ucCalender1.Name = "ucCalender1";
            this.ucCalender1.Size = new System.Drawing.Size(1344, 760);
            this.ucCalender1.TabIndex = 1;
            // 
            // FPlan_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 853);
            this.Controls.Add(this.ucCalender1);
            this.Name = "FPlan_Worker";
            this.Text = "FPlan_Worker";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucCalender ucCalender1;
    }
}