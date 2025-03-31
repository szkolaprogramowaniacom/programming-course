using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    class ArrayExamples
    {
        public void TwoDimensionalArrays()
        {
            string[,] items = new string[3, 4]
            {
                { "A1", "A2", "A3", "A4" },
                { "B1", "B2", "B3", "B4" },
                { "C1", "C2", "C3", "C4" }
            };

            // iteracja po wszystkiech
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(items.GetValue(i, j) + " ");
                }
                Console.WriteLine();
            }

            // 3 kolumna
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(items.GetValue(i, 2));
            }

            // 2 wiersz
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(items.GetValue(1, j));
            }

        }

        public void JaggedArrays()
        {
            string[][] items = new string[3][]; // 3 rows
            items[0] = new string[] { "C#", "Python", "Java" };
            items[1] = new string[] { "ASP.NET", "Spring" };
            items[2] = new string[] { "Visual Studio", "PyCharm", "IntelliJ IDEA", "Visual Studio Code" };

            foreach (string[] row in items)
            {
                foreach (string item in row)
                {
                    Console.Write(item.PadRight(15));
                }
                Console.WriteLine();
            }
        }
    }
}
