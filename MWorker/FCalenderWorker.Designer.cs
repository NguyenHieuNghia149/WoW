namespace TheGioiViecLam
{
    partial class FCalenderWorker
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
            this.ucCalender1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucCalender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCalender1.Location = new System.Drawing.Point(-1, 3);
            this.ucCalender1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCalender1.Name = "ucCalender1";
            this.ucCalender1.Size = new System.Drawing.Size(1105, 613);
            this.ucCalender1.TabIndex = 0;
            this.ucCalender1.Load += new System.EventHandler(this.ucCalender1_Load);
            // 
            // FCalenderWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 613);
            this.Controls.Add(this.ucCalender1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FCalenderWorker";
            this.Text = "FCalenderWorker";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucCalender ucCalender1;
    }
}