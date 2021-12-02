using System.ComponentModel;

namespace Bored.Wpf.ViewModels.Base
{
    /// <summary>
    /// Base view model that fires PropertyChanged events
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public virtual void Dispose() { }

        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method for properties to call whenever its value gets modified
        /// </summary>
        /// <param name="propertyName">Name of the changing property</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
