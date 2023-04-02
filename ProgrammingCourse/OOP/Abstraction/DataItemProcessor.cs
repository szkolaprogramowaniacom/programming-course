using ProgrammingCourse.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var dataItem = new DataItem
//{
//    Id = 1,
//    Category = "Product",
//    Value = "Book"
//};

////var writer = new CsvWriter();
//var writer = new JsonWriter();
//var processor = new DataItemProcessor(writer, "DataItemProcess.txt");
//processor.Process(dataItem);

namespace ProgrammingCourse.OOP.Abstraction
{
    internal class DataItemProcessor
    {
        public DataItemProcessor(DataItemWriter writer, string filePath)
        {
            Writer = writer;
            FilePath = filePath;
        }

        public DataItemWriter Writer { get; }
        public string FilePath { get; }

        public void Process(DataItem dataItem)
        {
            Writer.Write(dataItem, FilePath);
        }
    }
}
