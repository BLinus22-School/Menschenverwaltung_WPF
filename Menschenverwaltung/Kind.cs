using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung
{
    public class Kind : Mensch
    {
        private bool einwilligung;

        public Kind(string vorname, string nachname, int alter, bool einwilligung) : base(vorname, nachname, alter)
        {
            this.Einwilligung = einwilligung;
        }

        public bool Einwilligung
        {
            get { return einwilligung; }
            set
            {
                einwilligung = value;
            }
        }
    }
}
