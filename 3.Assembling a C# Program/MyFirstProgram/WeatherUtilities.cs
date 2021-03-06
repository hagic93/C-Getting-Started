using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;  // or float temperatureCelsius = (float)((temperatureFahrenheit - 32) / 1.8);
            return temperatureCelsius;
        }

        static public float CelsiusToFahrenheit(float temperatureCelsius)
        {
            float temperatureFahrenheit = temperatureCelsius * 1.8f + 32;
            return temperatureFahrenheit;
        }

        // The higher the index, the lower the comfort.
        static private float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula:
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            float temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity)); // or Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}
