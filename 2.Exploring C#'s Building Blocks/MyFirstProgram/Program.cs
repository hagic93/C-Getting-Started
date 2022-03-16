using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;  // or float temperatureCelsius = (float)((temperatureFahrenheit - 32) / 1.8);
            return temperatureCelsius;
        }
    }
}
