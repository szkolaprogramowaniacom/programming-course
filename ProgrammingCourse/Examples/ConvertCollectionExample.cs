namespace ProgrammingCourse.Examples
{
    record class WordItem(string word, int length);

    internal class ConvertCollectionExample
    {
        public void Run()
        {
            var words = new List<string> { "this", "is", "word", "none", "important" };

            var items = new List<WordItem>();
            foreach (var word in words)
            {
                var wordItem = new WordItem(word, word.Length);
                items.Add(wordItem);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            var items2 = words.Select(word => new WordItem(word, word.Length));

            foreach (var item in items2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
