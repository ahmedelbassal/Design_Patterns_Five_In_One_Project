using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Interfaces;

namespace WeatherObserver.Entities
{
    class StatisticsDisplay: IDisplayElement, ISubscriber
    {

        private float _minTemp;
        private float _maxTemp;
        private int _numReadings = 0;
        private float _tempSum;
        public WeatherData _WeatherData;

        void IDisplayElement.Display(object sender, ChangeEventArgs e)
        {
            Console.WriteLine($"Notified statistics temperature: {_WeatherData._temperature} pressure: {_WeatherData._pressure} humidity: {_WeatherData._humdity}");
            StatisticsDisplayFunc();
        }
        void StatisticsDisplayFunc()
        {
            Console.WriteLine($"_maxTemp {_maxTemp} _minTemp {_minTemp} _numReadings {_numReadings}");
        }

        void ISubscriber.Update(object sender, ChangeEventArgs e)
        {
            _maxTemp = e._temperature+15;
            _minTemp = e._temperature-15;
            _numReadings++;
          

        }
    }
}
