using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Menschenverwaltung.ViewModels
{
    public class AddViewModel : BindableBase
    {
        private string vorname;
        public string Vorname
        {
            get { return this.vorname; }
            set
            {
                SetProperty(ref this.vorname, value, nameof(this.Vorname));
            }
        }

        private string nachname;
        public string Nachname
        {
            get { return this.nachname; }
            set
            {
                SetProperty(ref this.nachname, value, nameof(this.Nachname));
            }
        }

        private string alter;
        public string Alter
        {
            get { return this.alter; }
            set
            {
                SetProperty(ref this.alter, value, nameof(this.Alter));
            }
        }

        private string familienstand;
        public string Familienstand
        {
            get { return this.familienstand; }
            set
            {
                SetProperty(ref this.familienstand, value, nameof(this.Familienstand));
            }
        }

        private Menschen menschen;
        public Menschen Menschen
        {
            get { return this.menschen; }
            set
            {
                SetProperty(ref this.menschen, value, nameof(this.Menschen));
            }
        }

        public AddViewModel(Menschen menschen)
        {
            this.Menschen = menschen;

            MenschErschaffenCommand = new DelegateCommand(() => OnMenschErschaffen());
        }

        public DelegateCommand MenschErschaffenCommand { get; set; }

        private void OnMenschErschaffen()
        {
            var mindestAlter = Mensch.Volljaehrigkeit;
            var alterValid = int.TryParse(this.Alter, out int alter);

            if (alterValid)
            {
                Mensch neuerMensch;

                if (alter >= mindestAlter)
                {
                    neuerMensch = new Erwachsener(this.Vorname, this.Nachname, alter);
                }
                else
                {
                    neuerMensch = new Kind(this.Vorname, this.Nachname, alter);
                }

                this.Menschen.MenschenListe.Add(neuerMensch);

                this.Alter = "";
                this.Vorname = "";
                this.Nachname = "";
            }
            else
            {
                MessageBox.Show("Das angegebene Alter ist keine Zahl");
            }
        }
    }
}
