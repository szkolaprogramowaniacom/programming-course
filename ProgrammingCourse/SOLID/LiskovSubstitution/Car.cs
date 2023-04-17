using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.LiskovSubstitution
{
    internal abstract class Car : BaseCar
    {
        public Car(int speedLimit)
        {
            SpeedLimit = speedLimit;
        }        
        
        public int SpeedLimit { get; }

        public abstract void Break();
        public abstract int GetSpeed();
    }
}
