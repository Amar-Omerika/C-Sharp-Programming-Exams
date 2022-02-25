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
    public partial class frmIzvjestaj : Form
    {
     
        private List<Korisnik> _lista;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<Korisnik> lists):this()
        {
            this._lista = lists;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var tbl = new dsPredmeti.PolozeniPredmetiDataTable();

            if (_lista != null)
            {

                foreach (var korisnik in _lista)
                {
                    foreach (var polozeni in korisnik.Uspjeh)
                    {
                        var red = tbl.NewPolozeniPredmetiRow();
                        red.Ime = korisnik.Ime;
                        red.Prezime = korisnik.Prezime;
                        red.Predmeti = polozeni.Predmet.Naziv;
                        tbl.AddPolozeniPredmetiRow(red);

                    }

                }
            }
            rds.Name = "dsPred1";
            rds.Value = tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
