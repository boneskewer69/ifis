using System;

using Bored.Wpf.Navigation;
using Bored.Wpf.ViewModels.Factories;

namespace Bored.Wpf.Commands
{
    public class NavigateCommand : BaseCommand
    {
        private readonly INavigator _navigator;
        private readonly IViewModelFactory _viewModelFactory;


        public NavigateCommand(INavigator navigator, IViewModelFactory viewModelFactory)
        {
            _navigator = navigator ??
                throw new ArgumentNullException(nameof(navigator));
            _viewModelFactory = viewModelFactory ??
                throw new ArgumentNullException(nameof(viewModelFactory));
        }


        public override void Execute(object parameter)
        {
            if (parameter is ViewType viewType)
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
        }
    }
}
