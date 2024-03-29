namespace TheGioiViecLam
{
    partial class FForgetPassword
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
            System.Windows.Forms.Button btnGetPassword;
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNofication = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            btnGetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetPassword
            // 
            btnGetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(158)))));
            btnGetPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGetPassword.Location = new System.Drawing.Point(186, 334);
            btnGetPassword.Name = "btnGetPassword";
            btnGetPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnGetPassword.Size = new System.Drawing.Size(244, 80);
            btnGetPassword.TabIndex = 3;
            btnGetPassword.Text = "Get Password";
            btnGetPassword.UseVisualStyleBackColor = false;
            btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(158)))));
            this.lblTitle.Location = new System.Drawing.Point(193, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Password Recovery";
            // 
            // lblNofication
            // 
            this.lblNofication.AutoSize = true;
            this.lblNofication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.lblNofication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNofication.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNofication.Location = new System.Drawing.Point(38, 146);
            this.lblNofication.Name = "lblNofication";
            this.lblNofication.Size = new System.Drawing.Size(100, 20);
            this.lblNofication.TabIndex = 4;
            this.lblNofication.Text = "Nofication:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblResult.Location = new System.Drawing.Point(38, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 28);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "result";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(95, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(449, 48);
            this.txtEmail.TabIndex = 6;
            // 
            // FForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNofication);
            this.Controls.Add(btnGetPassword);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FForgetPassword";
            this.Text = "Forget Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNofication;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
    }
}