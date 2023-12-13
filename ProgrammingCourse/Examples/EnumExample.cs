using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class EnumExample
    {
        public void RunExample()
        {
            //AddProduct("Samsung", "Phone");
            AddProduct("Samsung", ProductType.Phone);
        }

        void AddProduct(string name, ProductType type)
        {
            Console.WriteLine($"Product: {name}, type: {type}");
        }
    }

    enum ProductType
    {
        Phone,
        TV
    }
}
