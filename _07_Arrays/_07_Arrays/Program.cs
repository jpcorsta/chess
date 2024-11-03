using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            string[,] matrix;
            
            // 3D array
            int[,,] threeD;

            //2D dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, //row 0
                {4, 5, 6}, //row 1
                {7, 8, 9}, //row 2
            };

           

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "Whats up" }
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };

            string[,] array2DString = new string[3, 2] 
            {
            { "one", "two" },
            { "three", "four"},
            { "five", "six" } 
            };


            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", dimensions);

        }
    }
}
