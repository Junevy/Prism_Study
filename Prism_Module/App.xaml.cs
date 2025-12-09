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

        /// <summary>
        /// 通过 Code 显示加载模块
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module_A>();
            moduleCatalog.AddModule<Module_B>();

            base.ConfigureModuleCatalog(moduleCatalog);
        }

        /// <summary>
        /// 通过 DLL 直接加载模块
        /// </summary>
        /// <returns></returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            // 指定模块所在的文件夹路径
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        }
    }
}
