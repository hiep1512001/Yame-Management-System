
namespace Fahasa_Management_System
{
    partial class frmChitietSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietSize));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboSanpham = new System.Windows.Forms.ComboBox();
            this.cbo_Product_Type = new System.Windows.Forms.ComboBox();
            this.txt_ProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.numUD_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSize = new Guna.UI.WinForms.GunaLabel();
            this.lblSanpham = new Guna.UI.WinForms.GunaLabel();
            this.lblSoluong = new Guna.UI.WinForms.GunaLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gr_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.gr_Button.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 532);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gr_Information);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 409);
            this.panel4.TabIndex = 1;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.Controls.Add(this.cboSize);
            this.gr_Information.Controls.Add(this.cboSanpham);
            this.gr_Information.Controls.Add(this.cbo_Product_Type);
            this.gr_Information.Controls.Add(this.txt_ProductID);
            this.gr_Information.Controls.Add(this.gunaLabel1);
            this.gr_Information.Controls.Add(this.numUD_Quantity);
            this.gr_Information.Controls.Add(this.lblSize);
            this.gr_Information.Controls.Add(this.lblSanpham);
            this.gr_Information.Controls.Add(this.lblSoluong);
            this.gr_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Information.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Information.ForeColor = System.Drawing.Color.White;
            this.gr_Information.Location = new System.Drawing.Point(0, 0);
            this.gr_Information.Name = "gr_Information";
            this.gr_Information.Padding = new System.Windows.Forms.Padding(4);
            this.gr_Information.ShadowDecoration.Parent = this.gr_Information;
            this.gr_Information.Size = new System.Drawing.Size(289, 409);
            this.gr_Information.TabIndex = 6;
            this.gr_Information.Text = "Nhập thông tin";
            this.gr_Information.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // cboSize
            // 
            this.cboSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(34, 243);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(229, 33);
            this.cboSize.TabIndex = 3;
            this.cboSize.Text = "Tên size";
            // 
            // cboSanpham
            // 
            this.cboSanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSanpham.FormattingEnabled = true;
            this.cboSanpham.Location = new System.Drawing.Point(31, 172);
            this.cboSanpham.Name = "cboSanpham";
            this.cboSanpham.Size = new System.Drawing.Size(229, 33);
            this.cboSanpham.TabIndex = 3;
            this.cboSanpham.Text = "Tên sản phẩm";
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.FormattingEnabled = true;
            this.cbo_Product_Type.Location = new System.Drawing.Point(30, 122);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.Size = new System.Drawing.Size(232, 33);
            this.cbo_Product_Type.TabIndex = 3;
            this.cbo_Product_Type.Text = "Loại sản phẩm";
            this.cbo_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Product_Type_SelectedIndexChanged_1);
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
            this.txt_ProductID.Location = new System.Drawing.Point(30, 69);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.PasswordChar = '\0';
            this.txt_ProductID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_ProductID.PlaceholderText = "Mã Sản phẩm:";
            this.txt_ProductID.SelectedText = "";
            this.txt_ProductID.ShadowDecoration.Parent = this.txt_ProductID;
            this.txt_ProductID.Size = new System.Drawing.Size(230, 36);
            this.txt_ProductID.TabIndex = 33;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(29, 318);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(109, 36);
            this.gunaLabel1.TabIndex = 32;
            this.gunaLabel1.Text = "Số lượng:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.numUD_Quantity.Location = new System.Drawing.Point(147, 318);
            this.numUD_Quantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.ShadowDecoration.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Size = new System.Drawing.Size(111, 36);
            this.numUD_Quantity.TabIndex = 31;
            this.numUD_Quantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numUD_Quantity.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Red;
            this.lblSize.Location = new System.Drawing.Point(31, 279);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(105, 20);
            this.lblSize.TabIndex = 30;
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
            this.lblSanpham.Location = new System.Drawing.Point(31, 209);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(145, 20);
            this.lblSanpham.TabIndex = 29;
            this.lblSanpham.Text = "Chưa chọn sản phẩm";
            this.lblSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSanpham.Visible = false;
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.ForeColor = System.Drawing.Color.Red;
            this.lblSoluong.Location = new System.Drawing.Point(116, 356);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(138, 20);
            this.lblSoluong.TabIndex = 22;
            this.lblSoluong.Text = "Chưa nhập số lượng";
            this.lblSoluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoluong.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gr_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 123);
            this.panel3.TabIndex = 0;
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
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(0, 0);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(289, 123);
            this.gr_Button.TabIndex = 5;
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
            this.btnDatlai.Location = new System.Drawing.Point(156, 36);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnDatlai.OnHoverImage = null;
            this.btnDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatlai.Size = new System.Drawing.Size(127, 36);
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
            this.btn_Update_Product.Size = new System.Drawing.Size(139, 36);
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
            this.btn_Delete_Product.Location = new System.Drawing.Point(156, 78);
            this.btn_Delete_Product.Name = "btn_Delete_Product";
            this.btn_Delete_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Delete_Product.OnHoverImage = null;
            this.btn_Delete_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.Size = new System.Drawing.Size(126, 36);
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
            this.btn_Add_Product.Size = new System.Drawing.Size(139, 36);
            this.btn_Add_Product.TabIndex = 4;
            this.btn_Add_Product.Text = "Thêm";
            this.btn_Add_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_Product.TextOffsetX = 10;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Product);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(289, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 532);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Product.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 20, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.Location = new System.Drawing.Point(0, 0);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 28;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(665, 532);
            this.dgv_Product.TabIndex = 2;
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
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietSize_CellClick);
            // 
            // frmChitietSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChitietSize";
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.frmChitietSize_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gr_Button.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Product;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatlai;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Product;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI.WinForms.GunaLabel lblSize;
        private Guna.UI.WinForms.GunaLabel lblSanpham;
        private Guna.UI.WinForms.GunaLabel lblSoluong;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUD_Quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_ProductID;
        private System.Windows.Forms.ComboBox cbo_Product_Type;
        private System.Windows.Forms.ComboBox cboSanpham;
        private System.Windows.Forms.ComboBox cboSize;
    }
}