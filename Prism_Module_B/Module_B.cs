using Prism.Ioc;
using Prism.Modularity;
using Prism_Module_B.Views;

namespace Prism_Module_B
{
    public class Module_B : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Module_BView>();


        }
    }
}
