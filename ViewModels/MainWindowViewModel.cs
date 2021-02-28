using System.Windows.Input;
using ReactiveUI;

namespace myAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int countClick = 0;
        private string _greeting;
        private bool _closeApplication;

        public string Greeting 
        { 
            get => this._greeting;
            set => this.RaiseAndSetIfChanged(ref this._greeting, value);
        }

        public bool CloseApplication 
        { 
            get => this._closeApplication; 
            set => this.RaiseAndSetIfChanged(ref this._closeApplication, value);
        }

        public ICommand ClickMeCommand { get; }

        public ICommand CloseApplicationCommand { get; }

        public MainWindowViewModel()
        {
            this.Greeting = "No clicks observed";

            this.ClickMeCommand = ReactiveCommand.Create(this.OnClickMe);
            this.CloseApplicationCommand = ReactiveCommand.Create(this.OnCloseApplication); 
        }

        private void OnCloseApplication()
        {
            this.CloseApplication = true;            
        }

        private void OnClickMe()
        {
            countClick ++;
            this.Greeting = $"Clicks: {this.countClick}";
        }
    }
}
