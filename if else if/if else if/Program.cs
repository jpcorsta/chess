using System;

namespace if_else_if
{
    class Program
    {
        
        static void Main(string[] args)
        { 
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if(userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It's superhot!");
            }else
            {
                Console.WriteLine("Short are enough today");
            }
        }
    }
}
