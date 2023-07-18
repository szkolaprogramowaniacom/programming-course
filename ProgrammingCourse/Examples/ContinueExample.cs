using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class ContinueExample
    {
        public void Run()
        {
            var allowed = new List<char>
            {
                'a',
                'd',
                'f'
            };

            var content = "skdkfdkjakkkekkwkdkkflkkrkldkltkiikdslasklsdkf";

            foreach (var letter in content)
            {
                if (!allowed.Contains(letter)) continue;
                Console.Write(letter);
            }
        }
    }
}
