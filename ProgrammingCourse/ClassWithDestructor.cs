using ProgrammingCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for (int i = 0; i < 100; i++)
//{
//    var obj = new ClassWithDestructor();
//}

//if (true)
//{
//    var obj = new ClassWithDestructor();
//}

//Console.WriteLine("end");

namespace ProgrammingCourse
{  
    public class ClassWithDestructor
    {
        public string Name { get; set; }

        public ClassWithDestructor()
        {
            Name = RandomStringGenerator.GenerateString(10000);
            Console.WriteLine("Object Created");
        }

        ~ClassWithDestructor()
        {
            Console.WriteLine("Object destructed");
        }
    }
}
