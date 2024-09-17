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
    }
}
