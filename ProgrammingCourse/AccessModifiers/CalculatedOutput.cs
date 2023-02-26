using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.AccessModifiers
{
//    var calculatedOutput = new CalculatedOutput();
//    calculatedOutput.Input = 2;
//    calculatedOutput.CalculateOutput();
//    //calculatedOutput.Output = 4;
//    var result = calculatedOutput.Output;
//    Console.WriteLine(result);

    // internal
    // public
    // private
    // protected
    // internal protected
    public class CalculatedOutput
    {
        public double Input { get; set; }
        public double Output { get; private set; }

        public void CalculateOutput()
        {
            Output = Input * 2;
        }
    }
}
