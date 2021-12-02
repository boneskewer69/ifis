using System;

using Bored.Wpf.ViewModels;

namespace Bored.Wpf.Commands
{
    public class UnlockActivitiesCommand : BaseCommand
    {
        private readonly ActivitiesViewModel _viewModel;


        public UnlockActivitiesCommand(ActivitiesViewModel viewModel)
        {
            _viewModel = viewModel
                ?? throw new ArgumentNullException(nameof(viewModel));
        }


        public override bool CanExecute(object parameter) => _viewModel.NotBusy;

        public override void Execute(object parameter)
        {
            _viewModel.NotBusy = false;

            foreach (var viewModel in _viewModel.ActivityViewModels)
                viewModel.IsLocked = false;

            _viewModel.NotBusy = true;
        }
    }
}
