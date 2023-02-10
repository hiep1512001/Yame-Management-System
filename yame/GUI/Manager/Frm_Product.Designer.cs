
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnChitietsize = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblDvt = new Guna.UI.WinForms.GunaLabel();
            this.lblMausac = new Guna.UI.WinForms.GunaLabel();
            this.lblChatlieu = new Guna.UI.WinForms.GunaLabel();
            this.lblNhomsp = new Guna.UI.WinForms.GunaLabel();
            this.cbo_Material = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_Color = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbo_Unit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Product_Price_Error = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Product_Name_Error = new Guna.UI.WinForms.GunaLabel();
            this.txt_ProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_Product_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Sell_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Product_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Product_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            this.gr_Button.SuspendLayout();
            this.pnl_Product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
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
            this.pnl_Detail.TabIndex = 7;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.Controls.Add(this.btnChitietsize);
            this.gr_Information.Controls.Add(this.lblDvt);
            this.gr_Information.Controls.Add(this.lblMausac);
            this.gr_Information.Controls.Add(this.lblChatlieu);
            this.gr_Information.Controls.Add(this.lblNhomsp);
            this.gr_Information.Controls.Add(this.cbo_Material);
            this.gr_Information.Controls.Add(this.cbo_Color);
            this.gr_Information.Controls.Add(this.cbo_Unit);
            this.gr_Information.Controls.Add(this.lbl_Product_Price_Error);
            this.gr_Information.Controls.Add(this.lbl_Product_Name_Error);
            this.gr_Information.Controls.Add(this.txt_ProductID);
            this.gr_Information.Controls.Add(this.cbo_Product_Type);
            this.gr_Information.Controls.Add(this.txt_Sell_Price);
            this.gr_Information.Controls.Add(this.txt_Product_Name);
            this.gr_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Information.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Information.ForeColor = System.Drawing.Color.White;
            this.gr_Information.Location = new System.Drawing.Point(8, 8);
            this.gr_Information.Name = "gr_Information";
            this.gr_Information.Padding = new System.Windows.Forms.Padding(4);
            this.gr_Information.ShadowDecoration.Parent = this.gr_Information;
            this.gr_Information.Size = new System.Drawing.Size(244, 483);
            this.gr_Information.TabIndex = 5;
            this.gr_Information.Text = "Nhập thông tin";
            this.gr_Information.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // btnChitietsize
            // 
            this.btnChitietsize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChitietsize.Animated = true;
            this.btnChitietsize.AnimationHoverSpeed = 0.07F;
            this.btnChitietsize.AnimationSpeed = 0.03F;
            this.btnChitietsize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnChitietsize.BorderColor = System.Drawing.Color.Black;
            this.btnChitietsize.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChitietsize.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChitietsize.CheckedForeColor = System.Drawing.Color.White;
            this.btnChitietsize.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnChitietsize.CheckedImage")));
            this.btnChitietsize.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChitietsize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChitietsize.FocusedColor = System.Drawing.Color.Empty;
            this.btnChitietsize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietsize.ForeColor = System.Drawing.Color.White;
            this.btnChitietsize.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btnChitietsize.ImageSize = new System.Drawing.Size(32, 32);
            this.btnChitietsize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChitietsize.Location = new System.Drawing.Point(12, 440);
            this.btnChitietsize.Name = "btnChitietsize";
            this.btnChitietsize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnChitietsize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChitietsize.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnChitietsize.OnHoverImage = null;
            this.btnChitietsize.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChitietsize.OnPressedColor = System.Drawing.Color.Black;
            this.btnChitietsize.Size = new System.Drawing.Size(220, 36);
            this.btnChitietsize.TabIndex = 8;
            this.btnChitietsize.Text = "Chi tiết size sản phẩm";
            this.btnChitietsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChitietsize.TextOffsetX = 12;
            this.btnChitietsize.Click += new System.EventHandler(this.btnChitietsize_Click);
            // 
            // lblDvt
            // 
            this.lblDvt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDvt.AutoSize = true;
            this.lblDvt.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvt.ForeColor = System.Drawing.Color.Red;
            this.lblDvt.Location = new System.Drawing.Point(7, 315);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(109, 20);
            this.lblDvt.TabIndex = 31;
            this.lblDvt.Text = "Chưa chọn DVT";
            this.lblDvt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDvt.Visible = false;
            // 
            // lblMausac
            // 
            this.lblMausac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMausac.AutoSize = true;
            this.lblMausac.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMausac.ForeColor = System.Drawing.Color.Red;
            this.lblMausac.Location = new System.Drawing.Point(117, 315);
            this.lblMausac.Name = "lblMausac";
            this.lblMausac.Size = new System.Drawing.Size(135, 20);
            this.lblMausac.TabIndex = 30;
            this.lblMausac.Text = "Chưa chọn màu sắc";
            this.lblMausac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMausac.Visible = false;
            // 
            // lblChatlieu
            // 
            this.lblChatlieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChatlieu.AutoSize = true;
            this.lblChatlieu.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatlieu.ForeColor = System.Drawing.Color.Red;
            this.lblChatlieu.Location = new System.Drawing.Point(8, 263);
            this.lblChatlieu.Name = "lblChatlieu";
            this.lblChatlieu.Size = new System.Drawing.Size(134, 20);
            this.lblChatlieu.TabIndex = 29;
            this.lblChatlieu.Text = "Chưa chọn chất liệu";
            this.lblChatlieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChatlieu.Visible = false;
            // 
            // lblNhomsp
            // 
            this.lblNhomsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhomsp.AutoSize = true;
            this.lblNhomsp.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomsp.ForeColor = System.Drawing.Color.Red;
            this.lblNhomsp.Location = new System.Drawing.Point(8, 206);
            this.lblNhomsp.Name = "lblNhomsp";
            this.lblNhomsp.Size = new System.Drawing.Size(186, 20);
            this.lblNhomsp.TabIndex = 28;
            this.lblNhomsp.Text = "Chưa chọn nhóm sản phẩm";
            this.lblNhomsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhomsp.Visible = false;
            // 
            // cbo_Material
            // 
            this.cbo_Material.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Material.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Material.DisplayMember = "ProductTypeID";
            this.cbo_Material.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Material.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Material.FocusedState.Parent = this.cbo_Material;
            this.cbo_Material.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Material.FormattingEnabled = true;
            this.cbo_Material.HoverState.Parent = this.cbo_Material;
            this.cbo_Material.ItemHeight = 30;
            this.cbo_Material.ItemsAppearance.Parent = this.cbo_Material;
            this.cbo_Material.Location = new System.Drawing.Point(12, 229);
            this.cbo_Material.Name = "cbo_Material";
            this.cbo_Material.ShadowDecoration.Parent = this.cbo_Material;
            this.cbo_Material.Size = new System.Drawing.Size(225, 36);
            this.cbo_Material.TabIndex = 27;
            this.cbo_Material.ValueMember = "ProductTypeID";
            this.cbo_Material.SelectedIndexChanged += new System.EventHandler(this.cbo_Material_SelectedIndexChanged);
            // 
            // cbo_Color
            // 
            this.cbo_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Color.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Color.DisplayMember = "ProductTypeID";
            this.cbo_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Color.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Color.FocusedState.Parent = this.cbo_Color;
            this.cbo_Color.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Color.FormattingEnabled = true;
            this.cbo_Color.HoverState.Parent = this.cbo_Color;
            this.cbo_Color.ItemHeight = 30;
            this.cbo_Color.Items.AddRange(new object[] {
            "Trắng",
            "Vàng",
            "Cam",
            "Đỏ",
            "Đen",
            "Hồng",
            "Xanh rêu",
            "Xanh dương",
            "Nâu",
            "Hồng",
            "Tím"});
            this.cbo_Color.ItemsAppearance.Parent = this.cbo_Color;
            this.cbo_Color.Location = new System.Drawing.Point(124, 286);
            this.cbo_Color.Name = "cbo_Color";
            this.cbo_Color.ShadowDecoration.Parent = this.cbo_Color;
            this.cbo_Color.Size = new System.Drawing.Size(113, 36);
            this.cbo_Color.TabIndex = 26;
            this.cbo_Color.ValueMember = "ProductTypeID";
            // 
            // cbo_Unit
            // 
            this.cbo_Unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Unit.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Unit.DisplayMember = "ProductTypeID";
            this.cbo_Unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Unit.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Unit.FocusedState.Parent = this.cbo_Unit;
            this.cbo_Unit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Unit.FormattingEnabled = true;
            this.cbo_Unit.HoverState.Parent = this.cbo_Unit;
            this.cbo_Unit.ItemHeight = 30;
            this.cbo_Unit.Items.AddRange(new object[] {
            "Đôi",
            "Chiếc",
            "Cái"});
            this.cbo_Unit.ItemsAppearance.Parent = this.cbo_Unit;
            this.cbo_Unit.Location = new System.Drawing.Point(8, 286);
            this.cbo_Unit.Name = "cbo_Unit";
            this.cbo_Unit.ShadowDecoration.Parent = this.cbo_Unit;
            this.cbo_Unit.Size = new System.Drawing.Size(108, 36);
            this.cbo_Unit.TabIndex = 24;
            this.cbo_Unit.ValueMember = "ProductTypeID";
            this.cbo_Unit.SelectedIndexChanged += new System.EventHandler(this.cbo_Unit_SelectedIndexChanged);
            // 
            // lbl_Product_Price_Error
            // 
            this.lbl_Product_Price_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Price_Error.AutoSize = true;
            this.lbl_Product_Price_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Price_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Product_Price_Error.Location = new System.Drawing.Point(8, 379);
            this.lbl_Product_Price_Error.Name = "lbl_Product_Price_Error";
            this.lbl_Product_Price_Error.Size = new System.Drawing.Size(147, 20);
            this.lbl_Product_Price_Error.TabIndex = 22;
            this.lbl_Product_Price_Error.Text = "Vui lòng nhập giá bán";
            this.lbl_Product_Price_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Product_Price_Error.Visible = false;
            // 
            // lbl_Product_Name_Error
            // 
            this.lbl_Product_Name_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Name_Error.AutoSize = true;
            this.lbl_Product_Name_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Product_Name_Error.Location = new System.Drawing.Point(8, 152);
            this.lbl_Product_Name_Error.Name = "lbl_Product_Name_Error";
            this.lbl_Product_Name_Error.Size = new System.Drawing.Size(187, 20);
            this.lbl_Product_Name_Error.TabIndex = 19;
            this.lbl_Product_Name_Error.Text = "Tên SP không được bỏ trống";
            this.lbl_Product_Name_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Product_Name_Error.Visible = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ProductID.Animated = true;
            this.txt_ProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProductID.DefaultText = "";
            this.txt_ProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ProductID.DisabledState.Parent = this.txt_ProductID;
            this.txt_ProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ProductID.Enabled = false;
            this.txt_ProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ProductID.FocusedState.Parent = this.txt_ProductID;
            this.txt_ProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_ProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_ProductID.HoverState.Parent = this.txt_ProductID;
            this.txt_ProductID.Location = new System.Drawing.Point(8, 53);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.PasswordChar = '\0';
            this.txt_ProductID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_ProductID.PlaceholderText = "Mã Sản phẩm:";
            this.txt_ProductID.SelectedText = "";
            this.txt_ProductID.ShadowDecoration.Parent = this.txt_ProductID;
            this.txt_ProductID.Size = new System.Drawing.Size(230, 36);
            this.txt_ProductID.TabIndex = 15;
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Product_Type.DisplayMember = "ProductTypeID";
            this.cbo_Product_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Product_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Product_Type.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Product_Type.FocusedState.Parent = this.cbo_Product_Type;
            this.cbo_Product_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Product_Type.FormattingEnabled = true;
            this.cbo_Product_Type.HoverState.Parent = this.cbo_Product_Type;
            this.cbo_Product_Type.ItemHeight = 30;
            this.cbo_Product_Type.ItemsAppearance.Parent = this.cbo_Product_Type;
            this.cbo_Product_Type.Location = new System.Drawing.Point(8, 170);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.ShadowDecoration.Parent = this.cbo_Product_Type;
            this.cbo_Product_Type.Size = new System.Drawing.Size(230, 36);
            this.cbo_Product_Type.TabIndex = 14;
            this.cbo_Product_Type.ValueMember = "ProductTypeID";
            this.cbo_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Product_Type_SelectedIndexChanged);
            // 
            // txt_Sell_Price
            // 
            this.txt_Sell_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Sell_Price.Animated = true;
            this.txt_Sell_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sell_Price.DefaultText = "";
            this.txt_Sell_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Sell_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Sell_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sell_Price.DisabledState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sell_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sell_Price.FocusedState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Sell_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Sell_Price.HoverState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Location = new System.Drawing.Point(8, 339);
            this.txt_Sell_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Sell_Price.Name = "txt_Sell_Price";
            this.txt_Sell_Price.PasswordChar = '\0';
            this.txt_Sell_Price.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Sell_Price.PlaceholderText = "Giá bán:";
            this.txt_Sell_Price.SelectedText = "";
            this.txt_Sell_Price.ShadowDecoration.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Size = new System.Drawing.Size(230, 36);
            this.txt_Sell_Price.TabIndex = 10;
            this.txt_Sell_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sell_Price_KeyPress);
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Product_Name.Animated = true;
            this.txt_Product_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Product_Name.DefaultText = "";
            this.txt_Product_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Product_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Product_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Product_Name.DisabledState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Product_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Product_Name.FocusedState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Product_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Product_Name.HoverState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Location = new System.Drawing.Point(8, 112);
            this.txt_Product_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.PasswordChar = '\0';
            this.txt_Product_Name.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Product_Name.PlaceholderText = "Tên Sản phẩm:";
            this.txt_Product_Name.SelectedText = "";
            this.txt_Product_Name.ShadowDecoration.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Size = new System.Drawing.Size(230, 36);
            this.txt_Product_Name.TabIndex = 8;
            this.txt_Product_Name.TextChanged += new System.EventHandler(this.txt_Product_Name_TextChanged);
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Button.Controls.Add(this.btnDatlai);
            this.gr_Button.Controls.Add(this.btn_Update_Product);
            this.gr_Button.Controls.Add(this.btn_Delete_Product);
            this.gr_Button.Controls.Add(this.btn_Add_Product);
            this.gr_Button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Button.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(8, 491);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(244, 121);
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
            this.btnDatlai.Location = new System.Drawing.Point(129, 36);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnDatlai.OnHoverImage = null;
            this.btnDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatlai.Size = new System.Drawing.Size(108, 36);
            this.btnDatlai.TabIndex = 7;
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
            this.btn_Update_Product.Location = new System.Drawing.Point(11, 78);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Update_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Update_Product.OnHoverImage = null;
            this.btn_Update_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Product.TabIndex = 6;
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
            this.btn_Delete_Product.Location = new System.Drawing.Point(129, 78);
            this.btn_Delete_Product.Name = "btn_Delete_Product";
            this.btn_Delete_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Delete_Product.OnHoverImage = null;
            this.btn_Delete_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Product.TabIndex = 5;
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
            this.btn_Add_Product.Location = new System.Drawing.Point(11, 36);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Add_Product.OnHoverImage = null;
            this.btn_Add_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Add_Product.TabIndex = 4;
            this.btn_Add_Product.Text = "Thêm";
            this.btn_Add_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_Product.TextOffsetX = 12;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Update_Product_Click);
            // 
            // pnl_Product_Info
            // 
            this.pnl_Product_Info.Controls.Add(this.dgv_Product);
            this.pnl_Product_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product_Info.Location = new System.Drawing.Point(268, 8);
            this.pnl_Product_Info.Name = "pnl_Product_Info";
            this.pnl_Product_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Product_Info.ShadowDecoration.Parent = this.pnl_Product_Info;
            this.pnl_Product_Info.Size = new System.Drawing.Size(468, 620);
            this.pnl_Product_Info.TabIndex = 8;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Product.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.Location = new System.Drawing.Point(8, 8);
            this.dgv_Product.MultiSelect = false;
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 28;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(452, 604);
            this.dgv_Product.TabIndex = 1;
            this.dgv_Product.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Product.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Product.ThemeStyle.ReadOnly = true;
            this.dgv_Product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Product.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellClick);
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(744, 636);
            this.Controls.Add(this.pnl_Product_Info);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Product";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Product";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Product_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sell_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Product_Name;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Product;
        private Guna.UI2.WinForms.Guna2Panel pnl_Product_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Product;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Product_Type;
        private Guna.UI2.WinForms.Guna2TextBox txt_ProductID;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Product;
        private Guna.UI.WinForms.GunaLabel lbl_Product_Name_Error;
        private Guna.UI.WinForms.GunaLabel lbl_Product_Price_Error;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Material;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Color;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Unit;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatlai;
        private Guna.UI.WinForms.GunaLabel lblChatlieu;
        private Guna.UI.WinForms.GunaLabel lblNhomsp;
        private Guna.UI.WinForms.GunaLabel lblDvt;
        private Guna.UI.WinForms.GunaLabel lblMausac;
        private Guna.UI.WinForms.GunaAdvenceButton btnChitietsize;
    }
}