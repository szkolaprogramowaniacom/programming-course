using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var workers = new List<Worker>
//{
//    new Administrator(){ FirstName = "John", LastName = "Connor"},
//    new Developer(){ FirstName = "Ann", LastName = "Morawsky"},
//    new Manager(){ FirstName = "Monic", LastName = "Smith"},
//};

//foreach (var worker in workers)
//{
//    Console.WriteLine($"W: {worker.FirstName} {worker.LastName} => TIME: {worker.CalculateWorkTime()}");
//}    

namespace ProgrammingCourse.Examples.WorkerExample
{
    internal class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual double CalculateWorkTime()
        {
            // worker time calculate

            return 160; //example
        }
    }
}
