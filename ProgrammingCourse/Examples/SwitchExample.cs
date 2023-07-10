using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class SwitchExample
    {
        public void Run()
        {
            var size = 88;

            switch (size)
            {
                case var mySize when mySize > 100:
                    Console.WriteLine("LARGE");
                    break;
                case var mySize when mySize <= 100:
                    Console.WriteLine("SMALL");
                    break;
                default:
                    break;
            }

            //if (size > 100)
            //{
            //    Console.WriteLine("LARGE");
            //}
            //else
            //{
            //    Console.WriteLine("SMALL");
            //}
        }
    }
}
