using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    delegate void MadeHandler(int value);

    internal class DelegateExample
    {
        void Make(int value)
        {
            Console.WriteLine(value);
        }

        void Make2(int value)
        {
            Console.WriteLine(value + 2);
        }


        int GetResult(int value)
        {
            Console.WriteLine($"{value * 2}");
            return value * 2;
        }

        public void Run()
        {
            Action<int> method1 = Make;
            Func<int, int> method2 = GetResult;
            MadeHandler method3 = Make;

            method3(3);
            method3 = Make2;
            method3(3);
        }
    }
}
