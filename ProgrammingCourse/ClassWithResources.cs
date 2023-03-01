using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    //if (true)
    //{
    //    using var res = new ClassWithResources();
    //    // end
    //}

    //using (var res = new ClassWithResources())
    //{

    //}

    public class ClassWithResources : IDisposable
    {
        public ClassWithResources()
        {
            Console.WriteLine("Opening file connections");
        }

        public void Dispose()
        {
            Console.WriteLine("Closing file connections");
        }
    }
}
