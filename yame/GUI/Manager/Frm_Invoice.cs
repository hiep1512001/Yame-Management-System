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
using Fahasa_Management_System.Report;

namespace Fahasa_Management_System.GUI.Manager
{
    public partial class Frm_Invoice : Form
    {
        static public List<Hoadon> listDHchitiet;
        static public List<Doanthungay> listDoanhthu;
        private int Sohd = 0;
        private DataTable dtInvoice;
        public Frm_Invoice()
        {
            InitializeComponent();
/*            dtp_Invoice_Date_From.Value = DateTime.Now;
            dtp_Invoice_Date_To.Value = DateTime.Now;
            dtp_Invoice_Date_From.MaxDate = DateTime.Now;
            dtp_Invoice_Date_To.MaxDate = DateTime.Now;*/
        }

        private void Frm_Invoice_Load(object sender, EventArgs e)
        {
            dtInvoice = new DataTable("dtinvoice");
            dtInvoice.Columns.Add("Mã hóa đơn", System.Type.GetType("System.Int32"));
            dtInvoice.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dtInvoice.Columns.Add("Thành tiền", System.Type.GetType("System.Int32"));
            dgv_Invoice.DataSource = dtInvoice;
            txt_Total_Amount.Text = "Tổng tiền: 0 VND";
            ThemdgvInvoice();
        }
        void ThemdgvInvoice()
        {
            dtInvoice.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADON> listCTHoadonsp = cont.CHITIETHOADONs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            foreach (HOADON a in listHoadon)
            {
                int Thanhtien = 0;
                foreach (CHITIETHOADON b in listCTHoadonsp)
                {
                    int masp = 0;
                    if (a.SOHOADON == b.SOHD)
                    {
                        masp = b.MASP;
                    }
                    int giaban = 0;
                    foreach (SANPHAM c in listSanpham)
                    {
                        if (masp == c.MASP)
                        {
                            giaban = Convert.ToInt32(c.GIABAN);
                        }
                    }
                    Thanhtien = Thanhtien + giaban * Convert.ToInt32(b.SOLUONG);
                }
                dtInvoice.Rows.Add(new object[] {a.SOHOADON, a.NGAYLAPHOADON, Thanhtien });
            }
            txt_Total_Amount.Text = "Tổng tiền: " + Tongtien().ToString() + " VND";
        }
        int Tongtien()
        {
            int t = 0;
            for (int i = 0; i < dgv_Invoice.RowCount; i++)
            {
                t = t + Convert.ToInt32(dgv_Invoice.Rows[i].Cells[2].Value);
            }
            return t;
        }

