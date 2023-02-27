using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    // using constructor with params
    //var john = new Person(1, "John");
    //john.Name = "John";
    //john.Id = 1;

    // using constructor without params
    //var anonymous = new Person();

    //var monica = new Person {Id=2, Name = "Monica" };

    internal class Person
    {
        public Person()
        {

        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public required int Id { get; set; }
        public string Name { get; set; }
    }
}
