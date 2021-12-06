using System.Collections.Generic;

namespace Anrede
{
    public class History : IObserver
    {
        private readonly Subject _subject = SalutationViewModel.Singleton;
        private readonly List<string> _saltuations = new();

        public void Update()
        {
            _saltuations.Add(_subject.GetState<SalutationViewModel>().Salutation);
        }

        public void Clear()
        {
            _saltuations.Clear();
        }
    }
}
