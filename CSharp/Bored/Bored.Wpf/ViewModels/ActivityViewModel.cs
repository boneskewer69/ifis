using System;
using Bored.Wpf.Models;
using Bored.Wpf.Commands;
using Bored.Wpf.ViewModels.Base;
using Bored.Core.Interfaces;

namespace Bored.Wpf.ViewModels
{
    public class ActivityViewModel : BaseViewModel
    {
        #region Fields
        private readonly IActivityService _activityService;
        #endregion

        #region Properties
        private bool _isLocked = false;
        public bool IsLocked
        {
            get => _isLocked;
            set
            {
                if (value == _isLocked) return;
                _isLocked = value;
                OnPropertyChanged(nameof(IsLocked));
                FavourActivity.RaiseCanExecuteChangedEvent();
                DefavourActivity.RaiseCanExecuteChangedEvent();
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private string _type;
        public string Type
        {
            get => _type;
            set
            {
                if (value == _type) return;
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private int _numberOfParticipants;
        public int NumberOfParticipants
        {
            get => _numberOfParticipants;
            set
            {
                if (value == _numberOfParticipants) return;
                _numberOfParticipants = value;
                OnPropertyChanged(nameof(NumberOfParticipants));
            }
        }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value == _price) return;
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        private string _link;
        public string Link
        {
            get => _link;
            set
            {
                if (value == _link) return;
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }
        #endregion

        #region Commands
        public BaseCommand FetchActivity { get; }
        public BaseCommand FavourActivity { get; }
        public BaseCommand DefavourActivity { get; }
        public BaseCommand OpenWebsite { get; }
        #endregion

        #region Constructor
        public ActivityViewModel(IActivityService activityService)
        {
            _activityService = activityService ??
                throw new ArgumentNullException(nameof(activityService));

            FavourActivity = new FavourActivityCommand(this);
            DefavourActivity = new DefavourActivityCommand(this);
            OpenWebsite = new OpenWebsiteCommand(this);

            FetchActivity = new FetchActivityCommand(this, activityService);
        }

        public ActivityViewModel(Activity activity)
        {
            NumberOfParticipants = activity.NumberOfParticipants;
            Description = activity.Description;
            Price = activity.Price;
            Type = activity.Type;
            Link = activity.Link;

            FavourActivity = new FavourActivityCommand(this);
            DefavourActivity = new DefavourActivityCommand(this);
            OpenWebsite = new OpenWebsiteCommand(this);
        }
        #endregion
    }
}
