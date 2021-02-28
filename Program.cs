using Avalonia;
// using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;
using Extensions;
using Microsoft.Extensions.DependencyInjection;
using myAvaloniaApp.ViewModels;
using ViewModels;

namespace myAvaloniaApp
{
    class Program
    {
        private static ServiceProvider _serviceProvider;
        public static ServiceProvider ServiceProvider => _serviceProvider;

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args)
        {
            // Locator.CurrentMutable.Register<IViewModel, MainWindowViewModel>();
            _serviceProvider = new ServiceCollection()
                .AddScoped<IViewModel, MainWindowViewModel>("MainWindowViewModel")
                .AddScoped<IViewModel, MainViewModel>("MainViewModel")
                .BuildServiceProvider();

            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        } 
        
        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                // .LogToDebug()
                .UseReactiveUI();
    }
}
