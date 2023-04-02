using ProgrammingCourse.OOP.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var animals = new List<Animal> {
//    new Dog(),
//    new Cat(),
//    new Dog(),
//    new Dog(),
//    new Cat(),
//    new Cat(),
//};

//foreach (Animal animal in animals)
//{
//    animal.Talk();
//}

namespace ProgrammingCourse.OOP.Polymorphism
{
    internal abstract class Animal
    {
        public abstract void Talk();
    }
}
