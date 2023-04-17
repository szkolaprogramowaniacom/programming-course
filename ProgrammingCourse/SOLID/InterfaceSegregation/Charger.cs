using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.InterfaceSegregation
{
    internal class Charger
    {
        public void Charge(IChargable car)
        {
            car.Connect();
            car.Charge();
        }
    }
}
