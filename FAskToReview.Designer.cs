namespace TheGioiViecLam
{
    partial class FAskToReview
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
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_No);
            this.panel1.Controls.Add(this.btn_Yes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 246);
            this.panel1.TabIndex = 8;
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(134)))), ((int)(((byte)(211)))));
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_No.Location = new System.Drawing.Point(315, 106);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(173, 74);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(134)))), ((int)(((byte)(211)))));
            this.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yes.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Yes.Location = new System.Drawing.Point(117, 106);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(173, 74);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to write a review?";
            // 
            // FAskToReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 246);
            this.Controls.Add(this.panel1);
            this.Name = "FAskToReview";
            this.Text = "FAskToReview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Label label1;
    }
}