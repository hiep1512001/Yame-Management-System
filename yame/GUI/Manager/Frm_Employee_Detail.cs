using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahasa_Management_System.Model;

namespace Fahasa_Management_System.GUI.Manager
{
    public partial class Frm_Employee_Detail : Form
    {
        public Frm_Employee_Detail()
        {
            InitializeComponent();
            
        }

        public DataTable SetupDataTable()
        {
            DataTable dtEmployee = new DataTable("Employee");
            dtEmployee.Columns.Add("Mã nhân viên", System.Type.GetType("System.Int32"));
            dtEmployee.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Công việc", System.Type.GetType("System.String"));
            return dtEmployee;
        }
        private void ResetControl()
        {
            txt_Address.Text = "";
            txt_EmployeeID.Text = "";
            txt_Fullname.Text = "";
            txt_Phone.Text = "";
            cbo_Work_Type.Text = "Vị trí công việc";
/*            dtp_Begin_Date.Value = DateTime.Now;
            dtp_Day_of_Birth.Value = DateTime.Now;*/
            btn_Add_Employee.Enabled = true;
            btnDatlai.Enabled = false;
            btn_Delete_Employee.Enabled = false;
            btn_Update_Employee.Enabled = false;
        }

        private int isCheckOver()
        {
            int t = 1;
            if (String.IsNullOrEmpty(txt_Fullname.Text))
            {
                lbl_Employee_Name_Error.Visible = true;
                t = 0;
            }
            else lbl_Employee_Name_Error.Visible =false;

            if (String.IsNullOrEmpty(txt_Phone.Text) || txt_Phone.Text.Trim().Length < 10)
            {
                lbl_Employee_Phone_Error.Visible = true;
                t = 0;
            }
            else lbl_Employee_Phone_Error.Visible = false;

            if (dtp_Day_of_Birth.Value >= DateTime.Now)
            {
                lbl_DOB_Error.Visible = true;
                t = 0;
            }
            else lbl_DOB_Error.Visible =false;

            if (dtp_Begin_Date.Value >= DateTime.Now)
            {
                lbl_BeginDate_Error.Visible = true;
                t = 0;
            }
            else lbl_BeginDate_Error.Visible =false;
            if (String.IsNullOrEmpty(cbo_Work_Type.Text))
            {
                lblVitricongviec.Visible = true;
                t = 0;
            }
            else lblVitricongviec.Visible = false;
            return t;
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void ThemCboCongviec()
        {
            YameContextDB cont = new YameContextDB();
            List<THONGTINCONGVIEC> listThongtincv = cont.THONGTINCONGVIECs.ToList();
            foreach (THONGTINCONGVIEC a in listThongtincv)
            {
                cbo_Work_Type.Items.Add(a.TENCV);
            }
            cbo_Work_Type.StartIndex = 0;

        }
        private void Frm_Employee_Detail_Load(object sender, EventArgs e)
        {
            dtp_Begin_Date.MaxDate = DateTime.Now;
            dtp_Begin_Date.Value = DateTime.Now;
            dtp_Day_of_Birth.MaxDate = dtp_Begin_Date.MaxDate.AddYears(-18);
            ThemdgvNhanvien();
            ThemCboCongviec();
        }
        void ThemdgvNhanvien()
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont =new YameContextDB();
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
                dt.Rows.Add(new object[] { a.MANV, a.TENNV, a.NGAYSINH.Value.ToShortDateString(), a.DIACHI, a.SDT, a.NGAYVAOLAM.Value.ToShortDateString(), Tencv });
            }
            dgv_Employee.DataSource = dt;
        }
        void ThemNhanvien()
        {
            YameContextDB cont = new YameContextDB();
            List<THONGTINCONGVIEC> listThongtincv = cont.THONGTINCONGVIECs.ToList();
            string Kt = "";
            if (isCheckOver()==1)
            {
                NHANVIEN a = new NHANVIEN();
                a.TENNV = txt_Fullname.Text;
                a.NGAYSINH = dtp_Day_of_Birth.Value;
                a.DIACHI = txt_Address.Text;
                a.SDT = txt_Phone.Text.Trim();
                a.NGAYVAOLAM = dtp_Begin_Date.Value;
                foreach (THONGTINCONGVIEC b in listThongtincv)
                {
                    if (cbo_Work_Type.Text == b.TENCV)
                    {
                        a.MACV = b.MACV;
                    }
                }
                int t = 1;
                List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
                foreach (NHANVIEN b in listNhanvien)
                {
                    if (b.TENNV == a.TENNV && b.SDT.Trim() == a.SDT)
                    {
                        t = 0;
                        MessageBox.Show("Trùng thông tin nhân viên!");
                        break;
                    }
                    if (b.SDT.Trim() == a.SDT)
                    {
                        t = 0;
                        MessageBox.Show("Trùng số điện thoại đã có!");
                        break;
                    }
                }
                if (t == 1)
                {
                    using (var db = new YameContextDB())
                    {
                        db.NHANVIENs.Add(a);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    ResetControl();
                }
            }
        }
        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            ThemNhanvien();
            ThemdgvNhanvien();
        }

