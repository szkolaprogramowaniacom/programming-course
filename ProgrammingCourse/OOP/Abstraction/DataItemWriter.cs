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

//var csvWriter = new CsvWriter();
//csvWriter.Write(dataItem, "DataItem.csv");

//var jsonWriter = new JsonWriter();
//jsonWriter.Write(dataItem, "DataItem.json");

namespace ProgrammingCourse.OOP.Abstraction
{
    internal abstract class DataItemWriter
    {
        public abstract string Serialize(DataItem dataItem);
        public abstract void Write(DataItem dataItem, string filePath);
    }
}
