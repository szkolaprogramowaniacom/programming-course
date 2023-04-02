using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Abstraction
{
    internal class JsonWriter : DataItemWriter
    {
        public override string Serialize(DataItem dataItem)
        {
            return JsonSerializer.Serialize(dataItem);
        }

        public override void Write(DataItem dataItem, string filePath)
        {
            var content = Serialize(dataItem);
            File.WriteAllText(filePath, content);
        }
    }
}
