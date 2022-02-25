namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmPrintaj
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mojDataset = new cSharpIntroWinForms.IspitIB190069.mojDataset();
            this.dtPorukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mojDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPorukeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsPrintaj";
            reportDataSource1.Value = this.dtPorukeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IspitIB190069.rptMojreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 325);
            this.reportViewer1.TabIndex = 0;
            // 
            // mojDataset
            // 
            this.mojDataset.DataSetName = "mojDataset";
            this.mojDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPorukeBindingSource
            // 
            this.dtPorukeBindingSource.DataMember = "dtPoruke";
            this.dtPorukeBindingSource.DataSource = this.mojDataset;
            // 
            // frmPrintaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintaj";
            this.Text = "frmPrintaj";
            this.Load += new System.EventHandler(this.frmPrintaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mojDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPorukeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPorukeBindingSource;
        private mojDataset mojDataset;
    }
}