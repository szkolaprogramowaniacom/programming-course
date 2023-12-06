using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes.CalculatorExample
{
    internal abstract class Operation
    {
        public float A { get; set; }
        public float B { get; set; }

        abstract public float Calculate();
    }
}
