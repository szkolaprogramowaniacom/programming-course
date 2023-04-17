using ProgrammingCourse.SOLID.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var engine = new Engine();
//var car = new Car(engine);
//car.Run();

namespace ProgrammingCourse.SOLID.DependencyInversion
{
    internal class Car
    {
        public Car(IEngine engine)
        {
            Engine = engine;
        }

        public IEngine Engine { get; }

        public void Run()
        {
            Engine.Start();
        }
    }
}
