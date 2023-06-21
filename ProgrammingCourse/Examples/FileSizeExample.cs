using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class FileSizeExample
    {
        string GetFileSizeInfo(long fileSize)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };

            double size = fileSize;
            int index = 0;
            while (size >= 1024 && index < sizes.Length - 1)
            {
                index++;
                size = size / 1024;
            }

            return $"{size:0.##} {sizes[index]}";
        }

        public void Run()
        {
            var filePath = @"C:\Projekty\SzkolaProgramowania.com\Pliki\LoremIpsum.txt";
            var info = new FileInfo(filePath);
            var sizeB = info.Length;

            var sizeInfo = GetFileSizeInfo(sizeB);
            Console.WriteLine(sizeInfo);
        }
    }
}
