using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes.CalculatorExample
{
    internal class Subtract : Operation
    {
        public override float Calculate()
        {
            return A - B;
        }
    }
}
