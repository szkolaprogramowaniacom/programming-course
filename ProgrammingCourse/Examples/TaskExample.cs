using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class TaskExample
    {
        private object obj = new();

        public void Run()
        {
            
            void FindLetter(string text, char search, ConsoleColor color)
            {
                foreach (var letter in text)
                {
                    // synchronization
                    lock (obj)
                    {
                        if (letter == search)
                        {
                            Console.ForegroundColor = color;
                        }
                        Console.Write(letter);
                        Console.ResetColor();
                    }
                    Thread.Sleep(100);
                }
            }

            //FindLetter("asdlkajsdlakdja;sldajsdkajsdasldkjhaslkdjhaks", 'a', ConsoleColor.Red);
            //FindLetter("dfiusdfiusdofusoidfusodifusoidfuoisduf", 'i', ConsoleColor.Green);
            //FindLetter("iuasdiuasudasduaosiudoaiusdasoudoaisudiad", 'o', ConsoleColor.Blue);

            var tasks = new List<Task>
            {
                Task.Run(() => FindLetter("asdlkajsdlakdja;sldajsdkajsdasldkjhaslkdjhaks", 'a', ConsoleColor.Red)),
                Task.Run(() => FindLetter("dfiusdfiusdofusoidfusodifusoidfuoisduf", 'i', ConsoleColor.Green)),
                Task.Run(() => FindLetter("iuasdiuasudasduaosiudoaiusdasoudoaisudiad", 'o', ConsoleColor.Blue))
            };

            Console.WriteLine("Waiting for finish");
            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("Finished");

            //Console.WriteLine("Press ENTER to close");
            //Console.ReadLine();
        }

        public void CancelExample()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var task = Task.Run(async () => {
                for (int i = 0; i < 100; i++)
                {
                    // 1 way
                    // token.ThrowIfCancellationRequested();
                    // 2 way
                    if (token.IsCancellationRequested) break;
                    Console.Write(".");
                    await Task.Delay(1000, token);
                }
            }, token);

            Console.WriteLine("Waiting");
            Task.Delay(7000).Wait(); // 5s

            if (!task.IsCompleted)
            {
                Console.WriteLine("Cancelling task (7s)");
                cts.Cancel();
            }

            task.Wait();
            Console.WriteLine("Done");
        }

        async Task TestAsync()
        {
            Console.WriteLine("Connecting to server...");
            await Task.Delay(5000);
            Console.WriteLine("Server connected");
        }

        public async Task Compare()
        {
            // i/o operation
            // not blocking the thread
            // not creating a new thread
            var task1 = TestAsync();

            // cpu-bound operation
            // move operation to another thread from the thread pool
            var task2 = Task.Run(() => {
                for (int i = 0; i < 40; i++)
                {
                    Task.Delay(100).Wait();
                    Console.WriteLine("CPU Operation");
                }
                Console.WriteLine("Task.Run finished");
            });

            // multiple tasks in parallel
            var movies = new List<string> { "Matrix", "Titanic", "Die Hard" };
            var options = new ParallelOptions { MaxDegreeOfParallelism = 3 };
            var task3 = Parallel.ForEachAsync(movies, options, async (movie, token) => {
                Console.WriteLine($"Movie {movie} start convertion");
                await Task.Delay(1000, token);
                Console.WriteLine($"Movie {movie} converted");
            });

            Console.WriteLine("Waiting...");
            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("Press any key to exit...");
        }
    }
}
