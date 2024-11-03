using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(0, 5000);

            while(true) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Typ een nummer in");
                Console.ResetColor();

                int num = Convert.ToInt16(Console.ReadLine());

                if(num == numberToGuess)
                    Console.WriteLine("goed");
                else if(num > numberToGuess)
                    Console.WriteLine("te hoog");
                if(num < numberToGuess)
                    Console.WriteLine("te laag");


            }
        }
    }
}
