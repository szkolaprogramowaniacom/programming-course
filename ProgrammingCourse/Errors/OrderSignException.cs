using ProgrammingCourse.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//try
//{
//    var service = new OrderService();
//    //int id = service.GetLastOrderId();
//    service.SignOrder(1, "xyz12");
//}
//catch (OrderSignException exc)
//{
//    // logger.Error()
//    Console.WriteLine($"Problems with signing {exc.OrderId} - {exc.SignErrorCode}");
//}
//catch (Exception exc)
//{
//    // logger.Error()
//    Console.WriteLine("Other problems...");
//}

namespace ProgrammingCourse.Errors
{
    internal class OrderSignException : Exception
    {
        public OrderSignException() { }
        public OrderSignException(string message) 
            : base(message) { }
        public OrderSignException(string message, Exception inner) 
            : base(message, inner) { }
        public OrderSignException(string message, int orderId, string signErrorCode )
            : base(message) { 
            OrderId = orderId;
            SignErrorCode = signErrorCode;
        }

        public int OrderId { get; private set; }
        public string SignErrorCode { get; private set; }
    }
}
