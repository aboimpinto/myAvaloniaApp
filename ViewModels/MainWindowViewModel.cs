using System.Windows.Input;
using ReactiveUI;

namespace myAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int countClick = 0;
        private string greeting;

        public string Greeting 
        { 
            get => this.greeting;
            set => this.RaiseAndSetIfChanged(ref this.greeting, value);
        }

        public ICommand ClickMeCommand { get; }

        public MainWindowViewModel()
        {
            this.Greeting = "No clicks observed";

            this.ClickMeCommand = ReactiveCommand.Create(this.OnClickMe); 
        }

        private void OnClickMe()
        {
            countClick ++;
            this.Greeting = $"Clicks: {this.countClick}";
        }
    }
}
