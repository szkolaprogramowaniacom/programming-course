using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Interface
{
    internal class Cat : IAnimal
    {
        public string EyeColor { get; set ; }

        public void MakeSound()
        {
            Console.WriteLine("Meaow...");
        }

        public void Sleep()
        {

        }
    }
}
