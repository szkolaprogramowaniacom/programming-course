namespace ProgrammingCourse.SOLID.OpenClosed
{
    public interface ICoffeeMachine
    {
        void AddMilk(int portions);
        void BoilWater(int portions, int temperature);
        void BrewCoffee();
        void Finish();
        void GroundCofee(int portions);
        void MakeCoffee(ICoffeeRecipe recipe);
    }
}