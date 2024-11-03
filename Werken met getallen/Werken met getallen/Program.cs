using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Werken_met_getallen
{
    class Program
    {
        static void Main(string[] args)
        {
            int bewerking = 100 / 50;
            Console.WriteLine(bewerking);

            int y = 5;
            y++;
            Console.WriteLine(y);

            int x = 100;
            x += 50;
            Console.WriteLine(x);

            Console.WriteLine(Math.Max(5, 7));

            Console.WriteLine(Math.Min(5, 7));

            Console.WriteLine(Math.Sqrt(64));

            Console.WriteLine(Math.Abs(2.4));

            Console.WriteLine(Math.Round(9.99));

            Console.WriteLine(Math.Cos(90));

            Console.WriteLine(Math.Sin(90));

            Console.WriteLine(Math.Tan(90));

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Acos(1));

            Console.WriteLine(Math.Asin(90));

            Console.WriteLine(Math.BigMul(14, 15));
        }
    }
}
