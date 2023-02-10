
namespace Fahasa_Management_System.Report
{
    partial class frmTinhluong
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
            this.rpvLuong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TinhluongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TinhluongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvLuong
            // 
            this.rpvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLuong";
            reportDataSource1.Value = this.TinhluongBindingSource;
            this.rpvLuong.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvLuong.LocalReport.ReportEmbeddedResource = "Fahasa_Management_System.Report.RDLCLuong.rdlc";
            this.rpvLuong.Location = new System.Drawing.Point(0, 0);
            this.rpvLuong.Name = "rpvLuong";
            this.rpvLuong.ServerReport.BearerToken = null;
            this.rpvLuong.Size = new System.Drawing.Size(1155, 477);
            this.rpvLuong.TabIndex = 0;
            // 
            // TinhluongBindingSource
            // 
            this.TinhluongBindingSource.DataSource = typeof(Fahasa_Management_System.Tinhluong);
            // 
            // frmTinhluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 477);
            this.Controls.Add(this.rpvLuong);
            this.Name = "frmTinhluong";
            this.Text = "frmTinhluong";
            this.Load += new System.EventHandler(this.frmTinhluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TinhluongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvLuong;
        private System.Windows.Forms.BindingSource TinhluongBindingSource;
    }
}