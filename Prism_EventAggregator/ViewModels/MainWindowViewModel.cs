using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism_EventAggregator.Models;

namespace Prism_EventAggregator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand PublishCommand { get; set; }
        public DelegateCommand OpenAdminDialog { get; set; }
        public DelegateCommand OpenUserDialog { get; set; }

        public MainWindowViewModel(IDialogService dialogService, IEventAggregator aggregator)
        {
            OpenAdminDialog = new DelegateCommand(() =>
            {
                dialogService.Show("AdminView");
            });

            OpenUserDialog = new DelegateCommand(() =>
            {
                dialogService.Show("UserView");
            });

            PublishCommand = new DelegateCommand(() =>
            {
                aggregator.GetEvent<MsgEventArgs>().Publish();
            });
        }
    }
}
