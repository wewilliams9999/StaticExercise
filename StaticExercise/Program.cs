using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celsius: {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(23);
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}