        private void chkB_Access_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Access_Invoice.Checked == true)
            {
                dtp_Invoice_Date_From.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtp_Invoice_Date_To.Value = dtp_Invoice_Date_From.Value.AddMonths(1).AddDays(-1);
                Hienthitheongay();
            }
            else
            {
                ThemdgvInvoice();
            }
        }
        void Hienthitheongay()
        {
            dtInvoice.Clear();
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADON> listCTHoadonsp = cont.CHITIETHOADONs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            foreach (HOADON a in listHoadon)
            {
                if (a.NGAYLAPHOADON <= dtp_Invoice_Date_To.Value && a.NGAYLAPHOADON >= dtp_Invoice_Date_From.Value)
                {
                    int Thanhtien = 0;
                    foreach (CHITIETHOADON b in listCTHoadonsp)
                    {
                        int masp = 0;
                        if (a.SOHOADON == b.SOHD)
                        {
                            masp = b.MASP;
                        }
                        int giaban = 0;
                        foreach (SANPHAM c in listSanpham)
                        {
                            if (masp == c.MASP)
                            {
                                giaban = Convert.ToInt32(c.GIABAN);
                            }
                        }
                        Thanhtien = Thanhtien + giaban * Convert.ToInt32(b.SOLUONG);
                    }
                    dtInvoice.Rows.Add(new object[] { a.SOHOADON, a.NGAYLAPHOADON, Thanhtien });
                }
                txt_Total_Amount.Text = "Tổng tiền: " + Tongtien().ToString() + " VND";
            }
        }

        private void dtp_Invoice_Date_From_ValueChanged(object sender, EventArgs e)
        {
            Hienthitheongay();
        }

        private void dtp_Invoice_Date_To_ValueChanged(object sender, EventArgs e)
        {
            Hienthitheongay();
        }

        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Sohd = Convert.ToInt32(dgv_Invoice.Rows[e.RowIndex].Cells["Mã hóa đơn"].FormattedValue.ToString());
            }
        }

        private void btn_Export_Invoice_Click(object sender, EventArgs e)
        {
            if (Sohd != 0)
            {
                InHDchitiet(Sohd);
                frmHoadonchitiet a = new frmHoadonchitiet();
                a.Show();
                Sohd = 0;
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn cần xem");
            }
        }
        void InHDchitiet(int mahd)
        {
            if (mahd != 0)
            {
                listDHchitiet = new List<Hoadon>();
                Hoadon hoadon;
                YameContextDB cont = new YameContextDB();
                List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                List<CHITIETHOADON> listCTHoadonsp = cont.CHITIETHOADONs.ToList();
                List<HOADON> listHoadon = cont.HOADONs.ToList();
                foreach (CHITIETHOADON a in listCTHoadonsp)
                {
                    hoadon = new Hoadon();
                    hoadon.Mahd = mahd;
                    foreach (HOADON b in listHoadon)
                    {
                        if (mahd == b.SOHOADON)
                        {
                            hoadon.Ngaylap = Convert.ToDateTime(b.NGAYLAPHOADON.ToString()).ToShortDateString();
                        }
                    }
                    if (mahd == a.SOHD)
                    {
                        hoadon.Ma = a.MASP;
                        hoadon.Soluong = Convert.ToInt32(a.SOLUONG);
                        foreach (SANPHAM b in listSanpham)
                        {
                            if (a.MASP == b.MASP)
                            {
                                hoadon.Tensp = b.TENSP;
                                hoadon.Giaban = Convert.ToInt32(b.GIABAN);
                                hoadon.Thanhtien = hoadon.Soluong * hoadon.Giaban;
                                hoadon.Size = "";
                            }
                        }
                        listDHchitiet.Add(hoadon);
                    }
                }

            }
        }
        void Tinhdaonhthu()
        {
            YameContextDB cont = new YameContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADON> listCTHoadonsp = cont.CHITIETHOADONs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            listDoanhthu = new List<Doanthungay>();
            int[] sohd = new int[listHoadon.Count];
            int n = 0;
            foreach (HOADON a in listHoadon)
            {
                if (Convert.ToDateTime(a.NGAYLAPHOADON).ToShortDateString() == dtpDoanhthu.Value.ToShortDateString())
                {
                    sohd[n] = a.SOHOADON;
                    n = n + 1;
                }
            }
            int x = 0;
            int y = 0;
            int[] masp = new int[listSanpham.Count];
            int[] DemSLsp = new int[listSanpham.Count];
            for (int i = 0; i < n + 1; i++)
            {
                foreach (CHITIETHOADON a in listCTHoadonsp)
                {
                    if (sohd[i] == a.SOHD)
                    {
                        masp[y] = a.MASP;
                        DemSLsp[y] = Convert.ToInt32(a.SOLUONG);
                        y = y + 1;
                    }
                }
            }
            TimsoluongbanSp(masp, DemSLsp, y, listDoanhthu);
        }
        void TimsoluongbanSp(int[] ma, int[] sl, int n, List<Doanthungay> Listdoanhtu)
        {
            Doanthungay doanhthu;
            for (int i = 0; i < n; i++)
            {
                if (sl[i] != 0)
                {
                    doanhthu = new Doanthungay();
                    doanhthu.Soluongban = sl[i];

                    for (int j = i + 1; j < n + 1; j++)
                    {
                        if (ma[j] == ma[i])
                        {
                            doanhthu.Soluongban = doanhthu.Soluongban + sl[j];
                            sl[j] = 0;
                        }
                    }
                    doanhthu.Ma = ma[i];
                    doanhthu.Ngayban = Convert.ToDateTime(dtpDoanhthu.Value).ToShortDateString();
                    YameContextDB cont = new YameContextDB();
                    List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                    foreach (SANPHAM a in listSanpham)
                    {
                        if (ma[i] == a.MASP)
                        {
                            doanhthu.Tensp = a.TENSP;
                            doanhthu.Tensach = "";
                            doanhthu.Giaban = Convert.ToInt32(a.GIABAN);
                            doanhthu.Giamua = 0;
                            doanhthu.Doanhthu = (doanhthu.Giaban - doanhthu.Giamua) * doanhthu.Soluongban;
                            Listdoanhtu.Add(doanhthu);
                        }
                    }
                }

            }
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Tinhdaonhthu();
            frmDoanhthu a = new frmDoanhthu();
            a.Show();
        }
    }
}
