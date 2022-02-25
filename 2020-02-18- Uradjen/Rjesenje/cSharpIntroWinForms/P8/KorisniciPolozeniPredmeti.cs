using cSharpIntroWinForms.IspitIB190069;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
         Korisnik korisnik;
        KonekcijaNaBazu _db = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            korisnik = _db.Korisnici.FirstOrDefault();
        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajSadrzaj();
                UcitajPredmete();
                UcitajGodine();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void UcitajGodine()
        {
            cmbGodineStudija.DataSource = _db.GodineStudija.ToList();
            cmbGodineStudija.DisplayMember = "Naziv";
            cmbGodineStudija.ValueMember="Id";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = _db.Predmeti.ToList();
        }

        private void UcitajSadrzaj()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = _db.KorisniciPredmeti.ToList();
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            var godina = cmbGodineStudija.SelectedItem as GodineStudija;

            foreach (var polozeni in korisnik.Uspjeh)
            {
                if (polozeni.Predmet.Naziv == predmet.Naziv && godina.Id == polozeni.GodineStudija.Id)
                {
                    err.SetError(btnDodajPolozeni, "Onemoguceno dodavanje istoimenih predmeta na istoj godini studija!");
                    return;
                }
            }
            var kp = new KorisniciPredmeti()
            {
                Korisnik = korisnik,
                Datum = dtpDatumPolaganja.Value.ToString(),
                Ocjena = int.Parse(txtOcjena.Text),
                Predmet = predmet,
                GodineStudija = godina
            };
            korisnik.Uspjeh.Add(kp);
            _db.SaveChanges();
            UcitajSadrzaj();
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
           
            frmPrintaj frmPrintaj = new frmPrintaj(korisnik);
            frmPrintaj.ShowDialog();
        }
    }
}
