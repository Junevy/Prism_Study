using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;
using Prism_EventAggregator.Models;
using System;
using System.Windows;

namespace Prism_EventAggregator.ViewModels
{
    public class UserViewModel : IDialogAware
    {
        public string Title => "User";

        public event Action<IDialogResult> RequestClose;

        public DelegateCommand SubscribeCommand { get; set; }


        public UserViewModel(IEventAggregator aggregator)
        {
            SubscribeCommand = new DelegateCommand(() =>
            {
                aggregator.GetEvent<MsgEventArgs>().Subscribe(() =>
                {
                    MessageBox.Show("User Received a Message");
                });


                aggregator.GetEvent<ValidateEventArgs>().Subscribe((r) => {
                    MessageBox.Show($"The user validation result is {r}");
                },
                    ThreadOption.PublisherThread,
                    false,
                    (r) => { return r; });
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
