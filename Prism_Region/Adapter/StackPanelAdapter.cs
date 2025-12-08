using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace Prism_Region.Adapter
{
    /// <summary>
    /// StackPanel Adapter. 指定区域时，StackPanel可被指定为区域。
    /// </summary>
    public class StackPanelAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {

        }

        /// <summary>
        /// 当 区域中的视图发生变化时，调用此方法进行适配（添加、显示）。
        /// </summary>
        /// <param name="region">装载视图的区域（容器）</param>
        /// <param name="regionTarget">区域（容器）的类型</param>
        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach ( FrameworkElement item in e.NewItems)
                    {
                        regionTarget.Children.Add(item);
                    }
                }
            };
        }

        /// <summary>
        /// 区域适配器都需要一个Region对象。
        /// </summary>
        /// <returns>装载视图的区域（容器）</returns>
        protected override IRegion CreateRegion()
        {
            return new Region();
        }
    }
}
