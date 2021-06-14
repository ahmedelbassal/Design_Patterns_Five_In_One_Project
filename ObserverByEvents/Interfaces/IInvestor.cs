using ObserverByEvents.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByEvents.Interfaces
{
    interface IInvestor
    {
        void Update(object sender,ChangeEventArgs e);
    }
}
