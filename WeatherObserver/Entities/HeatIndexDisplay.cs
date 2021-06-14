using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Interfaces;

namespace WeatherObserver.Entities
{
    class HeatIndexDisplay : ISubscriber, IDisplayElement
    {

        private float _HeatIndex;
        public WeatherData _WeatherData;

        void IDisplayElement.Display(object sender, ChangeEventArgs e)
        {
            Console.WriteLine($"Notified HeatIndexDisplay temperature: {_WeatherData._temperature} pressure: {_WeatherData._pressure} humidity: {_WeatherData._humdity}");
            HeatIndexDisplayFunc();
        }

        void ISubscriber.Update(object sender, ChangeEventArgs e)
        {
            _HeatIndex = e._temperature/100;

        }

        void HeatIndexDisplayFunc()
        {
            Console.WriteLine($"temperature = {_HeatIndex*100} and assumed headindex={_HeatIndex}");
        }
        
        void ComputeHeatIndexDisplay()
        {
            Console.WriteLine("Computed heat index");
        }
    }
}
