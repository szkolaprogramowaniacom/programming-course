using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Polymorphism
{
    internal class Square : Polygon
    {
        public Square(int a)
        {
            A = a;
        }

        public int A { get; }

        public override double GetSize()
        {
            return A * A;
        }
    }
}
