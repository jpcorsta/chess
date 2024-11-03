using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_decimal_long
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            Console.WriteLine("");
            int min1 = int.MinValue;
            int max1 = int.MaxValue;
            Console.WriteLine($"The range of the int type is {min1} to {max1}");
            Console.WriteLine("");
            long min2 = long.MinValue;
            long max2 = long.MaxValue;
            Console.WriteLine($"The range of the int type is {min2} to {max2}");
        }
    }
}
