
namespace Fahasa_Management_System.GUI.Employee
{
    partial class Frm_Export_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Export_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSoluong = new Guna.UI.WinForms.GunaLabel();
            this.dtp_Invoice_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gr_Product = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSize = new Guna.UI.WinForms.GunaLabel();
            this.lblSanpham = new Guna.UI.WinForms.GunaLabel();
            this.lblNhomsp = new Guna.UI.WinForms.GunaLabel();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cbo_Product_Type = new System.Windows.Forms.ComboBox();
            this.cboSanpham = new System.Windows.Forms.ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DoB = new Guna.UI.WinForms.GunaLabel();
            this.numUD_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Export_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Invoice = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Invoice_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Total = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Total_Amount = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            this.gr_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.gr_Button.SuspendLayout();
            this.pnl_Invoice.SuspendLayout();
            this.pnl_Invoice_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.pnl_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.Controls.Add(this.gr_Information);
            this.pnl_Detail.Controls.Add(this.gr_Button);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Detail.Location = new System.Drawing.Point(8, 8);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Detail.ShadowDecoration.Parent = this.pnl_Detail;
            this.pnl_Detail.Size = new System.Drawing.Size(260, 620);
            this.pnl_Detail.TabIndex = 4;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.Controls.Add(this.lblSoluong);
            this.gr_Information.Controls.Add(this.dtp_Invoice_Date);
            this.gr_Information.Controls.Add(this.gr_Product);
            this.gr_Information.Controls.Add(this.gunaLabel1);
            this.gr_Information.Controls.Add(this.lbl_DoB);
            this.gr_Information.Controls.Add(this.numUD_Quantity);
            this.gr_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Information.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Information.ForeColor = System.Drawing.Color.White;
            this.gr_Information.Location = new System.Drawing.Point(8, 8);
            this.gr_Information.Name = "gr_Information";
            this.gr_Information.Padding = new System.Windows.Forms.Padding(4);
            this.gr_Information.ShadowDecoration.Parent = this.gr_Information;
            this.gr_Information.Size = new System.Drawing.Size(244, 426);
            this.gr_Information.TabIndex = 5;
            this.gr_Information.Text = "Nhập thông tin";
            this.gr_Information.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.ForeColor = System.Drawing.Color.Red;
            this.lblSoluong.Location = new System.Drawing.Point(90, 399);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(136, 20);
            this.lblSoluong.TabIndex = 33;
            this.lblSoluong.Text = "Chưa chọn số lượng";
            this.lblSoluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoluong.Visible = false;
            // 
            // dtp_Invoice_Date
            // 
            this.dtp_Invoice_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Invoice_Date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Invoice_Date.BorderThickness = 1;
            this.dtp_Invoice_Date.CheckedState.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.FillColor = System.Drawing.Color.White;
            this.dtp_Invoice_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Invoice_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Invoice_Date.HoverState.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.Location = new System.Drawing.Point(98, 44);
            this.dtp_Invoice_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Invoice_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Invoice_Date.Name = "dtp_Invoice_Date";
            this.dtp_Invoice_Date.ShadowDecoration.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.Size = new System.Drawing.Size(141, 36);
            this.dtp_Invoice_Date.TabIndex = 3;
            this.dtp_Invoice_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Invoice_Date.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // gr_Product
            // 
            this.gr_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gr_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Product.Controls.Add(this.lblSize);
            this.gr_Product.Controls.Add(this.lblSanpham);
            this.gr_Product.Controls.Add(this.lblNhomsp);
            this.gr_Product.Controls.Add(this.cboSize);
            this.gr_Product.Controls.Add(this.cbo_Product_Type);
            this.gr_Product.Controls.Add(this.cboSanpham);
            this.gr_Product.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Product.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Product.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Product.ForeColor = System.Drawing.Color.White;
            this.gr_Product.Location = new System.Drawing.Point(2, 118);
            this.gr_Product.Name = "gr_Product";
            this.gr_Product.ShadowDecoration.Parent = this.gr_Product;
            this.gr_Product.Size = new System.Drawing.Size(241, 218);
            this.gr_Product.TabIndex = 9;
            this.gr_Product.Text = "Sản phẩm";
            this.gr_Product.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Red;
            this.lblSize.Location = new System.Drawing.Point(2, 185);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(105, 20);
            this.lblSize.TabIndex = 32;
            this.lblSize.Text = "Chưa chọn size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSize.Visible = false;
            // 
            // lblSanpham
            // 
            this.lblSanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanpham.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.Red;
            this.lblSanpham.Location = new System.Drawing.Point(1, 135);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(145, 20);
            this.lblSanpham.TabIndex = 31;
            this.lblSanpham.Text = "Chưa chọn sản phẩm";
            this.lblSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSanpham.Visible = false;
            // 
            // lblNhomsp
            // 
            this.lblNhomsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhomsp.AutoSize = true;
            this.lblNhomsp.BackColor = System.Drawing.Color.Transparent;
            this.lblNhomsp.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomsp.ForeColor = System.Drawing.Color.Red;
            this.lblNhomsp.Location = new System.Drawing.Point(5, 80);
            this.lblNhomsp.Name = "lblNhomsp";
            this.lblNhomsp.Size = new System.Drawing.Size(171, 20);
            this.lblNhomsp.TabIndex = 30;
            this.lblNhomsp.Text = "Chưa chọn loại sản phẩm";
            this.lblNhomsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhomsp.Visible = false;
            // 
            // cboSize
            // 
            this.cboSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cboSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cboSize.ItemHeight = 25;
            this.cboSize.Location = new System.Drawing.Point(6, 158);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(230, 33);
            this.cboSize.TabIndex = 7;
            this.cboSize.Text = "Size";
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Product_Type.ItemHeight = 25;
            this.cbo_Product_Type.Location = new System.Drawing.Point(6, 49);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.Size = new System.Drawing.Size(230, 33);
            this.cbo_Product_Type.TabIndex = 6;
            this.cbo_Product_Type.Text = "Loại sản phẩm";
            this.cbo_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Product_Type_SelectedIndexChanged);
            // 
            // cboSanpham
            // 
            this.cboSanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cboSanpham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cboSanpham.ItemHeight = 25;
            this.cboSanpham.Location = new System.Drawing.Point(6, 103);
            this.cboSanpham.Name = "cboSanpham";
            this.cboSanpham.Size = new System.Drawing.Size(230, 33);
            this.cboSanpham.TabIndex = 5;
            this.cboSanpham.Text = "Tên sản phẩm";
            this.cboSanpham.SelectedIndexChanged += new System.EventHandler(this.cbo_Product_Name_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 363);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 36);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Số lượng:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_DoB.Location = new System.Drawing.Point(4, 43);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(102, 36);
            this.lbl_DoB.TabIndex = 7;
            this.lbl_DoB.Text = "Ngày lập:";
            this.lbl_DoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUD_Quantity
            // 
            this.numUD_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.numUD_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUD_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numUD_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numUD_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numUD_Quantity.DisabledState.Parent = this.numUD_Quantity;
            this.numUD_Quantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numUD_Quantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numUD_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numUD_Quantity.FocusedState.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.numUD_Quantity.Location = new System.Drawing.Point(113, 363);
            this.numUD_Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.ShadowDecoration.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Size = new System.Drawing.Size(126, 36);
            this.numUD_Quantity.TabIndex = 6;
            this.numUD_Quantity.TextOffset = new System.Drawing.Point(12, 0);
            this.numUD_Quantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numUD_Quantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numUD_Quantity.ValueChanged += new System.EventHandler(this.numUD_Quantity_ValueChanged);
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Button.Controls.Add(this.btnDatlai);
            this.gr_Button.Controls.Add(this.btn_Update_Product);
            this.gr_Button.Controls.Add(this.btn_Delete_Product);
            this.gr_Button.Controls.Add(this.btn_Add_Product);
            this.gr_Button.Controls.Add(this.btn_Export_Invoice);
            this.gr_Button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Button.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(8, 434);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(244, 178);
            this.gr_Button.TabIndex = 4;
            this.gr_Button.Text = "Tác vụ";
            this.gr_Button.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // btnDatlai
            // 
            this.btnDatlai.Animated = true;
            this.btnDatlai.AnimationHoverSpeed = 0.07F;
            this.btnDatlai.AnimationSpeed = 0.03F;
            this.btnDatlai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDatlai.BorderColor = System.Drawing.Color.Black;
            this.btnDatlai.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDatlai.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.CheckedForeColor = System.Drawing.Color.White;
            this.btnDatlai.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDatlai.CheckedImage")));
            this.btnDatlai.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDatlai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDatlai.Enabled = false;
            this.btnDatlai.FocusedColor = System.Drawing.Color.Empty;
            this.btnDatlai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatlai.ForeColor = System.Drawing.Color.White;
            this.btnDatlai.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btnDatlai.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDatlai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.Location = new System.Drawing.Point(127, 50);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnDatlai.OnHoverImage = null;
            this.btnDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatlai.Size = new System.Drawing.Size(108, 36);
            this.btnDatlai.TabIndex = 11;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDatlai.TextOffsetX = 4;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.Animated = true;
            this.btn_Update_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Update_Product.AnimationSpeed = 0.03F;
            this.btn_Update_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Update_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Update_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Update_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Update_Product.CheckedImage")));
            this.btn_Update_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Update_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update_Product.Enabled = false;
            this.btn_Update_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Product.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btn_Update_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Update_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Product.Location = new System.Drawing.Point(9, 92);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Update_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Update_Product.OnHoverImage = null;
            this.btn_Update_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Product.TabIndex = 10;
            this.btn_Update_Product.Text = "Cập nhật";
            this.btn_Update_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_Delete_Product
            // 
            this.btn_Delete_Product.Animated = true;
            this.btn_Delete_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Delete_Product.AnimationSpeed = 0.03F;
            this.btn_Delete_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Product.CheckedImage")));
            this.btn_Delete_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete_Product.Enabled = false;
            this.btn_Delete_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Product.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btn_Delete_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Delete_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.Location = new System.Drawing.Point(127, 92);
            this.btn_Delete_Product.Name = "btn_Delete_Product";
            this.btn_Delete_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Delete_Product.OnHoverImage = null;
            this.btn_Delete_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Product.TabIndex = 9;
            this.btn_Delete_Product.Text = "Xóa";
            this.btn_Delete_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Product.TextOffsetX = 16;
            this.btn_Delete_Product.Click += new System.EventHandler(this.btn_Delete_Product_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Animated = true;
            this.btn_Add_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Add_Product.AnimationSpeed = 0.03F;
            this.btn_Add_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_Product.CheckedImage")));
            this.btn_Add_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Product.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Product.Location = new System.Drawing.Point(9, 50);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Add_Product.OnHoverImage = null;
            this.btn_Add_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Add_Product.TabIndex = 8;
            this.btn_Add_Product.Text = "Thêm";
            this.btn_Add_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_Product.TextOffsetX = 12;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // btn_Export_Invoice
            // 
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
            this.btn_Export_Invoice.Location = new System.Drawing.Point(8, 138);
            this.btn_Export_Invoice.Name = "btn_Export_Invoice";
            this.btn_Export_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Export_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Export_Invoice.OnHoverImage = null;
            this.btn_Export_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.Size = new System.Drawing.Size(230, 36);
            this.btn_Export_Invoice.TabIndex = 6;
            this.btn_Export_Invoice.Text = "Xuất HĐ";
            this.btn_Export_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Export_Invoice.TextOffsetX = 20;
            this.btn_Export_Invoice.Click += new System.EventHandler(this.btn_Export_Invoice_Click);
            // 
            // pnl_Invoice
            // 
            this.pnl_Invoice.Controls.Add(this.pnl_Invoice_Info);
            this.pnl_Invoice.Controls.Add(this.pnl_Total);
            this.pnl_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice.Location = new System.Drawing.Point(268, 8);
            this.pnl_Invoice.Name = "pnl_Invoice";
            this.pnl_Invoice.ShadowDecoration.Parent = this.pnl_Invoice;
            this.pnl_Invoice.Size = new System.Drawing.Size(468, 620);
            this.pnl_Invoice.TabIndex = 5;
            // 
            // pnl_Invoice_Info
            // 
            this.pnl_Invoice_Info.Controls.Add(this.dgv_Invoice);
            this.pnl_Invoice_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice_Info.Location = new System.Drawing.Point(0, 0);
            this.pnl_Invoice_Info.Name = "pnl_Invoice_Info";
            this.pnl_Invoice_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Invoice_Info.ShadowDecoration.Parent = this.pnl_Invoice_Info;
            this.pnl_Invoice_Info.Size = new System.Drawing.Size(468, 572);
            this.pnl_Invoice_Info.TabIndex = 5;
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
            this.dgv_Invoice.Size = new System.Drawing.Size(452, 556);
            this.dgv_Invoice.TabIndex = 1;
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
            // pnl_Total
            // 
            this.pnl_Total.Controls.Add(this.gunaLabel2);
            this.pnl_Total.Controls.Add(this.txt_Total_Amount);
            this.pnl_Total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Total.Location = new System.Drawing.Point(0, 572);
            this.pnl_Total.Name = "pnl_Total";
            this.pnl_Total.ShadowDecoration.Parent = this.pnl_Total;
            this.pnl_Total.Size = new System.Drawing.Size(468, 48);
            this.pnl_Total.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel2.Location = new System.Drawing.Point(51, 6);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(83, 36);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Tổng tiền:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Total_Amount
            // 
            this.txt_Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Total_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Total_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total_Amount.Enabled = false;
            this.txt_Total_Amount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Total_Amount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Amount.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Total_Amount.Location = new System.Drawing.Point(140, 6);
            this.txt_Total_Amount.Name = "txt_Total_Amount";
            this.txt_Total_Amount.PasswordChar = '\0';
            this.txt_Total_Amount.ReadOnly = true;
            this.txt_Total_Amount.SelectedText = "";
            this.txt_Total_Amount.Size = new System.Drawing.Size(277, 36);
            this.txt_Total_Amount.TabIndex = 0;
            this.txt_Total_Amount.Text = "0 VND";
            // 
            // Frm_Export_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(744, 636);
            this.Controls.Add(this.pnl_Invoice);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Export_Invoice";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Export_Invoice";
            this.Load += new System.EventHandler(this.Frm_Export_Invoice_Load);
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            this.gr_Product.ResumeLayout(false);
            this.gr_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Invoice.ResumeLayout(false);
            this.pnl_Invoice_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            this.pnl_Total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice;
        private Guna.UI2.WinForms.Guna2Panel pnl_Total;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Invoice;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Export_Invoice;
        private Guna.UI.WinForms.GunaLineTextBox txt_Total_Amount;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Product;
        private System.Windows.Forms.ComboBox cboSanpham;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_DoB;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUD_Quantity;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Invoice_Date;
        private System.Windows.Forms.ComboBox cbo_Product_Type;
        private System.Windows.Forms.ComboBox cboSize;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatlai;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Product;
        private Guna.UI.WinForms.GunaLabel lblSoluong;
        private Guna.UI.WinForms.GunaLabel lblSize;
        private Guna.UI.WinForms.GunaLabel lblSanpham;
        private Guna.UI.WinForms.GunaLabel lblNhomsp;
    }
}