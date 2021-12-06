using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;

namespace Anrede
{
    public class SalutationViewModel : Subject, INotifyPropertyChanged
    {
        #region Singleton
        private SalutationViewModel() { }
        private static readonly SalutationViewModel singleton = new();
        public static SalutationViewModel Singleton => singleton;
        #endregion

        #region Fields
        private string _title = string.Empty;
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private bool _isMale = true;
        private List<IObserver> _observers = new();
        #endregion

        #region Props
        public string Firstname
        {
            get => _firstname;
            set
            {
                if (value == _firstname)
                    return;

                _firstname = value;
                
                InvokePropertyChanged(nameof(Firstname));
                InvokePropertyChanged(nameof(Salutation));
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                if (value == _lastname)
                    return;

                _lastname = value;

                InvokePropertyChanged(nameof(Lastname));
                InvokePropertyChanged(nameof(Salutation));
            }
        }
        public object Title
        {
            get => _title;
            set
            {
                var newValue = ((ComboBoxItem)value).Content.ToString();

                if (newValue == _title)
                    return;

                _title = newValue;

                InvokePropertyChanged(nameof(Title));
                InvokePropertyChanged(nameof(Salutation));
            }
        }
        public bool IsMale
        {
            get => _isMale;
            set
            {
                if (value == _isMale)
                    return;

                _isMale = value;

                InvokePropertyChanged(nameof(IsMale));
                InvokePropertyChanged(nameof(Salutation));
            }
        }
        public string Salutation => $"{(IsMale ? "Herr" : "Frau")} {((Title.ToString() == "--") ? "" : Title.ToString() + " ")}{Firstname} {Lastname}";
        public bool IsFelmale => !IsMale;
        #endregion

        #region PropChange
        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propName));
        }
        #endregion

        #region Subject
        public override TSubject GetState<TSubject>()
        {
            if (this is TSubject subject)
                return subject;

            return default;
        }
        #endregion
    }
}
