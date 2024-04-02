namespace TheGioiViecLam
{
    partial class FViewRequire_Worker
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbx_districts = new System.Windows.Forms.ComboBox();
            this.cbx_cities = new System.Windows.Forms.ComboBox();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_View = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.PanelTop.Controls.Add(this.btn_Search);
            this.PanelTop.Controls.Add(this.txt_Search);
            this.PanelTop.Controls.Add(this.cbx_districts);
            this.PanelTop.Controls.Add(this.cbx_cities);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1404, 82);
            this.PanelTop.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(954, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(127, 39);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(385, 26);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(563, 36);
            this.txt_Search.TabIndex = 2;
            // 
            // cbx_districts
            // 
            this.cbx_districts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_districts.FormattingEnabled = true;
            this.cbx_districts.Location = new System.Drawing.Point(206, 36);
            this.cbx_districts.Name = "cbx_districts";
            this.cbx_districts.Size = new System.Drawing.Size(121, 26);
            this.cbx_districts.TabIndex = 1;
            this.cbx_districts.Text = "Districts";
            // 
            // cbx_cities
            // 
            this.cbx_cities.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cities.FormattingEnabled = true;
            this.cbx_cities.Location = new System.Drawing.Point(39, 36);
            this.cbx_cities.Name = "cbx_cities";
            this.cbx_cities.Size = new System.Drawing.Size(145, 26);
            this.cbx_cities.TabIndex = 0;
            this.cbx_cities.Text = "City";
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.PanelCenter.Controls.Add(this.comboBox1);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCenter.Location = new System.Drawing.Point(0, 82);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1404, 66);
            this.PanelCenter.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cost",
            "Rate",
            "Experience",
            "Job Field"});
            this.comboBox1.Location = new System.Drawing.Point(56, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Sort by";
            // 
            // panel_View
            // 
            this.panel_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_View.Location = new System.Drawing.Point(0, 148);
            this.panel_View.Name = "panel_View";
            this.panel_View.Size = new System.Drawing.Size(1404, 708);
            this.panel_View.TabIndex = 3;
            // 
            // FViewRequire_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 856);
            this.Controls.Add(this.panel_View);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.Name = "FViewRequire_Worker";
            this.Text = "FViewRequire_Worker";
            this.Load += new System.EventHandler(this.FViewRequire_Worker_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbx_districts;
        private System.Windows.Forms.ComboBox cbx_cities;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel_View;
    }
}