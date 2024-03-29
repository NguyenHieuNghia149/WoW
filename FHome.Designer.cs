﻿namespace TheGioiViecLam
{
    partial class FHome
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
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbx_districts = new System.Windows.Forms.ComboBox();
            this.cbx_cities = new System.Windows.Forms.ComboBox();
            this.worldOfWorkDataSet = new TheGioiViecLam.WorldOfWorkDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new TheGioiViecLam.WorldOfWorkDataSetTableAdapters.WorkerTableAdapter();
            this.panel1.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.PanelBottom);
            this.panel1.Controls.Add(this.PanelCenter);
            this.panel1.Controls.Add(this.PanelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 856);
            this.panel1.TabIndex = 6;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.PanelBottom.Location = new System.Drawing.Point(56, 198);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1190, 660);
            this.PanelBottom.TabIndex = 2;
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.comboBox1);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCenter.Location = new System.Drawing.Point(0, 126);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1303, 66);
            this.PanelCenter.TabIndex = 1;
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
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.lbl_Home);
            this.PanelTop.Controls.Add(this.btn_Search);
            this.PanelTop.Controls.Add(this.txt_Search);
            this.PanelTop.Controls.Add(this.cbx_districts);
            this.PanelTop.Controls.Add(this.cbx_cities);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1303, 126);
            this.PanelTop.TabIndex = 0;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Tahoma", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(88)))));
            this.lbl_Home.Location = new System.Drawing.Point(12, 9);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(145, 51);
            this.lbl_Home.TabIndex = 53;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(959, 64);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(127, 39);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(390, 67);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(563, 36);
            this.txt_Search.TabIndex = 2;
            // 
            // cbx_districts
            // 
            this.cbx_districts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_districts.FormattingEnabled = true;
            this.cbx_districts.Location = new System.Drawing.Point(211, 77);
            this.cbx_districts.Name = "cbx_districts";
            this.cbx_districts.Size = new System.Drawing.Size(121, 26);
            this.cbx_districts.TabIndex = 1;
            this.cbx_districts.Text = "Districts";
            this.cbx_districts.SelectedIndexChanged += new System.EventHandler(this.cbx_districts_SelectedIndexChanged);
            // 
            // cbx_cities
            // 
            this.cbx_cities.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cities.FormattingEnabled = true;
            this.cbx_cities.Location = new System.Drawing.Point(44, 77);
            this.cbx_cities.Name = "cbx_cities";
            this.cbx_cities.Size = new System.Drawing.Size(145, 26);
            this.cbx_cities.TabIndex = 0;
            this.cbx_cities.Text = "City";
            this.cbx_cities.SelectedIndexChanged += new System.EventHandler(this.cbx_cities_SelectedIndexChanged);
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
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 856);
            this.Controls.Add(this.panel1);
            this.Name = "FHome";
            this.Text = "FHome";
            this.Load += new System.EventHandler(this.FHome_Load);
            this.panel1.ResumeLayout(false);
            this.PanelCenter.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldOfWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbx_districts;
        private System.Windows.Forms.ComboBox cbx_cities;
        private WorldOfWorkDataSet worldOfWorkDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private WorldOfWorkDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Home;
    }
}