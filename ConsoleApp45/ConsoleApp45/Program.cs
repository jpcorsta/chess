using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(20, 80);


            while(true)
            {
                Console.WriteLine("enter number");
                
                int num = Convert.ToInt16(Console.ReadLine());

                if (numberToGuess == num)
                    Console.WriteLine("indeed");
                else if (numberToGuess > num)
                    Console.WriteLine("You guessed to low");
                else if (numberToGuess < num)
                    Console.WriteLine("You guessed to hi");


            }
        }
    }
}
