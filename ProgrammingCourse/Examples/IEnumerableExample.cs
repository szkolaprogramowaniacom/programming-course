using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class IEnumerableExample
    {
        IEnumerable<int> LoadCollection()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        IEnumerable<int> LoadCollection2()
        {
            var items = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(i);
            }
            return items;
        }

        public void Run()
        {
            IEnumerable<int> collection = LoadCollection();

            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
