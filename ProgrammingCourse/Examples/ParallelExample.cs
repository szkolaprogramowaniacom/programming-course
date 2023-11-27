using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class ParallelExample
    {
        record Person(string Name, string Category = "Client");

        object sync = new object();

        public void Run()
        {
            var clients = new List<Person>
            {
                new("John"),
                new("Ann"),
                new("Monica")
            };            

            Console.WriteLine("Parallel.ForEach:");
            var position = Console.GetCursorPosition();

            Parallel.ForEach(clients, MakeLongOperation);

            Console.SetCursorPosition(position.Left, position.Top + clients.Count);

            void MakeLongOperation(Person person)
            {
                var position = Console.GetCursorPosition();

                lock (sync)
                {
                    position = Console.GetCursorPosition();
                    Console.WriteLine($"{person.Name}...");
                }

                // long operation 3s
                Task.Delay(2000 + Random.Shared.Next(5000)).Wait();

                lock (sync)
                {
                    Console.SetCursorPosition(position.Left + person.Name.Length + 3, position.Top);
                    Console.Write($"DONE");
                }
            }            
        }
    }
}
