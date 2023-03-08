using ProgrammingCourse.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//try
//{
//    var lastOrderId = new ClassWithErrors().GetLastOrderId();
//}
//catch (IndexOutOfRangeException exc)
//{
//    // log error
//    Console.WriteLine("Wrong index");
//}
//catch (Exception exc)
//{
//    // log exc
//    Console.WriteLine("Other error");
//}
//
//Console.WriteLine("Next application code");

namespace ProgrammingCourse.Errors
{
    internal class ClassWithErrors
    {
        public int GetLastOrderId()
        {
            var orders = new int[] { 243, 53, 545 };
            return orders[3];
        }
    }
}
