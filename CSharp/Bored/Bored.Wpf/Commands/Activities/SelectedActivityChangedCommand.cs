using System;

using Bored.Wpf.ViewModels;

namespace Bored.Wpf.Commands
{
    public class SelectedActivityChangedCommand : BaseCommand
    {
        private ActivitiesViewModel _viewModel;


        public SelectedActivityChangedCommand(ActivitiesViewModel viewModel)
        {
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));
        }


        public override void Execute(object parameter)
        {
            if (parameter is ActivityViewModel activityViewModel)
                _viewModel.SelectedActivity = activityViewModel;
        }
    }
}
