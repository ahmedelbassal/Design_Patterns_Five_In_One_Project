using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByEvents.ConcreteClasses
{
    class ChangeEventArgs:EventArgs
    {
        public String symbol { get; set; }
        public double price { get; set; }
    }
}