        private void dgv_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void SuaNhanvien()
        {
            int MaNV = Convert.ToInt32(txt_EmployeeID.Text.Trim());
            if (isCheckOver()==1)
            {
                int Macv = 0;
                YameContextDB conn = new YameContextDB();
                List<THONGTINCONGVIEC> listThongtincv = conn.THONGTINCONGVIECs.ToList();
                foreach (THONGTINCONGVIEC b in listThongtincv)
                {
                    if (cbo_Work_Type.Text == b.TENCV)
                    {
                        Macv = b.MACV;
                    }
                }
                var update = (from u in conn.NHANVIENs where u.MANV == MaNV select u).Single();
                update.TENNV = txt_Fullname.Text;
                update.NGAYSINH = dtp_Day_of_Birth.Value;
                update.DIACHI = txt_Address.Text;
                update.SDT = txt_Phone.Text.Trim();
                update.NGAYVAOLAM = dtp_Begin_Date.Value;
                update.MACV = Macv;
                conn.SaveChanges();
                Macv = 0;
                MessageBox.Show("Sửa thành công!");
                ResetControl();
            }
        }
        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            SuaNhanvien();
            ThemdgvNhanvien();
        }

        private void btn_Update_Employee_DoubleClick(object sender, EventArgs e)
        {
            
        }
        int Ktxoa(int manv)
        {
            int t = 1;
            YameContextDB cont = new YameContextDB();
            List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
            foreach (CHAMCONG a in listChamcong)
            {
                if (manv == a.MANV)
                {
                    t = 0;
                }
            }
            return t;
        }
        void XoaNhanvien()
        {
            int MaNV = Convert.ToInt32(txt_EmployeeID.Text.Trim());
            YameContextDB cont = new YameContextDB();
            if (MaNV != 0)
            {
                if (Ktxoa(MaNV) == 1)
                {
                    var delete = (from a in cont.NHANVIENs where (a.MANV == MaNV) select a).Single();
                    cont.NHANVIENs.Remove(delete);
                    cont.SaveChanges();
                    MaNV = 0;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin của nhân viên, vì nhân viên đã được tính công!\nĐể xóa nhân viên phải thực hiện xóa chấm công trước!");
                }
            }
        }
        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            XoaNhanvien();
            ThemdgvNhanvien();
            ResetControl();
        }

        private void dtp_Day_of_Birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lbl_Employee_Name_Error.Visible = false;
                lbl_Employee_Phone_Error.Visible = false;
                lbl_DOB_Error.Visible = false;
                lbl_BeginDate_Error.Visible = false;
                lblVitricongviec.Visible = false;
                txt_EmployeeID.Text =dgv_Employee.Rows[e.RowIndex].Cells["Mã nhân viên"].FormattedValue.ToString();               
                txt_Fullname.Text = dgv_Employee.Rows[e.RowIndex].Cells["Tên nhân viên"].FormattedValue.ToString();
                txt_Address.Text = dgv_Employee.Rows[e.RowIndex].Cells["Địa chỉ"].FormattedValue.ToString();
                txt_Phone.Text = dgv_Employee.Rows[e.RowIndex].Cells["Số điện thoại"].FormattedValue.ToString().Trim();
                dtp_Day_of_Birth.Value = Convert.ToDateTime(dgv_Employee.Rows[e.RowIndex].Cells["Ngày sinh"].FormattedValue.ToString());
                dtp_Begin_Date.Value = Convert.ToDateTime(dgv_Employee.Rows[e.RowIndex].Cells["Ngày vào làm"].FormattedValue.ToString());
                cbo_Work_Type.Text = dgv_Employee.Rows[e.RowIndex].Cells["Công việc"].FormattedValue.ToString();
                btn_Add_Employee.Enabled = false;
                btnDatlai.Enabled = true;
                btn_Delete_Employee.Enabled = true;
                btn_Update_Employee.Enabled = true;
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            ResetControl();
            lbl_Employee_Name_Error.Visible = false;
            lbl_Employee_Phone_Error.Visible = false;
            lbl_DOB_Error.Visible = false;
            lbl_BeginDate_Error.Visible = false;
            lblVitricongviec.Visible = false;
        }
    }
}
