namespace ProgrammingCourse.Examples.Classes
{
    public class Order
    {
        private int size;
        
        public int Size { 
            get {
                return size; 
            } 
            set { 
                size = value; 
            }
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        public void Send()
        {
            Console.WriteLine($"Order sent... (Size: {size})");
        }
    }
}
