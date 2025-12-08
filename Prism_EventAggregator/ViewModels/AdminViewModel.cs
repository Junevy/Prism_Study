using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;
using Prism_EventAggregator.Models;
using System;
using System.Windows;

namespace Prism_EventAggregator.ViewModels
{
    public class AdminViewModel : IDialogAware
    {
        public string Title => "Admin";

        public event Action<IDialogResult> RequestClose;
        public DelegateCommand SubscribeCommand { get; set; }
        public DelegateCommand SubValidateCommand { get; set; }

        public AdminViewModel(IEventAggregator aggregator)
        {
            SubscribeCommand = new DelegateCommand(() =>
            {
                aggregator.GetEvent<MsgEventArgs>().Subscribe(() =>
                {
                    MessageBox.Show("Admin Received a Message");
                });
            });

            SubValidateCommand = new DelegateCommand(() =>
            {
                aggregator.GetEvent<ValidateEventArgs>().Subscribe((r) =>
                {
                    MessageBox.Show($"The validation result is {r}");
                });
            });
        }

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
