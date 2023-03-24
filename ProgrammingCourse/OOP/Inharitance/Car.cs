using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Inharitance
{
    internal class Car
    {
        public Car(string color)
        {
            Color = color;
        }

        public string Color { get; private set; }
        
        public void Run()
        {
            Console.WriteLine("Running...");
        }

        public void Open()
        {
            Console.WriteLine("Opening...");
        }
    }
}
