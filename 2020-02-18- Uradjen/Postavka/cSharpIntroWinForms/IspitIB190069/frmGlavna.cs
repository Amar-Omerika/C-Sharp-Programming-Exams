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
using cSharpIntroWinForms.P8;
namespace cSharpIntroWinForms.IspitIB190069
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnIzracunajSumu_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Sumiraj);
            var n = long.Parse(txtBroj.Text);
            thread.Start(n);
        }
        private void Sumiraj(object obj)
        {
            long suma = 0;
            var n = long.Parse(txtBroj.Text);
            for (int i = 1; i <=n; i++)
            {
                suma += i;
            }
            Action action = () => txtBroj.Text = suma.ToString();
            BeginInvoke(action);
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            frmGodineStudija frmGodineStudija = new frmGodineStudija();
            frmGodineStudija.ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {

            KorisniciPolozeniPredmeti KorisniciPolozeniPredmeti = new KorisniciPolozeniPredmeti();
            KorisniciPolozeniPredmeti.ShowDialog();
        }
    }
}
