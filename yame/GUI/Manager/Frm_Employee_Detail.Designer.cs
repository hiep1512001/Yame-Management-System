
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Employee_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblVitricongviec = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DOB_Error = new Guna.UI.WinForms.GunaLabel();
            this.lbl_BeginDate_Error = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Employee_Phone_Error = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Employee_Name_Error = new Guna.UI.WinForms.GunaLabel();
            this.txt_EmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_Work_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Begin_Date = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DoB = new Guna.UI.WinForms.GunaLabel();
            this.dtp_Day_of_Birth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_Begin_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Employee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Employee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_Employee = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Employee_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.toolTip_Phone = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDOB = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            this.gr_Button.SuspendLayout();
            this.pnl_Employee_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
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
            this.pnl_Detail.TabIndex = 5;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Information.Controls.Add(this.lblVitricongviec);
            this.gr_Information.Controls.Add(this.lbl_DOB_Error);
            this.gr_Information.Controls.Add(this.lbl_BeginDate_Error);
            this.gr_Information.Controls.Add(this.lbl_Employee_Phone_Error);
            this.gr_Information.Controls.Add(this.lbl_Employee_Name_Error);
            this.gr_Information.Controls.Add(this.txt_EmployeeID);
            this.gr_Information.Controls.Add(this.cbo_Work_Type);
            this.gr_Information.Controls.Add(this.txt_Phone);
            this.gr_Information.Controls.Add(this.txt_Address);
            this.gr_Information.Controls.Add(this.txt_Fullname);
            this.gr_Information.Controls.Add(this.lbl_Begin_Date);
            this.gr_Information.Controls.Add(this.lbl_DoB);
            this.gr_Information.Controls.Add(this.dtp_Day_of_Birth);
            this.gr_Information.Controls.Add(this.dtp_Begin_Date);
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
            // lblVitricongviec
            // 
            this.lblVitricongviec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVitricongviec.AutoSize = true;
            this.lblVitricongviec.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitricongviec.ForeColor = System.Drawing.Color.Red;
            this.lblVitricongviec.Location = new System.Drawing.Point(4, 454);
            this.lblVitricongviec.Name = "lblVitricongviec";
            this.lblVitricongviec.Size = new System.Drawing.Size(235, 20);
            this.lblVitricongviec.TabIndex = 25;
            this.lblVitricongviec.Text = "Vị trí công việc không đươc bỏ trống";
            this.lblVitricongviec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVitricongviec.Visible = false;
            // 
            // lbl_DOB_Error
            // 
            this.lbl_DOB_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB_Error.AutoSize = true;
            this.lbl_DOB_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB_Error.Location = new System.Drawing.Point(4, 222);
            this.lbl_DOB_Error.Name = "lbl_DOB_Error";
            this.lbl_DOB_Error.Size = new System.Drawing.Size(205, 20);
            this.lbl_DOB_Error.TabIndex = 23;
            this.lbl_DOB_Error.Text = "Vui lòng nhập Ngày sinh hợp lý";
            this.lbl_DOB_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DOB_Error.Visible = false;
            // 
            // lbl_BeginDate_Error
            // 
            this.lbl_BeginDate_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_BeginDate_Error.AutoSize = true;
            this.lbl_BeginDate_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BeginDate_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_BeginDate_Error.Location = new System.Drawing.Point(4, 392);
            this.lbl_BeginDate_Error.Name = "lbl_BeginDate_Error";
            this.lbl_BeginDate_Error.Size = new System.Drawing.Size(228, 20);
            this.lbl_BeginDate_Error.TabIndex = 22;
            this.lbl_BeginDate_Error.Text = "Vui lòng nhập ngày vào làm hợp lý";
            this.lbl_BeginDate_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BeginDate_Error.Visible = false;
            // 
            // lbl_Employee_Phone_Error
            // 
            this.lbl_Employee_Phone_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Employee_Phone_Error.AutoSize = true;
            this.lbl_Employee_Phone_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Phone_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Phone_Error.Location = new System.Drawing.Point(4, 336);
            this.lbl_Employee_Phone_Error.Name = "lbl_Employee_Phone_Error";
            this.lbl_Employee_Phone_Error.Size = new System.Drawing.Size(259, 20);
            this.lbl_Employee_Phone_Error.TabIndex = 21;
            this.lbl_Employee_Phone_Error.Text = "SĐT không hợp lệ (phải bao gồm 10 số )";
            this.lbl_Employee_Phone_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Employee_Phone_Error.Visible = false;
            // 
            // lbl_Employee_Name_Error
            // 
            this.lbl_Employee_Name_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Employee_Name_Error.AutoSize = true;
            this.lbl_Employee_Name_Error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Name_Error.Location = new System.Drawing.Point(4, 165);
            this.lbl_Employee_Name_Error.Name = "lbl_Employee_Name_Error";
            this.lbl_Employee_Name_Error.Size = new System.Drawing.Size(192, 20);
            this.lbl_Employee_Name_Error.TabIndex = 19;
            this.lbl_Employee_Name_Error.Text = "Tên NV không được bỏ trống";
            this.lbl_Employee_Name_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Employee_Name_Error.Visible = false;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmployeeID.DefaultText = "";
            this.txt_EmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmployeeID.DisabledState.Parent = this.txt_EmployeeID;
            this.txt_EmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmployeeID.Enabled = false;
            this.txt_EmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmployeeID.FocusedState.Parent = this.txt_EmployeeID;
            this.txt_EmployeeID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_EmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_EmployeeID.HoverState.Parent = this.txt_EmployeeID;
            this.txt_EmployeeID.Location = new System.Drawing.Point(7, 66);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.PasswordChar = '\0';
            this.txt_EmployeeID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_EmployeeID.PlaceholderText = "Mã Nhân viên:";
            this.txt_EmployeeID.SelectedText = "";
            this.txt_EmployeeID.ShadowDecoration.Parent = this.txt_EmployeeID;
            this.txt_EmployeeID.Size = new System.Drawing.Size(230, 36);
            this.txt_EmployeeID.TabIndex = 16;
            // 
            // cbo_Work_Type
            // 
            this.cbo_Work_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Work_Type.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Work_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Work_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Work_Type.FocusedColor = System.Drawing.Color.Empty;
            this.cbo_Work_Type.FocusedState.Parent = this.cbo_Work_Type;
            this.cbo_Work_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Work_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Work_Type.FormattingEnabled = true;
            this.cbo_Work_Type.HoverState.Parent = this.cbo_Work_Type;
            this.cbo_Work_Type.ItemHeight = 30;
            this.cbo_Work_Type.ItemsAppearance.Parent = this.cbo_Work_Type;
            this.cbo_Work_Type.Location = new System.Drawing.Point(7, 415);
            this.cbo_Work_Type.Name = "cbo_Work_Type";
            this.cbo_Work_Type.ShadowDecoration.Parent = this.cbo_Work_Type;
            this.cbo_Work_Type.Size = new System.Drawing.Size(230, 36);
            this.cbo_Work_Type.TabIndex = 11;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.Parent = this.txt_Phone;
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.FocusedState.Parent = this.txt_Phone;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Phone.HoverState.Parent = this.txt_Phone;
            this.txt_Phone.Location = new System.Drawing.Point(7, 297);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Phone.PlaceholderText = "Số điện thoại:";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.ShadowDecoration.Parent = this.txt_Phone;
            this.txt_Phone.Size = new System.Drawing.Size(230, 36);
            this.txt_Phone.TabIndex = 10;
            this.toolTip_Phone.SetToolTip(this.txt_Phone, "Chỉ nhập vào số từ 0 đến 9. Độ dài 10 kí tự.");
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.Parent = this.txt_Address;
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.FocusedState.Parent = this.txt_Address;
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Address.HoverState.Parent = this.txt_Address;
            this.txt_Address.Location = new System.Drawing.Point(7, 240);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Address.PlaceholderText = "Địa chỉ:";
            this.txt_Address.SelectedText = "";
            this.txt_Address.ShadowDecoration.Parent = this.txt_Address;
            this.txt_Address.Size = new System.Drawing.Size(230, 36);
            this.txt_Address.TabIndex = 9;
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fullname.DefaultText = "";
            this.txt_Fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fullname.DisabledState.Parent = this.txt_Fullname;
            this.txt_Fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Fullname.FocusedState.Parent = this.txt_Fullname;
            this.txt_Fullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_Fullname.HoverState.Parent = this.txt_Fullname;
            this.txt_Fullname.Location = new System.Drawing.Point(7, 123);
            this.txt_Fullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.PasswordChar = '\0';
            this.txt_Fullname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Fullname.PlaceholderText = "Họ và tên:";
            this.txt_Fullname.SelectedText = "";
            this.txt_Fullname.ShadowDecoration.Parent = this.txt_Fullname;
            this.txt_Fullname.Size = new System.Drawing.Size(230, 36);
            this.txt_Fullname.TabIndex = 8;
            // 
            // lbl_Begin_Date
            // 
            this.lbl_Begin_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Begin_Date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Begin_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Begin_Date.Location = new System.Drawing.Point(3, 354);
            this.lbl_Begin_Date.Name = "lbl_Begin_Date";
            this.lbl_Begin_Date.Size = new System.Drawing.Size(105, 36);
            this.lbl_Begin_Date.TabIndex = 7;
            this.lbl_Begin_Date.Text = "Ngày vào làm: ";
            this.lbl_Begin_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_DoB.Location = new System.Drawing.Point(8, 183);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(100, 36);
            this.lbl_DoB.TabIndex = 6;
            this.lbl_DoB.Text = "Ngày sinh:";
            this.lbl_DoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Day_of_Birth
            // 
            this.dtp_Day_of_Birth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Day_of_Birth.Animated = true;
            this.dtp_Day_of_Birth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Day_of_Birth.BorderThickness = 1;
            this.dtp_Day_of_Birth.CheckedState.Parent = this.dtp_Day_of_Birth;
            this.dtp_Day_of_Birth.FillColor = System.Drawing.Color.White;
            this.dtp_Day_of_Birth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Day_of_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Day_of_Birth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Day_of_Birth.HoverState.Parent = this.dtp_Day_of_Birth;
            this.dtp_Day_of_Birth.Location = new System.Drawing.Point(110, 183);
            this.dtp_Day_of_Birth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Day_of_Birth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Day_of_Birth.Name = "dtp_Day_of_Birth";
            this.dtp_Day_of_Birth.ShadowDecoration.Parent = this.dtp_Day_of_Birth;
            this.dtp_Day_of_Birth.Size = new System.Drawing.Size(127, 36);
            this.dtp_Day_of_Birth.TabIndex = 4;
            this.dtp_Day_of_Birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipDOB.SetToolTip(this.dtp_Day_of_Birth, "Chọn ngày sinh (Nhân viên phải đủ 18 tuổi)");
            this.dtp_Day_of_Birth.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            this.dtp_Day_of_Birth.ValueChanged += new System.EventHandler(this.dtp_Day_of_Birth_ValueChanged);
            // 
            // dtp_Begin_Date
            // 
            this.dtp_Begin_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Begin_Date.Animated = true;
            this.dtp_Begin_Date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Begin_Date.BorderThickness = 1;
            this.dtp_Begin_Date.CheckedState.Parent = this.dtp_Begin_Date;
            this.dtp_Begin_Date.FillColor = System.Drawing.Color.White;
            this.dtp_Begin_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Begin_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Begin_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dtp_Begin_Date.HoverState.Parent = this.dtp_Begin_Date;
            this.dtp_Begin_Date.Location = new System.Drawing.Point(110, 354);
            this.dtp_Begin_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Begin_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Begin_Date.Name = "dtp_Begin_Date";
            this.dtp_Begin_Date.ShadowDecoration.Parent = this.dtp_Begin_Date;
            this.dtp_Begin_Date.Size = new System.Drawing.Size(127, 36);
            this.dtp_Begin_Date.TabIndex = 3;
            this.dtp_Begin_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Begin_Date.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_Button.Controls.Add(this.btnDatlai);
            this.gr_Button.Controls.Add(this.btn_Delete_Employee);
            this.gr_Button.Controls.Add(this.btn_Update_Employee);
            this.gr_Button.Controls.Add(this.btn_Add_Employee);
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
            this.btnDatlai.Location = new System.Drawing.Point(129, 35);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnDatlai.OnHoverImage = null;
            this.btnDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatlai.Size = new System.Drawing.Size(108, 36);
            this.btnDatlai.TabIndex = 6;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDatlai.TextOffsetX = 12;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
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
            this.btn_Delete_Employee.Location = new System.Drawing.Point(129, 77);
            this.btn_Delete_Employee.Name = "btn_Delete_Employee";
            this.btn_Delete_Employee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Delete_Employee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Delete_Employee.OnHoverImage = null;
            this.btn_Delete_Employee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Employee.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Employee.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Employee.TabIndex = 5;
            this.btn_Delete_Employee.Text = "Xóa";
            this.btn_Delete_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Employee.TextOffsetX = 24;
            this.btn_Delete_Employee.Click += new System.EventHandler(this.btn_Delete_Employee_Click);
            // 
            // btn_Update_Employee
            // 
            this.btn_Update_Employee.Animated = true;
            this.btn_Update_Employee.AnimationHoverSpeed = 0.07F;
            this.btn_Update_Employee.AnimationSpeed = 0.03F;
            this.btn_Update_Employee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Update_Employee.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_Employee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Update_Employee.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Employee.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Update_Employee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Update_Employee.CheckedImage")));
            this.btn_Update_Employee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Update_Employee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update_Employee.Enabled = false;
            this.btn_Update_Employee.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update_Employee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Employee.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btn_Update_Employee.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Update_Employee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Employee.Location = new System.Drawing.Point(7, 77);
            this.btn_Update_Employee.Name = "btn_Update_Employee";
            this.btn_Update_Employee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Update_Employee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Employee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Update_Employee.OnHoverImage = null;
            this.btn_Update_Employee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Employee.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Employee.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Employee.TabIndex = 4;
            this.btn_Update_Employee.Text = "Sửa";
            this.btn_Update_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update_Employee.TextOffsetX = 24;
            this.btn_Update_Employee.Click += new System.EventHandler(this.btn_Update_Employee_Click);
            this.btn_Update_Employee.DoubleClick += new System.EventHandler(this.btn_Update_Employee_DoubleClick);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.Animated = true;
            this.btn_Add_Employee.AnimationHoverSpeed = 0.07F;
            this.btn_Add_Employee.AnimationSpeed = 0.03F;
            this.btn_Add_Employee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Employee.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_Employee.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_Employee.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Employee.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_Employee.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_Employee.CheckedImage")));
            this.btn_Add_Employee.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_Employee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_Employee.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_Employee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Employee.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_Employee.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_Employee.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Employee.Location = new System.Drawing.Point(7, 35);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Add_Employee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Employee.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btn_Add_Employee.OnHoverImage = null;
            this.btn_Add_Employee.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Employee.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_Employee.Size = new System.Drawing.Size(108, 36);
            this.btn_Add_Employee.TabIndex = 3;
            this.btn_Add_Employee.Text = "Thêm ";
            this.btn_Add_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_Employee.TextOffsetX = 16;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // pnl_Employee_Info
            // 
            this.pnl_Employee_Info.Controls.Add(this.dgv_Employee);
            this.pnl_Employee_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Employee_Info.Location = new System.Drawing.Point(268, 8);
            this.pnl_Employee_Info.Name = "pnl_Employee_Info";
            this.pnl_Employee_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Employee_Info.ShadowDecoration.Parent = this.pnl_Employee_Info;
            this.pnl_Employee_Info.Size = new System.Drawing.Size(468, 620);
            this.pnl_Employee_Info.TabIndex = 6;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Employee.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 20, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Employee.EnableHeadersVisualStyles = false;
            this.dgv_Employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Employee.Location = new System.Drawing.Point(8, 8);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee.RowHeadersVisible = false;
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 28;
            this.dgv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Employee.Size = new System.Drawing.Size(452, 604);
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
            this.dgv_Employee.ThemeStyle.ReadOnly = true;
            this.dgv_Employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Employee.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellClick);
            // 
            // toolTip_Phone
            // 
            this.toolTip_Phone.AutoPopDelay = 5000;
            this.toolTip_Phone.InitialDelay = 500;
            this.toolTip_Phone.ReshowDelay = 0;
            this.toolTip_Phone.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Frm_Employee_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(744, 636);
            this.Controls.Add(this.pnl_Employee_Info);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Employee_Detail";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Employee_Detail";
            this.Load += new System.EventHandler(this.Frm_Employee_Detail_Load);
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Employee_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Begin_Date;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Employee;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Employee;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Employee;
        private Guna.UI2.WinForms.Guna2Panel pnl_Employee_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Employee;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Day_of_Birth;
        private Guna.UI.WinForms.GunaLabel lbl_Begin_Date;
        private Guna.UI.WinForms.GunaLabel lbl_DoB;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private Guna.UI2.WinForms.Guna2TextBox txt_Fullname;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private System.Windows.Forms.ToolTip toolTip_Phone;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Work_Type;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmployeeID;
        private Guna.UI.WinForms.GunaLabel lbl_DOB_Error;
        private Guna.UI.WinForms.GunaLabel lbl_BeginDate_Error;
        private Guna.UI.WinForms.GunaLabel lbl_Employee_Phone_Error;
        private Guna.UI.WinForms.GunaLabel lbl_Employee_Name_Error;
        private System.Windows.Forms.ToolTip toolTipDOB;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatlai;
        private Guna.UI.WinForms.GunaLabel lblVitricongviec;
    }
}