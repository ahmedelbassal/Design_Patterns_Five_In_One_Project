using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherObserver.Interfaces;

namespace WeatherObserver.Entities
{
    class WeatherData : IPublisher
    {
        public float _humdity { get; set; }
        public float _pressure { get; set; }
        public float _temperature { get; set; }
        public List<ISubscriber> _subscribers { get; set; }

        public WeatherData(float humdity, float pressure, float temperature)
        {
            _temperature = temperature;_humdity = humdity;_pressure = pressure;
        }

        public WeatherData()
        {
           
        }

        private event EventHandler<ChangeEventArgs> MeasurementsChanged;

        public void NotifySubscribers(ChangeEventArgs e)
        {
            if (MeasurementsChanged != null)
            {
                MeasurementsChanged.Invoke(this,e);
            }
        }

        public void SetMeasurements(float Humidity, float Pressure, float Temperature)
        {

            _humdity = Humidity;_pressure = Pressure;_temperature = Temperature;

            if (MeasurementsChanged != null)
            {
                NotifySubscribers(new ChangeEventArgs { _temperature = Temperature, _pressure = Pressure, _humdity = _humdity });
            }
        }



        public void RegisterSubscriber(ISubscriber newSubscriber)
        {
            MeasurementsChanged += newSubscriber.Display;
            MeasurementsChanged += newSubscriber.Update;
        }

        public void RemoveSubscriber(ISubscriber removedSubscriber)
        {
            MeasurementsChanged -= removedSubscriber.Display;
            MeasurementsChanged -= removedSubscriber.Update;

        }
    }
}
