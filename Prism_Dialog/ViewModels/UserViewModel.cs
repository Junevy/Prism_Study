using Prism.Services.Dialogs;
using System;
using System.Windows;

namespace Prism_Dialog.ViewModels
{
    public class UserViewModel : IDialogAware
    {
        public string Title => "User Dialog";
        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog() => false;

        public void OnDialogClosed()
        {
            MessageBox.Show("User Dialog Closed");
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }
    }
}
