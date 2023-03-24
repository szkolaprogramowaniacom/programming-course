using ProgrammingCourse.OOP.Inharitance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Car car = new Car("RED");
//car.Open();
//car.Run();

//Ranault renault = new Ranault("WHITE");
//renault.Open();
//renault.Run();
//renault.ConnectWithCompany();

//Car r1 = new Ranault("BLACK");

namespace ProgrammingCourse.OOP.Inharitance
{
    internal class Ranault : Car
    {
        public Ranault(string color) : base(color)
        {
            
        }

        public void ConnectWithCompany()
        {
            Console.WriteLine("Connecting");
        }
    }
}
