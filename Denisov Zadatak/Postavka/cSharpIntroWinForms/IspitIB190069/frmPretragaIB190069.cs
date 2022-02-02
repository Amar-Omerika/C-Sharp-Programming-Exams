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
    public partial class frmPretragaIB190069 : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        public frmPretragaIB190069()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblProsjek.Text = "";
                var filter = txtPretraga.Text.ToLower();
                var prosjekOcjena = _db.KorisniciPredmeti.Where(x => x.Predmet.Naziv.Contains(filter)).ToList();
                if (prosjekOcjena!=null)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = prosjekOcjena;
                }

                lblProsjek.Text = prosjekOcjena.Count == 0 ? "0" : prosjekOcjena.Average(x => x.Ocjena).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }

        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Sumiraj);
            var n = long.Parse(txtBroj.Text);
            thread.Start(n);
        }
        private void Sumiraj(object obj)
        {
            var n = long.Parse(txtBroj.Text);
            long suma = 0;
            for (int i = 1; i < n; i++)
            {
                suma += i;
            }
            Action action = () => lblSuma.Text = suma.ToString();
            BeginInvoke(action);

        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex==4)
            {
                var porukeKorisnik = dgvPretraga.SelectedRows[0].DataBoundItem as KorisniciPredmeti;
                if (porukeKorisnik!=null)
                {
                    frmPorukeIB190069 frmPorukeIB190069 = new frmPorukeIB190069(porukeKorisnik.Korisnik);
                    frmPorukeIB190069.ShowDialog();
                }

            }
        }
    }
}
