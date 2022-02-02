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
    public partial class frmNovaPorukaIB190069 : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        private Korisnik _korisnik;
        private KorisniciPoruke _poruke;

        public frmNovaPorukaIB190069(Korisnik korisnik, KorisniciPoruke poruke=null)
        {
            InitializeComponent();
            this._korisnik = korisnik;
            this._poruke = poruke;
        }

        private bool ValidanUnos()
        {
            return Validator.ObaveznoPolje(txtSadrzaj, err, "Obavezna poruka") &&
                Validator.ObaveznoPolje(pbSlika, err, "Ona nije obavezna");
        }
        private void frmNovaPorukaIB190069_Load(object sender, EventArgs e)
        {
            txtStudent.Text = _korisnik.ToString();
            UcitajPoruku();
        }
        private void UcitajPoruku()
        {
            if (_poruke!=null)
            {
                txtSadrzaj.Text = _poruke.Sadrzaj;
                pbSlika.Image = ImageHelper.FromByteToImage(_poruke.Slika);
            }
        }
        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var edit = _poruke != null;
                if (!edit)
               
                _poruke = new KorisniciPoruke();
                _poruke.DatumVrijeme = DateTime.Now;
                _poruke.Korisnik = _korisnik;
                _poruke.Sadrzaj = txtSadrzaj.Text;
                _poruke.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                if (edit)
                _db.Entry(_poruke).State = System.Data.Entity.EntityState.Modified;
                else
                _db.KorisniciPoruke.Add(_poruke);
                _db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();

            }
        }
    }
}
