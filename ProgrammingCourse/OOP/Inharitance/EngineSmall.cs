using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Inharitance
{
    internal class EngineSmall : IEngine
    {
        public int OilLevel { get; set; }

        public void Start()
        {
            Console.WriteLine("Small Engine starting");
            CheckOilLevel();
        }

        private void CheckOilLevel()
        {
            OilLevel = Random.Shared.Next(0, 50);
        }

        public void Stop()
        {
            Console.WriteLine("Small Engine Stopped");
        }

    }
}
