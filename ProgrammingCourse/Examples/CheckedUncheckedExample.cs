using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class CheckedUncheckedExample
    {
        public void Run()
        {
            checked
            {
                int a = int.MaxValue;
                int b = a + 1;
                Console.WriteLine(b);
                unchecked
                {
                    // unchecked code
                }
            }
        }
    }
}
