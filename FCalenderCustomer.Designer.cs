namespace TheGioiViecLam
{
    partial class FCalenderCustomer
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
            this.ucCalender1.Location = new System.Drawing.Point(23, 12);
            this.ucCalender1.Name = "ucCalender1";
            this.ucCalender1.Size = new System.Drawing.Size(1344, 722);
            this.ucCalender1.TabIndex = 0;
            // 
            // FCalenderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 747);
            this.Controls.Add(this.ucCalender1);
            this.Name = "FCalenderCustomer";
            this.Text = "FCalenderCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucCalender ucCalender1;
    }
}