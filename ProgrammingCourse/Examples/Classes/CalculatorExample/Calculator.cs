using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes.CalculatorExample
{
    internal class Calculator
    {
        public void RunExample()
        {
            var calculator = new Calculator();

            // without abstraction
            //var result = calculator.Calculate(1, 2, "add");
            var operation = new Add
            {
                A = 1,
                B = 2
            };

            var result = calculator.Calculate(operation);
            calculator.Calculate(new Subtract { A = 1, B = 2 });
            calculator.Calculate(new Multiply { A = 1, B = 2 });
            //calculator.Calculate(new Divide { A = 1, B = 2 });
            //calculator.Calculate(new Power { A = 1, B = 2 });

            Console.WriteLine(result);
        }
        public float Calculate(Operation operation)
        {
            return operation.Calculate();
        }

        //public float Calculate(float a, float b, string operation)
        //{
        //    float result = 0;
        //    switch (operation)
        //    {
        //        case "add":
        //            result = Add(a, b);
        //            break;
        //        case "subtract":
        //            result = Subtract(a, b);
        //            break;
        //        case "multiply":
        //            result = Multiply(a, b);
        //            break;
        //        default:
        //            break;
        //    }
        //    return result;
        //}

        //private float Multiply(float a, float b)
        //{
        //    return a * b;
        //}

        //private float Subtract(float a, float b)
        //{
        //    return a - b;
        //}

        //private float Add(float a, float b)
        //{
        //    return a + b;
        //}
    }
}
