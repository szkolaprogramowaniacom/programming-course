using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class FileNameExample
    {
        public string RemoveIllegalCharacters(string input)
        {
            var characters = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
            return Regex.Replace(input, $"[{characters}]", "", RegexOptions.Singleline | RegexOptions.CultureInvariant);
        }

        public void Run()
        {
            var fileName = "sa\tdj\r35ak\r\nl5a/sjd";
            var clear = RemoveIllegalCharacters(fileName);

            Console.WriteLine($"{fileName} -> {clear}");
        }
    }
}
