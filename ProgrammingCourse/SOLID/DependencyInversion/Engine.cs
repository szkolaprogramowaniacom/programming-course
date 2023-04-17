using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.DependencyInversion
{
    internal class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting engine...");
        }
    }
}
