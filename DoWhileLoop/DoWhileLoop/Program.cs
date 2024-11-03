using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a Friend");
                string nameOfAFriend = Console.ReadLine();
                int currentlenght = nameOfAFriend.Length;
                lenghtOfText += currentlenght;
                                                
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks that is long enough" + wholeText);
        }
    }
}
