namespace ProgrammingCourse.Examples
{
    internal class AnonymousMethodExample
    {
        void LoadItems()
        {
            // loading
            Console.WriteLine("Loading items");
            Task.Delay(5000).Wait();
            Console.WriteLine("OK");
        }

        public void Run()
        {
            //Action method1 = LoadItems;
            //method1();
            var method2 = (int a) =>
            {
                // loading
                Console.WriteLine("Loading items");
                Task.Delay(5000).Wait();
                Console.WriteLine("OK");
            };

            var items = new List<string> { "asd", "dss" };

            bool IsA(string text)
            {
                if (text.Contains('a'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            var firstWithA = items.First((text) => text.Contains('a'));
        }
    }
}
