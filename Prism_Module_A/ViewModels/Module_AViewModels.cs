using Prism.Mvvm;

namespace Prism_Module_A.ViewModels
{
    public class Module_AViewModels : BindableBase
    {
        private string title = "Module A";
        public string Title
        {
            get => title;
            set
            {
                SetProperty(ref title, value);
                RaisePropertyChanged();
            }
        }
    }
}
