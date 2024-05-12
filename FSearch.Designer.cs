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
            this.cbx_districts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_cities = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.worldOfWorkDataSet = new TheGioiViecLam.WorldOfWorkDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneFilter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cb5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cb2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Rating1Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.Rating2Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.Rating3Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.Rating4Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label3 = new System.Windows.Forms.Label();
            this.Rating5Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.ScrollBar = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.btnApply = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.workerTableAdapter = new TheGioiViecLam.WorldOfWorkDataSetTableAdapters.WorkerTableAdapter();
            this.lblHome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneFilter.SuspendLayout();
            this.SuspendLayout();
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
            this.cbx_districts.Location = new System.Drawing.Point(278, 49);
            this.cbx_districts.Name = "cbx_districts";
            this.cbx_districts.Size = new System.Drawing.Size(166, 36);
            this.cbx_districts.TabIndex = 12;
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
            this.cbx_cities.Location = new System.Drawing.Point(90, 49);
            this.cbx_cities.Name = "cbx_cities";
            this.cbx_cities.Size = new System.Drawing.Size(182, 36);
            this.cbx_cities.TabIndex = 11;
            this.cbx_cities.SelectedIndexChanged += new System.EventHandler(this.cbx_cities_SelectedIndexChanged);
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
            this.txt_Search.Location = new System.Drawing.Point(450, 49);
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.paneFilter);
            this.panel1.Controls.Add(this.cbx_districts);
            this.panel1.Controls.Add(this.cbx_cities);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.PanelBottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 641);
            this.panel1.TabIndex = 7;
            // 
            // paneFilter
            // 
            this.paneFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.paneFilter.BorderRadius = 15;
            this.paneFilter.BorderThickness = 2;
            this.paneFilter.Controls.Add(this.cb5);
            this.paneFilter.Controls.Add(this.cb4);
            this.paneFilter.Controls.Add(this.cb3);
            this.paneFilter.Controls.Add(this.cb1);
            this.paneFilter.Controls.Add(this.cb2);
            this.paneFilter.Controls.Add(this.Rating1Star);
            this.paneFilter.Controls.Add(this.Rating2Star);
            this.paneFilter.Controls.Add(this.Rating3Star);
            this.paneFilter.Controls.Add(this.Rating4Star);
            this.paneFilter.Controls.Add(this.label3);
            this.paneFilter.Controls.Add(this.Rating5Star);
            this.paneFilter.Controls.Add(this.label2);
            this.paneFilter.Controls.Add(this.lblValue);
            this.paneFilter.Controls.Add(this.ScrollBar);
            this.paneFilter.Controls.Add(this.btnApply);
            this.paneFilter.Controls.Add(this.label1);
            this.paneFilter.Location = new System.Drawing.Point(665, 119);
            this.paneFilter.Name = "paneFilter";
            this.paneFilter.Size = new System.Drawing.Size(266, 325);
            this.paneFilter.TabIndex = 5;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.BorderRadius = 0;
            this.cb5.CheckedState.BorderThickness = 0;
            this.cb5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cb5.Location = new System.Drawing.Point(149, 110);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(18, 17);
            this.cb5.TabIndex = 1020;
            this.cb5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb5.UncheckedState.BorderRadius = 0;
            this.cb5.UncheckedState.BorderThickness = 0;
            this.cb5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb5.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.BorderRadius = 0;
            this.cb4.CheckedState.BorderThickness = 0;
            this.cb4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.Location = new System.Drawing.Point(149, 137);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(86, 28);
            this.cb4.TabIndex = 1019;
            this.cb4.Text = "above";
            this.cb4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb4.UncheckedState.BorderRadius = 0;
            this.cb4.UncheckedState.BorderThickness = 0;
            this.cb4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb4.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.BorderRadius = 0;
            this.cb3.CheckedState.BorderThickness = 0;
            this.cb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.Location = new System.Drawing.Point(149, 171);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(86, 28);
            this.cb3.TabIndex = 1018;
            this.cb3.Text = "above";
            this.cb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb3.UncheckedState.BorderRadius = 0;
            this.cb3.UncheckedState.BorderThickness = 0;
            this.cb3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb3.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.BorderRadius = 0;
            this.cb1.CheckedState.BorderThickness = 0;
            this.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.Location = new System.Drawing.Point(149, 239);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(86, 28);
            this.cb1.TabIndex = 1017;
            this.cb1.Text = "above";
            this.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb1.UncheckedState.BorderRadius = 0;
            this.cb1.UncheckedState.BorderThickness = 0;
            this.cb1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb1.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.BorderRadius = 0;
            this.cb2.CheckedState.BorderThickness = 0;
            this.cb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.Location = new System.Drawing.Point(149, 205);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(86, 28);
            this.cb2.TabIndex = 1016;
            this.cb2.Text = "above";
            this.cb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb2.UncheckedState.BorderRadius = 0;
            this.cb2.UncheckedState.BorderThickness = 0;
            this.cb2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb2.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // Rating1Star
            // 
            this.Rating1Star.Location = new System.Drawing.Point(19, 239);
            this.Rating1Star.Name = "Rating1Star";
            this.Rating1Star.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Rating1Star.ReadOnly = true;
            this.Rating1Star.Size = new System.Drawing.Size(120, 28);
            this.Rating1Star.TabIndex = 1008;
            this.Rating1Star.Value = 1F;
            // 
            // Rating2Star
            // 
            this.Rating2Star.Location = new System.Drawing.Point(19, 205);
            this.Rating2Star.Name = "Rating2Star";
            this.Rating2Star.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Rating2Star.ReadOnly = true;
            this.Rating2Star.Size = new System.Drawing.Size(120, 28);
            this.Rating2Star.TabIndex = 1007;
            this.Rating2Star.Value = 2F;
            // 
            // Rating3Star
            // 
            this.Rating3Star.Location = new System.Drawing.Point(19, 171);
            this.Rating3Star.Name = "Rating3Star";
            this.Rating3Star.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Rating3Star.ReadOnly = true;
            this.Rating3Star.Size = new System.Drawing.Size(120, 28);
            this.Rating3Star.TabIndex = 1006;
            this.Rating3Star.Value = 3F;
            // 
            // Rating4Star
            // 
            this.Rating4Star.Location = new System.Drawing.Point(19, 137);
            this.Rating4Star.Name = "Rating4Star";
            this.Rating4Star.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Rating4Star.ReadOnly = true;
            this.Rating4Star.Size = new System.Drawing.Size(120, 28);
            this.Rating4Star.TabIndex = 1005;
            this.Rating4Star.Value = 4F;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(145, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 1004;
            // 
            // Rating5Star
            // 
            this.Rating5Star.Location = new System.Drawing.Point(19, 103);
            this.Rating5Star.Name = "Rating5Star";
            this.Rating5Star.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.Rating5Star.ReadOnly = true;
            this.Rating5Star.Size = new System.Drawing.Size(120, 28);
            this.Rating5Star.TabIndex = 1003;
            this.Rating5Star.Value = 5F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Review:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblValue.Location = new System.Drawing.Point(64, 18);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(19, 21);
            this.lblValue.TabIndex = 1001;
            this.lblValue.Text = "0";
            // 
            // ScrollBar
            // 
            this.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ScrollBar.InUpdate = false;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(19, 54);
            this.ScrollBar.Maximum = 1000;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.ScrollbarSize = 10;
            this.ScrollBar.Size = new System.Drawing.Size(220, 10);
            this.ScrollBar.TabIndex = 1000;
            this.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnApply.BorderRadius = 10;
            this.btnApply.BorderThickness = 1;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.White;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.btnApply.Location = new System.Drawing.Point(149, 287);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 22);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost:";
            // 
            // btnFilter
            // 
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
            this.btnFilter.Location = new System.Drawing.Point(903, 92);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFilter.Size = new System.Drawing.Size(43, 29);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::TheGioiViecLam.Properties.Resources.search__2_;
            this.btn_Search.Location = new System.Drawing.Point(814, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Search.Size = new System.Drawing.Size(37, 29);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.PanelBottom.Location = new System.Drawing.Point(4, 135);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1035, 502);
            this.PanelBottom.TabIndex = 2;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(136, 37);
            this.lblHome.TabIndex = 13;
            this.lblHome.Text = "JobName";
            this.lblHome.Click += new System.EventHandler(this.lbl_Home_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneFilter.ResumeLayout(false);
            this.paneFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbx_districts;
        private Guna.UI2.WinForms.Guna2CircleButton btnFilter;
        public Guna.UI2.WinForms.Guna2ComboBox cbx_cities;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private WorldOfWorkDataSet worldOfWorkDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelBottom;
        private WorldOfWorkDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel paneFilter;
        private Guna.UI2.WinForms.Guna2CheckBox cb5;
        private Guna.UI2.WinForms.Guna2CheckBox cb4;
        private Guna.UI2.WinForms.Guna2CheckBox cb3;
        private Guna.UI2.WinForms.Guna2CheckBox cb1;
        private Guna.UI2.WinForms.Guna2CheckBox cb2;
        private Guna.UI2.WinForms.Guna2RatingStar Rating1Star;
        private Guna.UI2.WinForms.Guna2RatingStar Rating2Star;
        private Guna.UI2.WinForms.Guna2RatingStar Rating3Star;
        private Guna.UI2.WinForms.Guna2RatingStar Rating4Star;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RatingStar Rating5Star;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HScrollBar ScrollBar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblValue;
        public Guna.UI2.WinForms.Guna2Button btnApply;
        private System.Windows.Forms.Label lblHome;
    }
}