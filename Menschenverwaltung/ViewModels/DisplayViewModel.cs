using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung.ViewModels
{
    public class DisplayViewModel : BindableBase
    {
        private Menschen menschen;
        public Menschen Menschen
        {
            get { return this.menschen; }
            set
            {
                SetProperty(ref this.menschen, value, nameof(this.Menschen));
            }
        }

        public DisplayViewModel(Menschen menschen)
        {
            this.Menschen = menschen;
        }
    }
}
