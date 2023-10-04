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

        public string CreateRandomFileName(string extension = "txt")
        {
            var fileName = Path.GetRandomFileName();
            var fileTitle = Path.GetFileNameWithoutExtension(fileName);
            return fileTitle + "." + extension;
        }

        public string CreateRandomFileNameAdvanced(char[] letters, uint length = 12, string extension = "txt")
        {
            var fileName = "";
            var random = new Random();

            if (letters.Length < 1)
            {
                throw new ArgumentException("Letters collection is empty");
            }

            for (var i = 0; i < length; i++)
            {
                var position = random.Next(letters.Length);
                fileName += letters[position];
            }

            return fileName + "." + extension;
        }

        public string CreateRandomFileNameAdvancedWithoutException(char[] letters, uint length = 12, string extension = "txt")
        {
            var fileName = "";
            var random = new Random();

            if (letters.Length > 0 && length > 0)
            {
                for (var i = 0; i < length; i++)
                {
                    var position = random.Next(letters.Length);
                    fileName += letters[position];
                }
            }

            return fileName + "." + extension;
        }


        public void Run()
        {
            var fileName = "sa\tdj\r35ak\r\nl5a/sjd";
            var clear = RemoveIllegalCharacters(fileName);

            Console.WriteLine($"{fileName} -> {clear}");

            var fileNameTool = new FileNameExample();


            //var letters = new char[] { 'a', 'b', 'c', 'd', 'e', '1' };
            var letterString = "";
            try
            {
                var fileName1 = fileNameTool.CreateRandomFileNameAdvanced(letterString.ToArray(), 8, "txt");
                Console.WriteLine(fileName1);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.WriteLine(fileNameTool
                .CreateRandomFileNameAdvancedWithoutException("abcdefghijklmnopqrstw".ToArray(), 12, "dat"));
        }
    }
}
