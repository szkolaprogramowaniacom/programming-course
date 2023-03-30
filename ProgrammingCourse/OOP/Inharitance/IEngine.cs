using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Inharitance
{
    internal interface IEngine
    {
        void Start();
        void Stop();
        int OilLevel { get; set; }
    }
}
