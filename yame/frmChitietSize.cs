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

namespace Fahasa_Management_System
{
    public partial class frmChitietSize : Form
    {
        public frmChitietSize()
        {
            InitializeComponent();
        }
        private int isCheckOver()
        {
            int t = 1;
            if (cboSanpham.Text=="Tên sản phẩm")
            {
                lblSanpham.Visible = true;
                t = 0;
            }
            else lblSanpham.Visible = false;
            if (cboSize.Text== "Tên size")
            {
                lblSize.Visible = true;
                t = 0;
            }
            else lblSize.Visible = false;
            if (numUD_Quantity.Value==0)
            {
                lblSoluong.Visible = true;
                t = 0;
            }
            else lblSoluong.Visible = false;
            return t;
        }
        public DataTable SetupDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã SP", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Tên SP", System.Type.GetType("System.String"));
            dt.Columns.Add("Thuộc nhóm SP", System.Type.GetType("System.String"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            return dt;
        }
        private void frmChitietSize_Load(object sender, EventArgs e)
        {
            ThemcboNhomsp();
            ThemcboSize();
        }
        void ThemcboNhomsp()
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhom = cont.NHOMs.ToList();
            foreach (NHOM a in listNhom)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
        }
        void ThemcboSize()
        {
            YameContextDB cont = new YameContextDB();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SIZE a in listSize)
            {
                cboSize.Items.Add(a.TENSIZE);
            }
        }
        void ThemcboSanpham(int manhom)
        {
            cboSanpham.Items.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            foreach(SANPHAM a in listSanpham)
            {
                if (a.MANHOM == manhom)
                {
                    cboSanpham.Items.Add(a.TENSP);
                }
            }
        }
        void ThemdgvSanpham(int manhom)
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<PRODUCTSIZE> listChitiesize = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach(SANPHAM a in listSanpham)
            {
                if (a.MANHOM == manhom)
                {
                    foreach(PRODUCTSIZE b in listChitiesize)
                    {
                        int masize = 0;
                        string Tensize = "";
                        int soluong = 0;
                        if (a.MASP == b.MASP)
                        {
                            masize = b.MASIZE;
                            soluong = b.SOLUONG;
                            foreach(SIZE c in listSize)
                            {
                                if (c.MASIZE == masize)
                                {
                                    Tensize = c.TENSIZE;
                                }
                            }
                            dt.Rows.Add(new object[] { a.MASP, a.TENSP, cbo_Product_Type.Text, Tensize, soluong });
                        }
                    }
                }
            }
            dgv_Product.DataSource = dt;
        }
        private void ResetControl()
        {
            txt_ProductID.Text = "";
            cboSanpham.Text = "Tên sản phẩm";
            cboSize.Text = "Tên size";
            btn_Add_Product.Enabled = true;
            btnDatlai.Enabled = false;
            btn_Update_Product.Enabled = false;
            btn_Delete_Product.Enabled = false;
            numUD_Quantity.Value = 0;
            cboSize.Enabled = true;
            cboSanpham.Enabled = true;
            cbo_Product_Type.Enabled = true;
        }
        void Themchitietsize()
        {
            YameContextDB cont = new YameContextDB();
            PRODUCTSIZE a = new PRODUCTSIZE();
            if (isCheckOver() == 1)
            {
                List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                foreach(SANPHAM b in listSanpham)
                {
                    if (b.TENSP == cboSanpham.Text)
                    {
                        a.MASP =b.MASP;
                        break;
                    }
                }
                List<SIZE> listSize = cont.SIZEs.ToList();
                foreach (SIZE b in listSize)
                {
                    if (b.TENSIZE == cboSize.Text)
                    {
                        a.MASIZE = b.MASIZE;
                        break;
                    }
                }
                a.SOLUONG = Convert.ToInt32(numUD_Quantity.Value);
                int t = 1;
                List<PRODUCTSIZE> listProductsize = cont.PRODUCTSIZEs.ToList();
                foreach (PRODUCTSIZE b in listProductsize)
                {
                    if (b.MASIZE ==a.MASIZE && b.MASP == a.MASP)
                    {
                        MessageBox.Show("Sản phẩm đã có trong kho!");
                        t = 0;
                        ResetControl();
                        break;
/*                        DialogResult dlr = MessageBox.Show("Sản phẩm đã có trong kho!\nNhấn OK để tăng số lượng.\nNhấn Hủy bỏ để kết thúc.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlr == DialogResult.OK)
                        {
                            int soluong = a.SOLUONG + b.SOLUONG;
                            var update = (from u in cont.PRODUCTSIZEs where (u.MASP == b.MASP && u.MASIZE == b.MASIZE) select u).;
                            update.SOLUONG = soluong;
                            cont.SaveChanges();
                            t = 0;
                            ResetControl();
                            break;
                        }
                        else
                        {
                            t = 0;
                            ResetControl();
                            break;
                        }*/
                    }
                }
                if (t == 1)
                {
                    using (var db = new YameContextDB())
                    {
                        db.PRODUCTSIZEs.Add(a);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    ResetControl();
                }
            }
        }
        void LoadDb() 
        {

            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhom = cont.NHOMs.ToList();
            int Manhom = 0;
            foreach (NHOM a in listNhom)
            {
                if (a.TENNHOM == cbo_Product_Type.Text)
                {
                    Manhom = a.MANHOM;
                    break;
                }
            }
            ThemdgvSanpham(Manhom);
        }
        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Themchitietsize();
            LoadDb();
        }

        private void cbo_Product_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhom = cont.NHOMs.ToList();
            int Manhom = 0;
            foreach (NHOM a in listNhom)
            {
                if (a.TENNHOM == cbo_Product_Type.Text)
                {
                    Manhom = a.MANHOM;
                    break;
                }
            }
            ThemcboSanpham(Manhom);
            ThemdgvSanpham(Manhom);
        }
        int getMasize()
        {
            YameContextDB cont = new YameContextDB();
            int t = 0;
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SIZE b in listSize)
            {
                if (b.TENSIZE == cboSize.Text)
                {
                    t = b.MASIZE;
                    break;
                }
            }
            return t;
        }
        void Xoa()
        {
            int MaSp = Convert.ToInt32(txt_ProductID.Text.Trim());
            int Masize = getMasize();
            YameContextDB cont = new YameContextDB();
            if (MaSp != 0)
            {
                var delete = (from a in cont.PRODUCTSIZEs where (a.MASP == MaSp && a.MASIZE == Masize) select a).FirstOrDefault();
                cont.PRODUCTSIZEs.Remove(delete);
                cont.SaveChanges();
                MaSp = 0;
                MessageBox.Show("Xóa thành công!");
            }
        }
        private void btn_Delete_Product_Click(object sender, EventArgs e)
        {
            Xoa();
            LoadDb();
            ResetControl();
        }

        private void dgvChitietSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txt_ProductID.Text = dgv_Product.Rows[e.RowIndex].Cells["Mã SP"].FormattedValue.ToString();
                cboSanpham.Text = dgv_Product.Rows[e.RowIndex].Cells["Tên SP"].FormattedValue.ToString();
                cbo_Product_Type.Text = dgv_Product.Rows[e.RowIndex].Cells["Thuộc nhóm SP"].FormattedValue.ToString();
                cboSize.Text = dgv_Product.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                numUD_Quantity.Value = Convert.ToInt32(dgv_Product.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                btn_Add_Product.Enabled = false;
                btnDatlai.Enabled = true;
                btn_Update_Product.Enabled = true;
                btn_Delete_Product.Enabled = true;
                cboSize.Enabled = false;
                cboSanpham.Enabled = false;
                cbo_Product_Type.Enabled = false;
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            ResetControl();
            lblSanpham.Visible = false;
            lblSize.Visible = false;
            lblSoluong.Visible = false;
        }
        void Sua()
        {
            int MaSp = Convert.ToInt32(txt_ProductID.Text.Trim());
            int Masize = getMasize();
            YameContextDB cont = new YameContextDB();
            List<PRODUCTSIZE> listProductsize = cont.PRODUCTSIZEs.ToList();
            PRODUCTSIZE Xb = new PRODUCTSIZE();
            foreach (PRODUCTSIZE b in listProductsize)
            {
                if (b.MASIZE ==Masize && b.MASP == MaSp)
                {
                    Xb.MASIZE = Masize;
                    Xb.MASP = MaSp;
                    Xb.SOLUONG =Convert.ToInt32( numUD_Quantity.Value);
                    var delete = (from a in cont.PRODUCTSIZEs where (a.MASP == MaSp && a.MASIZE == Masize) select a).FirstOrDefault();
                    cont.PRODUCTSIZEs.Remove(delete);
                    cont.SaveChanges();
                    using (var db = new YameContextDB())
                    {
                        db.PRODUCTSIZEs.Add(Xb);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    ResetControl();
                    ResetControl();
                    break;
                }
            }
        }
        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Sua();
            LoadDb();
            ResetControl();
        }
    }
}
