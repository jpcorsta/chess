using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = new Random().Next(20, 80);

            while (true)
            {
                Console.WriteLine("Enter number");

                int num = Convert.ToInt32(Console.ReadLine());

                if(num == numberToGuess)
                    Console.WriteLine("Indeed");
                else if(num > numberToGuess)
                    Console.WriteLine("You guessed to hi");
                else if(num < numberToGuess)
                    Console.WriteLine("You guessed to low");

            }
        }
    }
}
        
