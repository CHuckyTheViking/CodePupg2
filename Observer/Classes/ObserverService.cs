using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.Classes
{
    class ObserverService<X>
    {
        private List<IObserver<X>> observers = new List<IObserver<X>>();
        private X subject;

        public X Subject
        {
            get => subject;
            set
            {
                subject = value;
                Notify();
            }
        }

        public void Register(IObserver<X> observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver<X> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(subject);
            }
        }

    }
}
