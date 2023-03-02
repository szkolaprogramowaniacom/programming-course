using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var randomString = RandomStringGenerator.GenerateString(1000);
//Console.WriteLine(randomString);

//var randomNumbers = RandomStringGenerator.GenerateString("1234567890", 1000);
//Console.WriteLine(randomNumbers);

namespace ProgrammingCourse
{
    internal static class RandomStringGenerator
    {
        public static string GenerateString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVYXZ1234567890";
            return GenerateString(chars, length);
        }

        public static string GenerateString(string allowedCharacters, int length)
        {
            Random random = new Random();
            string result = "";
            for (int i = 0; i < length; i++)
            {
                int randomPosition = random.Next(allowedCharacters.Length);
                result += allowedCharacters[randomPosition];
            }
            return result;
        }
    }
}
