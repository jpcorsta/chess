using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_then
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are a not a male but you are tall");
            } else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.ReadLine();
        }
    }
}
