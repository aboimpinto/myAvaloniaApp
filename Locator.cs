using Extensions;
using myAvaloniaApp.ViewModels;

namespace myAvaloniaApp
{
    public class Locator
    {
        public object this[string item]
        {
            get 
            {
                var viewModel = Program.ServiceProvider.GetService<IViewModel>(item); 
                return viewModel;
            }
        }
    }
}