using ProgrammingCourse.OOP.Inharitance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////var engine = new EngineSmall();
//var engine = new EngineBig();
//var car = new Car(engine);
//car.Start();
//car.Run();

namespace ProgrammingCourse.OOP.Inharitance
{
    internal class Car : ICar
    {
        public IEngine Engine { get; set; }

        public Car()
        {
            
        }

        public Car(IEngine engine)
        {
            Engine = engine;
        }

        public Car(string color)
        {
            Color = color;
        }

        public string Color { get; private set; }
        
        public void Start()
        {
            Engine.Start();
            Console.WriteLine("Car Started");
            Console.WriteLine($"Oil Level: {Engine.OilLevel}");
        }

        public void Run()
        {            
            Console.WriteLine("Running...");
        }

        public void Open()
        {
            Console.WriteLine("Opening...");
        }
    }
}
