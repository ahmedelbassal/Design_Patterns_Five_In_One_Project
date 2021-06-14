using ObserverByEvents.ConcreteClasses;
using System;

namespace ObserverByEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM IBMCar = new IBM(102_000_000.500);

            IBMCar.Attach(new Investor { _Name = "Bill Gates" });
            IBMCar.Attach(new Investor { _Name = "Zuckunberg" });
            IBMCar.Attach(new Investor { _Name = "Eleon Musk" });
            IBMCar.Attach(new Investor { _Name = "Angela Merkel" });

            IBMCar.price = 99_000_000;
            IBMCar.price = 105_000_000.154;
            IBMCar.price = 120_000_000.5;
            IBMCar.price = 97_000_000.44;

        }
    }
}
