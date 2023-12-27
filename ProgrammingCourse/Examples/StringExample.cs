using System.Globalization;
using System.Text;

namespace ProgrammingCourse.Examples
{
    internal class StringExample
    {
        public void Run()
        {
            Console.WriteLine("Start");
            //var longString = BuildLongString();
            var longString = BuildLongStringWithBuilder();
            Console.WriteLine(longString.Length);
        }

        public string BuildLongString()
        {
            var value = "";

            for (int i = 0; i < 100000; i++)
            {
                value = value + "a";
            }

            return value;
        }

        public string BuildLongStringWithBuilder()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                stringBuilder.Append("a");
            }
            return stringBuilder.ToString();
        }

        public void LetterSize()
        {
            var text = "This is a text";
            var upper = text.ToUpper();
            Console.WriteLine($"UPPER: {upper}");

            var lower = text.ToLower();
            Console.WriteLine($"lower: {lower}");

            var title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
            Console.WriteLine(title);
        }

        public void SplitJoinExample()
        {
            var items = new string[] { "John", "Ann", "Monica" };
            var sentence = string.Join(", ", items);
            Console.WriteLine(sentence);

            var sentence2 = "This is a text";
            var items2 = sentence2.Split(' ');
            foreach (var item2 in items2)
            {
                Console.WriteLine(item2);
            }

            var csvRow = "John\t2023\t123";
            Console.WriteLine($"CSV Row: {csvRow}");

            var fields = csvRow.Split("\t");
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }
        }

        internal string GetShortString(string text, int size = 10, string appendix = "...")
        {
            if (text.Length > size)
            {
                return text[..size] + appendix;
            }

            return text;
        }

        //internal string GetShortString(string text)
        //{
        //    return GetShortString(text, 10, "...");
        //}
    }
}
