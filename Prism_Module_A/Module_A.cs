
using Prism.Ioc;
using Prism.Modularity;
using Prism_Module_A.Views;

namespace Prism_Module_A
{
    public class Module_A : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Module_AView>();
        }
    }

}
