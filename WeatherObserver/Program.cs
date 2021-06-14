using System;
using WeatherObserver.Entities;

namespace WeatherObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData(25, 80, 40);

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay { _WeatherData = weatherData };
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay { _WeatherData = weatherData };
            CurrentConditions currentConditions = new CurrentConditions { _WeatherData = weatherData };
            ForecastDisplay forecastDisplay = new ForecastDisplay { _WeatherData=weatherData};

            weatherData.RegisterSubscriber(statisticsDisplay);
            weatherData.RegisterSubscriber(heatIndexDisplay);
            weatherData.RegisterSubscriber(currentConditions);
            weatherData.RegisterSubscriber(forecastDisplay);

            Console.WriteLine("When set temperature for different value");
            weatherData.SetMeasurements(17, 80, 38);


            Console.WriteLine("\n\nWhen set temperature for different value");
            weatherData.SetMeasurements(30, 40, 58);

        }
    }
}
