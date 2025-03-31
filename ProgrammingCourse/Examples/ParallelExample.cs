using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                Task.Delay(2000 + Random.Shared.Next(3000)).Wait();

                lock (sync)
                {
                    Console.SetCursorPosition(position.Left + person.Name.Length + 3, position.Top);
                    Console.Write($"DONE");
                }
            }            
        }

        public void ParalelForEach()
        {
            var clipPath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\Clips";

            var clips = new List<string>{
                "clip1.mkv",
                "clip2.mkv",
                "clip3.mkv"
            };

            // process clips here
            //foreach (var clip in clips)
            //{
            //    ConvertClip(clip);
            //}
            Parallel.ForEach(clips, ConvertClip);

            //Parallel.ForEach(clips, clip => { 
            //    // code here
            //});

            void ConvertClip(string fileName)
            {
                Console.WriteLine($"Converting {fileName}...");

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        // ffmpeg.exe -i clip1.mkv -ac 1 converted_clip1.mkv
                        FileName = "ffmpeg.exe",
                        Arguments = $"-i {fileName} -ac 1 converted_{fileName}",
                        UseShellExecute = false,
                        WorkingDirectory = clipPath,
                    }
                };
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
