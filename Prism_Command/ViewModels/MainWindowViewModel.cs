using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace Prism_Command.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                RaisePropertyChanged();
                ChangeMsgCommand.RaiseCanExecuteChanged();  //Notify the command that the CanExecute value have changed.
            }
        }
        private void ChangeMsg()
        {
            Message = "Message Changed.";
        }
        private bool CanChangeMsg() => !string.IsNullOrEmpty(Message);
        public DelegateCommand ChangeMsgCommand { get; set; }


        private int userId;
        public int UserId
        {
            get { return userId; }
            set { SetProperty(ref userId, value); SubmitUserIdCommand.RaiseCanExecuteChanged(); }
        }
        public DelegateCommand<string> SubmitUserIdCommand { get; set; }
        public void SubmitUserId(string id)
        {
            MessageBox.Show($"User ID {id} submitted.");
        }
        private bool IsUserIdValid(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            if (int.TryParse(id, out int _id))
            {
                return _id > 0;
            }
            return false;
        }

        public MainWindowViewModel()
        {
            ChangeMsgCommand = new(ChangeMsg, CanChangeMsg);
            SubmitUserIdCommand = new(SubmitUserId, IsUserIdValid);
        }
    }
}
