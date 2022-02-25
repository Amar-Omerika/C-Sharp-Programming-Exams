
namespace DLWMS.WinForms.Izvjestaji
{
    partial class frmIzvjestaji
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
            this.ScanReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDLWMS = new DLWMS.WinForms.Izvjestaji.dsDLWMS();
            this.PorukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ScanReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDLWMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorukeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanReportBindingSource
            // 
            this.ScanReportBindingSource.DataMember = "ScanReport";
            this.ScanReportBindingSource.DataSource = this.dsDLWMS;
            // 
            // dsDLWMS
            // 
            this.dsDLWMS.DataSetName = "dsDLWMS";
            this.dsDLWMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsScanReport";
            reportDataSource1.Value = this.ScanReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.IspitIB190069.rptScanReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(831, 778);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 778);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIzvjestaji";
            this.Text = "frmIzvjestaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDLWMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorukeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PorukeBindingSource;
        private System.Windows.Forms.BindingSource ScanReportBindingSource;
        private dsDLWMS dsDLWMS;
    }
}