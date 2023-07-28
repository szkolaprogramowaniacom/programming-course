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
    }
}
