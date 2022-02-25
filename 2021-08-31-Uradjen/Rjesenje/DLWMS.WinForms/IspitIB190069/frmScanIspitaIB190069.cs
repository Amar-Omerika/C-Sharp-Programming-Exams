using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmScanIspitaIB190069 : Form
    {
        public MojaKlasa _studentIspit;
        KonekcijaNaBazu _db = DLWMSdb.Baza;

       

        public frmScanIspitaIB190069(MojaKlasa studentIspit)
        {
            InitializeComponent();
            this._studentIspit = studentIspit;
            dgvKorisniciIspit.AutoGenerateColumns = false;
        }
        private void UcitajStudenta()
        {
            lblStudent.Text = _studentIspit.Student.ToString();
        }
        private void UcitajSadrzaj()
        {
            dgvKorisniciIspit.DataSource = null;
            dgvKorisniciIspit.DataSource = _db.KorisniciIspitiScan.Where(x => x.Student.Id == _studentIspit.Student.Id).ToList();
        }
        private void frmScanIspitaIB190069_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajStudenta();
                UcitajSadrzaj();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
           
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            
            frmNoviScanIspitaIB190069 frmNoviScanIspitaIB190069 = new frmNoviScanIspitaIB190069(_studentIspit);
            if (frmNoviScanIspitaIB190069.ShowDialog()==DialogResult.OK)
            {
                UcitajSadrzaj();
            }
           
        }

        private void dgvKorisniciIspit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var napomena = dgvKorisniciIspit.SelectedRows[0].DataBoundItem as KorisniciIspitiScan;
            if (e.ColumnIndex==4)
            {
                if (MessageBox.Show("Da li ste sigurni da li zelite obrisati ovu napomenu","Upozorenje",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    _db.KorisniciIspitiScan.Remove(napomena);
                    _db.SaveChanges();
                 

                }
                UcitajSadrzaj();

            }
            else
            {
                //ovo je za modified
                frmNoviScanIspitaIB190069 frmNoviScanIspitaIB190069 = new frmNoviScanIspitaIB190069(_studentIspit, napomena);
                frmNoviScanIspitaIB190069.ShowDialog();

            }
            
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var skenovi = dgvKorisniciIspit.DataSource as List<KorisniciIspitiScan>;
            frmIzvjestaji frm = new frmIzvjestaji(skenovi);
            frm.ShowDialog();
        }
    }
}
