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
    public partial class frmGodineStudija : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        GodineStudija _godine;
        bool modifikacija = false;
        public frmGodineStudija()
        {
            InitializeComponent();
            dgvGodine.AutoGenerateColumns = false;
        }
        private void UcitajGodine()
        {
            dgvGodine.DataSource = null;
            dgvGodine.DataSource = _db.GodineStudija.ToList();
        }
        private void frmGodineStudija_Load(object sender, EventArgs e)
        {
            UcitajGodine();
        }
        private bool ValidanUnos()
        {
            return Validator.ObaveznoPolje(txtNaziv, err, "Obavezno Polje");

        }
     
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                if (!modifikacija)
                {
                    foreach (var godine in _db.GodineStudija)
                        if (godine.Naziv == txtNaziv.Text.ToLower())
                        {
                            err.SetError(txtNaziv, "Ne smije se isto unosit konju");
                            return;
                        }
                    _godine = new GodineStudija();
                    _godine.Naziv = txtNaziv.Text.ToLower();
                    _godine.Aktivna = cbAktivna.Checked;
                    _db.GodineStudija.Add(_godine);
                    _db.SaveChanges();
                    UcitajGodine();
                }
                else
                {
                    foreach (var godine in _db.GodineStudija)
                        if (godine.Id == _godine.Id)
                        {
                            godine.Naziv= txtNaziv.Text;
                            godine.Aktivna = cbAktivna.Checked;
                        }
                    _db.SaveChanges();
                    modifikacija = false;
                    UcitajGodine();
                }
              
            }
         
        }

        private void dgvGodine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var godina = dgvGodine.SelectedRows[0].DataBoundItem as GodineStudija;
            txtNaziv.Text = godina.Naziv;
            cbAktivna.Checked = godina.Aktivna;
            modifikacija = true;
            _godine = godina;
        }
    }
}
