namespace TheGioiViecLam
{
    partial class FSignIn
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
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnWorkers = new Guna.UI2.WinForms.Guna2Button();
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblFGpassword = new System.Windows.Forms.Label();
            this.lblsignin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(118)))));
            this.btnSignIn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(538, 435);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(180, 62);
            this.btnSignIn.TabIndex = 38;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(396, 359);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(465, 48);
            this.txtPassword.TabIndex = 37;
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
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(396, 277);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(465, 48);
            this.txtEmail.TabIndex = 36;
            // 
            // btnWorkers
            // 
            this.btnWorkers.BorderRadius = 10;
            this.btnWorkers.BorderThickness = 1;
            this.btnWorkers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWorkers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(158)))));
            this.btnWorkers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnWorkers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWorkers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWorkers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWorkers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWorkers.FillColor = System.Drawing.Color.White;
            this.btnWorkers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkers.ForeColor = System.Drawing.Color.Black;
            this.btnWorkers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(171)))), ((int)(((byte)(238)))));
            this.btnWorkers.Location = new System.Drawing.Point(556, 12);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(140, 45);
            this.btnWorkers.TabIndex = 35;
            this.btnWorkers.Text = "For Workers";
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btn
            // 
            this.btn.BorderRadius = 10;
            this.btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn.Checked = true;
            this.btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(158)))));
            this.btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.FillColor = System.Drawing.Color.White;
            this.btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.Black;
            this.btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(171)))), ((int)(((byte)(238)))));
            this.btn.Location = new System.Drawing.Point(396, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(139, 45);
            this.btn.TabIndex = 34;
            this.btn.Text = "For Customers";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(666, 535);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(117, 20);
            this.lblCreateAccount.TabIndex = 33;
            this.lblCreateAccount.Text = "Sign up now!";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.ForeColor = System.Drawing.Color.Black;
            this.lblNoAccount.Location = new System.Drawing.Point(447, 535);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(195, 20);
            this.lblNoAccount.TabIndex = 32;
            this.lblNoAccount.Text = "Do not have an account?";
            // 
            // lblFGpassword
            // 
            this.lblFGpassword.AutoSize = true;
            this.lblFGpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblFGpassword.Location = new System.Drawing.Point(706, 335);
            this.lblFGpassword.Name = "lblFGpassword";
            this.lblFGpassword.Size = new System.Drawing.Size(145, 20);
            this.lblFGpassword.TabIndex = 30;
            this.lblFGpassword.Text = "Forgot Password?";
            // 
            // lblsignin
            // 
            this.lblsignin.BackColor = System.Drawing.Color.White;
            this.lblsignin.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(158)))));
            this.lblsignin.Location = new System.Drawing.Point(417, 79);
            this.lblsignin.Name = "lblsignin";
            this.lblsignin.Size = new System.Drawing.Size(413, 63);
            this.lblsignin.TabIndex = 29;
            this.lblsignin.Text = "SIGN IN";
            this.lblsignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(520, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "or use your email infor: ";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(175)))));
            this.guna2CircleButton2.BorderThickness = 1;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = global::TheGioiViecLam.Properties.Resources.google;
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton2.Location = new System.Drawing.Point(658, 156);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton2.TabIndex = 41;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(175)))));
            this.guna2CircleButton1.BorderThickness = 1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::TheGioiViecLam.Properties.Resources.facebook;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.Location = new System.Drawing.Point(538, 156);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton1.TabIndex = 40;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::TheGioiViecLam.Properties.Resources.c2d3ea4e7db59e78d0af0125bcd570aa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -62);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(369, 733);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 39;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.lblFGpassword);
            this.Controls.Add(this.lblsignin);
            this.Name = "FSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnWorkers;
        private Guna.UI2.WinForms.Guna2Button btn;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblFGpassword;
        private System.Windows.Forms.Label lblsignin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label1;
    }
}