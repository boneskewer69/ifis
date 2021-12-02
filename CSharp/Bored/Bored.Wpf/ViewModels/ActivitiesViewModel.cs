using System.Collections.ObjectModel;

using Bored.Wpf.Commands;
using Bored.Wpf.ViewModels.Base;
using Bored.Core.Interfaces;

namespace Bored.Wpf.ViewModels
{
    public class ActivitiesViewModel : BaseViewModel
    {
        #region Properties
        private ObservableCollection<ActivityViewModel> _activityViewModels = new();
        public ObservableCollection<ActivityViewModel> ActivityViewModels
        {
            get => _activityViewModels;
            set
            {
                if (value == _activityViewModels) return;
                _activityViewModels = value;
                OnPropertyChanged(nameof(ActivityViewModels));
            }
        }

        private bool _notBusy = true;
        public bool NotBusy
        {
            get => _notBusy;
            set
            {
                if (value == _notBusy) return;
                _notBusy = value;
                OnPropertyChanged(nameof(NotBusy));
                FetchActivities.RaiseCanExecuteChangedEvent();
                UnlockActivities.RaiseCanExecuteChangedEvent();
            }
        }

        private ActivityViewModel _selectedActivity;
        public ActivityViewModel SelectedActivity
        {
            get => _selectedActivity;
            set
            {
                if (value == _selectedActivity) return;
                _selectedActivity = value;
                OnPropertyChanged(nameof(SelectedActivity));
            }
        }
        #endregion

        #region Commands
        public BaseCommand FetchActivities { get; }
        public BaseCommand UnlockActivities { get; }
        public BaseCommand SelectedActivityChanged { get; }
        #endregion

        #region Constructor
        public ActivitiesViewModel(IActivityService activityService)
        {
            FetchActivities = new FetchActivitiesCommand(this, activityService);
            UnlockActivities = new UnlockActivitiesCommand(this);
            SelectedActivityChanged = new SelectedActivityChangedCommand(this);

            FetchActivities.Execute(null);
        }
        #endregion
    }
}
