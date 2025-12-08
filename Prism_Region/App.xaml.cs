using Prism.Ioc;
using Prism.Regions;
using Prism_Region.Adapter;
using Prism_Region.Views;
using System.Windows;
using System.Windows.Controls;

namespace Prism_Region
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

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            // 注册区域与适配器（容器）的映射关系。例如当某个区域为 StackPanel时，使用StackPanelAdapter进行适配。
            // 这样指定某个布局控件为区域时，Prism才能正确的调用Adapt方法，将视图添加进区域中。
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelAdapter>());
        }
    }
}
