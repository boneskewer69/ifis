using System;

using Bored.Wpf.ViewModels.Base;

namespace Bored.Wpf.Navigation
{
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
