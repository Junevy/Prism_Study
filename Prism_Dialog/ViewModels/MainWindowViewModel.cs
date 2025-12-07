using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

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

        public MainWindowViewModel(IDialogService dialogService)
        {
            //Open dialog
            OpenDialogCommand = new DelegateCommand(() =>
            {
                //dialogService.Show("UserView"); // Main window can be operated while dialog is open.
                dialogService.ShowDialog("UserView");   // Main window cannot be operated while dialog is open.
            });
        }
    }
}
