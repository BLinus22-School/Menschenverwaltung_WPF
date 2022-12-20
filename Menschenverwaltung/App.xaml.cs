using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Menschenverwaltung.Views;
using Prism.Ioc;
using Prism.Unity;

namespace Menschenverwaltung
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MenuView>("MenuView");
            containerRegistry.RegisterForNavigation<AddView>("AddView");
            containerRegistry.RegisterForNavigation<EditView>("EditView");
            containerRegistry.RegisterForNavigation<DisplayView>("DisplayView");

            Container.Resolve<Menschen>();

            // register other needed services here
        }

        protected override Window CreateShell()
        {
            var w = Container.Resolve<MainWindow>();
            return w;
        }
    }
}