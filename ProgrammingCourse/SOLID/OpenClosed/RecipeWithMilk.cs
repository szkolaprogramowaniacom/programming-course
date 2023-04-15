using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.OpenClosed
{
    internal class RecipeWithMilk : ICoffeeRecipe
    {
        public void RunRecipe(ICoffeeMachine machine)
        {
            machine.GroundCofee(1);
            machine.BoilWater(5, 100);
            machine.BrewCoffee();
            machine.AddMilk(1);
            machine.Finish();

        }
    }
}
