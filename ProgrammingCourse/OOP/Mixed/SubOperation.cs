﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Mixed
{
    internal class SubOperation : MathOperation
    {
        int a;
        int b;
        public SubOperation() : base("SUBTRACT")
        {
        }

        public override double Calculate(int a, int b)
        {
            this.a = a;
            this.b = b;
            return a - b;
        }

        public override string GetA()
        {
            return a.ToString();
        }

        public override string GetB()
        {
            return b.ToString();
        }

        public override string GetOperator()
        {
            return "-";
        }
    }
}
