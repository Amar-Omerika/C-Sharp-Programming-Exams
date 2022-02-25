using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IspitIB190069
{
    public partial class frmKorisniciAdminIB190069 : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
      
        public frmKorisniciAdminIB190069()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmKorisniciAdminIB190069_Load(object sender, EventArgs e)
        {
            cbSpol.DataSource = _db.Spolovi.ToList();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Sumiraj);
            var n = long.Parse(txtBroj.Text);       
            thread.Start(n);
       
        }
        private void Sumiraj(object obj)
        {
            var n = long.Parse(txtBroj.Text);
            long suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Action action = ()=>txtBroj.Text=suma.ToString();           
            BeginInvoke(action);
            

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = txtPretraga.Text.ToLower();
                var korisnik = _db.Korisnici.Where(x => x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter)).ToList();
                if (korisnik!=null)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = korisnik;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var filter = cbSpol.SelectedItem as Spolovi;
                var korisniciSpol = _db.Korisnici.Where(x => x.Spol.Id == filter.Id && x.Admin == checkAdmin.Checked).ToList();
                if (korisniciSpol!=null)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = korisniciSpol;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void DgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                var korisnikSlika = dgvPretraga.SelectedRows[0].DataBoundItem as Korisnik;
                if (korisnikSlika!=null)
                {
                    frmKorisniciSlikePregled frmKorisniciSlikePregled = new frmKorisniciSlikePregled(korisnikSlika);
                    frmKorisniciSlikePregled.ShowDialog();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var printaj = new frmPrintaj(dgvPretraga.DataSource as List<Korisnik>);
            printaj.ShowDialog();
        }
    }
}
