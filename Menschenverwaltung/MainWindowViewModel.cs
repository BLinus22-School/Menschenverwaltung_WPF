using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung
{
    public class MainWindowViewModel : BindableBase
    {
        private RegionManager regionManager;

        public MainWindowViewModel(RegionManager regionManager)
        {
            this.regionManager = regionManager;

            RegisterViews();
        }

        private void RegisterViews()
        {
            this.regionManager.RegisterViewWithRegion("MenuRegion", "MenuView");

            this.regionManager.RegisterViewWithRegion("MainRegion", "AddView");
            this.regionManager.RegisterViewWithRegion("MainRegion", "EditView");

            this.regionManager.RegisterViewWithRegion("DisplayRegion", "DisplayView");
        }
    }
}
