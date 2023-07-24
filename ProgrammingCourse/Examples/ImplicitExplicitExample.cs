using ProgrammingCourse.Examples.BaseExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class ImplicitExplicitExample
    {
        public void Run()
        {
            var user = new User("John Smith");
            string text = user;
            Console.WriteLine(text);

            User user2 = (User)"John Smith";
        }
    }
}
