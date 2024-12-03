using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class DateTimeExamples
    {
        public void RunExample()
        {
            var date = new DateTime(2023, 1, 20, 13, 20, 0);
            Console.WriteLine(date);
            var later = date.AddHours(14);
            Console.WriteLine(later);

            var span = new TimeSpan(1, 2, 15, 0);
            var later2 = date.Add(span);
            Console.WriteLine(later2);
        }

        public void TimeSpanExample()
        {
            var eventDate = new DateTime(2024, 12, 24);
            var now = DateTime.Now;
            TimeSpan time = eventDate - now;
            Console.WriteLine($"{time.TotalDays:0.00} days to event: {eventDate.ToShortDateString()}");
            Console.WriteLine($"{time.TotalHours:0.00} hours to event: {eventDate.ToShortDateString()}");
            Console.WriteLine($"{time.TotalMinutes:0.00} minutes to event: {eventDate.ToShortDateString()}");
        }
    }
}
