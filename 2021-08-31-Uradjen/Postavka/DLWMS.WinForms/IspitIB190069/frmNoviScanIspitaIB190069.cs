using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB190069
{
    public partial class frmNoviScanIspitaIB190069 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        public MojaKlasa _student;
        KorisniciIspitiScan _scan;



        public frmNoviScanIspitaIB190069(MojaKlasa student, KorisniciIspitiScan scan=null)
        {
            InitializeComponent();
            this._student = student;
            this._scan = scan;
        }

        private void frmNoviScanIspitaIB190069_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = _db.Predmet.ToList();

        }
        private bool ValidanUnos()
        {
          return  Validator.ValidirajKontrolu(txtNapomena, err, "Napomena je obavezna") &&
                   Validator.ValidirajKontrolu(pbSlika, err, "Slika nije pod moranjem");
        }
        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var edit = _scan != null;
                if (!edit)
                _scan = new KorisniciIspitiScan();
                _scan.Student = _student.Student;
                _scan.Predmet = cmbPredmeti.SelectedItem as Predmet;
                _scan.Napomena = txtNapomena.Text;
                _scan.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                _scan.Varanje = checkboxVaranje.Checked;
                if (edit)
                    _db.Entry(_scan).State = System.Data.Entity.EntityState.Unchanged;
                else
                 _db.KorisniciIspitiScan.Add(_scan);
                DialogResult = DialogResult.OK;
                _db.SaveChanges();
                Close();

            }

        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
