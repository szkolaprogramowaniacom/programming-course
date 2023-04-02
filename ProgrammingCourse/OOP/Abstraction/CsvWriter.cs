using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Abstraction
{
    internal class CsvWriter : DataItemWriter
    {
        public override string Serialize(DataItem dataItem)
        {
            return $"{dataItem.Id}\t{dataItem.Category}\t{dataItem.Value}";
        }

        public override void Write(DataItem dataItem, string filePath)
        {
            var content = Serialize(dataItem);
            File.WriteAllText(filePath, content);
        }
    }
}
