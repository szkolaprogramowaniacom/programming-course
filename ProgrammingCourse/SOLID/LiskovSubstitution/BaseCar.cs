namespace ProgrammingCourse.SOLID.LiskovSubstitution
{
    internal abstract class BaseCar
    {
        public int Speed { get; set; }
        public virtual void Accelerate()
        {
            Speed += 10;
        }
    }
}