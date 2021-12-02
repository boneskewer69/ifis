using Bored.Wpf.Navigation;
using Bored.Wpf.ViewModels.Base;

namespace Bored.Wpf.ViewModels.Factories
{
    public interface IViewModelFactory
    {
        BaseViewModel CreateViewModel(ViewType viewType);
    }
}
