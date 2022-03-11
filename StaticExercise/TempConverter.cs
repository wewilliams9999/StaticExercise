using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double FahrenheitNumber)
        {
            
            var result = (FahrenheitNumber - 32) * 5/9;
            return result;
        }

        public static double CelsiusToFahrenheit(double CelsiusNumber)
        {
            var result = CelsiusNumber * 9/5 + 32;
            return result;
        }
    }
}
