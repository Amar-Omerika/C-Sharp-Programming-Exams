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
        private List<Korisnik> _lista;
        public frmPrintaj()
        {
            InitializeComponent();
        }
        public frmPrintaj(List<Korisnik> lista) : this()
        {
            this._lista = lista;
        }
        private void frmPrintaj_Load(object sender, EventArgs e)
        {
            dtKorisnici.dtPrintajDataTable tbl = new dtKorisnici.dtPrintajDataTable();

            foreach (var korisnik in _lista)
            {
                foreach (var polozeni in korisnik.Uspjeh)
                {
                    var red = tbl.NewdtPrintajRow();
                    red.Ime = korisnik.Ime;
                    red.Prezime = korisnik.Prezime;
                    red.Predmet = polozeni.Predmet.Naziv;
                    tbl.AdddtPrintajRow(red);
                }
            }
            var rds = new ReportDataSource();
            rds.Name = "dsPrintajKorisnike";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
