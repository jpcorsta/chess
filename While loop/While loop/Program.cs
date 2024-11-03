using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
                Console.ReadLine();
        }
    }
}
