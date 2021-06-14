using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Interfaces;

namespace WeatherObserver.Entities
{
    class CurrentConditions : ISubscriber, IDisplayElement
    {
        private float _Humdity;
        private float _Temperature;
        public WeatherData _WeatherData;


        void IDisplayElement.Display(object sender, ChangeEventArgs e)
        {
            Console.WriteLine($"Notified CurrentConditions temperature: {_WeatherData._temperature} pressure: {_WeatherData._pressure} humidity: {_WeatherData._humdity}");
            CurrentConditionsDisplay();
        }
        void CurrentConditionsDisplay()
        {
            Console.WriteLine($"CurrentConditionsDisplay: _Humdity {_Temperature}  _Temperature {_Temperature}");
        }

        void ISubscriber.Update(object sender, ChangeEventArgs e)
        {
            _Humdity = e._humdity ;
            _Temperature = e._temperature ;
        }
    }
}
