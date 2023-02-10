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

namespace Fahasa_Management_System.GUI.Employee
{
    public partial class Frm_Product : Form
    {
        public Frm_Product()
        {
            InitializeComponent();
        }

        public DataTable SetupDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã SP", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Tên SP", System.Type.GetType("System.String"));
            dt.Columns.Add("Thuộc nhóm SP", System.Type.GetType("System.String"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Giá bán", System.Type.GetType("System.Int32"));
            return dt;
        }
        void ThemdgvProduct()
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<PRODUCTSIZE> listChitiesize = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                foreach (PRODUCTSIZE b in listChitiesize)
                {
                    int masize = 0;
                    string Tensize = "";
                    int soluong = 0;
                    if (a.MASP == b.MASP)
                    {
                        masize = b.MASIZE;
                        soluong = b.SOLUONG;
                        foreach (SIZE c in listSize)
                        {
                            if (c.MASIZE == masize)
                            {
                                Tensize = c.TENSIZE;
                            }
                        }
                        dt.Rows.Add(new object[] { a.MASP, a.TENSP, cbo_Product_Type.Text, Tensize, soluong, a.GIABAN });
                    }
                }
            }
            dgv_Product.DataSource = dt;
        }
        void ThemdgvSanpham(int manhom)
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<PRODUCTSIZE> listChitiesize = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                if (a.MANHOM == manhom)
                {
                    foreach (PRODUCTSIZE b in listChitiesize)
                    {
                        int masize = 0;
                        string Tensize = "";
                        int soluong = 0;
                        if (a.MASP == b.MASP)
                        {
                            masize = b.MASIZE;
                            soluong = b.SOLUONG;
                            foreach (SIZE c in listSize)
                            {
                                if (c.MASIZE == masize)
                                {
                                    Tensize = c.TENSIZE;
                                }
                            }
                            dt.Rows.Add(new object[] { a.MASP, a.TENSP, cbo_Product_Type.Text, Tensize, soluong,a.GIABAN });
                        }
                    }
                }
            }
            dgv_Product.DataSource = dt;
        }
        void ThemcboLaoisp()
        {
            YameContextDB cont = new YameContextDB();
            List<NHOM> listNhomsp = cont.NHOMs.ToList();
            foreach (NHOM a in listNhomsp)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
        }
        private void txt_Find_Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //
                //Search Function
                //
            }
        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            ThemdgvProduct();
            ThemcboLaoisp();
        }

        private void txt_Find_Product_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_Find_Product.Text.Trim();
            YameContextDB contextDB = new YameContextDB();
            List<SANPHAM> listPd = new List<SANPHAM>();
            List<SANPHAM> products = contextDB.SANPHAMs.ToList();
            foreach (SANPHAM product in products)
            {
                if (product.TENSP.Contains(keyWord))
                {
                    listPd.Add(product);
                }
            }
            LoadDB(listPd);
            cbo_Product_Type.Text = "Loại Sản phẩm:";
        }
        void LoadDB(List<SANPHAM> listsp)
        {
            DataTable dt = SetupDataTable();
            dt.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<PRODUCTSIZE> listChitiesize = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SANPHAM a in listsp)
            {
                foreach (PRODUCTSIZE b in listChitiesize)
                {
                    int masize = 0;
                    string Tensize = "";
                    int soluong = 0;
                    if (a.MASP == b.MASP)
                    {
                        masize = b.MASIZE;
                        soluong = b.SOLUONG;
                        foreach (SIZE c in listSize)
                        {
                            if (c.MASIZE == masize)
                            {
                                Tensize = c.TENSIZE;
                            }
                        }
                        dt.Rows.Add(new object[] { a.MASP, a.TENSP, cbo_Product_Type.Text, Tensize, soluong, a.GIABAN });
                    }
                }
            }
            dgv_Product.DataSource = dt;
        }
        void Loctheogia(int tu, int den)
        {
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            cbo_Product_Type.Text = "Loại Sản phẩm:";
            txt_Find_Product.Text = "";
            DataTable dt = SetupDataTable();
            dt.Clear();
            List<PRODUCTSIZE> listChitiesize = cont.PRODUCTSIZEs.ToList();
            List<SIZE> listSize = cont.SIZEs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                if(tu <= a.GIABAN && a.GIABAN <= den)
                {
                    foreach (PRODUCTSIZE b in listChitiesize)
                    {
                        int masize = 0;
                        string Tensize = "";
                        int soluong = 0;
                        if (a.MASP == b.MASP)
                        {
                            masize = b.MASIZE;
                            soluong = b.SOLUONG;
                            foreach (SIZE c in listSize)
                            {
                                if (c.MASIZE == masize)
                                {
                                    Tensize = c.TENSIZE;
                                }
                            }
                            dt.Rows.Add(new object[] { a.MASP, a.TENSP, cbo_Product_Type.Text, Tensize, soluong, a.GIABAN });
                        }
                    }
                }
            }
            dgv_Product.DataSource = dt;
        }
        private void rdBtn_Price_Type1_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(0, 100000);
        }

        private void rdBtn_Price_Type2_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia( 100000,200000);
        }

        private void rdBtn_Price_Type3_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia( 200000, 300000);
        }

        private void rdBtn_Price_Type4_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(300000,10000000);
        }

        private void cbo_Product_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Loaisp = cbo_Product_Type.Text;
            int Maloai = 0;
            DataTable dtProduct = SetupDataTable();
            dtProduct.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<NHOM> listNhomsp = cont.NHOMs.ToList();
            foreach (NHOM a in listNhomsp)
            {
                if (Loaisp == a.TENNHOM)
                {
                    Maloai = a.MANHOM;
                    break;
                }
            }
            ThemdgvSanpham(Maloai);
        }
    }
}
