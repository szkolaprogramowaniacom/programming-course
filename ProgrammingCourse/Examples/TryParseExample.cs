using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class TryParseExample
    {
        public void Run()
        {
            string numberAsString = "12";

            //int number = int.Parse(numberAsString);
            //Console.WriteLine(number);

            //int number2;
            //bool success = int.TryParse(numberAsString, out number2);
            //if (success)
            //{
            //    Console.WriteLine(number2);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect format");
            //}

            if (int.TryParse(numberAsString, out int number3))
            {
                Console.WriteLine(number3);
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }
        }
    }
}
