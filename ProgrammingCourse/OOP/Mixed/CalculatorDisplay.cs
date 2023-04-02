using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Mixed
{
    internal class CalculatorDisplay
    {
        public void ShowInformation(IDisplayable dis)
        {
            Console.WriteLine($"{dis.GetA()} | {dis.GetOperator()} | {dis.GetB()}");
        }
    }
}
