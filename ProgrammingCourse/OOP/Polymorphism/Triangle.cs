using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Polymorphism
{
    internal class Triangle : Polygon
    {
        public Triangle(int a, int h)
        {
            A = a;
            H = h;
        }

        public int A { get; }
        public int H { get; }

        public override double GetSize()
        {
            return A * H / 2;
        }
    }
}
