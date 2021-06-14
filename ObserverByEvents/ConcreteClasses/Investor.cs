using ObserverByEvents.abstract_classes;
using ObserverByEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByEvents.ConcreteClasses
{
    class Investor : IInvestor
    {
        public String _Name { get; set; }
        public Stock _Stock { get; set; }

        public void Update(object sender, ChangeEventArgs e)
        {
            Console.WriteLine($"Notified {e.symbol} that price has been changed to {e.price}");
        }
    }
}
