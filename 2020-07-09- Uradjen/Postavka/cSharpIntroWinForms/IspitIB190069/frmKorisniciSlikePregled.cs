using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IspitIB190069
{
    public partial class frmKorisniciSlikePregled : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        int index = 0;
        private Korisnik _korisnik;

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public frmKorisniciSlikePregled(Korisnik korisnik)
        {
            InitializeComponent();
            this._korisnik = korisnik;
        }
        private void UcitajSlike()
        {
            if (_korisnik.KorisniciSlike.Count!=0)          
                pbSlika.Image = byteArrayToImage(_korisnik.KorisniciSlike[0].Slika);
            else
                    MessageBox.Show("Nemate postavljenu profilnu sliku.");
                   
        }
        private void frmKorisniciSlikePregled_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var putanja = openFileDialog1.FileName;
                Image slika = Image.FromFile(putanja);
                var ks = new KorisniciSlike()
                {
                    Korisnik = _korisnik,
                    Slika = ImageToByteArray(slika)
                };
                _korisnik.KorisniciSlike.Add(ks);
                _db.SaveChanges();
            }
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            if (index < _korisnik.KorisniciSlike.Count - 1)
            {
                pbSlika.Image = byteArrayToImage(_korisnik.KorisniciSlike[index + 1].Slika);
                index++;
            }
            else
                MessageBox.Show("Ne postoji slika!");
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                pbSlika.Image = byteArrayToImage(_korisnik.KorisniciSlike[index - 1].Slika);
                index--;
            }
            else
                MessageBox.Show("Ne postoji slika!");
        }
    }
}
