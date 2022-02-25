using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB190069
{
    public class MojaKlasa
    {
        public virtual Student Student{ get; set; }
        public string  PolozeniPredmeti { get; set; }
        public int BrojPolozenih { get; set; }
        public double Prosjek { get; set; }
        public MojaKlasa(Student student, List<StudentiPredmeti> studentipredmeti)
        {
            Student = student;
            BrojPolozenih = studentipredmeti.Count;
            Prosjek = studentipredmeti.Average(x => x.Ocjena);
            for (int i = 0; i < studentipredmeti.Count; i++)
            {
                PolozeniPredmeti = studentipredmeti[i].Predmet.ToString() + ";";
            }
        }

    }
    
 
}
