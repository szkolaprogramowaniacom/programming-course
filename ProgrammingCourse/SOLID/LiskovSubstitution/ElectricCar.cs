using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.LiskovSubstitution
{
    internal class ElectricCar : BaseCar
    {
        public override void Accelerate()
        {
            Speed += 20;
        }
    }
}
