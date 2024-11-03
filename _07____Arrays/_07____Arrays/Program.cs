using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07____Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare and initialze array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();

            grades[0] = int.Parse(input);
            // assign value to array grades at index 0
            Console.WriteLine("grades at index 0 : {0}", grades[0]);
           
            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();
        }
    }
}
