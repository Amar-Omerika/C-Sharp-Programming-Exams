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
    public partial class frmKorisniciAdmini : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        public frmKorisniciAdmini()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmKorisniciAdmini_Load(object sender, EventArgs e)
        {

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            lblProsjek.Text = "";
            var filter = txtPretraga.Text.ToLower();
            var korisnici = _db.Korisnici.Where(x => x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter)).ToList();
            if (korisnici!=null)
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = korisnici;
            }
            lblProsjek.Text = korisnici.Count == 0 ? "0" : _db.KorisniciPredmeti.Average(x => x.Ocjena).ToString();

        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                var korisnik = dgvPretraga.SelectedRows[0].DataBoundItem as Korisnik;
                if (korisnik!=null)
                {
                    frmKorisniciPolozeniPredmeti frmKorisniciPolozeniPredmeti = new frmKorisniciPolozeniPredmeti(korisnik);
                    frmKorisniciPolozeniPredmeti.ShowDialog();

                }

            }
        }
    }
}
