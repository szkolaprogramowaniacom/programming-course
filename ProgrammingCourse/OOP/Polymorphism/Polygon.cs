using ProgrammingCourse.OOP.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var polygons = new List<Polygon>
//{
//    new Square(12),
//    new Square(3),
//    new Triangle(6, 5),
//    new Triangle(7, 4),
//};

//foreach (var polygon in polygons)
//{
//    Console.WriteLine(polygon.GetSize());
//}

namespace ProgrammingCourse.OOP.Polymorphism
{
    internal class Polygon
    {
        public virtual double GetSize()
        {
            return 0;
        }
    }
}
