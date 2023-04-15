using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.OpenClosed
{
    public class BadCoffeeMachine
    {
        public void MakeCoffee(string name)
        {
            Console.WriteLine($"Making coffee [BadMachine]");

            if (name == "WithMilk")
            {
                GroundCofee(1);
                BoilWater(5, 100);
                BrewCoffee();
                AddMilk(1);
                Finish();
            }
            else if(name == "Espresso")
            {
                GroundCofee(1);
                BoilWater(1, 100);
                BrewCoffee();
                Finish();
            }
        }

        public void GroundCofee(int portions)
        {
            Console.WriteLine($"Grounded {portions} portions of cofee");
        }

        public void BoilWater(int portions, int temperature)
        {
            Console.WriteLine($"Boiled {portions} portions of water");
        }

        public void BrewCoffee()
        {
            Console.WriteLine($"Brew process");
        }

        public void AddMilk(int portions)
        {
            Console.WriteLine($"Added {portions} portions of milk");
        }

        public void Finish()
        {
            Console.WriteLine($"Finished");
        }
    }
}
