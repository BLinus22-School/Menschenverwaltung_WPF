using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung
{
    public class Mensch
    {
        protected int alter;
        protected string vorname;
        protected string nachname;
        protected string familienstand;
        private static int volljaehrigkeit = 18; //nicht abhängig vom Objekt, sondern der Klasse zugehörig: Klassenattribut

        public Mensch(string vorname, string nachname, int alter)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            familienstand = "ledig";
        }

        public int Alter
        {
            get { return alter; }
            //set { alter = value; }
        }

        public string Vorname
        {
            get { return vorname; }
            //set { vorname = value; }
        }

        public string Nachname
        {
            get { return nachname; }
            //set { nachname = value; }
        }

        public string Familienstand
        {
            get { return familienstand; }
            //set { familienstand = value; }
        }

        public static int Volljaehrigkeit
        {
            get { return volljaehrigkeit; }
        }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }

        public void Geburtstag()
        {
            alter++;
        }

        public bool Heiraten(string neuerNachname)
        {
            if (familienstand == "ledig" || familienstand == "geschieden")
            {
                familienstand = "verheiratet";
                nachname = neuerNachname;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
