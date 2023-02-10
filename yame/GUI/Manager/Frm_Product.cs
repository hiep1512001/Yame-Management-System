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
    public partial class Frm_Product : Form
    {
        public Frm_Product()
        {
            InitializeComponent();
            
        }
        private int isCheckOver()
        {
            int t = 1;
            if (String.IsNullOrEmpty(txt_Product_Name.Text))
            {
                lbl_Product_Name_Error.Visible = true;
                t=0;
            }
            else lbl_Product_Name_Error.Visible = false;
            if (String.IsNullOrEmpty(txt_Sell_Price.Text))
            {
                lbl_Product_Price_Error.Visible = true;
                t=0;
            }
            else lbl_Product_Price_Error.Visible = false;
            if (String.IsNullOrEmpty(cbo_Product_Type.Text))
            {
                lblNhomsp.Visible = true;
                t = 0;
            }
            else lblNhomsp.Visible = false;
            if (String.IsNullOrEmpty(cbo_Material.Text))
            {
                lblChatlieu.Visible = true;
                t = 0;
            }
            else lblChatlieu.Visible = false;
            if (String.IsNullOrEmpty(cbo_Material.Text))
            {
                lblChatlieu.Visible = true;
                t = 0;
            }
            else lblChatlieu.Visible = false;
            if (String.IsNullOrEmpty(cbo_Color.Text))
            {
                lblMausac.Visible = true;
                t = 0;
            }
            else lblMausac.Visible = false;
            if (String.IsNullOrEmpty(cbo_Unit.Text))
            {
                lblDvt.Visible = true;
                t = 0;
            }
            else lblDvt.Visible = false;
            return t;
        }

        public DataTable SetupDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã SP", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Tên SP", System.Type.GetType("System.String"));
            dt.Columns.Add("Màu sắc", System.Type.GetType("System.String"));
            dt.Columns.Add("Chất liệu", System.Type.GetType("System.String"));
            dt.Columns.Add("Giá bán", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("Đơn vị tính", System.Type.GetType("System.String"));
            dt.Columns.Add("Thuộc nhóm SP", System.Type.GetType("System.String"));
            return dt;
        }
        private void Frm_Product_Load(object sender, EventArgs e)
        {
            
            ThemcboChatlieu();
            Themdgvsanpham();
            ThemcboNhomsp();
        }
        void ThemcboChatlieu()
        {
            YameContextDB cont = new YameContextDB();
            List<CHATLIEU> listChatlieu = cont.CHATLIEUx.ToList();
            foreach (CHATLIEU a in listChatlieu)
            {
                cbo_Material.Items.Add(a.TENCL);
            }
            
        }
        void ThemcboNhomsp()
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhom = cont.NHOMs.ToList();
            foreach (NHOM a in listNhom)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
            cbo_Material.StartIndex = 1;
            cbo_Color.StartIndex = 0;
            cbo_Product_Type.StartIndex = 1;
            cbo_Unit.StartIndex = 0;
        }
        private void txt_Buy_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Sell_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void Themdgvsanpham()
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<NHOM> listNhomsp = cont.NHOMs.ToList();
            List<CHATLIEU> listChatlieu = cont.CHATLIEUx.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                string Loaisp = "";
                string Chatlieu = "";
                foreach (NHOM b in listNhomsp)
                {
                    if (a.MANHOM == b.MANHOM)
                    {
                        Loaisp = b.TENNHOM;
                    }
                }
                foreach (CHATLIEU b in listChatlieu)
                {
                    if (a.MANHOM == b.MACL)
                    {
                        Chatlieu = b.TENCL;
                    }
                }
                dt.Rows.Add(new object[] { a.MASP, a.TENSP, a.MAUSAC, Chatlieu, a.GIABAN, a.DVT,Loaisp });
            }
            dgv_Product.DataSource = dt;
        }
        void Themsanpham()
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhomsp = cont.NHOMs.ToList();
            List<CHATLIEU> listChatlieu = cont.CHATLIEUx.ToList();
            if (isCheckOver() == 1)
            {
                SANPHAM a = new SANPHAM();
                a.TENSP = txt_Product_Name.Text;
                a.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                a.MAUSAC = cbo_Color.Text;
                a.DVT = cbo_Unit.Text;
                foreach (NHOM b in listNhomsp)
                {
                    if (cbo_Product_Type.Text == b.TENNHOM)
                    {
                        a.MANHOM = b.MANHOM;
                    }
                }
                foreach (CHATLIEU b in listChatlieu)
                {
                    if (cbo_Material.Text == b.TENCL)
                    {
                        a.MACL = b.MACL;
                    }
                }
                int t = 1;
                List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                foreach (SANPHAM b in listSp)
                {
                    if (a.TENSP == b.TENSP)
                    {
                        MessageBox.Show("Sản phẩm đã có trong kho!");
                        t = 0;
                        ResetControl();
                        break;
                    }
                }
                if (t == 1)
                {
                    using (var db = new YameContextDB())
                    {
                        db.SANPHAMs.Add(a);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    ResetControl();
                }
            }
        }
        private void btn_Add_Update_Product_Click(object sender, EventArgs e)
        {
            Themsanpham();
            Themdgvsanpham();
        }
        private void ResetControl()
        {
            txt_ProductID.Text = "";
            txt_Product_Name.Text = "";
            cbo_Product_Type.Text = "Nhóm SP";
            txt_Sell_Price.Text = "";
            btn_Add_Product.Enabled = true;
            btnDatlai.Enabled = false;
            btn_Update_Product.Enabled = false;
            btn_Delete_Product.Enabled = false;
        }

        private void cbo_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        int Ktxoa(int masp)
        {
            int t = 1;
            YameContextDB cont = new YameContextDB();
            List<CHITIETHOADON> listChitietHoadonsp = cont.CHITIETHOADONs.ToList();
            foreach (CHITIETHOADON a in listChitietHoadonsp)
            {
                if (masp == a.MASP)
                {
                    t = 0;
                }
            }
            List<PRODUCTSIZE> listsize = cont.PRODUCTSIZEs.ToList();
            foreach (PRODUCTSIZE a in listsize)
            {
                if (masp == a.MASP)
                {
                    t = 0;
                }
            }
            return t;
        }
        void Xoa()
        {
            int MaSp = Convert.ToInt32(txt_ProductID.Text.Trim());
            YameContextDB cont = new YameContextDB();
            if (MaSp != 0)
            {
                if (Ktxoa(MaSp) == 1)
                {
                    var delete = (from a in cont.SANPHAMs where (a.MASP == MaSp) select a).Single();
                    cont.SANPHAMs.Remove(delete);
                    cont.SaveChanges();
                    MaSp = 0;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin sản phẩm, vì sản phẩm đã được lưu vào dữ liệu chi tiết hóa đơn sản phẩm và zhi tiết size!\nĐể xóa sản phẩm phải thực hiện xóa dữ liệu trong chi tiết hóa đơn sản phẩm hoặc chi tiết size trước!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btn_Delete_Product_Click(object sender, EventArgs e)
        {
            Xoa();
            Themdgvsanpham();
            ResetControl();
        }

        private void txt_Product_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lbl_Product_Name_Error.Visible = false;
                lbl_Product_Price_Error.Visible = false;
                lblNhomsp.Visible = false;
                lblChatlieu.Visible = false;
                lblChatlieu.Visible = false;
                lblMausac.Visible = false;
                lblDvt.Visible = false;
                txt_ProductID.Text = dgv_Product.Rows[e.RowIndex].Cells["Mã SP"].FormattedValue.ToString();
                txt_Product_Name.Text = dgv_Product.Rows[e.RowIndex].Cells["Tên SP"].FormattedValue.ToString();
                cbo_Product_Type.Text = dgv_Product.Rows[e.RowIndex].Cells["Thuộc nhóm SP"].FormattedValue.ToString();
                txt_Sell_Price.Text = dgv_Product.Rows[e.RowIndex].Cells["Giá bán"].FormattedValue.ToString();
                cbo_Unit.Text= dgv_Product.Rows[e.RowIndex].Cells["Đơn vị tính"].FormattedValue.ToString();
                cbo_Material.Text= dgv_Product.Rows[e.RowIndex].Cells["Chất liệu"].FormattedValue.ToString();
                cbo_Color.Text= dgv_Product.Rows[e.RowIndex].Cells["Màu sắc"].FormattedValue.ToString();
                btn_Add_Product.Enabled = false;
                btnDatlai.Enabled = true;
                btn_Update_Product.Enabled = true;
                btn_Delete_Product.Enabled = true;
            }
        }
        void Sua()
        {
            int MaSp = Convert.ToInt32(txt_ProductID.Text.Trim());
            if (isCheckOver()==1)
            {
                int Manhom = 0;
                int MaCl = 0;
                YameContextDB cont = new YameContextDB();
                List<NHOM> listNhomsp = cont.NHOMs.ToList();
                List<CHATLIEU> listChatlieu = cont.CHATLIEUx.ToList();
                foreach (NHOM b in listNhomsp)
                {
                    if (cbo_Product_Type.Text == b.TENNHOM)
                    {
                        Manhom = b.MANHOM;
                    }
                }
                foreach (CHATLIEU b in listChatlieu)
                {
                    if (cbo_Material.Text == b.TENCL)
                    {
                        MaCl = b.MACL;
                    }
                }
                var update = (from u in cont.SANPHAMs where u.MASP == MaSp select u).Single();
                update.TENSP = txt_Product_Name.Text;
                update.MANHOM = Manhom;
                update.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                update.MACL = MaCl;
                update.DVT = cbo_Unit.Text;
                update.MAUSAC = cbo_Color.Text;
                cont.SaveChanges();
                Manhom = 0;
                MaCl = 0;
                MessageBox.Show("Sửa thành công!");
                ResetControl();
            }
        }
        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Sua();
            Themdgvsanpham();
        }

        private void cbo_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Material_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            ResetControl();
            lbl_Product_Name_Error.Visible = false;
            lbl_Product_Price_Error.Visible = false;
            lblNhomsp.Visible = false;
            lblChatlieu.Visible = false;
            lblChatlieu.Visible = false;
            lblMausac.Visible = false;
            lblDvt.Visible = false;
        }

        private void btnChitietsize_Click(object sender, EventArgs e)
        {
            new frmChitietSize().Show();
        }
    }
}
