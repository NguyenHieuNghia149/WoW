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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeny = new Guna.UI2.WinForms.Guna2Button();
            this.btnComfirmed = new Guna.UI2.WinForms.Guna2Button();
            this.btncompleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnInOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Body.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.Controls.Add(this.guna2Separator1);
            this.panel_Body.Location = new System.Drawing.Point(1, 75);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1301, 828);
            this.panel_Body.TabIndex = 3;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(93)))), ((int)(((byte)(156)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1564, 12);
            this.guna2Separator1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnDeny);
            this.panelTop.Controls.Add(this.btnComfirmed);
            this.panelTop.Controls.Add(this.btncompleted);
            this.panelTop.Controls.Add(this.btnInOrder);
            this.panelTop.Location = new System.Drawing.Point(1, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1298, 67);
            this.panelTop.TabIndex = 4;
            // 
            // btnDeny
            // 
            this.btnDeny.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnDeny.BorderRadius = 10;
            this.btnDeny.BorderThickness = 1;
            this.btnDeny.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeny.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnDeny.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeny.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeny.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeny.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeny.FillColor = System.Drawing.Color.White;
            this.btnDeny.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(118)))));
            this.btnDeny.Location = new System.Drawing.Point(567, 6);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(180, 58);
            this.btnDeny.TabIndex = 3;
            this.btnDeny.Text = "Cancelled";
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnComfirmed
            // 
            this.btnComfirmed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnComfirmed.BorderRadius = 10;
            this.btnComfirmed.BorderThickness = 1;
            this.btnComfirmed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnComfirmed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnComfirmed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComfirmed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComfirmed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComfirmed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComfirmed.FillColor = System.Drawing.Color.White;
            this.btnComfirmed.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnComfirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(118)))));
            this.btnComfirmed.Location = new System.Drawing.Point(195, 6);
            this.btnComfirmed.Name = "btnComfirmed";
            this.btnComfirmed.Size = new System.Drawing.Size(180, 58);
            this.btnComfirmed.TabIndex = 2;
            this.btnComfirmed.Text = "Confirmed";
            this.btnComfirmed.Click += new System.EventHandler(this.btnComfirmed_Click);
            // 
            // btncompleted
            // 
            this.btncompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btncompleted.BorderRadius = 10;
            this.btncompleted.BorderThickness = 1;
            this.btncompleted.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncompleted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btncompleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncompleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncompleted.FillColor = System.Drawing.Color.White;
            this.btncompleted.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(118)))));
            this.btncompleted.Location = new System.Drawing.Point(381, 6);
            this.btncompleted.Name = "btncompleted";
            this.btncompleted.Size = new System.Drawing.Size(180, 58);
            this.btncompleted.TabIndex = 1;
            this.btncompleted.Text = "Completed";
            this.btncompleted.Click += new System.EventHandler(this.btncompleted_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnInOrder.BorderRadius = 10;
            this.btnInOrder.BorderThickness = 1;
            this.btnInOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnInOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInOrder.FillColor = System.Drawing.Color.White;
            this.btnInOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(118)))));
            this.btnInOrder.Location = new System.Drawing.Point(9, 3);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(180, 61);
            this.btnInOrder.TabIndex = 0;
            this.btnInOrder.Text = "In Order";
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // FOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 856);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel_Body);
            this.Name = "FOrders";
            this.Text = "FOrders";
            this.panel_Body.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Body;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Button btncompleted;
        public Guna.UI2.WinForms.Guna2Button btnInOrder;
        public Guna.UI2.WinForms.Guna2Button btnDeny;
        public Guna.UI2.WinForms.Guna2Button btnComfirmed;
    }
}