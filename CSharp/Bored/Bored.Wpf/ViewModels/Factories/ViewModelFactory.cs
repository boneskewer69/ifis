using System;

using Bored.Core.Interfaces;
using Bored.Wpf.Navigation;
using Bored.Wpf.ViewModels.Base;

namespace Bored.Wpf.ViewModels.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly IActivityService _activityService;


        public ViewModelFactory(IActivityService activityService)
        {
            _activityService = activityService ??
                throw new ArgumentNullException(nameof(activityService));
        }


        public BaseViewModel CreateViewModel(ViewType viewType)
        {
            return viewType switch
            {
                ViewType.Activities => new ActivitiesViewModel(_activityService),
                _ => throw new ArgumentException("The ViewType does not have a ViewModel.", nameof(viewType)),
            };
        }
    }
}
