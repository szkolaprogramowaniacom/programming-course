using ProgrammingCourse.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var encpsulation = new Encapsulation();
//encpsulation.Calculate();
//Console.WriteLine(encpsulation.Result);

namespace ProgrammingCourse.OOP
{
    internal class Encapsulation
    {
        public const double PI = 3.14;
        private int age;
        private int result;

        public Encapsulation()
        {
            
        }
        public Encapsulation(int age) {
            this.age = age;
        }

        public void Calculate()
        {
            int part1 = CalculatePart1();
            int part2 = CalculatePart2();
            result = part1 + part2;
        }

        private int CalculatePart2()
        {
            return 4;
        }

        private int CalculatePart1()
        {
            return 8;
        }

        public int Result
        {
            get { return result; }
        }
    }
}
