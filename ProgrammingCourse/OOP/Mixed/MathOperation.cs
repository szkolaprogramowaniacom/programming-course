using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Mixed
{
    internal abstract class MathOperation : IDisplayable
    {
        public MathOperation(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract double Calculate(int a, int b);
        public abstract string GetA();
        public abstract string GetB();
        public abstract string GetOperator();
    }
}
