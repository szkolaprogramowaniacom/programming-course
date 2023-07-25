using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.IsExample
{
    //int a = 12;
    //object obj = a;

    //void DoSth(object obj)
    //{
    //    if(obj is int)
    //    {
    //        Console.WriteLine("This is int");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Something else");
    //    }
    //}

    //DoSth("asd");

    //Animal animal = new Cat();

    //void MakeSound(Animal animal)
    //{
    //    animal.MakeSound();
    //}

    //MakeSound(animal);

    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meaow");
        }
    }
}
