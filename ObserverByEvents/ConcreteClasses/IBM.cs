using ObserverByEvents.abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByEvents.ConcreteClasses
{
    class IBM:Stock
    {
        public IBM(double _Price) : base(Symbol:"IBM", Price: _Price) { }
    
    }
}
