using System.Windows;

using Bored.Core;
using Bored.Core.Configuration;
using Bored.DataAccess;
using Bored.Wpf.Navigation;
using Bored.Wpf.ViewModels;
using Bored.Wpf.ViewModels.Factories;

namespace Bored.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
{
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var apiConfiguration = new BoredApiConfiguration();
            var activityRepository = new ActivityRepository(apiConfiguration);
            var activityService = new ActivityService(activityRepository);

            var navigator = new Navigator();

            var viewModelFactory = new ViewModelFactory(activityService);
            var mainViewModel = new MainViewModel(navigator, viewModelFactory);
            
            var window = new MainWindow(mainViewModel);
            window.Show();
        }
    }
}
