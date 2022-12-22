using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung.ViewModels
{
    public class EditViewModel : BindableBase
    {
        private string neuerNachname = "";

        public string NeuerNachname
        {
            get { return this.neuerNachname; }
            set
            {
                SetProperty(ref this.neuerNachname, value, nameof(this.NeuerNachname));
            }
        }

        private bool einwilligung = false;

        public bool Einwilligung
        {
            get { return this.einwilligung; }
            set
            {
                SetProperty(ref this.einwilligung, value, nameof(this.Einwilligung));
            }
        }

        public EditViewModel()
        {
            HeiratenCommand = new DelegateCommand(() => OnHeiraten());
            GeburtstagCommand = new DelegateCommand(() => OnGeburtstag());
        }

        public DelegateCommand HeiratenCommand { get; set; }
        public DelegateCommand GeburtstagCommand { get; set; }

        private void OnHeiraten()
        {
            
        }

        private void OnGeburtstag()
        {

        }
    }
}
