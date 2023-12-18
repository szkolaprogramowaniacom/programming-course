using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    class FractalGenerator
    {
        static double offsetX = 0.0;
        static double offsetY = 0.0;
        static double zoom = 1.0;

        public void RunExample()
        {
            while (true)
            {
                Console.Clear();
                DrawFractal();
                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        offsetX -= 0.1 * zoom;
                        break;
                    case ConsoleKey.RightArrow:
                        offsetX += 0.1 * zoom;
                        break;
                    case ConsoleKey.DownArrow:
                        offsetY += 0.1 * zoom;
                        break;
                    case ConsoleKey.UpArrow:
                        offsetY -= 0.1 * zoom;
                        break;
                    case ConsoleKey.Enter:
                        zoom *= 0.9;
                        break;
                    case ConsoleKey.Backspace:
                        zoom /= 0.9;
                        break;
                }
            }
        }

        void DrawFractal()
        {
            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    double a = (x - Console.WindowWidth / 2.0) * zoom / Console.WindowWidth + offsetX;
                    double b = (y - Console.WindowHeight / 2.0) * zoom / Console.WindowHeight + offsetY;
                    var c = new Complex(a, b);
                    var z = new Complex(0, 0);
                    int it = 0;

                    while (it < 100 && z.Magnitude < 2.0)
                    {
                        z = z * z + c;
                        it++;
                    }

                    SetColor(it);
                    Console.Write(it < 100 ? '#' : ' ');
                }
                Console.WriteLine();
            }
        }

        void SetColor(int iterations)
        {
            if (iterations < 20)
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (iterations < 40)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (iterations < 60)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (iterations < 80)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;
        }
    }

    struct Complex
    {
        public double Re;
        public double Im;

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static Complex operator +(Complex c1, Complex c2) => new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        public static Complex operator *(Complex c1, Complex c2) => new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c1.Im * c2.Re);
        public double Magnitude => Math.Sqrt(Re * Re + Im * Im);
    }
}
