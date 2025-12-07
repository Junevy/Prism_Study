using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_Dialog.Models;
using System;

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

                var dialogResult = new DialogResult();
                dialogResult.Parameters.Add(nameof(Message), "All request processed!");

                //Transmit data back to MainWindowViewModel
                RequestClose?.Invoke(dialogResult);
            });
        }

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
            ///
            /// Summary:
            ///     The method will be DialogResult out of life cycle.
            ///
            //var dialogResult = new DialogResult();
            //dialogResult.Parameters.Add(nameof(Message), "All request processed!");
            //RequestClose?.Invoke(dialogResult);

            //RequestClose?.Invoke(new DialogResult(ButtonResult.OK, dialogParams));
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>(nameof(Message));
            User = parameters.GetValue<UserModel>(nameof(UserModel));
        }
    }
}
