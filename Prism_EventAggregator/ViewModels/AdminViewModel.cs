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
        private readonly IEventAggregator eventAggregator;
        public string Title => "Admin";

        public event Action<IDialogResult> RequestClose;
        public DelegateCommand SubscribeCommand { get; set; }
        public DelegateCommand SubValidateCommand { get; set; }
        public DelegateCommand CancelSubscribeCommand { get; set; }

        public AdminViewModel(IEventAggregator aggregator)
        {
            this.eventAggregator = aggregator;

            SubscribeCommand = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MsgEventArgs>().Subscribe(SubscribeEvents);
            });

            // subscribe event and filter
            SubValidateCommand = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<ValidateEventArgs>().Subscribe((r) =>
                {
                    MessageBox.Show($"The admin validation result is {r}");
                }, ThreadOption.PublisherThread, false,

                // a filter that inverts the bool
                (r) => { return !r; });
            });

            CancelSubscribeCommand = new DelegateCommand(() =>
            {
                eventAggregator.GetEvent<MsgEventArgs>().Unsubscribe(SubscribeEvents);
            });
        }

        private void SubscribeEvents()
        {
            MessageBox.Show("Admin Received a Message");
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
