using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Entities;

namespace WeatherObserver.Interfaces
{
    interface  ISubscriber:IDisplayElement
    {
        void Update(object sender,ChangeEventArgs e);
    }
}
