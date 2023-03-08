using ProgrammingCourse.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//try
//{
//    var service = new OrderService();
//    service.GetLastOrderId();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Sth wrong: {ex.Message}");
//}

namespace ProgrammingCourse.Errors
{
    internal class OrderService
    {
        public int GetLastOrderId()
        {
            try
            {
                var lastOrderId = new ClassWithErrors()
                    .GetLastOrderId();
                return lastOrderId;
            }
            catch (Exception ex)
            {
                // logger.Error(ex);
                throw;
            }
        }
    }
}
