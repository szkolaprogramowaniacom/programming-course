using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP
{
    internal class ClassWithFields
    {        
        private string name;

        public void InitializeName(string name)
        {
            
            this.name = name;
        }

        public const string DEFAULT_TYPE = "BOOK11";

        //public readonly string DefaultName = "BK_NM1";        
        //public static readonly string DefaultValue = "123";

        public void Run()
        {    
            var type = "book";
            Calculate(type);
            CalculateOther(type);

            name = "John" + DEFAULT_TYPE;
            TestName();
            Console.WriteLine($"{name} running");
        }

        private void TestName()
        {
            if (name.Equals("John", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("OK");
            }
        }

        private void Calculate(string type)
        {
            // use type
            Console.WriteLine(type);
        }

        private void CalculateOther(string type)
        {
            // use type
            Console.WriteLine(type);
        }

        public int Size { get; set; }
    }
}
