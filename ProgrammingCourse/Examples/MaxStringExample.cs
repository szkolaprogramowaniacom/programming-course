using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class MaxStringExample
    {
        public void Run()
        {
            var text = "";
            var add = "lsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsdlsjdflkjsd";

            while (true)
            {
                text += add;

                if (text.Length % 100000 == 0)
                {
                    Console.WriteLine(text.Length);
                }
            }
        }
    }
}
