using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class EventExample
    {
        public void Run()
        {
            var timer = new System.Timers.Timer(3000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Console.WriteLine("Event Elapsed");
            }

            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
