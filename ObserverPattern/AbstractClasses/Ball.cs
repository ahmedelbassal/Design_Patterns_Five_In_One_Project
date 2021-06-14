using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.AbstractClasses
{
  abstract  class Ball
    {
        protected List<Observer> observers = new List<Observer>();

        public void AttachObserver(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void DeAttachObserver(Observer RemovedObserver)
        {
            observers.Remove(RemovedObserver);
        }

        protected void NotifyObservers()
        {
            foreach (Observer observ in observers)
            {
                observ.Update();
            }
        }

    }
}
