using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace Prism_Module.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand NavigateACommand { get; set; }
        public DelegateCommand NavigateBCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;

            NavigateACommand = new DelegateCommand(NavigateA);
            NavigateBCommand = new DelegateCommand(NavigateB);
        }

        private void NavigateB()
        {
            _regionManager.Regions["ContentRegion"].RequestNavigate("Module_BView");
        }

        private void NavigateA()
        {
            _regionManager.Regions["ContentRegion"].RequestNavigate("Module_AView");
        }
    }
}
