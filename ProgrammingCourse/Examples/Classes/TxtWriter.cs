using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes
{
    internal class TxtWriter : FileWriter
    {
        public void Write(string path, string line)
        {
            base.Write(path, line + Environment.NewLine);
        }
    }
}
