using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.Classes
{
    internal sealed class CsvWriter : FileWriter
    {
        public void Write(string path, List<string> row)
        {
            var content = string.Join("\t", row) + Environment.NewLine;
            base.Write(path, content);
        }
    }

    // sealed
    //public class BetterCsvWriter : CsvWriter
    //{
    //}
}
