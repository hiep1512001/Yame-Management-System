
namespace Fahasa_Management_System.Report
{
    partial class frmDoanhthu
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
            this.rpvDoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoanthungayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DoanthungayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvDoanhthu
            // 
            this.rpvDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDoanhthu";
            reportDataSource1.Value = this.DoanthungayBindingSource;
            this.rpvDoanhthu.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDoanhthu.LocalReport.ReportEmbeddedResource = "Fahasa_Management_System.Report.RDLCDoanhthungay.rdlc";
            this.rpvDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.rpvDoanhthu.Name = "rpvDoanhthu";
            this.rpvDoanhthu.ServerReport.BearerToken = null;
            this.rpvDoanhthu.Size = new System.Drawing.Size(1192, 533);
            this.rpvDoanhthu.TabIndex = 0;
            // 
            // DoanthungayBindingSource
            // 
            this.DoanthungayBindingSource.DataSource = typeof(Fahasa_Management_System.Doanthungay);
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 533);
            this.Controls.Add(this.rpvDoanhthu);
            this.Name = "frmDoanhthu";
            this.Text = "frmDoanhthu";
            this.Load += new System.EventHandler(this.frmDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoanthungayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDoanhthu;
        private System.Windows.Forms.BindingSource DoanthungayBindingSource;
    }
}