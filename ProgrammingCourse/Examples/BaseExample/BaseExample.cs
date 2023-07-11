using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.BaseExample
{
    public class BaseExample
    {
        public void Run()
        {
            var worker = new Worker("John");
            Console.WriteLine(worker.GetInfo());
        }
    }
}
