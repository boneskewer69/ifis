using System;

using Bored.Wpf.ViewModels;

namespace Bored.Wpf.Commands
{
    public class FavourActivityCommand : BaseCommand
    {
        private readonly ActivityViewModel _viewModel;


        public FavourActivityCommand(ActivityViewModel viewModel)
        {
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));
        }


        public override bool CanExecute(object parameter) => !_viewModel.IsLocked;

        public override void Execute(object parameter)
        {
            _viewModel.IsLocked = true;
        }
    }
}
