using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Fahasa_Management_System.GUI.Manager;

namespace Fahasa_Management_System.Report
{
    public partial class frmDoanhthu : Form
    {
        public frmDoanhthu()
        {
            InitializeComponent();
        }

        private void frmDoanhthu_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetDoanhthu", Frm_Invoice.listDoanhthu);
            this.rpvDoanhthu.LocalReport.DataSources.Clear();
            this.rpvDoanhthu.LocalReport.DataSources.Add(rds);
            this.rpvDoanhthu.RefreshReport();
        }
    }
}
