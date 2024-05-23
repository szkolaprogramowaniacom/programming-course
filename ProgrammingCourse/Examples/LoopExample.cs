namespace ProgrammingCourse.Examples
{
    internal class LoopExample
    {
        public void Run()
        {
            var persons = new List<string>
            {
                "John",
                "Ann",
                "Bob"
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            for (int index = 0; index < persons.Count; index++)
            {
                var person = persons[index];
                Console.WriteLine(person);
            }

            for (int index = persons.Count - 1; index >= 0; index--)
            {
                var person = persons[index];
                Console.WriteLine(person);
            }
        }
    }
}
