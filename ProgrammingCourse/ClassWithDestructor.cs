using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    //if (true)
    //{
    //    var obj = new ClassWithDestructor();
    //}

    //Console.WriteLine("end");
    
    public class ClassWithDestructor
    {
        public ClassWithDestructor()
        {
            Console.WriteLine("Created");
        }

        ~ClassWithDestructor()
        {
            Console.WriteLine("Object destructed");
        }
    }
}
