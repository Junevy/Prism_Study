using Prism.Services.Dialogs;
using System.Windows;

namespace Prism_Dialog.Views
{
    /// <summary>
    /// DefaultView.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultView : Window, IDialogWindow
    {
        public DefaultView()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }
    }
}
