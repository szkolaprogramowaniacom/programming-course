using NLog;
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

//try
//{
//    var id = new OrderService().GetLastOrderId();
//}
//catch
//{
//    Console.WriteLine("Can't get last order id");
//}

namespace ProgrammingCourse.Errors
{
    internal class OrderService
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

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
                logger.Error(ex);
                throw;
            }
        }

        public void SignOrder(int orderId, string signatureId)
        {
            // signing code here...
            throw new OrderSignException("Can't sign", orderId, "INVALID");
        }
    }
}
