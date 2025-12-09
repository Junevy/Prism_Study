using Prism.Mvvm;

namespace Prism_Module_C.ViewModels
{
    public class Module_CViewModel : BindableBase
    {
        private string msg = "Module CCCCCC";
        public string Msg
        {
            get => msg;
            set
            {
                SetProperty(ref msg, value);
                RaisePropertyChanged();
            }
        }
    }
}
