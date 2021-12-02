using System;
using System.Linq;

using Bored.Wpf.Converters;
using Bored.Wpf.ViewModels;
using Bored.Core.Interfaces;

namespace Bored.Wpf.Commands
{
    public class FetchActivitiesCommand : BaseCommand
    {
        private readonly ActivitiesViewModel _viewModel;
        private readonly IActivityService _activityService;


        public FetchActivitiesCommand(ActivitiesViewModel viewModel,
                                      IActivityService activityService)
        {
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));
            _activityService = activityService ??
                throw new ArgumentNullException(nameof(activityService));
        }

        public override bool CanExecute(object parameter) => _viewModel.NotBusy;

        public override async void Execute(object parameter)
        {
            _viewModel.NotBusy = false;
            _viewModel.SelectedActivity = null;

            try
            {
                var results = await _activityService.LoadRandomActivitiesAsync(50);
                var lockedActivities = _viewModel.ActivityViewModels.ToList().Where(x => x.IsLocked).ToList();

                _viewModel.ActivityViewModels.Clear();
                
                lockedActivities.ForEach(a => _viewModel.ActivityViewModels.Add(a));
                results.ForEach(r =>
                    _viewModel.ActivityViewModels.Add(
                        new ActivityViewModel(r.ToWpfModel())));
            }
            finally
            {
                _viewModel.NotBusy = true;
            }
        }
    }
}
