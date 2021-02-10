using myAvaloniaApp.ViewModels;
using ReactiveUI;

namespace ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _message;

        public string Message 
        { 
            get => this._message; 
            set => this.RaiseAndSetIfChanged(ref this._message, value);
        }

        public MainViewModel()
        {
            this.Message = "Set in the ViewModel";
        }
    }
}