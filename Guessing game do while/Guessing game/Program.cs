using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {

                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            } while (guess != secretWord && !outOfGuesses);
            if (outOfGuesses)
            {
                Console.Write("You lose");
            }
            else
            {
                Console.Write("You win!");
            } 


                Console.ReadLine();
        }
    }
}
