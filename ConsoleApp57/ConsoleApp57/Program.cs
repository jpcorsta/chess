namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = new Random().Next(20, 80);

            while(true)
            {
                Console.WriteLine("Enter number!");

                var num = Convert.ToByte(Console.ReadLine());

                if(num == numberToGuess)
                    Console.WriteLine("ok");
                else if(num > numberToGuess)
                    Console.WriteLine("to hi");
                else if(num < numberToGuess)
                    Console.WriteLine("to low");


                Console.Beep();
            }
        }
    }
}
