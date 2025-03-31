using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class OperatorsExample
    {
        public void Run()
        {
            EqualExample();
        }

        private void EqualExample()
        {
            bool isOk = false;
            int size = 12;

            // == porównanie
            // != różne
            if (size != 22)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("WRONG");
            }
        }

        private void Example()
        {
            int x = 10;
            Console.WriteLine(x);

            // += -= *= /=
            x += 5; // x = x + 5;
            x -= 5; // x = x - 5;
            x *= 5; // x = x * 5;
            x /= 5; // x = x / 5;

            int v, y, z;
            v = y = z = 4; // bardzo nietypowe
        }
    }
}
