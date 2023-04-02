using ProgrammingCourse.OOP.Mixed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var calulator = new Calculator();

//var operation = new AddOperation();
//var result = calulator.RunOperation(operation, 12, 5);
//Console.WriteLine(result);

//var subOperation = new SubOperation();
//var result2 = calulator.RunOperation(subOperation, 12, 5);
//Console.WriteLine(result2);

namespace ProgrammingCourse.OOP.Mixed
{
    internal class Calculator
    {
        private CalculatorDisplay display = new CalculatorDisplay();

        public double RunOperation(MathOperation operation, int a, int b)
        {
            var result = operation.Calculate(a, b);
            display.ShowInformation(operation);
            return result;
        }
    }
}
