using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "piet";
            friends[1] = "michael";
            friends[2] = "Jim";
            friends[3] = "Jo";
            friends[4] = "kareltje";

            luckyNumbers[1] = 900;

            Console.WriteLine( friends [1] );

            Console.ReadLine();
        }
    }
}
