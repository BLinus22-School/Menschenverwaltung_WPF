using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        private RegionNavigationService regionNavigationService;

        public MenuViewModel(RegionNavigationService regionNavigationService)
        {
            this.regionNavigationService = regionNavigationService;

            ShowAddViewCommand = new DelegateCommand(() => OnShowAddView());
            ShowEditViewCommand = new DelegateCommand(() => OnShowEditView());
        }

        public DelegateCommand ShowAddViewCommand { get; set; }
        public DelegateCommand ShowEditViewCommand { get; set; }
        
        private void OnShowAddView()
        {
            //TODO: Funktioniert noch nicht, muss wahrscheinlich nichtmal mit Funktionsaufruf gemacht werden.
            // Nochmal in Doku schauen
            this.regionNavigationService.RequestNavigate("AddView");
        }

        private void OnShowEditView()
        {
            this.regionNavigationService.RequestNavigate("EditView");
        }
    }
}
