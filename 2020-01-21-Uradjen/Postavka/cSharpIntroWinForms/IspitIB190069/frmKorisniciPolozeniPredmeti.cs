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

namespace cSharpIntroWinForms.IspitIB190069
{
    public partial class frmKorisniciPolozeniPredmeti : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        private Korisnik _korisnik;
        KorisniciPredmeti _kp;

        public frmKorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public frmKorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this._korisnik = korisnik;
        }

        private void UcitajPredmete(List<Predmeti> rezultat=null)
        {
            if (rezultat != null)
            {
                cbPolozeni.DataSource = rezultat;
            }
            else
            {
                cbPolozeni.DataSource = null;
                cbPolozeni.DataSource = _db.Predmeti.ToList();
            }
        }
        private void UcitajoOcjene()
        {
            List<int> ocjena = new List<int>()
            {
                6,7,8,9,10
            };
            cbOcjena.DataSource = ocjena;

        }
        private void UcitajSadrzaj()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = _korisnik.Uspjeh.ToList();
        }
        private void frmKorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajoOcjene();
            UcitajSadrzaj();
        }
        private void ValidirajPredmet(Predmeti odabraniPredmet)
        {
            if (_korisnik.Uspjeh.Where(x=>x.Predmet.Id==odabraniPredmet.Id).Count()>0)
            {
                throw new Exception("Nije moguce dodati isti predmet");
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Predmeti odabraniPredmet= cbPolozeni.SelectedItem as Predmeti; 
            ValidirajPredmet(odabraniPredmet);
            _kp = new KorisniciPredmeti();
            _kp.Korisnik = _korisnik;
            _kp.Ocjena =int.Parse(cbOcjena.Text);
            _kp.Predmet = odabraniPredmet;
            _kp.Datum = dtPicker.Value.ToString();
            _korisnik.Uspjeh.Add(_kp);
            _db.SaveChanges();
             UcitajSadrzaj();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var query = from c in _db.Predmeti.AsEnumerable()
                            where !(from o in _korisnik.Uspjeh select o.Predmet.Id).Contains(c.Id)
                            select c;

                UcitajPredmete(query.ToList());

            }
            else
            {
                UcitajPredmete();
            }

        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            Predmeti odabraniPredmet = cbPolozeni.SelectedItem as Predmeti;
            await Task.Run(() =>
            {
                for (int i = 0; i <= 500; i++)
                {
                    _kp = new KorisniciPredmeti();
                    _kp.Korisnik = _korisnik;
                    _kp.Ocjena = 6;
                    _kp.Predmet = odabraniPredmet;
                    _kp.Datum = DateTime.Now.ToString();
                    _korisnik.Uspjeh.Add(_kp);
                    _db.SaveChanges();
                }              
            });
            MessageBox.Show("Uspjesno je dodano 500 predmeta");
            UcitajSadrzaj();


        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var print = new frmIzvjestaj(dgvPolozeniPredmeti.DataSource as List<Korisnik>);
            print.ShowDialog();
          }
    }
}
