using System.Collections.Generic;

namespace Anrede
{
    public abstract class Subject
    {
        private List<IObserver> _observers = new();

        public virtual void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public virtual void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public virtual void Notify()
        {
            _observers.ForEach(x => x.Update());
        }

        public abstract TSubject GetState<TSubject>();
    }
}
