using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    //double tempC = 24.5;
    //var tempF = tempC.CelsiusToFahrenheit();
    //Console.WriteLine($"Temp C: {tempC}, Temp F: {tempF}");

    public static class ExtensionMethods
    {
        public static double CelsiusToFahrenheit(this double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
