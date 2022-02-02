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
    public partial class frmPorukeIB190069 : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
       
        private Korisnik _korisnik;

        
        public frmPorukeIB190069(Korisnik korisnik)
        {
            InitializeComponent();
            this._korisnik = korisnik;
            dgvPoruka.AutoGenerateColumns = false;
        }
      
        private void frmPorukeIB190069_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _korisnik.ToString();
              
             dgvPoruka.DataSource = null;
             dgvPoruka.DataSource = _db.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB190069 frmNovaPorukaIB190069 = new frmNovaPorukaIB190069(_korisnik);
            frmNovaPorukaIB190069.ShowDialog();
        }
        private void UcitajPoruke()
        {
            dgvPoruka.DataSource = null;
            dgvPoruka.DataSource = _db.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
        }
        private void dgvPoruka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var poruka = dgvPoruka.SelectedRows[0].DataBoundItem as KorisniciPoruke;
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite obrisati poruku?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _db.KorisniciPoruke.Remove(poruka);
                        _db.SaveChanges();
                      
                    }
                }
                else
                {
                    frmNovaPorukaIB190069 frmNovaPorukaIB190069 = new frmNovaPorukaIB190069(_korisnik, poruka);
                    frmNovaPorukaIB190069.ShowDialog();
                   
                }
                UcitajPoruke();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)

        {
            var porukee = dgvPoruka.DataSource as List<KorisniciPoruke>;
            frmPrintaj frmPrintaj = new frmPrintaj(porukee);
            frmPrintaj.ShowDialog();
        }
    }
}
