using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung
{
    public class Erwachsener : Mensch
    {
        public Erwachsener(string vorname, string nachname, int alter) : base(vorname, nachname, alter)
        {
        }
    }
}
