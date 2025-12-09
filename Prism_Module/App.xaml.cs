using Prism.Ioc;
using Prism.Modularity;
using Prism_Module.Views;
using Prism_Module_A;
using Prism_Module_B;
using System.Windows;
//using Prism_Module;

namespace Prism_Module
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module_A>();
            moduleCatalog.AddModule<Module_B>();

            base.ConfigureModuleCatalog(moduleCatalog);


        }
    }
}
