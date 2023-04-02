using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Polymorphism
{
    internal class Cat : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Meow");
        }
    }
}
