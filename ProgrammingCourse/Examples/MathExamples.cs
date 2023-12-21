using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class MathExamples
    {
        public void RoundExample()
        {
            var price = 12.32;

            var rounded = Math.Round(price);
            var floor = Math.Floor(price);
            var ceiling = Math.Ceiling(price);

            Console.WriteLine($"Round: {rounded}, Floor: {floor}, Ceiling: {ceiling}");
        }
    }
}
