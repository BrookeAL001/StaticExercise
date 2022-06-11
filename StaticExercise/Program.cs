using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var celsius = TempConverter.FarenheitToCelsius(68);

            Console.WriteLine($"Celsius {celsius}");

            var farenheit = TempConverter.CelsiusToFarenheit(20);

            Console.WriteLine($"Farenheit {farenheit}");

        }
    }
}
