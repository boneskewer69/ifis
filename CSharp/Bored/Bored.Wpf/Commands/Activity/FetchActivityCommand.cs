using System;

using Bored.Wpf.ViewModels;
using Bored.Core.Interfaces;

namespace Bored.Wpf.Commands
{
    public class FetchActivityCommand : BaseCommand
    {
        private readonly ActivityViewModel _viewModel;
        private readonly IActivityService _activityService;


        public FetchActivityCommand(ActivityViewModel viewModel,
                                      IActivityService activityService)
        {
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));
            _activityService = activityService ??
                throw new ArgumentNullException(nameof(activityService));
        }


        public override async void Execute(object parameter)
        {
            var result = await _activityService.LoadRandomActivityAsync();
            
            _viewModel.Description = result.Description;
            _viewModel.NumberOfParticipants = result.NumberOfParticipants;
            _viewModel.Price = result.Price;
            _viewModel.Type = result.Type;
        }
    }
}
