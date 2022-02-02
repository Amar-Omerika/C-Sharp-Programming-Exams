using cSharpIntroWinForms.P10;
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
      
        private Korisnik korisnik;

        public frmPrintaj()
        {
            InitializeComponent();
        }
  
        public frmPrintaj(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void frmPrintaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var tbl = new dsIzvjestaj.dtUvjerenjeDataTable();
            foreach (var polozeni in korisnik.Uspjeh)
            {
                var red = tbl.NewdtUvjerenjeRow();
                red.Predmet = polozeni.Predmet.Naziv;
                red.Ime = polozeni.Korisnik.Ime;
                red.Prezime = polozeni.Korisnik.Prezime;
                tbl.AdddtUvjerenjeRow(red);

            }
            rds.Name = "dsPrinter";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
