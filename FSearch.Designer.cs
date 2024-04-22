namespace TheGioiViecLam
{
    partial class FSearch
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneFilter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.worldOfWorkDataSet = new TheGioiViecLam.WorldOfWorkDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new TheGioiViecLam.WorldOfWorkDataSetTableAdapters.WorkerTableAdapter();
            this.cbx_cities = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_districts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbx_districts);
            this.panel1.Controls.Add(this.cbx_cities);
            this.panel1.Controls.Add(this.paneFilter);
            this.panel1.Controls.Add(this.PanelBottom);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 641);
            this.panel1.TabIndex = 6;
            // 
            // paneFilter
            // 
            this.paneFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.paneFilter.BorderRadius = 15;
            this.paneFilter.BorderThickness = 2;
            this.paneFilter.Location = new System.Drawing.Point(604, 120);
            this.paneFilter.Name = "paneFilter";
            this.paneFilter.Size = new System.Drawing.Size(266, 347);
            this.paneFilter.TabIndex = 5;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.PanelBottom.Location = new System.Drawing.Point(4, 121);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1035, 516);
            this.PanelBottom.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFilter.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.Image = global::TheGioiViecLam.Properties.Resources.filter;
            this.btnFilter.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFilter.Location = new System.Drawing.Point(849, 85);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFilter.Size = new System.Drawing.Size(43, 29);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.btn_Search.Location = new System.Drawing.Point(705, 67);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Search.Size = new System.Drawing.Size(37, 29);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(346, 60);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(412, 44);
            this.txt_Search.TabIndex = 8;
            // 
            // worldOfWorkDataSet
            // 
            this.worldOfWorkDataSet.DataSetName = "WorldOfWorkDataSet";
            this.worldOfWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.worldOfWorkDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
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
            this.cbx_cities.Location = new System.Drawing.Point(12, 60);
            this.cbx_cities.Name = "cbx_cities";
            this.cbx_cities.Size = new System.Drawing.Size(182, 36);
            this.cbx_cities.TabIndex = 11;
            this.cbx_cities.SelectedIndexChanged += new System.EventHandler(this.cbx_cities_SelectedIndexChanged);

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
            this.cbx_districts.Location = new System.Drawing.Point(200, 60);
            this.cbx_districts.Name = "cbx_districts";
            this.cbx_districts.Size = new System.Drawing.Size(140, 36);
            this.cbx_districts.TabIndex = 12;
            this.cbx_districts.SelectedIndexChanged += new System.EventHandler(this.cbx_districts_SelectedIndexChanged);
            // 
            // FSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 641);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FSearch";
            this.Text = "FHome";
            this.Load += new System.EventHandler(this.FHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelBottom;
        private WorldOfWorkDataSet worldOfWorkDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private WorldOfWorkDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel paneFilter;
        private Guna.UI2.WinForms.Guna2CircleButton btnFilter;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_districts;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_cities;
    }
}