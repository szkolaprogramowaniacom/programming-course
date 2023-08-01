namespace ProgrammingCourse.Examples
{
    internal class AsyncExample
    {
        void LoadItems()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loading item: " + i);
                Task.Delay(500).Wait();
            }
        }

        async Task RunAsync()
        {
            await Task.Run(LoadItems);
            Console.WriteLine("Finished");
        }

        void Run()
        {
            Task.Run(LoadItems).Wait();
            Console.WriteLine("Finished");
        }

        public void RunExample()
        {
            Run();
            //RunAsync();
            Console.WriteLine("Last line");

            Console.ReadLine();
        }

    }
}
