using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.WorkerExample
{
    internal class Manager : Worker
    {
        public override double CalculateWorkTime()
        {
            return 200; // example
        }
    }
}
