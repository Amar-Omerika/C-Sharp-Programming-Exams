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
            this.dtKorisnici = new cSharpIntroWinForms.IspitIB190069.dtKorisnici();
            this.dtPrintajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrintajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsNoviReport";
            reportDataSource1.Value = this.dtPrintajBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IspitIB190069.rtpPrintaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtKorisnici
            // 
            this.dtKorisnici.DataSetName = "dtKorisnici";
            this.dtKorisnici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPrintajBindingSource
            // 
            this.dtPrintajBindingSource.DataMember = "dtPrintaj";
            this.dtPrintajBindingSource.DataSource = this.dtKorisnici;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrintajBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPrintajBindingSource;
        private dtKorisnici dtKorisnici;
    }
}