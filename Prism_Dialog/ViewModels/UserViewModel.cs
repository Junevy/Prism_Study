using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_Dialog.Models;
using System;
using System.Windows;

namespace Prism_Dialog.ViewModels
{
    public class UserViewModel : BindableBase, IDialogAware
    {
        public string Title => "User Dialog";
        public event Action<IDialogResult> RequestClose;

        private string message;

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public UserModel User { get; set; }

        public DelegateCommand ChangeUserInfo { get; set; }


        public UserViewModel()
        {
            ChangeUserInfo = new(() =>
            {
                User.Name = "Junevy and Zing";
                User.Age = 18;
                User.Id += 1;
            });
        }

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
            MessageBox.Show("User Dialog Closed");
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>(nameof(Message));
            User = parameters.GetValue<UserModel>(nameof(UserModel));
        }
    }
}
