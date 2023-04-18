using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.OOP.Interface
{
    internal interface IAnimal
    {
        void MakeSound();

        string EyeColor { get; set; }
    }
}
