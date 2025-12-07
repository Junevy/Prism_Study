using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_Dialog.Models;

namespace Prism_Dialog.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand OpenDialogCommand { get; set; }
        public DelegateCommand OpenAdminDialogCommand { get; set; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            //Open dialog
            OpenDialogCommand = new DelegateCommand(() =>
            {
                IDialogParameters dialogParams = new DialogParameters();
                dialogParams.Add("Message", "Hello frome MainWindowViewModel");
                dialogParams.Add(nameof(UserModel), new UserModel() { Id = 01, Name = "Junevy", Age = 25 });

                dialogService.Show("UserView", dialogParams, null); // Main window can be operated while dialog is open.
                //dialogService.ShowDialog("UserView");   // Main window cannot be operated while dialog is open.

            });

            OpenAdminDialogCommand = new DelegateCommand(() =>
            {
                dialogService.Show("AdminView");
            });
        }
    }
}
