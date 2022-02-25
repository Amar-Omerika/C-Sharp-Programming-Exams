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
    public partial class frmPretragaIB190069 : Form
    {
       
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<MojaKlasa> _mojaKlasa = new List<MojaKlasa>();
        List<StudentiPredmeti> _studentiPredmeti;
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
                if (string.IsNullOrEmpty(filter))
                {
                    _studentiPredmeti = _db.StudentiPredmeti.ToList();
                }
                else
                {
                    _studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Contains(filter) || x.Student.Prezime.ToLower().Contains(filter)).ToList();
                }
                _mojaKlasa.Clear();
                _studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Contains(filter) || x.Student.Prezime.ToLower().Contains(filter)).ToList();
                for (int i = 0; i < _studentiPredmeti.Count; i++)
                {
                    //provjerava da li ima isti student
                    if (_mojaKlasa.Where(x=>x.Student.Id==_studentiPredmeti[i].Student.Id).ToList().Count==0)
                    {
                        //dodaje studenta i studente predmete u funkciju u klasi moja klasa
                        _mojaKlasa.Add(new MojaKlasa(_studentiPredmeti[i].Student, _studentiPredmeti[i].Student.StudentiPredmeti));
                    }
                }
                if (_mojaKlasa!=null)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = _mojaKlasa;
                    lblProsjek.Text = _mojaKlasa.Count == 0 ? "0" : _mojaKlasa.Average(x => x.Prosjek).ToString();
                }
                NajboljiStudent(_mojaKlasa);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }


        }
        private void NajboljiStudent(List<MojaKlasa> studentiPredmeti)
        {
            int brojac = 0;
            int lokacija = -1;
            double prosjek = 0;
            double najveciProsjek = 0;
            foreach (var student in studentiPredmeti)
            {
                prosjek = student.Student.StudentiPredmeti.Average(x => x.Ocjena);
                if (prosjek > najveciProsjek)
                {
                    najveciProsjek = prosjek;
                    lokacija = brojac;

                }
                brojac++;

            }
            if (lokacija == -1)
            {
                lblNajStudent.Text = "Not Set";
            }
            else
            {
                lblNajStudent.Text = studentiPredmeti[lokacija].Student.ToString();
            }


        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                var studentIspit = dgvPretraga.SelectedRows[0].DataBoundItem as MojaKlasa;
                if (studentIspit!=null)
                {
                    frmScanIspitaIB190069 frmScanIspitaIB190069 = new frmScanIspitaIB190069(studentIspit);
                    frmScanIspitaIB190069.ShowDialog();
                }
               
            }
        }
    }
}
