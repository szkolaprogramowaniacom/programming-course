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

        public void AnonymousTypeExample()
        {
            //Tuple<string, decimal> person2 = new("John", 123.32m);
            //(string name, decimal salary) person = new ("John", 123.34m);
            //Console.WriteLine(person.name, person.salary);

            var items = new List<(string name, decimal salary)>
            {
                new ("John", 123.3m),
                new ("Ann", 1246.3m),
                new ("Robert", 423.3m),
            };

            foreach (var person in items)
            {
                Console.WriteLine($"|{person.name,-15}|{person.salary,10}$|");
            }

        }
    }
}
