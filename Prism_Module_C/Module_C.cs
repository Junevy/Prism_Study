
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_Module_C.Views;

namespace Prism_Module_C
{
    public class Module_C : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // 如果不使用导航，而是直接注册视图到区域，可以使用下面的代码。
            // 注意这种方式注册的视图是单实例的 ？？？

            // 经测试，App启动时，首页为Module_CView。
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(Module_CView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Module_CView>();
        }
    }

}
