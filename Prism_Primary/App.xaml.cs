using Prism.Ioc;
using Prism.Mvvm;
using Prism_Primary.Machine.ViewModels;
using Prism_Primary.Machine.Views;
using Prism_Primary.Views;
using System;
using System.Windows;

namespace Prism_Primary
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

        }

        /// <summary>
        /// 自定义规则
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            // 方式1：单独注册
            //ViewModelLocationProvider.Register<Plc, PlcVM>();

            // 方式2：自定义默认规则
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(SetDefaultViewModel);
        }

        /// <summary>
        /// 自定义的默认规则
        /// </summary>
        /// <param name="type">view type</param>
        /// <returns>ViewModel type</returns>
        private Type SetDefaultViewModel(Type type)
            => Type.GetType(type.FullName.Replace("Views", "ViewModels") + "ViewModel");
    }
}
