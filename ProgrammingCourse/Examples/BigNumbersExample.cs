using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class BigNumbersExample
    {
        public void RunExample()
        {
            // -2147000000 .. 2147000000
            checked
            {
                int value = int.MaxValue;
                int value2 = int.MaxValue;

                unchecked
                {
                    int bigValue = value + value2;
                    //Console.WriteLine(bigValue);
                }

                int maxPlus = value + 1;
                //Console.WriteLine(maxPlus);

                BigInteger big = new BigInteger(value) + new BigInteger(value2);
                Console.WriteLine(big);

                long longValue = (long)value + (long)value2;
            }
        }
    }
}
