using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Prism_Navigation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand OpenAdminCommand { get; set; }
        public DelegateCommand OpenUserCommand { get; set; }
        public DelegateCommand ForwardCommand { get; set; }
        public DelegateCommand BackCommand { get; set; }

        public MainWindowViewModel(IRegionManager manager)
        {
            this.regionManager = manager;
            OpenAdminCommand = new DelegateCommand(ToAdmin);
            OpenUserCommand = new DelegateCommand(ToUser);
            ForwardCommand = new DelegateCommand(Forward);
            BackCommand = new DelegateCommand(Back);
        }

        private void Back()
        {
        }

        private void Forward()
        {
        }

        private void ToUser()
        {
            regionManager.RequestNavigate("ContentRegion", "User");
        }

        private void ToAdmin()
        {
            regionManager.RequestNavigate("ContentRegion", "Admin");
        }
    }
}
