
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Invoice));
            this.pnl_Date_ = new Guna.UI2.WinForms.Guna2Panel();
            this.chkB_Access_Invoice = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtp_Invoice_Date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_Invoice_Date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnl_Invoice_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpDoanhthu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Export_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_Total_Amount = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_Date_.SuspendLayout();
            this.pnl_Invoice_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Date_
            // 
            this.pnl_Date_.Controls.Add(this.chkB_Access_Invoice);
            this.pnl_Date_.Controls.Add(this.gunaLabel2);
            this.pnl_Date_.Controls.Add(this.gunaLabel1);
            this.pnl_Date_.Controls.Add(this.dtp_Invoice_Date_From);
            this.pnl_Date_.Controls.Add(this.dtp_Invoice_Date_To);
            this.pnl_Date_.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Date_.Location = new System.Drawing.Point(8, 8);
            this.pnl_Date_.Name = "pnl_Date_";
            this.pnl_Date_.ShadowDecoration.Parent = this.pnl_Date_;
            this.pnl_Date_.Size = new System.Drawing.Size(735, 132);
            this.pnl_Date_.TabIndex = 1;
            // 
            // chkB_Access_Invoice
            // 
            this.chkB_Access_Invoice.AutoSize = true;
            this.chkB_Access_Invoice.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.chkB_Access_Invoice.CheckedState.BorderRadius = 2;
            this.chkB_Access_Invoice.CheckedState.BorderThickness = 0;
            this.chkB_Access_Invoice.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.chkB_Access_Invoice.Location = new System.Drawing.Point(64, 20);
            this.chkB_Access_Invoice.Name = "chkB_Access_Invoice";
            this.chkB_Access_Invoice.Size = new System.Drawing.Size(279, 29);
            this.chkB_Access_Invoice.TabIndex = 9;
            this.chkB_Access_Invoice.Text = "Xem đơn hàng tháng hiện tại";
            this.chkB_Access_Invoice.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_Access_Invoice.UncheckedState.BorderRadius = 2;
            this.chkB_Access_Invoice.UncheckedState.BorderThickness = 0;
            this.chkB_Access_Invoice.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_Access_Invoice.UseVisualStyleBackColor = true;
            this.chkB_Access_Invoice.CheckedChanged += new System.EventHandler(this.chkB_Access_Invoice_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel2.Location = new System.Drawing.Point(60, 61);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(155, 25);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Xem hóa đơn từ: ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(421, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 25);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "đến ";
            // 
            // dtp_Invoice_Date_From
            // 
            this.dtp_Invoice_Date_From.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Invoice_Date_From.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Invoice_Date_From.BorderThickness = 1;
            this.dtp_Invoice_Date_From.CheckedState.Parent = this.dtp_Invoice_Date_From;
            this.dtp_Invoice_Date_From.FillColor = System.Drawing.Color.White;
            this.dtp_Invoice_Date_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Invoice_Date_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Invoice_Date_From.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Invoice_Date_From.HoverState.Parent = this.dtp_Invoice_Date_From;
            this.dtp_Invoice_Date_From.Location = new System.Drawing.Point(253, 52);
            this.dtp_Invoice_Date_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Invoice_Date_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Invoice_Date_From.Name = "dtp_Invoice_Date_From";
            this.dtp_Invoice_Date_From.ShadowDecoration.Parent = this.dtp_Invoice_Date_From;
            this.dtp_Invoice_Date_From.Size = new System.Drawing.Size(141, 36);
            this.dtp_Invoice_Date_From.TabIndex = 5;
            this.dtp_Invoice_Date_From.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Invoice_Date_From.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            this.dtp_Invoice_Date_From.ValueChanged += new System.EventHandler(this.dtp_Invoice_Date_From_ValueChanged);
            // 
            // dtp_Invoice_Date_To
            // 
            this.dtp_Invoice_Date_To.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Invoice_Date_To.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Invoice_Date_To.BorderThickness = 1;
            this.dtp_Invoice_Date_To.CheckedState.Parent = this.dtp_Invoice_Date_To;
            this.dtp_Invoice_Date_To.FillColor = System.Drawing.Color.White;
            this.dtp_Invoice_Date_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Invoice_Date_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Invoice_Date_To.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Invoice_Date_To.HoverState.Parent = this.dtp_Invoice_Date_To;
            this.dtp_Invoice_Date_To.Location = new System.Drawing.Point(481, 52);
            this.dtp_Invoice_Date_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Invoice_Date_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Invoice_Date_To.Name = "dtp_Invoice_Date_To";
            this.dtp_Invoice_Date_To.ShadowDecoration.Parent = this.dtp_Invoice_Date_To;
            this.dtp_Invoice_Date_To.Size = new System.Drawing.Size(141, 36);
            this.dtp_Invoice_Date_To.TabIndex = 4;
            this.dtp_Invoice_Date_To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Invoice_Date_To.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            this.dtp_Invoice_Date_To.ValueChanged += new System.EventHandler(this.dtp_Invoice_Date_To_ValueChanged);
            // 
            // pnl_Invoice_Info
            // 
            this.pnl_Invoice_Info.Controls.Add(this.dgv_Invoice);
            this.pnl_Invoice_Info.Controls.Add(this.guna2Panel2);
            this.pnl_Invoice_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice_Info.Location = new System.Drawing.Point(8, 140);
            this.pnl_Invoice_Info.Name = "pnl_Invoice_Info";
            this.pnl_Invoice_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Invoice_Info.ShadowDecoration.Parent = this.pnl_Invoice_Info;
            this.pnl_Invoice_Info.Size = new System.Drawing.Size(735, 488);
            this.pnl_Invoice_Info.TabIndex = 9;
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Invoice.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Invoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Invoice.EnableHeadersVisualStyles = false;
            this.dgv_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.Location = new System.Drawing.Point(8, 8);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.ReadOnly = true;
            this.dgv_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.RowHeadersVisible = false;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 28;
            this.dgv_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoice.Size = new System.Drawing.Size(719, 420);
            this.dgv_Invoice.TabIndex = 4;
            this.dgv_Invoice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Invoice.ThemeStyle.ReadOnly = true;
            this.dgv_Invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Invoice.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Invoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Invoice_CellClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dtpDoanhthu);
            this.guna2Panel2.Controls.Add(this.gunaAdvenceButton1);
            this.guna2Panel2.Controls.Add(this.btn_Export_Invoice);
            this.guna2Panel2.Controls.Add(this.txt_Total_Amount);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(8, 428);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(719, 52);
            this.guna2Panel2.TabIndex = 3;
            // 
            // dtpDoanhthu
            // 
            this.dtpDoanhthu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDoanhthu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDoanhthu.BorderThickness = 1;
            this.dtpDoanhthu.CheckedState.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.FillColor = System.Drawing.Color.White;
            this.dtpDoanhthu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtpDoanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoanhthu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtpDoanhthu.HoverState.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.Location = new System.Drawing.Point(3, 8);
            this.dtpDoanhthu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDoanhthu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDoanhthu.Name = "dtpDoanhthu";
            this.dtpDoanhthu.ShadowDecoration.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.Size = new System.Drawing.Size(148, 36);
            this.dtpDoanhthu.TabIndex = 10;
            this.dtpDoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDoanhthu.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::Fahasa_Management_System.Properties.Resources.print;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(158, 8);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(177, 36);
            this.gunaAdvenceButton1.TabIndex = 10;
            this.gunaAdvenceButton1.Text = "Thống kê doang thu";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btn_Export_Invoice
            // 
            this.btn_Export_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Export_Invoice.Animated = true;
            this.btn_Export_Invoice.AnimationHoverSpeed = 0.07F;
            this.btn_Export_Invoice.AnimationSpeed = 0.03F;
            this.btn_Export_Invoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Export_Invoice.BorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Export_Invoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Export_Invoice.CheckedImage")));
            this.btn_Export_Invoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Export_Invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Export_Invoice.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Export_Invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.Image = global::Fahasa_Management_System.Properties.Resources.print;
            this.btn_Export_Invoice.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Export_Invoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.Location = new System.Drawing.Point(341, 8);
            this.btn_Export_Invoice.Name = "btn_Export_Invoice";
            this.btn_Export_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Export_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Export_Invoice.OnHoverImage = null;
            this.btn_Export_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.Size = new System.Drawing.Size(179, 36);
            this.btn_Export_Invoice.TabIndex = 9;
            this.btn_Export_Invoice.Text = "Xem hóa đơn chi tiết";
            this.btn_Export_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Export_Invoice.Click += new System.EventHandler(this.btn_Export_Invoice_Click);
            // 
            // txt_Total_Amount
            // 
            this.txt_Total_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Total_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total_Amount.Enabled = false;
            this.txt_Total_Amount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Total_Amount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Amount.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Total_Amount.Location = new System.Drawing.Point(526, 8);
            this.txt_Total_Amount.Name = "txt_Total_Amount";
            this.txt_Total_Amount.PasswordChar = '\0';
            this.txt_Total_Amount.ReadOnly = true;
            this.txt_Total_Amount.SelectedText = "";
            this.txt_Total_Amount.Size = new System.Drawing.Size(190, 36);
            this.txt_Total_Amount.TabIndex = 8;
            this.txt_Total_Amount.Text = "Tổng tiền: ";
            // 
            // Frm_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(751, 636);
            this.Controls.Add(this.pnl_Invoice_Info);
            this.Controls.Add(this.pnl_Date_);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Invoice";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Invoice";
            this.Load += new System.EventHandler(this.Frm_Invoice_Load);
            this.pnl_Date_.ResumeLayout(false);
            this.pnl_Date_.PerformLayout();
            this.pnl_Invoice_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Date_;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice_Info;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Invoice;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Invoice_Date_From;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Invoice_Date_To;
        private Guna.UI.WinForms.GunaLineTextBox txt_Total_Amount;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Export_Invoice;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox chkB_Access_Invoice;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDoanhthu;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}