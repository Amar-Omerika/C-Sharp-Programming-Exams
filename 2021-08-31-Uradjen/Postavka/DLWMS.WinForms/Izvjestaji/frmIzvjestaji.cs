using DLWMS.WinForms.IspitIB190069;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        List<KorisniciIspitiScan> _scan;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<KorisniciIspitiScan> scan) : this()
        {
            this._scan = scan;
        }


        private void reportViewer1_Load(object sender, System.EventArgs e)
        {
           
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tblSken = new dsDLWMS.ScanReportDataTable();
            for (int i = 0; i < _scan.Count; i++)
            {
                var red = tblSken.NewScanReportRow();
                red.Predmet = _scan[i].Predmet.ToString();
                red.Napomena = _scan[i].Napomena;
                red.Varanje = _scan[i].Varanje == true ? "Da" : "Ne";
                tblSken.Rows.Add(red);
            }

            rds.Name = "noviReport";
            rds.Value = tblSken;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
