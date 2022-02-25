namespace cSharpIntroWinForms.IspitIB190069
{
    partial class frmIzvjestaj
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
            this.dsPredmeti = new cSharpIntroWinForms.IspitIB190069.dsPredmeti();
            this.PolozeniPredmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolozeniPredmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMoj";
            reportDataSource1.Value = this.PolozeniPredmetiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IspitIB190069.rptPrinter.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPredmeti
            // 
            this.dsPredmeti.DataSetName = "dsPredmeti";
            this.dsPredmeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PolozeniPredmetiBindingSource
            // 
            this.PolozeniPredmetiBindingSource.DataMember = "PolozeniPredmeti";
            this.PolozeniPredmetiBindingSource.DataSource = this.dsPredmeti;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestaj";
            this.Text = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolozeniPredmetiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PolozeniPredmetiBindingSource;
        private dsPredmeti dsPredmeti;
    }
}