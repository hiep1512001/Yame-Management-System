﻿
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Attendance));
            this.pnl_Employee_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Attendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_Task = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Take_Attendance_Task = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Delete_Employee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dtp_Attendacne_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Add_Attendance = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gr_Salary_Caculate = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbo_Salary_Month = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Export_Salary_Report = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Employee_Info.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.pnl_Task.SuspendLayout();
            this.gr_Take_Attendance_Task.SuspendLayout();
            this.gr_Salary_Caculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Employee_Info
            // 
            this.pnl_Employee_Info.Controls.Add(this.guna2Panel2);
            this.pnl_Employee_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Employee_Info.Location = new System.Drawing.Point(8, 375);
            this.pnl_Employee_Info.Name = "pnl_Employee_Info";
            this.pnl_Employee_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Employee_Info.ShadowDecoration.Parent = this.pnl_Employee_Info;
            this.pnl_Employee_Info.Size = new System.Drawing.Size(765, 253);
            this.pnl_Employee_Info.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgv_Attendance);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(749, 237);
            this.guna2Panel2.TabIndex = 7;
            // 
            // dgv_Attendance
            // 
            this.dgv_Attendance.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_Attendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Attendance.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Attendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Attendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Attendance.ColumnHeadersHeight = 32;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Attendance.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Attendance.EnableHeadersVisualStyles = false;
            this.dgv_Attendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Attendance.Location = new System.Drawing.Point(0, 0);
            this.dgv_Attendance.Name = "dgv_Attendance";
            this.dgv_Attendance.ReadOnly = true;
            this.dgv_Attendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Attendance.RowHeadersVisible = false;
            this.dgv_Attendance.RowHeadersWidth = 51;
            this.dgv_Attendance.RowTemplate.Height = 28;
            this.dgv_Attendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Attendance.Size = new System.Drawing.Size(749, 237);
            this.dgv_Attendance.TabIndex = 2;
            this.dgv_Attendance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Attendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Attendance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Attendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Attendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Attendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Attendance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Attendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Attendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Attendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Attendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Attendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Attendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Attendance.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Attendance.ThemeStyle.ReadOnly = true;
            this.dgv_Attendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Attendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Attendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Attendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Attendance.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Attendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Attendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Attendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Attendance_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgv_Employee);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(375, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(398, 367);
            this.guna2Panel1.TabIndex = 8;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Employee.ColumnHeadersHeight = 32;
            this.dgv_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCheck});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(8, 0, 12, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Employee.EnableHeadersVisualStyles = false;
            this.dgv_Employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Employee.Location = new System.Drawing.Point(8, 8);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.RowHeadersVisible = false;
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 28;
            this.dgv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Employee.Size = new System.Drawing.Size(382, 359);
            this.dgv_Employee.TabIndex = 1;
            this.dgv_Employee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Employee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Employee.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Employee.ThemeStyle.ReadOnly = false;
            this.dgv_Employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Employee.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmCheck
            // 
            this.clmCheck.HeaderText = "Check";
            this.clmCheck.MinimumWidth = 6;
            this.clmCheck.Name = "clmCheck";
            this.clmCheck.Width = 88;
            // 
            // pnl_Task
            // 
            this.pnl_Task.Controls.Add(this.gr_Take_Attendance_Task);
            this.pnl_Task.Controls.Add(this.gr_Salary_Caculate);
            this.pnl_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Task.Location = new System.Drawing.Point(8, 8);
            this.pnl_Task.Name = "pnl_Task";
            this.pnl_Task.ShadowDecoration.Parent = this.pnl_Task;
            this.pnl_Task.Size = new System.Drawing.Size(367, 367);
            this.pnl_Task.TabIndex = 9;
            // 
            // gr_Take_Attendance_Task
            // 
            this.gr_Take_Attendance_Task.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gr_Take_Attendance_Task.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Take_Attendance_Task.Controls.Add(this.btn_Delete_Employee);
            this.gr_Take_Attendance_Task.Controls.Add(this.dtp_Attendacne_Date);
            this.gr_Take_Attendance_Task.Controls.Add(this.btn_Add_Attendance);
            this.gr_Take_Attendance_Task.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Take_Attendance_Task.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Take_Attendance_Task.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Take_Attendance_Task.ForeColor = System.Drawing.Color.White;
            this.gr_Take_Attendance_Task.Location = new System.Drawing.Point(14, 8);
            this.gr_Take_Attendance_Task.Name = "gr_Take_Attendance_Task";
            this.gr_Take_Attendance_Task.ShadowDecoration.Parent = this.gr_Take_Attendance_Task;
            this.gr_Take_Attendance_Task.Size = new System.Drawing.Size(351, 173);
            this.gr_Take_Attendance_Task.TabIndex = 6;
            this.gr_Take_Attendance_Task.Text = "Điểm danh";
            this.gr_Take_Attendance_Task.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // btn_Delete_Employee
            // 
            this.btn_Delete_Employee.Animated = true;
            this.btn_Delete_Employee.AnimationHoverSpeed = 0.07F;
            this.btn_Delete_Employee.AnimationSpeed = 0.03F;
            this.btn_Delete_Employee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Employee.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete_Employee.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete_Employee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Employee.CheckedImage")));
            this.btn_Delete_Employee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete_Employee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete_Employee.Enabled = false;
            this.btn_Delete_Employee.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete_Employee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Employee.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btn_Delete_Employee.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Delete_Employee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Employee.Location = new System.Drawing.Point(173, 115);
            this.btn_Delete_Employee.Name = "btn_Delete_Employee";
            this.btn_Delete_Employee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Employee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Delete_Employee.OnHoverImage = null;
            this.btn_Delete_Employee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Employee.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.Size = new System.Drawing.Size(124, 36);
            this.btn_Delete_Employee.TabIndex = 7;
            this.btn_Delete_Employee.Text = "Xóa";
            this.btn_Delete_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Employee.TextOffsetX = 24;
            this.btn_Delete_Employee.Click += new System.EventHandler(this.btn_Delete_Employee_Click);
            // 
            // dtp_Attendacne_Date
            // 
            this.dtp_Attendacne_Date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Attendacne_Date.BorderThickness = 1;
            this.dtp_Attendacne_Date.CheckedState.Parent = this.dtp_Attendacne_Date;
            this.dtp_Attendacne_Date.FillColor = System.Drawing.Color.White;
            this.dtp_Attendacne_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Attendacne_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_Attendacne_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Attendacne_Date.HoverState.Parent = this.dtp_Attendacne_Date;
            this.dtp_Attendacne_Date.Location = new System.Drawing.Point(32, 49);
            this.dtp_Attendacne_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Attendacne_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Attendacne_Date.Name = "dtp_Attendacne_Date";
            this.dtp_Attendacne_Date.ShadowDecoration.Parent = this.dtp_Attendacne_Date;
            this.dtp_Attendacne_Date.Size = new System.Drawing.Size(265, 36);
            this.dtp_Attendacne_Date.TabIndex = 6;
            this.dtp_Attendacne_Date.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // btn_Add_Attendance
            // 
            this.btn_Add_Attendance.Animated = true;
            this.btn_Add_Attendance.AnimationHoverSpeed = 0.07F;
            this.btn_Add_Attendance.AnimationSpeed = 0.03F;
            this.btn_Add_Attendance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Attendance.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_Attendance.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_Attendance.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Attendance.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_Attendance.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_Attendance.CheckedImage")));
            this.btn_Add_Attendance.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_Attendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_Attendance.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_Attendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Attendance.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Attendance.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_Attendance.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_Attendance.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Attendance.Location = new System.Drawing.Point(31, 115);
            this.btn_Add_Attendance.Name = "btn_Add_Attendance";
            this.btn_Add_Attendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Attendance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Attendance.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Add_Attendance.OnHoverImage = null;
            this.btn_Add_Attendance.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Attendance.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_Attendance.Size = new System.Drawing.Size(124, 36);
            this.btn_Add_Attendance.TabIndex = 3;
            this.btn_Add_Attendance.Text = "Thêm ";
            this.btn_Add_Attendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_Attendance.TextOffsetX = 24;
            this.btn_Add_Attendance.Click += new System.EventHandler(this.btn_Add_Attendance_Click);
            // 
            // gr_Salary_Caculate
            // 
            this.gr_Salary_Caculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gr_Salary_Caculate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Salary_Caculate.Controls.Add(this.cbo_Salary_Month);
            this.gr_Salary_Caculate.Controls.Add(this.btn_Export_Salary_Report);
            this.gr_Salary_Caculate.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Salary_Caculate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Salary_Caculate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Salary_Caculate.ForeColor = System.Drawing.Color.White;
            this.gr_Salary_Caculate.Location = new System.Drawing.Point(14, 194);
            this.gr_Salary_Caculate.Name = "gr_Salary_Caculate";
            this.gr_Salary_Caculate.ShadowDecoration.Parent = this.gr_Salary_Caculate;
            this.gr_Salary_Caculate.Size = new System.Drawing.Size(351, 167);
            this.gr_Salary_Caculate.TabIndex = 5;
            this.gr_Salary_Caculate.Text = "Tính lương theo tháng";
            this.gr_Salary_Caculate.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // cbo_Salary_Month
            // 
            this.cbo_Salary_Month.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Salary_Month.DisplayMember = "BookTypeName";
            this.cbo_Salary_Month.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Salary_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Salary_Month.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Salary_Month.FocusedState.Parent = this.cbo_Salary_Month;
            this.cbo_Salary_Month.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Salary_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Salary_Month.FormattingEnabled = true;
            this.cbo_Salary_Month.HoverState.Parent = this.cbo_Salary_Month;
            this.cbo_Salary_Month.ItemHeight = 30;
            this.cbo_Salary_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_Salary_Month.ItemsAppearance.Parent = this.cbo_Salary_Month;
            this.cbo_Salary_Month.Location = new System.Drawing.Point(31, 50);
            this.cbo_Salary_Month.Name = "cbo_Salary_Month";
            this.cbo_Salary_Month.ShadowDecoration.Parent = this.cbo_Salary_Month;
            this.cbo_Salary_Month.Size = new System.Drawing.Size(266, 36);
            this.cbo_Salary_Month.StartIndex = 0;
            this.cbo_Salary_Month.TabIndex = 15;
            this.cbo_Salary_Month.ValueMember = "BookTypeID";
            // 
            // btn_Export_Salary_Report
            // 
            this.btn_Export_Salary_Report.Animated = true;
            this.btn_Export_Salary_Report.AnimationHoverSpeed = 0.07F;
            this.btn_Export_Salary_Report.AnimationSpeed = 0.03F;
            this.btn_Export_Salary_Report.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Export_Salary_Report.BorderColor = System.Drawing.Color.Black;
            this.btn_Export_Salary_Report.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Export_Salary_Report.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Salary_Report.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Export_Salary_Report.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Export_Salary_Report.CheckedImage")));
            this.btn_Export_Salary_Report.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Export_Salary_Report.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Export_Salary_Report.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Export_Salary_Report.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export_Salary_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Export_Salary_Report.Image = global::Fahasa_Management_System.Properties.Resources.print;
            this.btn_Export_Salary_Report.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Export_Salary_Report.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Salary_Report.Location = new System.Drawing.Point(31, 107);
            this.btn_Export_Salary_Report.Name = "btn_Export_Salary_Report";
            this.btn_Export_Salary_Report.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Export_Salary_Report.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Salary_Report.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Export_Salary_Report.OnHoverImage = null;
            this.btn_Export_Salary_Report.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Salary_Report.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Export_Salary_Report.Size = new System.Drawing.Size(266, 36);
            this.btn_Export_Salary_Report.TabIndex = 3;
            this.btn_Export_Salary_Report.Text = "Xuất bảng lương";
            this.btn_Export_Salary_Report.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Export_Salary_Report.Click += new System.EventHandler(this.btn_Export_Salary_Report_Click);
            // 
            // Frm_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(781, 636);
            this.Controls.Add(this.pnl_Task);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnl_Employee_Info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Attendance";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Attendance";
            this.Load += new System.EventHandler(this.Frm_Attendance_Load);
            this.pnl_Employee_Info.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.pnl_Task.ResumeLayout(false);
            this.gr_Take_Attendance_Task.ResumeLayout(false);
            this.gr_Salary_Caculate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Employee_Info;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Employee;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnl_Task;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Salary_Caculate;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Export_Salary_Report;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Take_Attendance_Task;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Attendance;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Attendacne_Date;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Salary_Month;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Employee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCheck;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Attendance;
    }
}