using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 5f;
            float b = 30.6f;

            if (b > a)
            {
                Console.WriteLine("b is groter is dan a");
            }
            else if (a == b)
            {
                Console.WriteLine("b is even groot als a");
            }
            else
            {
                Console.WriteLine("a is groter dan b");
            }

            bool hetRegent = false;
            bool koudWeer = true;

            if(hetRegent == true || koudWeer)
            {
                Console.WriteLine("Kleed je warm aan en neem een paraplu mee");
            }
            else if (hetRegent == false && !koudWeer)
            {
                Console.WriteLine("Trek een t-shirt aan");
            }
            else
            {
                Console.WriteLine("s");
            }

        }
    }
}
