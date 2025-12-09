using Prism.Mvvm;

namespace Prism_Module_B.ViewModels
{
    public class Module_BViewModel : BindableBase
    {
        private string title = "Module B";
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
