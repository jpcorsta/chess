namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(20, 80);

            while(true)
            {
                Console.WriteLine("Enter number");
                
                int num =  Convert.ToInt32(Console.ReadLine());

                if(num == numberToGuess)
                    Console.WriteLine("indeed");
                else if(num > numberToGuess)
                    Console.WriteLine("You guessed to hi");
                else if(num < numberToGuess)
                    Console.WriteLine("You guessed to low");

            }

        }
    }
}
