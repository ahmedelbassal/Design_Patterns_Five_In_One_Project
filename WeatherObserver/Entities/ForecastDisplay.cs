using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Interfaces;

namespace WeatherObserver.Entities
{
    internal class ForecastDisplay : ISubscriber, IDisplayElement
    {

        private float _currentPressure;
        private float _lastPressure;
        public WeatherData _WeatherData;

        void IDisplayElement.Display(object sender, ChangeEventArgs e)
        {
            Console.WriteLine($"Notified ForecastDisplay  pressure: {_WeatherData._pressure} ");
            ForecastDisplayFunc();
        }
        void ForecastDisplayFunc()
        {
            Console.WriteLine($"ForecastDisplay  : current pressure : {_currentPressure}");
        }


        void ISubscriber.Update(object sender, ChangeEventArgs e)
        {
            _currentPressure = e._pressure;
        }
    }
}
