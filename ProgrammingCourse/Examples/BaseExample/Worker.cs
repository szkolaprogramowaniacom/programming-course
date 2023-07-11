using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.BaseExample
{
    internal class Worker : User
    {
        public Worker(string username) : base(username)
        {
        }

        public string GetInfo()
        {
            var info = base.GetInfo();
            return $"This is worker - {info}";
        }
    }
}
