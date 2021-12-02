using System;

using Bored.Wpf.Commands;
using Bored.Wpf.Navigation;
using Bored.Wpf.ViewModels.Base;
using Bored.Wpf.ViewModels.Factories;

namespace Bored.Wpf.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public readonly IViewModelFactory ViewModelFactory;
        public readonly INavigator Navigator;

        public BaseViewModel CurrentViewModel => Navigator.CurrentViewModel;

        public BaseCommand UpdateCurrentViewModelCommand { get; }


        public MainViewModel(INavigator navigator, IViewModelFactory viewModelFactory)
        {
            Navigator = navigator ??
                throw new ArgumentNullException(nameof(navigator));
            ViewModelFactory = viewModelFactory ??
                throw new ArgumentNullException(nameof(viewModelFactory));
            
            Navigator.StateChanged += NavigatorStateChanged;

            UpdateCurrentViewModelCommand = new NavigateCommand(Navigator, ViewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Activities);
        }


        private void NavigatorStateChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public override void Dispose()
        {
            Navigator.StateChanged -= NavigatorStateChanged;

            base.Dispose();
        }
    }
}
