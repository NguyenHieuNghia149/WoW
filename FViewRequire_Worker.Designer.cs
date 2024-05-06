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
            this.panel_View = new System.Windows.Forms.Panel();
            this.cbx_districts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_cities = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // panel_View
            // 
            this.panel_View.BackColor = System.Drawing.Color.White;
            this.panel_View.Location = new System.Drawing.Point(0, 73);
            this.panel_View.Margin = new System.Windows.Forms.Padding(4);
            this.panel_View.Name = "panel_View";
            this.panel_View.Size = new System.Drawing.Size(1024, 582);
            this.panel_View.TabIndex = 3;
            // 
            // cbx_districts
            // 
            this.cbx_districts.BackColor = System.Drawing.Color.Transparent;
            this.cbx_districts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbx_districts.BorderRadius = 10;
            this.cbx_districts.BorderThickness = 2;
            this.cbx_districts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_districts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_districts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_districts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_districts.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_districts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_districts.ItemHeight = 30;
            this.cbx_districts.Location = new System.Drawing.Point(238, 13);
            this.cbx_districts.Name = "cbx_districts";
            this.cbx_districts.Size = new System.Drawing.Size(179, 36);
            this.cbx_districts.TabIndex = 16;
            this.cbx_districts.SelectedIndexChanged += new System.EventHandler(this.cbx_districts_SelectedIndexChanged);
            // 
            // cbx_cities
            // 
            this.cbx_cities.BackColor = System.Drawing.Color.Transparent;
            this.cbx_cities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbx_cities.BorderRadius = 10;
            this.cbx_cities.BorderThickness = 2;
            this.cbx_cities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cities.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_cities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_cities.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_cities.ItemHeight = 30;
            this.cbx_cities.Location = new System.Drawing.Point(50, 13);
            this.cbx_cities.Name = "cbx_cities";
            this.cbx_cities.Size = new System.Drawing.Size(182, 36);
            this.cbx_cities.TabIndex = 15;
            this.cbx_cities.SelectedIndexChanged += new System.EventHandler(this.cbx_cities_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::TheGioiViecLam.Properties.Resources.search__2_;
            this.btn_Search.Location = new System.Drawing.Point(746, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Search.Size = new System.Drawing.Size(37, 29);
            this.btn_Search.TabIndex = 14;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txt_Search.BorderRadius = 18;
            this.txt_Search.BorderThickness = 2;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(423, 13);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(412, 44);
            this.txt_Search.TabIndex = 13;
            // 
            // FViewRequire_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 655);
            this.Controls.Add(this.cbx_districts);
            this.Controls.Add(this.cbx_cities);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel_View);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FViewRequire_Worker";
            this.Text = "FViewRequire_Worker";
            this.Load += new System.EventHandler(this.FViewRequire_Worker_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_View;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_districts;
        public Guna.UI2.WinForms.Guna2ComboBox cbx_cities;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
    }
}