using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Order
{

//    var orders = new List<Order>()
//    {
//        new Order(){
//            Id=1,
//            Name = "TV",
//            Type = "RTV",
//            Status= OrderStatus.Waiting
//        },
//        new Order(){
//            Id=2,
//            Name="Mouse",
//            Type="COMPUTERS",
//            Status= OrderStatus.InProgres
//        }
//    };      
//    // find orders with type = computers
//    var computers = orders.Where(c => c.Type == "COMPUTERS").ToList();
//    Console.WriteLine(computers.Count);      
//    var inProgres = orders.Where(c => c.Status == OrderStatus.InProgres).ToList();
//    Console.WriteLine(inProgres.Count);

    public enum OrderStatus
    {
        Waiting,
        InProgres,
        Sent,
        Delivered,
        Rejected
    }
}
