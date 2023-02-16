using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    // simple example
    //var actions = new MethodAsAction();
    //actions.Calculate(3, 2, actions.Add);
    //actions.Calculate(4, 2, actions.Subtract);

    internal class MethodAsAction
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"a+b={a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"a-b={a - b}");
        }

        public void Calculate(int a, int b, Action<int, int> operation)
        {
            operation(a, b);
        }

    }
}
