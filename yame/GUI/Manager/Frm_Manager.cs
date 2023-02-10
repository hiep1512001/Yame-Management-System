using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahasa_Management_System.Model;
using Fahasa_Management_System.GUI.Manager;

namespace Fahasa_Management_System
{
    public partial class Frm_Container : Form
    {
        private DataTable dtEmployee;
        public Frm_Container()
        {
            InitializeComponent();
            InitialForm();
        }

        private void InitialForm()
        {
            this.Text = lbl_Title.Text + " - Fahasa";
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            CustomizeSubMenu();
            ActivateButton(btn_Dashboard);
            //lbl_Num_Of_Type.Text = Book.GetNumOfBooks();
            //lbl_Num_of_SchoolEquip.Text = Product.GetNumOfproduct(1);
            //lbl_Num_of_Toys.Text = Product.GetNumOfproduct(2);
            //lbl_Num_of_Medical.Text = Product.GetNumOfproduct(3);
            //lbl_Num_of_Souvernir.Text = Product.GetNumOfproduct(4);
        }

        private GunaAdvenceButton currentButton;
        private Form activeForm;

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int IPrama);

        private void btn_Close_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Really close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            } 
        }

        private void lbl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        const int _ = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        //Override WndProc Method
        protected override void DefWndProc(ref Message m)
        {
            const int
                HTLEFT = 10,
                HTRIGHT = 11,
                HTTOP = 12,
                HTTOPLEFT = 13,
                HTTOPRIGHT = 14,
                HTBOTTOM = 15,
                HTBOTTOMLEFT = 16,
                HTBOTTOMRIGHT = 17;

            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.DefWndProc(ref m);
            if (m.Msg == 0x0084) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) m.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) m.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) m.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) m.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) m.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) m.Result = (IntPtr)HTBOTTOM;
            }
        }


        private void ActivateCollapse()
        {
            if (pnl_Menu.Width > 200)
            {
                pnl_Menu.Width = 80;
            }
            else
            {
                pnl_Menu.Width = 240;
            }
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (GunaAdvenceButton)sender)
                {
                    DisableButton();
                    currentButton = (GunaAdvenceButton)sender;
                    currentButton.LineLeft = 4;
                    currentButton.ImageSize = new System.Drawing.Size(32, 32);
                    lbl_Title.Text = currentButton.Text;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control button in pnl_Button_Container.Controls)
            {
                if (button.GetType() == typeof(GunaAdvenceButton))
                {
                    currentButton = (GunaAdvenceButton)button;
                    currentButton.LineLeft = 0;
                    currentButton.ImageSize = new System.Drawing.Size(28, 28);
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            pnl_Dashboard.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pnl_Container.Controls.Add(childForm);
            this.pnl_Container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CustomizeSubMenu()
        {
            pnl_Employee_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(pnl_Employee_SubMenu.Visible == true)
                pnl_Employee_SubMenu.Visible = false;
        }

        private void ShowSubMenu(Guna2Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Logo_Nav_Click(object sender, EventArgs e)
        {
            ActivateCollapse();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            FormWindowState formState = this.WindowState;
            if (formState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Padding = new Padding(4);
                btn_Maximize.Image = global::Fahasa_Management_System.Properties.Resources.normal;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btn_Maximize.Image = global::Fahasa_Management_System.Properties.Resources.Maximize;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_Employee);
            if(pnl_Menu.Width==80) pnl_Menu.Width = 240;
            ShowSubMenu(pnl_Employee_SubMenu);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            HideSubMenu();
            ActivateButton(btn_Product);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Invoice(), btn_Report);
            HideSubMenu();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ThemdvgEmployee();
            ActivateButton(btn_Dashboard);
            pnl_Dashboard.Visible = true;
            pnl_Dashboard.BringToFront();
            HideSubMenu();
        }

        private void btn_Employee_Info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Employee_Detail(), btn_Employee);
            HideSubMenu();
        }

        private void btn_Employee_Salary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Attendance(), btn_Employee);
            HideSubMenu();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Really Logout?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    this.Visible = false;
                    new Frm_Login().Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btn_School_Equip_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }

        private void btn_Print_Invoice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Attendance(), btn_Employee);
            btn_Employee.Checked = true;
        }

        private void btn_Toy_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }

        private void btn_Medical_Equipment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }

        private void btn_Souvernir_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }

        private void btn_Book_Detail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Product(), btn_Product);
            btn_Product.Checked = true;
        }
        void ThemdvgEmployee()
        {
            dtEmployee.Clear();
            YameContextDB cont = new YameContextDB();
            List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
            List<THONGTINCONGVIEC> listThongtincv = cont.THONGTINCONGVIECs.ToList();
            foreach (NHANVIEN a in listNhanvien)
            {
                string Tencv = "";
                foreach (THONGTINCONGVIEC b in listThongtincv)
                {
                    if (a.MACV == b.MACV)
                    {
                        Tencv = b.TENCV;
                    }
                }
                dtEmployee.Rows.Add(new object[] { a.MANV, a.TENNV, a.NGAYSINH.Value.ToShortDateString(), a.DIACHI, a.SDT, a.NGAYVAOLAM.Value.ToShortDateString(), Tencv });
            }
            lblAo.Text = laysoluong(1).ToString();
            lblQuan.Text = laysoluong(2).ToString();
            lblTui.Text = laysoluong(3).ToString();
            lblGiay.Text = laysoluong(4).ToString();
            lblPhukien.Text = laysoluong(5).ToString();
        }
        private void Frm_Container_Load(object sender, EventArgs e)
        {
            dtEmployee = new DataTable("dtemployee");
            dtEmployee.Columns.Add("Mã nhân viên", System.Type.GetType("System.Int32"));
            dtEmployee.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Công việc", System.Type.GetType("System.String"));
            ThemdvgEmployee();
            dgv_Employee.DataSource = dtEmployee;
        }
        int laysoluong(int ma)
        {
            int t = 0;
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            foreach(SANPHAM a in listSp)
            {
                if (a.MANHOM == ma)
                {
                    t = t + 1;
                }
            }
            return t;
        }
    }
}
