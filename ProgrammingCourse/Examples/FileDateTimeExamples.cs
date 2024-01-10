using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingCourse.Examples
{
    internal class FileDateTimeExamples
    {
        public void RunExample()
        {
            var filePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\LoremIpsum.txt";

            //var creationDateTime = File.GetCreationTime(filePath);
            //var modifyDateTime = File.GetLastWriteTime(filePath);
            //var accessDateTime = File.GetLastAccessTime(filePath);

            //Console.WriteLine($"modify: {modifyDateTime}, access: {accessDateTime}");

            DateTime lastSaved = DateTime.Now;

            var timer = new System.Timers.Timer();
            timer.Interval = 3000;
            timer.Elapsed += (s, e) => {
                var lastAccess = File.GetLastAccessTime(filePath);
                if (lastAccess > lastSaved)
                {
                    Console.WriteLine($"Access: {lastAccess}");
                    lastSaved = lastAccess;
                }
            };
            timer.Start();

            while (timer.Enabled) ;
        }
    }
}
