using ProgrammingCourse.SOLID.OpenClosed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//var badMachine = new BadCoffeeMachine();
//badMachine.MakeCoffee("WithMilk");

//var machine = new CoffeeMachine();
//var recipe = new RecipeWithMilk();
//var recipe2 = new RecipeEspresso();
//machine.MakeCoffee(recipe2);

namespace ProgrammingCourse.SOLID.OpenClosed
{
    public class CoffeeMachine : ICoffeeMachine
    {
        public void MakeCoffee(ICoffeeRecipe recipe)
        {
            Console.WriteLine($"Making coffee [CoffeeMachine]");

            recipe.RunRecipe(this);
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
