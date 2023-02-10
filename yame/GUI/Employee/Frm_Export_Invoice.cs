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
using Fahasa_Management_System.Report;

namespace Fahasa_Management_System.GUI.Employee
{
    public partial class Frm_Export_Invoice : Form
    {
        static public List<Hoadon> listHoadonxuat;
        string Ten = "";
        public Frm_Export_Invoice()
        {
            InitializeComponent();
           
        }
        DataTable Dt;
        public DataTable SetupDataTable()
        {
            DataTable dt = new DataTable("Order");
            dt.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Giá bán", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Thành tiền", System.Type.GetType("System.Int32"));
            return dt;
        }
        void Themcbonhomsp()
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhomsp = cont.NHOMs.ToList();
            foreach (NHOM a in listNhomsp)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
        }

        private void cbo_Book_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Frm_Export_Invoice_Load(object sender, EventArgs e)
        {
            Dt = SetupDataTable();
            dgv_Invoice.DataSource = Dt;
            Themcbonhomsp();
            dtp_Invoice_Date.Value = DateTime.Now;
            dtp_Invoice_Date.MaxDate = DateTime.Now;
        }
        void ThemCbosize(int masp)
        {
            cboSize.Items.Clear();
            YameContextDB cont = new YameContextDB();
            List<PRODUCTSIZE> listSanpham = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (PRODUCTSIZE a in listSanpham)
            {
                if (a.MASP ==masp )
                {
                    string Tensize = "";
                    foreach(SIZE b in listSize)
                    {
                        if (b.MASIZE == a.MASIZE)
                        {
                            Tensize = b.TENSIZE;
                        }
                    }
                    cboSize.Items.Add(Tensize);
                }
            }
        }
        private void cbo_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSize.Text = "Size";
            numUD_Quantity.Maximum = 10000;
            numUD_Quantity.Value = 0;
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            int MaSp = 0;
            foreach (SANPHAM a in listSp)
            {
                if (a.TENSP == cboSanpham.Text)
                {
                    MaSp = a.MASP;
                    break;
                }
            }
            ThemCbosize(MaSp);
        }

        private void dgv_Invoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void numUD_Quantity_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_Add_Invoice_Click(object sender, EventArgs e)
        {
            //int count = Convert.ToInt32(dgv_Invoice.Rows.GetRowCount());
            //for (int i= 0;i)
        }

        private void dgv_Invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void ThemcboSanpham(int manhom)
        {
            cboSanpham.Items.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                if (a.MANHOM == manhom)
                {
                    cboSanpham.Items.Add(a.TENSP);
                }
            }
        }
        private void cbo_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSanpham.Text = "Tên sản phẩm";
            cboSize.Text = "Size";
            numUD_Quantity.Value = 0;
            numUD_Quantity.Maximum = 10000;
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
        int getMasp()
        {
            YameContextDB cont = new YameContextDB();
            int t = 0;
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            foreach (SANPHAM b in listSp)
            {
                if (b.TENSP == cboSanpham.Text)
                {
                    t = b.MASP;
                    break;
                }
            }
            return t;
        }
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            numUD_Quantity.Value = 0;
            numUD_Quantity.Maximum = 10000;
            int Masize = getMasize();
            int Masp = getMasp();
            if(Masp!=0 && Masize != 0)
            {
                YameContextDB cont = new YameContextDB();
                List<PRODUCTSIZE> listpr = cont.PRODUCTSIZEs.ToList();
                foreach(PRODUCTSIZE a in listpr)
                {
                    if (a.MASIZE == Masize && a.MASP == Masp)
                    {
                        numUD_Quantity.Maximum  = a.SOLUONG;
                    }
                }
            }
        }
        private int isCheckOver()
        {
            int t = 1;
            if (cbo_Product_Type.Text == "Loại sản phẩm")
            {
                lblNhomsp.Visible = true;
                t = 0;
            }
            else lblNhomsp.Visible = false;
            if (cboSanpham.Text == "Tên sản phẩm")
            {
                lblSanpham.Visible = true;
                t = 0;
            }
            else lblSanpham.Visible = false;
            if (cboSize.Text == "Size")
            {
                lblSize.Visible = true;
                t = 0;
            }
            else lblSize.Visible = false;
            if (numUD_Quantity.Value == 0)
            {
                lblSoluong.Visible = true;
                t = 0;
            }
            else lblSoluong.Visible = false;
            return t;
        }
        private int isCheckOver1()
        {
            int t = 1;
            if (cboSanpham.Text == "Tên sản phẩm")
            {
                lblSanpham.Visible = true;
                t = 0;
            }
            else lblSanpham.Visible = false;
            if (cboSize.Text == "Size")
            {
                lblSize.Visible = true;
                t = 0;
            }
            else lblSize.Visible = false;
            if (numUD_Quantity.Value == 0)
            {
                lblSoluong.Visible = true;
                t = 0;
            }
            else lblSoluong.Visible = false;
            return t;
        }
        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            if (isCheckOver() == 1)
            {
                int Giaban = 0;
                YameContextDB cont = new YameContextDB();
                List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                foreach (SANPHAM a in listSp)
                {
                    if (a.TENSP == cboSanpham.Text)
                    {
                        Giaban = Convert.ToInt32(a.GIABAN);
                        break;
                    }
                }
                int thanhtien = Giaban * Convert.ToInt32(numUD_Quantity.Value);
                Dt.Rows.Add(new object[] {dtp_Invoice_Date.Value.ToShortDateString(), cboSanpham.Text,cboSize.Text,Giaban,numUD_Quantity.Value,thanhtien });
                ResetControl();
                txt_Total_Amount.Text = Tongtien().ToString()+" VND";
            }
        }
        private void ResetControl()
        {
            cbo_Product_Type.Text = "Loại sản phẩm";
            cboSanpham.Text = "Tên sản phẩm";
            cboSize.Text = "Tên size";
            cboSize.Items.Clear();
            cboSanpham.Items.Clear();
            btn_Add_Product.Enabled = true;
            btnDatlai.Enabled = false;
            btn_Update_Product.Enabled = false;
            btn_Delete_Product.Enabled = false;
            numUD_Quantity.Value = 0;
        }

        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblNhomsp.Visible = false;
                lblSanpham.Visible = false;
                lblSize.Visible = false;
                lblSoluong.Visible = false;
                dtp_Invoice_Date.Value = Convert.ToDateTime(dgv_Invoice.Rows[e.RowIndex].Cells["Ngày lập hóa đơn"].FormattedValue.ToString());
                cboSize.Text = dgv_Invoice.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                Ten= dgv_Invoice.Rows[e.RowIndex].Cells["Tên sản phẩm"].FormattedValue.ToString();
                cboSanpham.Text = dgv_Invoice.Rows[e.RowIndex].Cells["Tên sản phẩm"].FormattedValue.ToString();
                numUD_Quantity.Value = Convert.ToInt32(dgv_Invoice.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                btn_Add_Product.Enabled = false;
                btnDatlai.Enabled = true;
                btn_Update_Product.Enabled = true;
                btn_Delete_Product.Enabled = true;
                cbo_Product_Type.Text= "Loại sản phẩm";
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            ResetControl();
            lblNhomsp.Visible = false;
            lblSanpham.Visible = false;
            lblSize.Visible = false;
            lblSoluong.Visible = false;
        }
        void Sua()
        {
            if (isCheckOver1() == 1)
            {
                if (Ten != "")
                {
                    for (int i = 0; i < dgv_Invoice.RowCount; i++)
                    {
                        if (dgv_Invoice.Rows[i].Cells[1].Value.ToString() == Ten)
                        {
                            dgv_Invoice.Rows[i].Cells[0].Value = dtp_Invoice_Date.Value;
                            dgv_Invoice.Rows[i].Cells[1].Value = cboSanpham.Text;
                            int Giaban = 0;
                            YameContextDB cont = new YameContextDB();
                            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                            foreach (SANPHAM a in listSp)
                            {
                                if (a.TENSP == cboSanpham.Text)
                                {
                                    Giaban = Convert.ToInt32(a.GIABAN);
                                    break;
                                }
                            }
                            int thanhtien = Giaban * Convert.ToInt32(numUD_Quantity.Value);
                            dgv_Invoice.Rows[i].Cells[2].Value = cboSize.Text;
                            dgv_Invoice.Rows[i].Cells[3].Value = Giaban;
                            dgv_Invoice.Rows[i].Cells[4].Value = numUD_Quantity.Value;
                            dgv_Invoice.Rows[i].Cells[5].Value = thanhtien;
                            break;
                        }
                    }
                    Ten = "";
                }
            }
        }
        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Sua();
            txt_Total_Amount.Text = Tongtien().ToString()+" VND";
            ResetControl();
        }
        int Tongtien()
        {
            int t = 0;
            for (int i = 0; i < dgv_Invoice.RowCount; i++)
            {
                t = t + Convert.ToInt32(dgv_Invoice.Rows[i].Cells[5].Value);
            }
            return t;
        }
        void Xoa()
        {
            if (Ten != "")
            {
                for (int i = 0; i < dgv_Invoice.RowCount; i++)
                {
                    if (dgv_Invoice.Rows[i].Cells[1].Value.ToString() == Ten)
                    {
                        dgv_Invoice.Rows.Remove(dgv_Invoice.Rows[i]); break;
                    }
                }
                Ten = "";
            }
        }
        private void btn_Delete_Product_Click(object sender, EventArgs e)
        {
            Xoa();
            ResetControl();
            txt_Total_Amount.Text = Tongtien() + " VND";
        }
        string Ktluu()
        {
            string kt = dgv_Invoice.Rows[0].Cells[0].Value.ToString();
            for (int i = 1; i < dgv_Invoice.RowCount; i++)
            {
                if (kt != dgv_Invoice.Rows[i].Cells[0].Value.ToString())
                    kt = "";
                break;
            }
            return kt;
        }
        void Luu()
        {
            if (Ktluu() != "")
            {
                listHoadonxuat = new List<Hoadon>();
                HOADON a = new HOADON();
                a.NGAYLAPHOADON = Convert.ToDateTime(Ktluu());
                using (var db = new YameContextDB())
                {
                    db.HOADONs.Add(a);
                    db.SaveChanges();
                }
                YameContextDB cont = new YameContextDB();
                List<HOADON> listHoadon = cont.HOADONs.ToList();
                List<CHITIETHOADON> listCTsp = cont.CHITIETHOADONs.ToList();
                int Mahd = 0;
                foreach (HOADON b in listHoadon)
                {
                    int x = 0;
                    if (Ktluu() == b.NGAYLAPHOADON.ToString())
                    {
                        x = b.SOHOADON;
                    }
                    foreach (CHITIETHOADON c in listCTsp)
                    {
                        if (b.SOHOADON == c.SOHD)
                        {
                            x = 0;
                        }
                    }
                    if (x != 0)
                    {
                        Mahd = x;
                    }
                }
                if (Mahd != 0)
                {
                    Hoadon hoadon;
                    for (int i = 0; i < dgv_Invoice.RowCount; i++)
                    {
                        if (dgv_Invoice.Rows[i].Cells[1].Value.ToString() != "")
                        {
                            int Masize = 0;
                            int MaSp = 0;
                            CHITIETHOADON ctsp = new CHITIETHOADON();
                            ctsp.SOHD = Mahd;
                            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                            foreach (SANPHAM b in listSanpham)
                            {
                                if (b.TENSP == dgv_Invoice.Rows[i].Cells[1].Value.ToString())
                                {
                                    ctsp.MASP = b.MASP;
                                    break;
                                }
                            }
                            List<SIZE> listSize = cont.SIZEs.ToList();
                            foreach (SIZE b in listSize)
                            {
                                if (b.TENSIZE == dgv_Invoice.Rows[i].Cells[2].Value.ToString())
                                {
                                    Masize = b.MASIZE;
                                    break;
                                }
                            }
                            MaSp = ctsp.MASP;
                            List<PRODUCTSIZE> listProductsize = cont.PRODUCTSIZEs.ToList();
                            PRODUCTSIZE Xb = new PRODUCTSIZE();
                            foreach (PRODUCTSIZE b in listProductsize)
                            {
                                if (b.MASIZE == Masize && b.MASP == MaSp)
                                {
                                    Xb.MASIZE = Masize;
                                    Xb.MASP = MaSp;
                                    Xb.SOLUONG = b.SOLUONG- Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                                    var delete = (from u in cont.PRODUCTSIZEs where (u.MASP == MaSp && u.MASIZE == Masize) select u).FirstOrDefault();
                                    cont.PRODUCTSIZEs.Remove(delete);
                                    cont.SaveChanges();
                                    using (var db = new YameContextDB())
                                    {
                                        db.PRODUCTSIZEs.Add(Xb);
                                        db.SaveChanges();
                                    }
                                    break;
                                }
                            }
                            ctsp.SOLUONG = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                            using (var db = new YameContextDB())
                            {
                                db.CHITIETHOADONs.Add(ctsp);
                                db.SaveChanges();
                            }
                            hoadon = new Hoadon();
                            hoadon.Mahd = Mahd;
                            hoadon.Ngaylap = (Convert.ToDateTime(dgv_Invoice.Rows[i].Cells[0].Value.ToString())).ToShortDateString();
                            hoadon.Ma = ctsp.MASP;
                            hoadon.Tensp = dgv_Invoice.Rows[i].Cells[1].Value.ToString();
                            hoadon.Giaban = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[3].Value);
                            hoadon.Soluong = Convert.ToInt32(ctsp.SOLUONG);
                            hoadon.Thanhtien = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[5].Value);
                            hoadon.Size = dgv_Invoice.Rows[i].Cells[2].Value.ToString(); ;
                            listHoadonxuat.Add(hoadon);
                        }
                    }
                }
                Dt.Clear();
                dgv_Invoice.DataSource = Dt;
            }
            else
            {
                MessageBox.Show("Ngày nhập phải giống nhau!");
            }
        }
        private void btn_Export_Invoice_Click(object sender, EventArgs e)
        {
            if (dgv_Invoice.RowCount != 0)
            {
                if (Ktluu() != "")
                {
                    DialogResult dlr = MessageBox.Show("Bạn đã chắc chắc sản phẩm cần mua?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlr == DialogResult.OK)
                    {
                        Luu();
                        frmHoadon a = new frmHoadon();
                        a.Show();
                        txt_Total_Amount.Text = Tongtien() + " VND";
                    }
                }
                else
                {
                    MessageBox.Show("Ngày lập hóa đơn phải giống nhau!");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập hóa đơn!");
            }
        }
    }
}
