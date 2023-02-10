
namespace Fahasa_Management_System.Report
{
    partial class frmHoadonchitiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvHoadonchitiet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHoadonchitiet
            // 
            this.rpvHoadonchitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHoadonchiotiet";
            reportDataSource1.Value = this.HoadonBindingSource;
            this.rpvHoadonchitiet.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHoadonchitiet.LocalReport.ReportEmbeddedResource = "Fahasa_Management_System.Report.RDLCHoadonchitiet.rdlc";
            this.rpvHoadonchitiet.Location = new System.Drawing.Point(0, 0);
            this.rpvHoadonchitiet.Name = "rpvHoadonchitiet";
            this.rpvHoadonchitiet.ServerReport.BearerToken = null;
            this.rpvHoadonchitiet.Size = new System.Drawing.Size(1253, 579);
            this.rpvHoadonchitiet.TabIndex = 0;
            // 
            // HoadonBindingSource
            // 
            this.HoadonBindingSource.DataSource = typeof(Fahasa_Management_System.Hoadon);
            // 
            // frmHoadonchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 579);
            this.Controls.Add(this.rpvHoadonchitiet);
            this.Name = "frmHoadonchitiet";
            this.Text = "frmHoadonchitiet";
            this.Load += new System.EventHandler(this.frmHoadonchitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoadonchitiet;
        private System.Windows.Forms.BindingSource HoadonBindingSource;
    }
}