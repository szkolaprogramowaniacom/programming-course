using ProgrammingCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var classWithParams = new MethodsWithParams();
//classWithParams.ShowNames(new string[] { "John", "Monica", "Ann" });

//// only with params keyword
//classWithParams.ShowNames("John", "Monica", "Ann", "xxxx");
//classWithParams.ShowNames();

namespace ProgrammingCourse
{
    public class MethodsWithParams
    {
        public void ShowNames(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
