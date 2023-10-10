using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class TextAnalyzeExample
    {
        public TextStatistics AnalyzeText(string text)
        {
            var stats = new TextStatistics();

            var words = text.Split(new char[] { ' ', '.', ','});
            foreach (var word in words)
            {
                var normalized = word.Trim();
                normalized = normalized.Replace("(","").Replace(")","").ToLower();
                if (normalized == "") continue;

                if (stats.WordDictionary.ContainsKey(normalized))
                {
                    stats.WordDictionary[normalized]++;
                }
                else
                {
                    stats.WordDictionary.Add(normalized, 1);
                }

                stats.TotalWords++;
            }

            return stats;
        }

        public void Run()
        {
            var url = "https://pl.wikipedia.org/wiki/Pablo_Picasso";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //Console.WriteLine(doc.DocumentNode.InnerText);

            var paragraphs = doc.DocumentNode.Descendants("p").ToList();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var paragraph in paragraphs)
            {
                stringBuilder.Append(paragraph.InnerText);
            }


            var text = stringBuilder.ToString();

            var analyzer = new TextAnalyzeExample();
            var result = analyzer.AnalyzeText(text);

            Console.WriteLine($"Total words: {result.TotalWords}");

            var words = result.WordDictionary.ToList();
            words.Sort((v1, v2) => -v1.Value.CompareTo(v2.Value));
            foreach (var word in words.Take(20))
            {
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
        }
    }
}
