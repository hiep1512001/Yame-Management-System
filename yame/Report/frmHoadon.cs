using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using Fahasa_Management_System.GUI.Employee;


namespace Fahasa_Management_System.Report
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetHoadon", Frm_Export_Invoice.listHoadonxuat);
            this.rpvHoadon.LocalReport.DataSources.Clear();
            this.rpvHoadon.LocalReport.DataSources.Add(rds);
            this.rpvHoadon.RefreshReport();
        }
    }
}
