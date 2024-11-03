using System;

namespace ConsoleApp69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(3, 50);

            while(true) 
            {
                Console.WriteLine("Enter number");
                
                
                3int userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput == numberToGuess)
                    Console.WriteLine("indeed");
                else if(userInput < numberToGuess)
                    Console.WriteLine("je moet hoger raden");
                else if(userInput > numberToGuess)
                    Console.WriteLine("je moet lager raden");
                
                
                else
                    Console.WriteLine("Guess again");
            }
        }
    }
}
