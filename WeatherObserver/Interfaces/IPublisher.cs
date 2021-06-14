using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Entities;

namespace WeatherObserver.Interfaces
{
    interface IPublisher
    {
        void NotifySubscribers(ChangeEventArgs e);
        void RegisterSubscriber(ISubscriber newSubscriber);
        void RemoveSubscriber(ISubscriber removedSubscriber);

    }
}
