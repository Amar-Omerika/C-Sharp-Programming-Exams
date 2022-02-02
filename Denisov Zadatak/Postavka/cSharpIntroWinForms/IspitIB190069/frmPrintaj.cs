using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IspitIB190069
{
    public partial class frmPrintaj : Form
    {
         List<KorisniciPoruke> _lists;

        public frmPrintaj()
        {
            InitializeComponent();
        }

        public frmPrintaj(List<KorisniciPoruke> list) : this()
        {
            this._lists = list;
        }

        private void frmPrintaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var tblPrintaj = new mojDataset.dtPorukeDataTable();
            for (int i = 0; i < _lists.Count; i++)
            {        
                var red = tblPrintaj.NewdtPorukeRow();
                red.Datum = _lists[i].DatumVrijeme;
                red.Sadrzaj = _lists[i].Sadrzaj;
               // red.Slika = _lists[i].Slika;
            }
            rds.Name = "dsSranje";
            rds.Value = tblPrintaj;

            reportViewer1.LocalReport.DataSources.Add(rds);
    
            this.reportViewer1.RefreshReport();
        }
    }
}
