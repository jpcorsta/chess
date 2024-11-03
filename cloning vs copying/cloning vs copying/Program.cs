using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloning_vs_copying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 3, 4, 5 };
            //int[] numbersCopy = numbers;
            //numbersCopy[2] = 0;
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbersCopy[2]);

            int[] numbers = { 2, 3, 4, 5 };
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            int[] numbersClone = (int[])numbers.Clone();
            numbersClone[2] = 0;
            Console.WriteLine(numbersClone[2]);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
