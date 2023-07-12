using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class BreakExample
    {
        public void Run()
        {
            int size = 10;
            switch (size)
            {
                case 1:
                    Console.WriteLine("size is 1");
                    break;
                case 2:
                    Console.WriteLine("size is 2");
                    break;
                case 10:
                    Console.WriteLine("size is 10");
                    break;

                default:
                    Console.WriteLine("Other size value");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 3) break;
            }

            var items = new List<string> { "1", "John", "Ann" };

            for (int i = 0; i < 10; i++)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                    if (item == "John") break;
                }
            }

            //while ()
            //{
            //    break;
            //}

            //int index = 0;

            //do {
            //    if (index == 5) break;
            //    index++;
            //} while(index < 10);
        }
    }
}
