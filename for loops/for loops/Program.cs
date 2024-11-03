using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] LuckyNumbers = { 4, 8, 15, 16, 23, 42 };
            
            for (int i = 0; i < LuckyNumbers.Length; i++) 
            {
                Console.WriteLine(LuckyNumbers[i]);
            }

          Console.ReadLine();
        }
    }
}
