using Prism.Services.Dialogs;
using System;

namespace Prism_Dialog.ViewModels
{
    internal class AdminViewModel : IDialogAware
    {
        public string Title => "Admin Dialog";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
    }
}
