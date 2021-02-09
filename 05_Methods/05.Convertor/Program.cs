using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convertor
{
    class Program
    {
        static double FahrenheitToCelsius(double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }


        static void Main(string[] args)
        {
            Console.Write("Temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.Write("Temperature in Celsius: {0:F2}", celsius);
        }
    }
}
