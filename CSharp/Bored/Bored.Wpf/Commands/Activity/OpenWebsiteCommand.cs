using System;
using System.Diagnostics;

using Bored.Wpf.ViewModels;

namespace Bored.Wpf.Commands
{
    public class OpenWebsiteCommand : BaseCommand
    {
        private readonly ActivityViewModel _viewModel;


        public OpenWebsiteCommand(ActivityViewModel viewModel)
        {
            _viewModel = viewModel ??
                throw new ArgumentNullException(nameof(viewModel));
        }


        public override bool CanExecute(object parameter) =>
            !string.IsNullOrWhiteSpace(_viewModel.Link);

        public override void Execute(object parameter)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = _viewModel.Link,
                UseShellExecute = true
            };

            _ = Process.Start(processStartInfo);
        }
    }
}
