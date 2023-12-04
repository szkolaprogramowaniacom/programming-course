using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes
{
    internal abstract class FileWriter
    {
        protected void Write(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
