using Prism.Ioc;
using Prism_Dialog.Views;
using System.Windows;

namespace Prism_Dialog
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
            containerRegistry.RegisterDialog<UserView>();
            containerRegistry.RegisterDialog<AdminView>();

            containerRegistry.RegisterDialogWindow<DefaultView>();  // Register default dialog window(style).
        }
    }
}
