using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.WorkerExample
{
    internal class Administrator : Worker
    {
        public override double CalculateWorkTime()
        {
            var originalTime =  base.CalculateWorkTime();
            return originalTime * 1.3; // example
        }
    }
}
