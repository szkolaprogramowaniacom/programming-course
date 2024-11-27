using ProgrammingCourse.Examples.Classes.CalculatorExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class PassingMethodsExample
    {
        public void Run()
        {
            //var size = 12;
            //void ShowSize(int size)
            //{
            //    Console.WriteLine(size);
            //}

            Calculate(2, 3, Add);
            Calculate(2, 3, Subtract);
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        void Calculate(int a, int b, Func<int, int, int> operation)
        {
            var result = operation(a, b);
            Console.WriteLine($"operation({a},{b}) = {result}");
        }
    }
}
