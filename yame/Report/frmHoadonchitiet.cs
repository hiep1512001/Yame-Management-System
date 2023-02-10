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
    public partial class frmHoadonchitiet : Form
    {
        public frmHoadonchitiet()
        {
            InitializeComponent();
        }

        private void frmHoadonchitiet_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetHoadonchiotiet", Frm_Invoice.listDHchitiet);
            this.rpvHoadonchitiet.LocalReport.DataSources.Clear();
            this.rpvHoadonchitiet.LocalReport.DataSources.Add(rds);
            this.rpvHoadonchitiet.RefreshReport();
        }
    }
}
