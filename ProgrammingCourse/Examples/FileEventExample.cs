using ProgrammingCourse.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var filePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\events.txt";
//var fileEvent = new FileEventExample(filePath);
//fileEvent.FileChanged += FileEvent_FileChanged;

//void FileEvent_FileChanged(string content)
//{
//    Console.WriteLine(content);
//}

//Console.ReadLine();

namespace ProgrammingCourse.Examples
{
    delegate void FileChangedHandler(string content);
    internal class FileEventExample
    {
        private readonly string filePath;
        private System.Timers.Timer timer;

        public FileEventExample(string filePath)
        {
            this.filePath = filePath;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();            
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            CheckFile();
        }

        public event FileChangedHandler FileChanged;

        private string prevContent;

        private void CheckFile()
        {
            if (!File.Exists(filePath)) return;

            var content = File.ReadAllText(filePath);
            if(content != prevContent)
            {
                // event
                //Console.WriteLine("File changed");
                FileChanged?.Invoke(content);
            }

            prevContent = content;
        }
    }
}
